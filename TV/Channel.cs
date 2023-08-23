namespace TVshow
{
    public class Channel
    {
        public string Name { get;}
        public string Info { get;}
        public int ChannelNumber { get;}
        public Channel(int сhannelNumber, string name)
        {
            ChannelNumber = сhannelNumber;
            Name = name;
            Info = name;
        }
        
    }
}
