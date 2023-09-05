using System.Text.Json.Serialization;

namespace HttpPractice;

public class DictionaryComponentResponseOfint64AndDestinyCharacterComponent
{
    [JsonPropertyName("data")]
    public Dictionary<string, DestinyCharacterComponent> Data { get; set; }
    [JsonPropertyName("privacy")]
    public int Privacy { get; set; }
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}
