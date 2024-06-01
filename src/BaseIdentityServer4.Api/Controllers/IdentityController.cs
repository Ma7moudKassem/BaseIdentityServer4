
using Microsoft.AspNetCore.Authorization;

namespace KassemIdentityServer4.Api.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => 
        new JsonResult(from claim in User.Claims
                       select new
                       {
                           claim.Type, 
                           claim.Value,
                       });

}