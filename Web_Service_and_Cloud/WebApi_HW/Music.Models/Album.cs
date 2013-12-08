using System;
using System.Collections.Generic;

namespace Music.Models
{
    public class Album
    {
        private ICollection<Artist> artists;
        private ICollection<Song> songs;

        public Album()
        {
            this.artists = new HashSet<Artist>();
            this.songs = new HashSet<Song>();
        }

        public virtual ICollection<Artist> Artists { get; set; }
                
        public virtual ICollection<Song> Songs { get; set; }
                        
        public int AlbumId { get; set; }
        
        public string Title { get; set; }

        public string Year { get; set; }

        public string Producer { get; set; }
    }
}
