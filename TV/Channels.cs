using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVshow
{
    static class Channels
    {
        private static List<Channel> _сhannels = new List<Channel>(){ new Channel(1, "Музтв"),
                                                                      new Channel(2, "Нтв"),
                                                                      new Channel(3, "МатчТВ"),
                                                                      new Channel(4, "Дисней"),
                                                                      new Channel(5, "Первый"),
                                                                      new Channel(6, "СТС"),
                                                                      new Channel(7, "ТНТ"),
                                                                      new Channel(8, "Nickelodeon")};

        public static List<Channel> GetRandomChannels(int count)
        {
            var randomChannelsList = new HashSet<Channel>();
            for (int i = 0; i < count; i++)
            {
                randomChannelsList.Add(_сhannels[Random.Shared.Next(_сhannels.Count - 1)]);
            }
            return randomChannelsList.ToList<Channel>();
        }
    }
}
