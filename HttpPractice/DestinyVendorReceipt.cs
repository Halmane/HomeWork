using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyVendorReceipt
{
    [JsonPropertyName("currencyPaid")]
    public DestinyItemQuantity[] CurrencyPaid { get; set; }
    [JsonPropertyName("itemReceived")]
    public DestinyItemQuantity ItemReceived { get; set; }
    [JsonPropertyName("licenseUnlockHash")]
    public uint LicenseUnlockHash { get; set; }
    [JsonPropertyName("purchasedByCharacterId")]
    public int PurchasedByCharacterId { get; set; }
    [JsonPropertyName("refundPolicy")]
    public int RefundPolicy { get; set; }
    [JsonPropertyName("sequenceNumber")]
    public int SequenceNumber { get; set; }
    [JsonPropertyName("timeToExpiration")]
    public int TimeToExpiration { get; set; }
    [JsonPropertyName("expiresOn")]
    public DateTime ExpiresOn { get; set; }
}
