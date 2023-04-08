using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Membership : BasicController
{
    [HttpGet]
    public async Task<IActionResult> Plans([FromQuery] int user_id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] object user_plan)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] object user_time)
    {
        throw new NotImplementedException();
    }
}