namespace HttpPractice
{
    public class DestinyCharacterComponent
    {
        public int membershipId { get; set; }
        public int membershipType { get; set; }
        public int characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public int minutesPlayedThisSession { get; set; }
        public int minutesPlayedTotal { get; set; }
        public int light { get; set; }
        public Dictionary<uint, int> stats { get; set; }
        public uint raceHash { get; set; }
        public uint genderHash { get; set; }
        public uint classHash { get; set; }
        public int raceType { get; set; }
        public int classType { get; set; }
        public int genderType { get; set; }
        public int baseCharacterLevel { get; set; }
    }
}
