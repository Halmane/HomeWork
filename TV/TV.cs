using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVshow
{
    internal class TV
    {
        public string Brand { get; }
        public string Model { get; }
        public double Diagonal { get; }
        private bool _isOn;
        private List<string> Channels;
        private int _playingChannel;
        private int _volume;
        int MaxVolume { get; }

        public TV()
        {
            Brand = "Standart";
            Model = "Standart";
            Diagonal = 20.5;
            _isOn = false;
            MaxVolume = 10;
            _volume = 0;
            FillChannels(51);
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
            FillChannels(channels);
            _playingChannel = 1;
        }

        private void FillChannels(int count)
        {
            Channels = new List<string>();
            for (int i = 1; i <= count; i++) 
            {
                Channels.Add(GetRandomChannels());
            }
        }

        private string GetRandomChannels()
        {
            Random random = new Random();

            List<string> channel = new List<string> { "МузТВ", "Нтв", "МатчТВ", "Дисней", "Первый", "СТС", "ТНТ", "Nickelodeon" };
            return channel[random.Next(channel.Count)];
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
            else _playingChannel = Channels.Count;
            Console.WriteLine($"Channel:{_playingChannel}-{Channels[_playingChannel]}");
        }

        public void NextChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel++;
            if (_playingChannel > Channels.Count) _playingChannel = 1;
            Console.WriteLine($"Channel:{_playingChannel}-{Channels[_playingChannel]}");
        }

        public void LastChannel()
        {
            if (_isOn == false) TVOn();
            _playingChannel--;
            if (_playingChannel < 1) _playingChannel = Channels.Count;
            Console.WriteLine($"Channel:{_playingChannel}-{Channels[_playingChannel]}");
        }

        public void ListOfChannels()
        {
            if (_isOn == false) TVOn();
            for ( int i = 1; i < Channels.Count; i++ )
            {
                Console.WriteLine($"Channel:{i}-{Channels[i]}");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nModel:{Model} \nDiagonal:{Diagonal}");
            Console.WriteLine(_isOn ? "On" : "Off");
            ListOfChannels();
            Console.WriteLine($"Now playing \nChannel:{_playingChannel}-{Channels[_playingChannel]}");
            Console.WriteLine($"Volume:{_volume}/{MaxVolume}");
        }
    }
}
