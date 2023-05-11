using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public class PlanBusiness
{
    public async Task<Plan> Save(Plan plan)
    {
        plan = await SavePlan(plan);

        var delete_profiles = new List<Profile>();

        await SavePackages(plan, delete_profiles);
        await SaveGroup(plan);
        await SaveCheckes(plan);
        await SaveReplies(plan);
        await DeleteProfiles(delete_profiles);

        return plan;
    }

    public async Task<Plan> Delete(Plan plan)
    {
        // TODO: delete plan = await DeletePlan(plan);

        var delete_profiles = new List<Profile>();

        await DeleteProfiles(delete_profiles);

        return plan;
    }

    private static async Task<Plan> SavePlan(Plan plan)
    {
        using var db = new RdContext();

        var original = await db.Plans.AsNoTracking()
                                     .Include(p => p.Packages)
                                     .Where(c => c.Id == plan.Id)
                                     .FirstOrDefaultAsync();

        if (original == null)
        {
            original = plan;

            plan.Created = plan.Modified = DateTime.Now;

            await db.Plans.AddAsync(plan);
        }
        else
        {
            plan.Modified = DateTime.Now;

            db.Plans.Attach(original);
            db.Entry(original).CurrentValues.SetValues(plan);
            db.Entry(original).Property(x => x.Created).IsModified = false;

            original.SessionCounts = plan.SessionCounts;
            original.Checks = plan.Checks;
            original.Replies = plan.Replies;
        }

        await db.SaveChangesAsync();

        return original;
    }

    private static async Task SavePackages(Plan plan, ICollection<Profile> delete)
    {
        using var db = new RdContext();

        var temp = await db.ProfilesWithSessionCounts()
                           .Where(p => p.PlanId == plan.Id)
                           .ToListAsync();

        var current_profiles = temp.GroupBy(p => p.SimultaneousUses)
                                   .ToDictionary(k => k.Key, v => v.ToList());

        var new_profiles = new List<Profile>();
        plan.Profiles = new List<Profile>();

        if (plan.SessionCounts == null || !plan.SessionCounts.Any(c => c > 0))
        {
            plan.SessionCounts = new int[] { 1 };
        }

        foreach (var count in plan.SessionCounts)
        {
            if (count <= 0) continue;

            var name = plan.Title + "-" + count;

            current_profiles.TryGetValue(count, out var originals);
            Profile? original;
            if (originals == null) original = null;
            else
            {
                original = originals.First();
                originals.RemoveAt(0);
                if (originals.Count == 0)
                    current_profiles.Remove(count);
            }

            if (original == null)
            {
                original = new Profile
                {
                    Name = name,
                    CloudId = ProfileViews.DefaultCloudId,
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                };

                new_profiles.Add(original);

                await db.Profiles.AddAsync(original);
            }
            else if (name != original.Name)
            {
                db.Profiles.Attach(original);

                original.Modified = DateTime.Now;
                original.Name = name;

                db.Entry(original).Property(x => x.Created).IsModified = false;
            }

            original.SimultaneousUses = count;
            plan.Profiles.Add(original);
        }

        await db.SaveChangesAsync();

        foreach (var pr in new_profiles)
            await db.Packages.AddAsync(new Package { PlanId = plan.Id, ProfileId = pr.Id });
        await db.SaveChangesAsync();

        foreach (var profiles in current_profiles.Values)
            foreach (var pr in profiles)
                delete.Add(pr);
    }

    private static async Task SaveGroup(Plan plan)
    {
        if (!plan.Profiles.Any())
        {
            return;
        }

        using var db = new RdContext();

        var groupnames = plan.Profiles.Select(p => ProfileViews.SimpleAdd + p.Id)
                                      .ToArray();

        var originals = await db.Radusergroups.AsNoTracking()
                                .Where(c => groupnames.Contains(c.Groupname))
                                .ToDictionaryAsync(k => k.Groupname);

        var components = await db.ProfileComponents.AsNoTracking()
                                .Where(c => groupnames.Contains(c.Name))
                                .ToDictionaryAsync(k => k.Name);

        foreach (var profile in plan.Profiles)
        {
            var groupname = ProfileViews.SimpleAdd + profile.Id;

            originals.TryGetValue(groupname, out var original);
            components.TryGetValue(groupname, out var component);

            if (original == null)
            {
                original = new Radusergroup
                {
                    Username = profile.Name,
                    Groupname = groupname,
                    Priority = 5,
                };

                await db.Radusergroups.AddAsync(original);
            }
            else if (profile.Name != original.Username)
            {
                db.Radusergroups.Attach(original);

                original.Username = profile.Name;
            }

            if (component == null)
            {
                component = new ProfileComponent
                {
                    Name= groupname,
                    CloudId = 23,
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                };

                await db.ProfileComponents.AddAsync(component);
            }
        }

        await db.SaveChangesAsync();
    }

    private static async Task SaveCheckes(Plan plan)
    {
        if (!plan.Profiles.Any())
        {
            return;
        }

        using var db = new RdContext();

        if (!plan.Checks.TryGetValue(ProfileViews.Simultaneous_Use, out var check_sim))
        {
            plan.Checks.Add(ProfileViews.Simultaneous_Use, new Radgroupcheck
            {
                Attribute = ProfileViews.Simultaneous_Use,
                Comment = "Auto",
                Op = ":=",
            });
        }

        foreach (var profile in plan.Profiles)
        {
            var groupname = ProfileViews.SimpleAdd + profile.Id;
            var originals = await db.Radgroupchecks.AsNoTracking()
                                    .Where(c => c.Groupname == groupname)
                                    .ToDictionaryAsync(k => k.Attribute);

            plan.Checks[ProfileViews.Simultaneous_Use].Value = profile.SimultaneousUses.ToString();

            foreach (var check in plan.Checks.Values)
            {
                originals.TryGetValue(check.Attribute, out var original);

                if (original == null)
                {
                    original = new Radgroupcheck
                    {
                        Attribute = check.Attribute,
                        Comment = check.Comment,
                        Groupname = groupname,
                        Op = check.Op,
                        Value = check.Value,
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                    };

                    await db.Radgroupchecks.AddAsync(original);
                }
                else
                {
                    originals.Remove(check.Attribute);

                    original.Modified = DateTime.Now;
                    original.Value = check.Value;

                    db.Radgroupchecks.Attach(original);
                }
            }

            foreach (var original in originals.Values)
            {
                db.Radgroupchecks.Remove(original);
            }
        }

        await db.SaveChangesAsync();
    }

    private static async Task SaveReplies(Plan plan)
    {
        if (!plan.Replies.Any() || !plan.Profiles.Any())
        {
            return;
        }

        using var db = new RdContext();

        foreach (var profile in plan.Profiles)
        {
            var groupname = ProfileViews.SimpleAdd + profile.Id;
            var originals = await db.Radgroupreplies.AsNoTracking()
                                    .Where(c => c.Groupname == groupname)
                                    .ToDictionaryAsync(k => k.Attribute);

            foreach (var reply in plan.Replies.Values)
            {
                originals.TryGetValue(reply.Attribute, out var original);

                if (original == null)
                {
                    original = new Radgroupreply
                    {
                        Attribute = reply.Attribute,
                        Comment = reply.Comment,
                        Groupname = groupname,
                        Op = reply.Op,
                        Value = reply.Value,
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                    };

                    await db.Radgroupreplies.AddAsync(original);
                }
                else
                {
                    originals.Remove(reply.Attribute);

                    original.Modified = DateTime.Now;
                    original.Value = reply.Value;

                    db.Radgroupreplies.Attach(original);
                }
            }

            foreach (var original in originals.Values)
            {
                db.Radgroupreplies.Remove(original);
            }
        }

        await db.SaveChangesAsync();
    }

    private static async Task DeleteProfiles(ICollection<Profile> profiles)
    {
        if (!profiles.Any())
        {
            return;
        }

        using var db = new RdContext();

        foreach (var profile in profiles)
        {
            var groupname = ProfileViews.SimpleAdd + profile.Id;

            db.Radusergroups.RemoveRange(db.Radusergroups.Where(g => g.Groupname == groupname));
            db.Radgroupchecks.RemoveRange(db.Radgroupchecks.Where(g => g.Groupname == groupname));
            db.Radgroupreplies.RemoveRange(db.Radgroupreplies.Where(g => g.Groupname == groupname));
            
            db.ProfileComponents.RemoveRange(db.ProfileComponents.Where(g => g.Name == groupname));
            db.Profiles.Remove(profile);
        }

        await db.SaveChangesAsync();
    }
}
