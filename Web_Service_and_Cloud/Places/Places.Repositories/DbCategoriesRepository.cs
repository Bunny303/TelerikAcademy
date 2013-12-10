using PlacesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Places.Repositories
{
    public class DbCategoriesRepository : IRepository<Category>
    {
        private DbContext dbContext;
        private DbSet<Category> entitySet;

        public DbCategoriesRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Category>();
        }

        public Category Add(Category item)
        {
            //validation if category is between 1 and 5
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Category Update(int id, Category item)
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

        public void Delete(Category item)
        {
            this.entitySet.Remove(item);
            this.dbContext.SaveChanges();
        }

        public Category Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Category> All()
        {
            return this.entitySet;
        }

        public IQueryable<Category> Find(Expression<Func<Category, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
