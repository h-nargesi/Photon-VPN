using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public static class ProfileViews
{
    public const string SimpleAdd = "SimpleAdd_";

    public const string Simultaneous_Use = "Simultaneous-Use";

    public const int DefaultCloudId = 23;

    public static IQueryable<Profile> ProfilesWithSessionCounts(this RdContext db)
    {
        var rad_group_replies = from rad in db.Radgroupchecks.AsNoTracking()
                                where rad.Attribute == Simultaneous_Use &&
                                      rad.Value != null
                                group rad by rad.Groupname into @group
                                select new
                                {
                                    Groupname = @group.Key,
                                    SimultaneousUses = @group.Max(c => c.Value),
                                };

        var profiles = from pr in db.Profiles.AsNoTracking()
                       join pk in db.Packages.AsNoTracking()
                               on pr.Id equals pk.ProfileId
                               into pkjoin
                       from pk in pkjoin.DefaultIfEmpty()
                       join at in rad_group_replies
                               on new { Groupname = SimpleAdd + pr.Id } equals new { at.Groupname }
                               into atjoin
                       from at in atjoin.DefaultIfEmpty()
                       let SafeSimultaneousUses = at.SimultaneousUses ?? "0"
                       select new Profile
                       {
                           Id = pr.Id,
                           Name = pr.Name,
                           PlanId = pk.PlanId,
                           SimultaneousUses = int.Parse(SafeSimultaneousUses),
                           CloudId = pr.CloudId,
                           Created = pr.Created,
                           Modified = pr.Modified,
                       };

        return profiles;
    }
}