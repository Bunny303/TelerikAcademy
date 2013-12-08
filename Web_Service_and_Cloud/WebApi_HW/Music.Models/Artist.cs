using System;
using System.Collections.Generic;

namespace Music.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public virtual IList<Album> Albums { get; set; }
                
        public virtual IList<Song> Songs { get; set; }
    }
}
