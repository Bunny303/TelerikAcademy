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
    public class PlacesController : ApiController
    {
        private IRepository<Place> placeRepository;

        public PlacesController(IRepository<Place> repository)
        {
            this.placeRepository = repository;
        }

        [HttpGet]
        public IEnumerable<PlaceModel> GetAll()
        {
            var placeEntities = this.placeRepository.All();

            var placeModel = new List<PlaceModel>();
            foreach (var placeEntity in placeEntities)
            {
                placeModel.Add(new PlaceModel()
                {
                    Id = placeEntity.Id,
                    Name = placeEntity.Name,
                    Longitude = placeEntity.Longitude,
                    Latitude = placeEntity.Latitude
                });
            }
            return placeModel;
        }

        [HttpGet]
        public PlaceFullModel GetById(int id)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The id must be positive");
                throw new HttpResponseException(errorResponse);
            }

            var placeEntity = this.placeRepository.Get(id);

            // Create method for next code
            var placeModel = new PlaceFullModel()
            {
                Id = placeEntity.Id,
                Name = placeEntity.Name,
                Longitude = placeEntity.Longitude,
                Latitude = placeEntity.Latitude,
                Description = placeEntity.Description,
                Categories = (from categoryEntity in placeEntity.Categories
                              select new CategoryModel
                              {
                                  Id = categoryEntity.Id,
                                  Name = categoryEntity.Name,
                                  PlacesCount = (categoryEntity.Places != null) ? categoryEntity.Places.Count : 0
                              }).ToList(),
                Votes = (from voteEntity in placeEntity.Votes
                        select new VoteModel()
                        {
                            Id = voteEntity.Id,
                            Value = voteEntity.Value,
                            Username = voteEntity.Username
                        }).ToList(),
                Comments = (from commentEntity in placeEntity.Comments
                            select new CommentModel()
                            {
                                Id = commentEntity.Id,
                                Test = commentEntity.Test,
                                Username = commentEntity.Username
                            }).ToList()
            };

            return placeModel;
        }

        [HttpPost]
        public HttpResponseMessage PostPlace(Place item)
        {
            if (item == null || item.Name == null)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Object is null");
                return errorResponse;
            }
            var entity = this.placeRepository.Add(item);
            var response = Request.CreateResponse(HttpStatusCode.Created, entity);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));

            return response;
        }
    }
}
