using System.Text.Json.Serialization;

namespace URLScanner.Models.DTOs;

public class ResultDto
{
    [JsonPropertyName("method")]
    public string Method { get; set; } = null!;

    [JsonPropertyName("engine_name")]
    public string Engine { get; set; } = null!;

    [JsonPropertyName("category")]
    public string Category { get; set; } = null!;

    [JsonPropertyName("result")]
    public string Outcome { get; set; } = null!;
}