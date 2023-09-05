using System.Text.Json.Serialization;

namespace HttpPractice;

public class UserSearchPrefixRequest
{
    [JsonPropertyName("displayNamePrefix")]
    public string DisplayNamePrefix { get; set; }
}
