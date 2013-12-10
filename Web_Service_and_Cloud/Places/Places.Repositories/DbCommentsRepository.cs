using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Repositories
{
    public class DbCommentsRepository: IRepository<Comment>
    {
        private DbContext dbContext;
        private DbSet<Comment> entitySet;

        public DbCommentsRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Comment>();
        }

        public Comment Add(Comment item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Comment Update(int id, Comment item)
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

        public void Delete(Comment item)
        {
            this.entitySet.Remove(item);
            this.dbContext.SaveChanges();
        }

        public Comment Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Comment> All()
        {
            return this.entitySet;
        }

        public IQueryable<Comment> Find(System.Linq.Expressions.Expression<Func<Comment, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
