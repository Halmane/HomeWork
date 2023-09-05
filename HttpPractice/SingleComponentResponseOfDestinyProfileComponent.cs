using System.Text.Json.Serialization;

namespace HttpPractice;

public class SingleComponentResponseOfDestinyProfileComponent
{
    [JsonPropertyName("data")]
    public DestinyProfileComponent Data { get; set; }
    [JsonPropertyName("privacy")]
    public int Privacy { get; set; }
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}
