using Music.Data;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
            var data = from item in db.Songs
                       select item;
            return data;
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
        public HttpResponseMessage Put(int id, [FromBody]Song value)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != value.SongId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(value).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
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
