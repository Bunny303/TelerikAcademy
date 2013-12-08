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

        public virtual ICollection<Album> Albums { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
