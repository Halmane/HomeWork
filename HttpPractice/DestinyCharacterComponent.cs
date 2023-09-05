namespace HttpPractice
{
    public class DestinyCharacterComponent
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public string characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public string minutesPlayedThisSession { get; set; }
        public string minutesPlayedTotal { get; set; }
        public int light { get; set; }
        public Dictionary<uint, int> stats { get; set; }
        public uint raceHash { get; set; }
        public uint genderHash { get; set; }
        public uint classHash { get; set; }
        public RaceType raceType { get; set; }
        public ClassType classType { get; set; }
        public GenderType genderType { get; set; }
        public int baseCharacterLevel { get; set; }
    }
}
