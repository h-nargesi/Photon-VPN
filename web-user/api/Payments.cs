using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Payments : BasicController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] object payment)
    {
        throw new NotImplementedException();
    }

}