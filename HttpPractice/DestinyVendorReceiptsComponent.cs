using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyVendorReceiptsComponent
{
    [JsonPropertyName("receipts")]
    public DestinyVendorReceipt[] Receipts { get; set; }
}
