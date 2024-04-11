using System.Text.Json;
using Microsoft.Extensions.Configuration;
using URLScanner.Models.DTOs;

namespace URLScanner.API;

public class ApiClient
{
    private readonly HttpClient _client;

    public ApiClient(IConfiguration configuration)
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri(configuration["VirusTotalApi:BaseAddress"]!)
        };
        _client.DefaultRequestHeaders.Add("x-apikey", configuration["VirusTotalApi:ApiKey"]);
    }

    public async Task<object?> SubmitScanAsync(string url)
    {
        var content = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("url", url)
        });

        var response = await _client.PostAsync("urls", content);
        var responseContent = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(responseContent);
        var root = doc.RootElement;

        if (response.IsSuccessStatusCode)
        {
            var data = root.GetProperty("data");
            return JsonSerializer.Deserialize<ScanDto>(data.GetRawText());
        }
        var error = root.GetProperty("error");
        return JsonSerializer.Deserialize<ApiErrorDto>(error.GetRawText());
    }

    public async Task<object?> GetAnalysisAsync(string id)
    {
        var response = await _client.GetAsync($"analyses/{id}");
        var content = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(content);
        var root = doc.RootElement;

        if (response.IsSuccessStatusCode)
        {
            var attributes = root.GetProperty("data").GetProperty("attributes");
            return JsonSerializer.Deserialize<AnalysisDto>(attributes.GetRawText());
        }
        var error = root.GetProperty("error");
        return JsonSerializer.Deserialize<ApiErrorDto>(error.GetRawText());
    }
}