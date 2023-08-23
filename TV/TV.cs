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
        private List<Channel> Channels;
        private int _playingChannel;
        private int _volume;
        public string Brand { get; }
        public string Model { get; }
        public double Diagonal { get; }
        public int MaxVolume { get; }
        public static Random Shared { get; }


        private void FillChannels(int count)
        {
            
            Channels = Channel.GetRandomChannels(count);
        }

        public TV()
        {
            Brand = "Standart";
            Model = "Standart";
            Diagonal = 20.5;
            _isOn = false;
            MaxVolume = 10;
            _volume = 0;
            FillChannels(50);
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
            if(_isOn == true) _isOn = false;
            else _isOn = true;
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

        public void ChangePlaingChannel(int newChannel)
        {
            if (_isOn == false) TVOn();
            if (newChannel <= Channels.Count && newChannel > 0) _playingChannel = newChannel;
            else _playingChannel = Channels.Count-1;
            Console.WriteLine($"Channel:{Channels[_playingChannel].Stream}-{Channels[_playingChannel].Name}");
        }

        public void NextChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel++;
            if (_playingChannel > Channels.Count) _playingChannel = 1;
            Console.WriteLine($"Channel:{Channels[_playingChannel].Stream}-{Channels[_playingChannel].Name}");
        }

        public void LastChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel--;
            if (_playingChannel < 1) _playingChannel = Channels.Count;
            Console.WriteLine($"Channel:{Channels[_playingChannel].Stream}-{Channels[_playingChannel].Name}");
        }

        public void ListOfChannels()
        {
            if (_isOn == false) TVOn();
            for ( int i = 0; i < Channels.Count; i++ )
            {
                Console.WriteLine($"Channel:{Channels[i].Stream}-{Channels[i].Name}");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nModel:{Model} \nDiagonal:{Diagonal}");
            Console.WriteLine(_isOn ? "On" : "Off");
            ListOfChannels();
            Console.WriteLine($"Now playing \nChannel:{Channels[_playingChannel].Stream}-{Channels[_playingChannel].Name}");
            Console.WriteLine($"Volume:{_volume}/{MaxVolume}");
        }
    }
}
