﻿using System.Text.Json.Serialization;

namespace URLScanner.Models.DTOs;

public class StatDto
{
    [JsonPropertyName("malicious")]
    public int Malicious { get; set; }

    [JsonPropertyName("suspicious")]
    public int Suspicious { get; set; }

    [JsonPropertyName("undetected")]
    public int Undetected { get; set; }

    [JsonPropertyName("harmless")]
    public int Harmless { get; set; }

    [JsonPropertyName("timeout")]
    public int Timeout { get; set; }
}