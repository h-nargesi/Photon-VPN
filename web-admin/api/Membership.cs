using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
[Route("srv/[controller]/[action]")]
public class Membership : Controller
{
    [HttpGet]
    public async Task<IActionResult> Balance([FromQuery] int user_id)
    {
        using var db = new RdContext();

        var plans = from pk in db.Packages.AsNoTracking()
                    join pl in db.Plans.AsNoTracking()
                            on pk.PlanId equals pl.Id
                    select new
                    {
                        pl.Id,
                        pl.Price,
                        pl.Color,
                        pk.ProfileId,
                    };

        var rad_group_replies = from rad in db.Radgroupreplies.AsNoTracking()
                                where rad.Attribute == ""
                                select new
                                {
                                    rad.Groupname,
                                    rad.Value
                                };

        var profiles = from pr in from pr in db.Profiles.AsNoTracking()
                                  select new
                                  {
                                      pr.Id,
                                      pr.Name,
                                      Key = "Sample_Code_" + pr.Id,
                                  }
                       let SimulateCount = rad_group_replies.Where(c => c.Groupname == pr.Key)
                                                            .Select(c => (int?)int.Parse(c.Value))
                                                            .FirstOrDefault()
                       select new
                       {
                           pr.Id,
                           pr.Name,
                           PriceFactor = SimulateCount ?? 0,
                       };

        var query = from up in db.PermanentUserPlans.AsNoTracking()
                    where up.PermanentUserId == user_id

                    join pr in profiles
                            on up.ProfileId equals pr.Id

                    join pl in plans
                            on up.ProfileId equals pl.ProfileId

                    orderby up.ValidTime descending, up.Created descending
                    select new
                    {
                        PlanId = pl.Id,
                        ProfileId = pr.Id,
                        pr.Name,
                        up.ValidTime,
                        Price = up.OverridePrice ?? (pl.Price * pr.PriceFactor),
                        pl.Color,
                        up.Created,
                        up.Modified,
                    };

        return Ok(await query.FirstOrDefaultAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] UserPlan user_plan)
    {
        if (user_plan == null) return BadRequest();

        using var db = new RdContext();

        var latest_valid_time = db.PermanentUserPlans.AsNoTracking()
                                                     .Max(up => up.ValidTime)
                                                     .Date;

        var now = DateTime.UtcNow.Date;
        if (now < latest_valid_time) latest_valid_time = now;

        var up = new PermanentUserPlan
        {
            PermanentUserId = user_plan.UserId,
            ProfileId = user_plan.ProfileId,
            OverridePrice = user_plan.OverridePrice,
            ValidTime = latest_valid_time.AddMonths(user_plan.Months).Date,
        };

        await db.PermanentUserPlans.AddAsync(up);
        await db.SaveChangesAsync();

        return Ok(Result.Success(data: up));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] UserTime user_time)
    {
        using var db = new RdContext();

        db.PermanentUserPlans.Remove(new PermanentUserPlan
        {
            PermanentUserId = user_time.UserId,
            ValidTime = user_time.Date.Date,
        });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}