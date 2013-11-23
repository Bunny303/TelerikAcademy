using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class TV: Article, IVideoPlayable
    {
        public string boxingColor;
        private VideoFormat[] formats;
        private Display display;

        public TV(string manufacturer, string model, decimal price, uint count, string boxingColor, VideoFormat[] formats, Display display)
            :base(manufacturer,  model,  price,  count)
        {
            this.boxingColor = boxingColor;
            this.formats = formats;
            this.display = display;
        }

        public string BoxingColor
        {
            get
            {
                return this.boxingColor;
            }
        }

        public VideoFormat[] Formats
        {
            get
            {
                return this.formats;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }

        
    }
}
