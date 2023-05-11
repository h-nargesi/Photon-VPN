using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models;

public static class ProfileViews
{
    public const string SimpleAdd = "SimpleAdd_";

    public const string Simultaneous_Use = "Simultaneous-Use";

    public const int DefaultCloudId = 23;

    public static IQueryable<Profile> ProfilesWithSessionCounts(this RdContext db)
    {
        var rad_group_replies = from rad in db.Radgroupreplies.AsNoTracking()
                                where rad.Attribute == ProfileViews.Simultaneous_Use &&
                                      rad.Value != null
                                group rad by rad.Groupname into @group
                                select new
                                {
                                    Groupname = @group.Key,
                                    SimultaneousUses = int.Parse(@group.Max(c => c.Value) ?? "0"),
                                };

        var profiles = from pr in db.Profiles.AsNoTracking()
                       join pk in db.Packages.AsNoTracking()
                               on pr.Id equals pk.ProfileId
                       join at in rad_group_replies
                       on new { Groupname = ProfileViews.SimpleAdd + pr.Id } equals new { at.Groupname }
                       select new Profile
                       {
                           Id = pr.Id,
                           PlanId = pk.PlanId,
                           Name = pr.Name,
                           SimultaneousUses = at.SimultaneousUses,
                           CloudId = pr.CloudId,
                           Created = pr.Created,
                           Modified = pr.Modified,
                       };

        return profiles;
    }
}