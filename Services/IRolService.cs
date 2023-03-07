using IGWebAPI.Dtos.Rol;
using IGWebAPI.Models;

namespace IGWebAPI.Services;

public interface IRolService
{
    Task<Response<RolFullGetResponseDto>> GetById(int id);
}