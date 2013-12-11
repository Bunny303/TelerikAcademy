using Places.Repositories;
using Places.Services.Models;
using PlacesDatabase.DataLayer;
using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Places.Services.Controllers
{
    public class CategoriesController : ApiController
    {
        private IRepository<Category> categoryRepository;

        // Use Iok - dependency resolver
        //public CategoriesController()
        //{
        //    var dbContext = new PlacesContext();
        //    this.categoryRepository = new DbCategoriesRepository(dbContext);
        //}

        public CategoriesController(IRepository<Category> repository)
        { 
            this.categoryRepository = repository;
        }
        
        [HttpGet]
        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryEntities =  this.categoryRepository.All();

            var categoryModel = new List<CategoryModel>();
            foreach (var categoryEntity in categoryEntities)
            {
                categoryModel.Add(new CategoryModel()
                                {
                                    Id = categoryEntity.Id,
                                    Name = categoryEntity.Name,
                                    PlacesCount = (categoryEntity.Places != null) ? categoryEntity.Places.Count : 0
                                });
            }
            return categoryModel; 
        }

        [HttpGet]
        public CategoryFullModel GetById(int id)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The id must be positive");
                throw new HttpResponseException(errorResponse);
            }

            var categoryEntity = this.categoryRepository.Get(id);

            // Create method for next code
            var categoryModel = new CategoryFullModel()
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
                Places = (from placeEntity in categoryEntity.Places
                               select new PlaceModel()
                               {
                                Id = placeEntity.Id,
                                Name = placeEntity.Name,
                                Longitude = placeEntity.Longitude,
                                Latitude = placeEntity.Latitude,
                               }).ToList()
            };

            return categoryModel;
        }

        [HttpPost]
        public HttpResponseMessage PostCategory(Category item)
        {
            if (item == null || item.Name == null)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Object is null");
                return errorResponse;
            }
            var entity = this.categoryRepository.Add(item);
            var response = Request.CreateResponse(HttpStatusCode.Created, entity);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));

            return response;
        }

        [HttpPut]
        public HttpResponseMessage PutCategory(int id, Category item)
        {
            if (id<=0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ID must be positive");
                return errorResponse;
            }
            if (item == null || item.Name == null)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Object is null");
                return errorResponse;
            }
            var entity = this.categoryRepository.Update(id, item);
            var response = Request.CreateResponse(HttpStatusCode.OK, entity);
            response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = entity.Id }));

            return response;
        } 

        [HttpDelete]
        public HttpResponseMessage DeleteCategory(int id)
        {
            if (id <= 0)
            {
                var errorResponse = this.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ID must be positive");
                return errorResponse;
            }
            this.categoryRepository.Delete(id);
            var response = Request.CreateResponse(HttpStatusCode.OK);

            return response;
        }
    }
}