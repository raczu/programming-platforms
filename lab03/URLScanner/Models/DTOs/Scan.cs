using System.Text.Json.Serialization;

namespace URLScanner.Models.DTOs;

public class ScanDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;
}