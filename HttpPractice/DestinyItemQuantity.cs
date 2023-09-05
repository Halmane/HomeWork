using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyItemQuantity
{
    [JsonPropertyName("itemInstanceId")]
    public int ItemInstanceId { get; set; }
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    [JsonPropertyName("hasConditionalVisibility")]
    public bool HasConditionalVisibility { get; set; }
}
