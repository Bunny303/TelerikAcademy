using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    interface IVideoPlayable
    {
        VideoFormat[] Formats { get; }
        Display Display { get; }
        void PlayVideo();
    }
}
