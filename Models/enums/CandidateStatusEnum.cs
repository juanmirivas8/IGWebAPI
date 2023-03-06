using System.Text.Json.Serialization;

namespace IGWebAPI.Models.enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CandidateStatusEnum
{
    InProgress,
    Pendant,
    Rejected,
    Hired,
    Doubt
}