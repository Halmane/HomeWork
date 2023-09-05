using System.Text.Json.Serialization;

namespace HttpPractice;

public class DestinyProfileComponent
{
    [JsonPropertyName("userInfo")]
    public UserInfoCard UserInfo { get; set; }
}
