using Places.Repositories;
using Places.Services.Models;
using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Places.Services.Controllers
{
    public class CommentsController : ApiController
    {
        private IRepository<Comment> commentRepository;

        public CommentsController(IRepository<Comment> repository)
        {
            this.commentRepository = repository;
        }

        [HttpGet]
        public IEnumerable<CommentModel> GetAll()
        {
            var commentEntities = this.commentRepository.All();

            var commentModel = new List<CommentModel>();
            foreach (var commentEntity in commentEntities)
            {
                commentModel.Add(new CommentModel()
                {
                    Id = commentEntity.Id,
                    Test = commentEntity.Test,
                    Username = commentEntity.Username
                });
            }
            return commentModel;
        }

        [HttpGet]
        public CommentFullModel GetById(int id)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The id must be positive");
                throw new HttpResponseException(errorResponse);
            }

            var commentEntity = this.commentRepository.Get(id);

            var commentModel = new CommentFullModel()
            {
                Id = commentEntity.Id,
                Test = commentEntity.Test,
                Username = commentEntity.Username,
                Place = new PlaceModel()
                {
                    Id = commentEntity.Place.Id,
                    Name = commentEntity.Place.Name,
                    Longitude = commentEntity.Place.Longitude,
                    Latitude = commentEntity.Place.Latitude
                }
            };

            return commentModel;
        }

        [HttpPost]
        public HttpResponseMessage PostComment(Comment item)
        {
            if (item == null)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Object is null");
                return errorResponse;
            }
            var entity = this.commentRepository.Add(item);
            var response = Request.CreateResponse(HttpStatusCode.Created, entity);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));

            return response;
        }

        [HttpPut]
        public HttpResponseMessage PutComment(int id, Comment item)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ID must be positive");
                return errorResponse;
            }
            if (item == null)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Object is null");
                return errorResponse;
            }
            var entity = this.commentRepository.Update(id, item);
            var response = Request.CreateResponse(HttpStatusCode.OK, entity);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));

            return response;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteComment(int id)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ID must be positive");
                return errorResponse;
            }
            this.commentRepository.Delete(id);
            var response = Request.CreateResponse(HttpStatusCode.OK);

            return response;
        }
    }
}
