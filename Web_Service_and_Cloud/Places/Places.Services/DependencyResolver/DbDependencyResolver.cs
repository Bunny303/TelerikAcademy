using Places.Repositories;
using Places.Services.Controllers;
using PlacesDatabase.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace Places.Services.DependencyResolver
{
    public class DbDependencyResolver: IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            var dbContext = new PlacesContext();

            if (serviceType == typeof(CategoriesController))
            {
                var repository = new DbCategoriesRepository(dbContext);
                return new CategoriesController(repository);
            }
            else if (serviceType == typeof(CommentsController))
            {
                var repository = new DbCommentsRepository(dbContext);
                return new CommentsController(repository);
            }
            else if (serviceType == typeof(PlacesController))
            {
                var repository = new DbPlacesRepository(dbContext);
                return new PlacesController(repository);
            }
            else if (serviceType == typeof(VotesController))
            {
                var repository = new DbVotesRepository(dbContext);
                return new VotesController(repository);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}