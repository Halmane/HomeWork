namespace TVshow
{
    public class Channel
    {
        public string Name { get;}
        public string Info { get;}
        public int ChannelNumber { get;}
        public Channel(int stream, string name)
        {
            ChannelNumber = stream;
            Name = name;
            Info = name;
        }
        
    }
}
