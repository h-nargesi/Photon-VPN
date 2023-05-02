using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;
using System.Numerics;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
[Route("srv/[controller]/[action]")]
public class Membership : Controller
{
    [HttpGet]
    [Route("{user_id}")]
    public async Task<IActionResult> Balance([FromRoute] int user_id)
    {
        using var db = new RdContext();

        var user_payments_query = from py in db.Payments.AsNoTracking()
                                  where py.PermanentUserId == user_id
                                  orderby py.DateTime descending, py.Created descending
                                  select py;

        var user_payments_task = user_payments_query.ToListAsync();

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
                                where rad.Attribute == "Simultaneous-Use"
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
                                      Key = "SimpleAdd_" + pr.Id,
                                  }
                       let SimulateCount = rad_group_replies.Where(c => c.Groupname == pr.Key)
                                                            .Select(c => (int?)int.Parse(c.Value))
                                                            .FirstOrDefault() ?? 0
                       select new
                       {
                           pr.Id,
                           pr.Name,
                           PriceFactor = SimulateCount <= 1 ? SimulateCount :
                                         SimulateCount == 2 ? 1.9 :
                                         SimulateCount == 3 ? 2.85 : (SimulateCount - 0.2),
                       };

        var user_plan_query = from up in db.PermanentUserPlans.AsNoTracking()
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
                                  Price = up.OverridePrice ?? (pl.Price * (decimal)pr.PriceFactor),
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
                Payments = new Payment[0],
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