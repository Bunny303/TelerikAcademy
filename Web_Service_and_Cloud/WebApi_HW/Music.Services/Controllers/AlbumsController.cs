using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Music.Models;
using Music.Data;

namespace Music.Services.Controllers
{
    public class AlbumsController : ApiController
    {
        private MusicContext db = new MusicContext();
                
        // GET api/albums
        public IEnumerable<Album> Get()
        {
            var data = from item in db.Albums.Include("Artists").Include("Songs")
                       select item;
            return data.ToList();
        }

        // GET api/albums/5
        public Album Get(int id)
        {
            var data = db.Albums.Find(id);
            return data;
            //var data = from item in db.Albums
            //           where item.AlbumId == id
            //           select item;
            //return data.SingleOrDefault(); --> Which of them is faster?
        }

        // POST api/albums
        public void Post([FromBody]Album value)
        {
            db.Albums.Add(value);
            db.SaveChanges();
        }

        // PUT api/albums/5
        public void Put(int id, [FromBody]Album value)
        {
            //Is this the best way?
            var data = db.Albums.Find(id);
            data.AlbumId = value.AlbumId;
            data.Title = value.Title;
            data.Year = value.Year;
            data.Producer = value.Producer;
            data.Artists = value.Artists;
            data.Songs = value.Songs;
            db.SaveChanges();
        }

        // DELETE api/albums/5
        public void Delete(int id)
        {
            //This is faster
            db.Database.ExecuteSqlCommand(
                "DELETE FROM Albums WHERE AlbumId = {0}", id);
            db.SaveChanges();
        }
    }
}
