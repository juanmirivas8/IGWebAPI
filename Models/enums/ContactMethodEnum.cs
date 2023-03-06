using System.Text.Json.Serialization;

namespace IGWebAPI.Models.enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ContactMethodEnum
{
    Agency,
    Direct,
    Referral
}