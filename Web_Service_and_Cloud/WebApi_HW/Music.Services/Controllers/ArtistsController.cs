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
    public class ArtistsController : ApiController
    {
        private MusicContext db = new MusicContext();
        
        // GET api/artists
        public IEnumerable<Artist> Get()
        {
            var data = from item in db.Artists.Include("Albums").Include("Songs")
                       select item;
            return data;
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
        public HttpResponseMessage Put(int id, [FromBody]Artist value)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != value.ArtistId)
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

        // DELETE api/artists/5
        public void Delete(int id)
        {
            db.Database.ExecuteSqlCommand(
                "DELETE FROM Artists WHERE ArtistId = {0}", id);
            db.SaveChanges();
        }
    }
}
