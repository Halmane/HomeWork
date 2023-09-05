using System.Text.Json.Serialization;

namespace HttpPractice;
public class SingleComponentResponseOfDestinyVendorReceiptsComponent
{
    [JsonPropertyName("data")]
    public DestinyVendorReceiptsComponent Data { get; set; }
    [JsonPropertyName("privacy")]
    public int Privacy { get; set; }
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}
