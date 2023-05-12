using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Payments : Controller
{
    [HttpPost]
    public async Task<IActionResult> List([FromQuery] int? user_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Payments.AsNoTracking();

        if (user_id.HasValue)
        {
            query = query.Where(p => p.PermanentUserId == user_id);
        }

        var filtered = filter.AddIdentityColumn()
                             .ApplyFilter(query);

        return Ok(await filtered.ToDynamicListAsync());
    }

    [HttpPost]
    public IActionResult Count([FromQuery] int? user_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Payments.AsNoTracking();

        if (user_id.HasValue)
        {
            query = query.Where(p => p.PermanentUserId == user_id);
        }

        var filtered = filter.ApplyFilterCount(query);

        return Ok(filtered.Count());
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        using var db = new RdContext();

        var model = await db.Payments.AsNoTracking()
                                     .Where(c => c.Id == id)
                                     .FirstOrDefaultAsync();

        return Ok(model);
    }

    [HttpPost]
    [Route("")]
    [Route("/srv/[controller]/[action]")]
    public async Task<IActionResult> Add([FromBody] Payment payment)
    {
        if (payment == null) return BadRequest();

        payment.Approved = false;

        using var db = new RdContext();

        var original = await db.Payments.AsNoTracking()
                                        .Where(c => c.Id == payment.Id)
                                        .FirstOrDefaultAsync();

        if (original == null) await db.Payments.AddAsync(payment);
        else
        {
            db.Payments.Attach(original);
            db.Entry(original).CurrentValues.SetValues(payment);
        }

        await db.SaveChangesAsync();

        return Ok(Result.Success(data: original?.Id ?? payment.Id));
    }

    [HttpPost]
    [Route("{id:int}")]
    public async Task<IActionResult> Approve([FromRoute] int id, [FromBody] bool approvement)
    {
        using var db = new RdContext();

        var payment = await db.Payments.AsNoTracking()
                                       .Where(c => c.Id == id)
                                       .FirstOrDefaultAsync();

        if (payment == null) return BadRequest();

        db.Payments.Attach(payment);
        payment.Approved = approvement;
        await db.SaveChangesAsync();

        return Ok(Result.Success(data: payment.Id));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] int id)
    {
        using var db = new RdContext();

        db.Payments.Remove(new Payment { Id = id });
        await db.SaveChangesAsync();

        return Ok(Result.Success());
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Transaction([FromRoute] string id)
    {
        if (id == null)
        {
            return BadRequest();
        }

        using var db = new RdContext();

        var model = await db.Payments.AsNoTracking()
                                     .Where(c => c.TrnsactionId == id)
                                     .Select(c => new
                                     {
                                         c.DateTime,
                                         c.BankName,
                                         c.BankAccount
                                     })
                                     .FirstOrDefaultAsync();

        return Ok(model);
    }
}