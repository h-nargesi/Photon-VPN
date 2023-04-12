using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Photon.Service.VPN.Models;

namespace Photon.Service.VPN.Handlers;

public class Account : Controller
{
    [HttpPost]
    [Route("/api/[controller]/login/{username}")]
    public async Task<IActionResult> AdminLogin([FromRoute] string username, [FromBody] string password)
    {
        using var db = new RdContext();

        var query = db.Users.AsNoTracking()
                            .Where(c => c.Username == username && c.Password == password)
                            .Select(c => (int?)c.Id);

        return Ok(await query.FirstOrDefaultAsync());
    }

    [HttpPost]
    [Route("/srv/[controller]/login/{username}")]
    public async Task<IActionResult> UserLogin([FromRoute] string username, [FromBody] string password)
    {
        using var db = new RdContext();

        var query = from account in db.Accounts.AsNoTracking()
                    join user in db.PermanentUsers.AsNoTracking()
                              on account.PermanentUserId equals user.Id
                    where user.Username == username && account.Password == password
                    select (int?)user.Id;

        return Ok(await query.FirstOrDefaultAsync());
    }

}