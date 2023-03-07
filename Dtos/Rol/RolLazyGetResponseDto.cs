using IGWebAPI.Models.enums;

namespace IGWebAPI.Dtos.Rol;

public class RolLazyGetResponseDto
{
    public int Id { get; set; }
    public string Project{get; set;} = string.Empty;
    public string Area { get; set; } = string.Empty;
    public RolEnum Rol { get; set; }
    public LocalizationEnum Localization { get; set; }
    public string Description { get; set; } = string.Empty;
    public RolStatusEnum Status { get; set; }
    public int Vacancies { get; set; } = 1;
    public DateOnly CreationDate { get; set; }
    public DateOnly ClosingDate { get; set; }
    public DateOnly LastUpdate { get; set; }
}