using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Threading.Channels;

namespace TVshow
{
    public static class Channels
    {
        private static List<Channel> _сhannels = new List<Channel>()
        {
            new(1, "Музтв"),
            new(2, "Нтв"),
            new(3, "МатчТВ"),
            new(4, "Дисней"),
            new(5, "Первый"),
            new(6, "СТС"),
            new(7, "ТНТ"),
            new(8, "Nickelodeon")
        };

        public static List<Channel> GetRandomChannels(int count)
        {
            if (count > _сhannels.Count - 1) count = _сhannels.Count - 1;
            if (count <= 0) count = 1;
            return _сhannels.OrderBy(x => Random.Shared.Next()).Take(count).ToList();
        }
    }
}
