using AutoMapper;
using IGWebAPI.Dtos.Rol;
using IGWebAPI.Models;

namespace IGWebAPI;

public class AutoMapperProfile:Profile
{
    public AutoMapperProfile()
    {
        // Add as many of these lines as you need to map your objects
        // CreateMap<Models.RolEntity, Dtos.Rol.RolLazyGetResponseDto>();
        CreateMap<RolEntity, RolFullGetResponseDto>();
        // CreateMap<Dtos.Rol.RolPostRequestDto, Models.RolEntity>();
        // CreateMap<Dtos.Rol.RolPutRequestDto, Models.RolEntity>();
        // CreateMap<Models.RolEntity, Dtos.Rol.RolPutRequestDto>();
    }
}