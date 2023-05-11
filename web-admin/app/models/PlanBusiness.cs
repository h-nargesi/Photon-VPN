using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public class PlanBusiness : IDisposable
{
    private readonly RdContext db;

    public PlanBusiness()
    {
        db = new RdContext();
    }

    public async Task<Plan> Save(Plan plan)
    {
        plan = await SavePlan(plan);

        await SavePackages(plan);
        await SaveCheckes(plan);
        await SaveReplies(plan);

        return plan;
    }

    private async Task<Plan> SavePlan(Plan plan)
    {
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

    private async Task SavePackages(Plan plan)
    {
        var current_profiles = await db.ProfilesWithSessionCounts()
                                        .Where(p => p.PlanId == plan.Id)
                                        .ToDictionaryAsync(k => k.SimultaneousUses);

        plan.Packages.Clear();

        if (plan.SessionCounts != null)
        {
            foreach (var count in plan.SessionCounts)
            {
                current_profiles.TryGetValue(count, out var original);
                var name = plan.Title + "-" + count;

                if (original == null)
                {
                    original = new Profile
                    {
                        Name = name,
                        CloudId = ProfileViews.DefaultCloudId,
                        Created = DateTime.Now,
                        Modified = DateTime.Now,
                    };

                    await db.Profiles.AddAsync(original);
                }
                else
                {
                    current_profiles.Remove(count);

                    if (name != original.Name)
                    {
                        db.Profiles.Attach(original);
                        
                        original.Modified = DateTime.Now;
                        original.Name = name;

                        db.Entry(original).Property(x => x.Created).IsModified = false;
                    }
                }
            }

        }

        await db.SaveChangesAsync();

        foreach (var pr in current_profiles.Values)
        {
            db.Packages.Remove(new Package { PlanId = plan.Id, ProfileId = pr.Id });
            db.Profiles.Remove(pr);
        }

        await db.SaveChangesAsync();
    }

    private async Task SaveCheckes(Plan plan)
    {
        if (!plan.Checks.Any())
        {
            return;
        }

        var ids = plan.Checks.Values.Select(c => c.Id);

        var originals = await db.Radgroupchecks.AsNoTracking()
                                .Where(c => ids.Contains(c.Id))
                                .ToDictionaryAsync(k => k.Id);

        foreach (var check in plan.Checks.Values)
        {
            originals.TryGetValue(check.Id, out var original);

            if (original == null)
            {
                original = check;

                check.Created = check.Modified = DateTime.Now;

                await db.Radgroupchecks.AddAsync(check);
            }
            else
            {
                check.Modified = DateTime.Now;

                db.Radgroupchecks.Attach(original);
                db.Entry(original).CurrentValues.SetValues(check);
                db.Entry(original).Property(x => x.Created).IsModified = false;
            }
        }

        await db.SaveChangesAsync();
    }

    private async Task SaveReplies(Plan plan)
    {
        if (!plan.Replies.Any())
        {
            return;
        }

        var ids = plan.Replies.Values.Select(c => c.Id);

        var originals = await db.Radgroupreplies.AsNoTracking()
                                .Where(c => ids.Contains(c.Id))
                                .ToDictionaryAsync(k => k.Id);

        foreach (var reply in plan.Replies.Values)
        {
            originals.TryGetValue(reply.Id, out var original);

            if (original == null)
            {
                original = reply;

                reply.Created = reply.Modified = DateTime.Now;

                await db.Radgroupreplies.AddAsync(reply);
            }
            else
            {
                reply.Modified = DateTime.Now;

                db.Radgroupreplies.Attach(original);
                db.Entry(original).CurrentValues.SetValues(reply);
                db.Entry(original).Property(x => x.Created).IsModified = false;
            }
        }

        await db.SaveChangesAsync();
    }

    public void Dispose()
    {
        db.Dispose();
    }
}
