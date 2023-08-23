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
        public Channel(int stream, string name)
        {
            Stream = stream;
            Name = name;
            Info = name;
        }
        
    }
}
