using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class DvdPlayer : Article, IVideoPlayable
    {
        private Dimensions dimentions;
        private VideoFormat[] formats;
        private Display display;


        public DvdPlayer(string manufacturer, string model, decimal price, uint count, Dimensions dimentions, VideoFormat[] formats, Display display)
            : base(manufacturer, model, price, count)
        {
            this.dimentions = dimentions;
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
            throw new NotImplementedException();
        }
    }
}
