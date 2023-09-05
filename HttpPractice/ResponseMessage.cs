using System.Text.Json.Serialization;

namespace HttpPractice;

public class ResponseMessage<T>
{
    [JsonPropertyName("Response")]
    public T Response { get; set; }
    [JsonPropertyName("ErrorCode")]
    public int ErrorCode { get; set; }

    [JsonPropertyName("ThrottleSeconds")]
    public int ThrottleSeconds { get; set; }

    [JsonPropertyName("ErrorStatus")]
    public string ErrorStatus { get; set; }

    [JsonPropertyName("Message")]
    public string Message { get; set; }

    [JsonPropertyName("MessageData")]
    public Dictionary<string, string> MessageData { get; set; }

    [JsonPropertyName("DetailedErrorTrace")]
    public string DetailedErrorTrace { get; set; }
}
