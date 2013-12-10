using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Repositories
{
    public class DbVotesRepository:IRepository<Vote>
    {
        private DbContext dbContext;
        private DbSet<Vote> entitySet;

        public DbVotesRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Vote>();
        }

        public Vote Add(Vote item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Vote Update(int id, Vote item)
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

        public void Delete(Vote item)
        {
            this.entitySet.Remove(item);
            this.dbContext.SaveChanges();
        }

        public Vote Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Vote> All()
        {
            return this.entitySet;
        }

        public IQueryable<Vote> Find(System.Linq.Expressions.Expression<Func<Vote, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
