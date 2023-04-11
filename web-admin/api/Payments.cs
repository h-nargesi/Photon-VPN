using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Handlers.Model;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Payments : Controller
{
    [HttpGet]
    public async Task<IActionResult> List([FromQuery] int? user_id, [FromBody] ListQuery filter)
    {
        using var db = new RdContext();

        var query = db.Payments.AsNoTracking();

        if (user_id.HasValue)
        {
            query = query.Where(p => p.PermanentUserId == user_id);
        }

        filter?.ApplyFilter(query);

        return Ok(await query.ToListAsync());
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
        else db.Entry(original).CurrentValues.SetValues(payment);

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
}