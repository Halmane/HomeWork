using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    internal class TV
    {
        string Brand { get; }
        string Model { get; }
        double Diagonal { get; }
        private bool _isOn;
        Dictionary<int, string> Channels { get; }
        private int _plaingChannel;
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
            FillChannels();
            _plaingChannel = 1;
        }
        public TV(string brand, string model, double diagonal) 
        {
            Brand = brand;
            Model = model;
            Diagonal = diagonal;
            _isOn = false;
            MaxVolume = 10;
            _volume = 0;
            FillChannels();
            _plaingChannel = 1;
        }

        private void FillChannels()
        {
            for(int i = 1; i <= 10; i++) 
            {
                Channels.Add(i,i.ToString());
            }
        }

        public void TVOn()
        {
            if(_isOn == true) _isOn = false;
            else _isOn = true;
        }

        public void ChangeVolume(int volume)
        {
            _volume += volume;
            if (_volume > MaxVolume) _volume = MaxVolume;
            if(_volume < 0) _volume = 0;
            Console.WriteLine(_volume);
        }

        public void ChangePlaingChanell(int newChanell)
        {
            
        }
    }
}
