using System.Text.Json.Serialization;
using URLScanner.Converters;

namespace URLScanner.Models.DTOs;

public class AnalysisDto
{
    public string Url { get; set; } = "";

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonConverter(typeof(UnixTimestampConverter))]
    [JsonPropertyName("date")]
    public DateTime Date { get; init; }

    [JsonPropertyName("results")]
    public Dictionary<string, ResultDto> Results { get; set; } = new();

    [JsonPropertyName("stats")]
    public StatDto Stat { get; set; } = null!;
}
