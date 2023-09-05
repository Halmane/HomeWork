using System.Text.Json.Serialization;

namespace HttpPractice;

public class UserSearchResponse
{
    [JsonPropertyName("searchResults")]
    public UserSearchResponseDetail[] SearchResults { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }
}
