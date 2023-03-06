using IGWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IGWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class RolController:ControllerBase
{
    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<RolEntity>> get(int id)
    {
        return Ok(new RolEntity());
    }
}