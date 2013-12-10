using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Repositories
{
    public class DbPlacesRepository : IRepository<Place>
    {
        private DbContext dbContext;
        private DbSet<Place> entitySet;

        public DbPlacesRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Place>();
        }

        public Place Add(Place item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Place Update(int id, Place item)
        {
            var attachedEntry = this.entitySet.Find(id);
            dbContext.Entry(attachedEntry).CurrentValues.SetValues(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var item = this.entitySet.Find(id);
            this.entitySet.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void Delete(Place item)
        {
            this.entitySet.Remove(item);
            this.dbContext.SaveChanges();
        }

        public Place Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Place> All()
        {
            return this.entitySet;
        }

        public IQueryable<Place> Find(System.Linq.Expressions.Expression<Func<Place, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
