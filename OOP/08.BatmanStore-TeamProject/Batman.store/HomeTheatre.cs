using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    class HomeTheatre : Article, ISoundable, IVideoPlayable
    {
        public Amplifier Amplifier { get; private set; }
        public Speakers[] Speakers { get; private set; }
        public TV TV { get; private set; }
        public DvdPlayer DVDPlayer { get; private set; }

        //implementing ISoundable - FrequencyRange & Power
        public Frequency FrequencyRange { get; private set; } //20kHz-90kHz
        public int Power { get; private set; }
        
        //implementing IVideoPlayable 
        public VideoFormat[] Formats { get; set; }
        public Display Display { get; set; }
        public void PlayVideo()
        {
            throw new NotFiniteNumberException();
        }
        
        public HomeTheatre(string manafacturer, string model, decimal price, uint count,
            Frequency frequencyRange, int power, VideoFormat[] formats, Display display,
            Amplifier amplifier, Speakers[] speakers, TV tv, DvdPlayer dvdPlayer)
            : base(manafacturer, model, price, count)
        {
            this.FrequencyRange = frequencyRange;
            this.Power = power;
            this.Formats = formats;
            this.Display = display;
            this.Amplifier = amplifier;
            this.Speakers = speakers;
            this.TV = tv;
            this.DVDPlayer = dvdPlayer;
        }
    }
}
