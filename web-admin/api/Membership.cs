using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Membership : Controller
{
    [HttpGet]
    public async Task<IActionResult> Plans([FromQuery] int user_id)
    {
        using var db = new RdContext();

        var query = from up in db.PermanentUserPlans.AsNoTracking()
                    where up.PermanentUserId == user_id

                    join pl in db.Plans.AsNoTracking()
                            on up.ProfileId equals pl.ProfileId

                    join pr in db.Profiles.AsNoTracking()
                            on up.ProfileId equals pr.Id

                    orderby up.ValidTime descending, up.RegisterTime descending
                    select new
                    {
                        PermanentUserPlan = up,
                        Plan = pl,
                        Profile = pr,
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