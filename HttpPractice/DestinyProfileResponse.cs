using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyProfileResponse
{
    [JsonPropertyName("responseMintedTimestamp")]
    public DateTime ResponseMintedTimestamp { get; set; }
    [JsonPropertyName("secondaryComponentsMintedTimestamp")]
    public DateTime SecondaryComponentsMintedTimestamp { get; set; }
    [JsonPropertyName("vendorReceipts")]
    public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }
}
