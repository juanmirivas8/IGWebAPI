using IGWebAPI.Dtos.Rol;
using IGWebAPI.Models;
using IGWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace IGWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class RolController:ControllerBase
{
    private readonly IRolService _rolService;

    public RolController(IRolService rolService)
    {
        _rolService = rolService;
    }

    [HttpGet("GetById/{id}")]
    public async Task<ActionResult<Response<RolFullGetResponseDto>>> get(int id)
    {
        var response = await _rolService.GetById(id);
        return response.Success ? Ok(response) : NotFound(response);
    }
}