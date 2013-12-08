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
    public class ArtistsController : ApiController
    {
        private MusicContext db = new MusicContext();
        
        // GET api/artists
        public IEnumerable<Artist> Get()
        {
            var data = from item in db.Artists.Include("Albums").Include("Songs")
                       select item;
            return data.ToList();
        }

        // GET api/artists/5
        public Artist Get(int id)
        {
            var data = db.Artists.Find(id);
            return data;
        }

        // POST api/artists
        public void Post([FromBody]Artist value)
        {
            db.Artists.Add(value);
            db.SaveChanges();
        }

        // PUT api/artists/5
        public void Put(int id, [FromBody]Artist value)
        {
            var data = db.Artists.Find(id);
            data.ArtistId = value.ArtistId;
            data.Name = value.Name;
            data.Country = value.Country;
            data.DateOfBirth = value.DateOfBirth;
            data.Albums = value.Albums;
            data.Songs = value.Songs;
            db.SaveChanges();
        }

        // DELETE api/artists/5
        public void Delete(int id)
        {
            db.Database.ExecuteSqlCommand(
                "DELETE FROM Artists WHERE ArtistId = {0}", id);
            db.SaveChanges();
        }
    }
}
