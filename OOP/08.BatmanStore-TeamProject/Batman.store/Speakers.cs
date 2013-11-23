using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    class Speakers : Article, ISoundable
    {
        public double Size { get; private set; } //the size of speaker in inchees 12", 12.5" etc.
        public double Sensitivity { get; private set; } //94dB, 120.5dB
        //implementing ISoundable - FrequencyRange & Power
        public Frequency FrequencyRange { get; private set; } //20kHz-90kHz
        public int Power { get; private set; }

        public Speakers(string manafacturer, string model, decimal price, uint count, double size, 
            double sensitivity, Frequency frequencyRange, int power)
            : base(manafacturer, model, price, count)
        {
            this.Size = size;
            this.Sensitivity = sensitivity;
            this.FrequencyRange = frequencyRange;
            this.Power = power;
        }
    }
}
