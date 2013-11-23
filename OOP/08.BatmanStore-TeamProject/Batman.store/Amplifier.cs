using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    class Amplifier : Article, ISoundable
    {
        public bool HasEqualizer { get; private set; } //hasEqualizer
        public int RecordOutput { get; private set; } //outputs for other sounds
        public int SubwooferOutput { get; private set; } //outputs for subwoofer

        //implementing ISoundable - FrequencyRange & Power
        public Frequency FrequencyRange { get; private set; } //20kHz-90kHz
        public int Power { get; private set; }

        public Amplifier(string manafacturer, string model, decimal price, uint count, bool hasEqualizer, 
            int recordOutput, int subwooferOutput)
            : base(manafacturer, model, price, count)
        {
            this.HasEqualizer = hasEqualizer;
            this.RecordOutput = recordOutput;
            this.SubwooferOutput = subwooferOutput;
        }


    }
}
