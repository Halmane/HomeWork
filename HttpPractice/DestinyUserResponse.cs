using System.Text.Json.Serialization;

namespace HttpPractice;
public class DestinyUserResponse
{
    [JsonPropertyName("profile")]
    public SingleComponentResponseOfDestinyProfileComponent profile { get; set; }
    [JsonPropertyName("characters")]
    public DictionaryComponentResponseOfint64AndDestinyCharacterComponent characters { get; set; }
}
