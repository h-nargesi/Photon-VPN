using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Membership : BasicController
{
    [HttpGet]
    public async Task<IActionResult> Plans([FromQuery] int _)
    {
        return Ok(await GetData());
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] object user_plan)
    {
        return Ok(await PostData(user_plan));
    }

    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] object user_time)
    {
        return Ok(await PostData(user_time));
    }
}