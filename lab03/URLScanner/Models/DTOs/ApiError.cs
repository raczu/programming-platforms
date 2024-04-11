using System.Text.Json.Serialization;

namespace URLScanner.Models.DTOs;

public class ApiErrorDto
{
    [JsonPropertyName("code")]
    public string Code { get; set; } = null!;

    [JsonPropertyName("message")]
    public string Message { get; set; } = null!;
}