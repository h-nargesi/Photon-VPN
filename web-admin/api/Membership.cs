using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.App;
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

        var user_payments = await user_payments_query.ToListAsync();
        user_payments.SyncTimeList();

        var profiles = from pr in db.ProfilesWithSessionCounts()
                       let PriceFactor = pr.SimultaneousUses <= 1 ? pr.SimultaneousUses :
                                         pr.SimultaneousUses == 2 ? 1.8 :
                                         pr.SimultaneousUses == 3 ? 2.7 : (pr.SimultaneousUses - 0.4)
                       select new
                       {
                           ProfileId = pr.Id,
                           pr.PlanId,
                           pr.Name,
                           pr.SimultaneousUses,
                           PriceFactor = (decimal)PriceFactor,
                       };

        var user_plan_query = from pr in profiles
                              join pl in db.Plans.AsNoTracking()
                                      on pr.PlanId equals pl.Id
                              join up in db.PermanentUserPlans.AsNoTracking()
                                      on pr.ProfileId equals up.ProfileId

                              where up.PermanentUserId == user_id

                              let CurrentPrice = up.OverridePrice ?? pl.Price
                              let Periods = up.Periods <= 0 ? 1 : up.Periods

                              orderby up.ValidTime descending, up.Created descending
                              select new UserPlan
                              {
                                  PlanId = pr.PlanId,
                                  ProfileId = pr.ProfileId,
                                  Title = pl.Title,
                                  SimultaneousUses = pr.SimultaneousUses,
                                  ValidTime = up.ValidTime,
                                  Price = pr.PriceFactor * Periods * CurrentPrice,
                                  Color = pl.Color,
                                  Created = up.Created,
                                  Modified = up.Modified,
                              };

        var user_plan = await user_plan_query.ToListAsync();
        user_plan.SyncTimeList();

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

                invoices.Insert(0, new
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

            invoices.Insert(0, new
            {
                Balance = balance,
                Plan = plan,
                Payments = invoice_payments,
            });
        }

        while (user_plan.Count > plan_index)
        {
            balance -= user_plan[plan_index].Price;
            invoices.Insert(0, new
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
    public async Task<IActionResult> Add([FromBody] UserPlanRequest user_plan)
    {
        if (user_plan == null) return BadRequest();

        user_plan.SyncTimeToUTC();
        if (user_plan.Months < 1) user_plan.Months = 1;

        using var db = new RdContext();

        var latest_valid_time = await db.PermanentUserPlans.AsNoTracking()
                                        .Where(up => up.PermanentUserId == user_plan.PermanentUserId)
                                        .MaxAsync(up => (DateTime?)up.ValidTime);

        var now = DateTime.UtcNow;
        if (latest_valid_time == null || now > latest_valid_time)
            latest_valid_time = now;

        var up = new PermanentUserPlan
        {
            PermanentUserId = user_plan.PermanentUserId,
            ProfileId = user_plan.ProfileId,
            OverridePrice = user_plan.OverridePrice,
            Periods = user_plan.Months,
            ValidTime = latest_valid_time.Value.Date.AddMonths(user_plan.Months).Date,
        };

        await db.PermanentUserPlans.AddAsync(up);
        await db.SaveChangesAsync();

        return Ok(Result.Success(data: up));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] UserTime user_time)
    {
        using var db = new RdContext();

        user_time.SyncTimeToUTC();

        db.PermanentUserPlans.Remove(new PermanentUserPlan
        {
            PermanentUserId = user_time.PermanentUserId,
            ValidTime = user_time.Date.Date,
        });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }
}