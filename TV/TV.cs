using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TVshow
{
    internal class TV
    {
        private bool _isOn;
        private List<Channel> _channels;
        private int _playingChannel;
        private int _volume;
        public string Brand { get; }
        public string Model { get; }
        public double Diagonal { get; }
        public int MaxVolume { get; }


        private void FillChannels(int count)
        {
            
            _channels = Channels.GetRandomChannels(count);
        }

        public TV()
        {
            Brand = "Standart";
            Model = "Standart";
            Diagonal = 20.5;
            _isOn = false;
            MaxVolume = 10;
            _volume = 0;
            FillChannels(10);
            _playingChannel = 1;
        }
        public TV(string brand, string model, double diagonal, int channels) 
        {
            Brand = brand;
            Model = model;
            Diagonal = diagonal;
            _isOn = false;
            MaxVolume = 10;
            _volume = 0;
            FillChannels(10);
            _playingChannel = 1;
        }

        

        public void TVOn()
        {
            _isOn = _isOn ? false : true;
            Console.WriteLine(_isOn ? "On" : "Off");
        }

        public void ChangeVolume(int volume)
        {
            if(_isOn == false) TVOn();
            _volume += volume;
            if (_volume > MaxVolume) _volume = MaxVolume;
            if(_volume < 0) _volume = 0;
            Console.WriteLine(_volume);
        }

        public void ChangePlayingChannel(int newChannel)
        {
            if (_isOn == false) TVOn();
            if (newChannel <= _channels.Count && newChannel > 0) _playingChannel = newChannel;
            else _playingChannel = _channels.Count-1;
            Console.WriteLine($"Channel:{_channels[_playingChannel].ChannelNumber}-{_channels[_playingChannel].Name}");
        }

        public void NextChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel++;
            if (_playingChannel > _channels.Count) _playingChannel = 1;
            Console.WriteLine($"Channel:{_channels[_playingChannel].ChannelNumber}-{_channels[_playingChannel].Name}");
        }

        public void LastChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel--;
            if (_playingChannel < 1) _playingChannel = _channels.Count;
            Console.WriteLine($"Channel:{_channels[_playingChannel].ChannelNumber}-{_channels[_playingChannel].Name}");
        }

        public void ListOfChannels()
        {
            if (_isOn == false) TVOn();
            for ( int i = 0; i < _channels.Count; i++ )
            {
                Console.WriteLine($"Channel:{_channels[i].ChannelNumber}-{_channels[i].Name}");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nModel:{Model} \nDiagonal:{Diagonal}");
            Console.WriteLine(_isOn ? "On" : "Off");
            ListOfChannels();
            Console.WriteLine($"Now playing \nChannel:{_channels[_playingChannel].ChannelNumber}-{_channels[_playingChannel].Name}");
            Console.WriteLine($"Volume:{_volume}/{MaxVolume}");
        }
    }
}
