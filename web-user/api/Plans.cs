using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Plans : BasicController
{
    [HttpGet]
    public async Task<IActionResult> List()
    {
        return Ok(await GetData());
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get([FromRoute] int _)
    {
        return Ok(await GetData());
    }

}