namespace TVshow
{
    internal class TV
    {
        private bool _isOn;
        private List<Channel> _channels;
        private int _playingChannel;
        private int _volume;
        public int Volume
        {
            get { return _volume; }
            private set
            {
                _volume = value;
                if (_volume > MaxVolume)
                    _volume = MaxVolume;
                if (_volume < 0)
                    _volume = 0;
            }
        }
        public string Brand { get; }
        public string Model { get; }
        public double Diagonal { get; }
        public const int MaxVolume = 10;

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
            Volume = 0;
            FillChannels(5);
            _playingChannel = 0;
        }

        public TV(string brand, string model, double diagonal, int channels)
        {
            Brand = brand;
            Model = model;
            Diagonal = diagonal;
            _isOn = false;
            Volume = 0;
            FillChannels(10);
            _playingChannel = 0;
        }

        public void TVOn()
        {
            _isOn = !_isOn;
            Console.WriteLine(_isOn ? "On" : "Off");
        }

        public void ChangeVolume(int volume)
        {
            Volume += volume;
            Console.WriteLine(Volume);
        }

        public void ChangePlayingChannel(int newChannel)
        {
            if (_isOn == false)
                TVOn();
            if (newChannel <= _channels.Count && newChannel > 0)
                _playingChannel = newChannel;
            else
                _playingChannel = _channels.Count - 1;
            Channel.PrintChannel(_channels[_playingChannel]);
        }

        public void NextChannel()
        {
            if (_isOn == false)
                TVOn();
            _playingChannel++;
            if (_playingChannel >= _channels.Count)
                _playingChannel = 0;
            Channel.PrintChannel(_channels[_playingChannel]);
        }

        public void LastChannel()
        {
            if (_isOn == false)
                TVOn();
            _playingChannel--;
            if (_playingChannel < 1)
                _playingChannel = _channels.Count-1;
            Channel.PrintChannel(_channels[_playingChannel]);
        }

        public void ListOfChannels()
        {
            for (int i = 0; i < _channels.Count; i++)
            {
                Channel.PrintChannel(_channels[i]);
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nModel:{Model} \nDiagonal:{Diagonal}");
            Console.WriteLine(_isOn ? "On" : "Off");
            ListOfChannels();
            Channel.PrintChannel(_channels[_playingChannel]);
            Console.WriteLine($"Volume:{Volume}/{MaxVolume}");
        }
    }
}
