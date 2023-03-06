using System.Text.Json.Serialization;

namespace IGWebAPI.Models.enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LocalizationEnum
{
    London,
    Barcelona,
    Cordoba
}