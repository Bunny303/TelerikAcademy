using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    class MP3Player : Article, ISoundable
    {
        public int Memory { get; set; } //internal memory 8GB
        public SoundFormat[] SupportedFormats { get; private set; } //mp3, wmv, wma, etc.
        public Display Display { get; set; } //colours 256k, 2" size
        
        //implementing ISoundable - FrequencyRange & Power
        public Frequency FrequencyRange { get; private set; } //20kHz-90kHz
        public int Power { get; private set; }

        public MP3Player(string manafacturer, string model, decimal price, uint count, int memory,
            SoundFormat[] supportedFormats, Display display,Frequency frequencyRange, int power)
            : base(manafacturer, model, price, count)
        {
            this.Memory = memory;
            this.SupportedFormats = supportedFormats;
            this.Display = display;
            this.FrequencyRange = frequencyRange;
            this.Power = power;
        }
    }
}
