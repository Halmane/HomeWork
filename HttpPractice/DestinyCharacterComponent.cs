using System.Text.Json.Serialization;

namespace HttpPractice
{
    public class DestinyCharacterComponent
    {
        [JsonPropertyName("membershipId")]
        public string MembershipId { get; set; }
        [JsonPropertyName("membershipType")]
        public int MembershipType { get; set; }
        [JsonPropertyName("characterId")]
        public string CharacterId { get; set; }
        [JsonPropertyName("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonPropertyName("minutesPlayedThisSession")]
        public string MinutesPlayedThisSession { get; set; }
        [JsonPropertyName("minutesPlayedTotal")]
        public string MinutesPlayedTotal { get; set; }
        [JsonPropertyName("light")]
        public int Light { get; set; }
        [JsonPropertyName("stats")]
        public Dictionary<uint, int> Stats { get; set; }
        [JsonPropertyName("raceHash")]
        public uint RaceHash { get; set; }
        [JsonPropertyName("genderHash")]
        public uint GenderHash { get; set; }
        [JsonPropertyName("classHash")]
        public uint ClassHash { get; set; }
        [JsonPropertyName("raceType")]
        public RaceType RaceType { get; set; }
        [JsonPropertyName("classType")]
        public ClassType ClassType { get; set; }
        [JsonPropertyName("genderType")]
        public GenderType GenderType { get; set; }
        [JsonPropertyName("baseCharacterLevel")]
        public int BaseCharacterLevel { get; set; }
    }
}
