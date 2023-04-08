using Microsoft.AspNetCore.Mvc;

namespace Photon.Service.VPN.Handlers;

[Route("api/[controller]/[action]")]
public class Plans : BasicController
{
    [HttpGet]
    public async Task<IActionResult> List()
    {
        throw new NotImplementedException();
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        throw new NotImplementedException();
    }

}