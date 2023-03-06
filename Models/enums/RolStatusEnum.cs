using System.Text.Json.Serialization;

namespace IGWebAPI.Models.enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RolStatusEnum
{
    Open,
    Closed,
    InProcess
}