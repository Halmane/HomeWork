using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVshow
{
    internal class Channel
    {
        public string Name;
        public string Info;
        public int Stream;
        public static Random Shared;
        public Channel(int stream, string name)
        {
            Stream = stream;
            Name = name;
            Info = name;
        }

        public static List<Channel> GetRandomChannels(int count) 
        {
            Shared = new Random();
            var channels = new List<Channel>() { new Channel(1, "Музтв"), 
                                                 new Channel(2, "Нтв"), 
                                                 new Channel(3, "МатчТВ"),
                                                 new Channel(4, "Дисней"), 
                                                 new Channel(5, "Первый"), 
                                                 new Channel(6, "СТС"),
                                                 new Channel(7, "ТНТ"),
                                                 new Channel(8, "Nickelodeon")};
            var randomChannelsList = new HashSet<Channel>();
            for(int i = 0; i < count;i++) 
            {
                randomChannelsList.Add(channels[Shared.Next(channels.Count-1)]);
            }
            return randomChannelsList.ToList<Channel>();
        }
    }
}
