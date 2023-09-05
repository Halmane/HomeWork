using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyProfileResponse
{
    [JsonPropertyName("responseMintedTimestamp")]
    public DateTime ResponseMintedTimestamp { get; set; }
    [JsonPropertyName("secondaryComponentsMintedTimestamp")]
    public DateTime SecondaryComponentsMintedTimestamp { get; set; }

    [JsonPropertyName("profile")]
    public SingleComponentResponseOfDestinyProfileComponent profile { get; set; }
    [JsonPropertyName("characters")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterComponent characters { get; set; }
}
