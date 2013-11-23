using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batman.store
{
    public interface ISoundable
    {
        int Power {get; } //the power of the audio measured in Watts
        Frequency FrequencyRange{ get; } //the supported frequency(int lower, int higher)
    }
}
