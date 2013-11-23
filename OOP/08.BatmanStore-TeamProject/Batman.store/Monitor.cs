using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class Monitor : Article, IVideoPlayable
    {
        bool hasTuner;
        private VideoFormat[] formats;
        private Display display;

        public Monitor(string manufacturer, string model, decimal price, uint count, bool hasTuner, VideoFormat[] formats, Display display)
            :base(manufacturer, model, price, count)
        {
            this.hasTuner = hasTuner;
            this.formats = formats;
            this.display = display;
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

        public VideoFormat[] Formats
        {
            get
            {
                return this.formats;
            }
        }

        public void PlayVideo()
        {
            throw new NotFiniteNumberException();
        }
    }
}
