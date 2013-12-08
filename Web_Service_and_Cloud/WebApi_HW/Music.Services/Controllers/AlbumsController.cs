using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Music.Models;
using Music.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Music.Services.Controllers
{
    public class AlbumsController : ApiController
    {
        private MusicContext db = new MusicContext();

        public AlbumsController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
                
        // GET api/albums
        public IEnumerable<Album> Get()
        {
            var data = from item in db.Albums.Include("Artists").Include("Songs")
                       select item;
            return data;
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
        public void Post(Album value)
        {
            db.Albums.Add(value);
            db.SaveChanges();
        }

        // PUT api/albums/5
        public HttpResponseMessage Put(int id, Album value)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != value.AlbumId)
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

        // DELETE api/albums/5
        public void Delete(int id)
        {
            //This is faster?
            db.Database.ExecuteSqlCommand(
                "DELETE FROM Albums WHERE AlbumId = {0}", id);
            db.SaveChanges();
        }
    }
}
