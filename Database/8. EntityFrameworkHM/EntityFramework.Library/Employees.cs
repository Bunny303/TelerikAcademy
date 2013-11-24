using System;
using System.Linq;
using System.Data.Linq;
using EntityFramework.Library;

namespace NorthwindObjectContext
{
    // 8. By inheriting the Employee entity class create a class which allows employees to access their corresponding 
    // territories as property of type EntitySet<T>.
        
    public partial class Employees
    {
        private EntitySet<Territory> entityTerritories;

        public EntitySet<Territory> EntityTerritories
        {
            get
            {
                //var employeeTerritories = Employees.Territories;
                EntitySet<Territory> entityTerritories = new EntitySet<Territory>();
                //entityTerritories.AddRange(employeeTerritories);
                return entityTerritories;
            }
        }
    }
}