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
    [Route("{user_id:int}")]
    public async Task<IActionResult> Balance([FromRoute] int user_id)
    {
        using var db = new RdContext();

        var user_payments_query = from py in db.Payments.AsNoTracking()
                                  where py.PermanentUserId == user_id
                                  orderby py.DateTime descending, py.Created descending
                                  select py;

        var user_payments_task = user_payments_query.ToListAsync();

        // var rad_group_replies = from rad in db.Radgroupreplies.AsNoTracking()
        //                         where rad.Attribute == ProfileViews.Simultaneous_Use &&
        //                               rad.Value != null
        //                         group rad by rad.Groupname into @group
        //                         select new
        //                         {
        //                             Groupname = @group.Key,
        //                             SimulateCount = int.Parse(@group.Max(c => c.Value) ?? "0"),
        //                         };

        var profiles = from pr in db.ProfilesWithSessionCounts()
                       select new
                       {
                           ProfileId = pr.Id,
                           pr.PlanId,
                           pr.Name,
                           pr.SimultaneousUses,
                           PriceFactor = pr.SimultaneousUses <= 1 ? pr.SimultaneousUses :
                                         pr.SimultaneousUses == 2 ? 1.9 :
                                         pr.SimultaneousUses == 3 ? 2.85 : (pr.SimultaneousUses - 0.2),
                       };

        var user_plan_query = from pr in profiles
                              join pl in db.Plans.AsNoTracking()
                                      on pr.PlanId equals pl.Id
                              join up in db.PermanentUserPlans.AsNoTracking()
                                      on pr.ProfileId equals up.ProfileId

                              where up.PermanentUserId == user_id

                              orderby up.ValidTime descending, up.Created descending
                              select new
                              {
                                  pr.PlanId,
                                  pr.ProfileId,
                                  pl.Title,
                                  pr.SimultaneousUses,
                                  up.ValidTime,
                                  Price = up.OverridePrice ?? (pl.Price * (decimal)pr.PriceFactor * up.Periods),
                                  pl.Color,
                                  up.Created,
                                  up.Modified,
                              };

        var user_plan_task = user_plan_query.ToListAsync();

        var user_payments = await user_payments_task;
        var user_plan = await user_plan_task;

        var plan_index = 0;
        var balance = (decimal)0;
        var invoice_payments = new List<Payment>();
        var invoices = new List<object>();
        foreach (var payment in user_payments)
        {
            balance += payment.Value;
            invoice_payments.Add(payment);

            if (user_plan.Count > plan_index && user_plan[plan_index].Price <= balance)
            {
                balance -= user_plan[plan_index].Price;

                invoices.Add(new
                {
                    Balance = balance,
                    Plan = user_plan[plan_index],
                    Payments = invoice_payments,
                });

                invoice_payments = new List<Payment>();
                plan_index++;
            }
        }

        if (invoice_payments.Count > 0)
        {
            object? plan = null;
            if (user_plan.Count > plan_index)
            {
                balance -= user_plan[plan_index].Price;
                plan = user_plan[plan_index];
                plan_index++;
            }

            invoices.Add(new
            {
                Balance = balance,
                Plan = plan,
                Payments = invoice_payments,
            });
        }

        while (user_plan.Count > plan_index)
        {
            balance -= user_plan[plan_index].Price;
            invoices.Add(new
            {
                Balance = balance,
                Plan = user_plan[plan_index],
                Payments = Array.Empty<Payment>(),
            });
            plan_index++;
        }

        return Ok(invoices);
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