using System.Text.Json.Serialization;

namespace HttpPractice;

public class UserSearchResponseDetail
{
    [JsonPropertyName("bungieGlobalDisplayName")]
    public string DungieGlobalDisplayName { get; set; }

    [JsonPropertyName("bungieGlobalDisplayNameCode")]
    public int BungieGlobalDisplayNameCode { get; set; }

    [JsonPropertyName("bungieNetMembershipId")]
    public string BungieNetMembershipId { get; set; }

    [JsonPropertyName("destinyMemberships")]
    public UserInfoCard[] DestinyMemberships { get; set; }
}
