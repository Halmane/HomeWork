using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HttpPractice;
public class HttpRequest
{
    JsonSerializerOptions option = new JsonSerializerOptions()
    { NumberHandling = (JsonNumberHandling)1 };
    public static HttpClient httpClient = new HttpClient();
    public async Task<T> Request<T>(HttpMethod requestType, string path, JsonContent content = null, string link = "https://www.bungie.net/Platform/")
    {
        HttpRequestMessage request = new HttpRequestMessage(requestType, $"{link}{path}");
        if (content != null)
            request.Content = content;

        request.Headers.Add("X-API-Key", "bcf113bb1115487baec8fc81b76ffdfd");
        var result = (await httpClient.SendAsync(request)).Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(await result,option);
    }
}
