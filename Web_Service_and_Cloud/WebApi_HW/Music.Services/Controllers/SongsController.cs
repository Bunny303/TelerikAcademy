using Music.Data;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Music.Services.Controllers
{
    public class SongsController : ApiController
    {
        private MusicContext db = new MusicContext();
        
        // GET api/songs
        public IEnumerable<Song> Get()
        {
            var data = from item in db.Songs.Include("Artists").Include("Albums")
                       select item;
            return data.ToList();
        }

        // GET api/songs/5
        public Song Get(int id)
        {
            var data = db.Songs.Find(id);
            return data;
        }

        // POST api/songs
        public void Post([FromBody]Song value)
        {
            db.Songs.Add(value);
            db.SaveChanges();
        }

        // PUT api/songs/5
        public void Put(int id, [FromBody]Song value)
        {
            var data = db.Songs.Find(id);
            data.SongId = value.SongId;
            data.Title = value.Title;
            data.Year = value.Year;
            data.Genre = value.Genre;
            data.Album = value.Album;
            data.Artist = value.Artist;
            db.SaveChanges();
        }

        // DELETE api/songs/5
        public void Delete(int id)
        {
            db.Database.ExecuteSqlCommand(
                "DELETE FROM Songs WHERE SongId = {0}", id);
            db.SaveChanges();
        }
    }
}
