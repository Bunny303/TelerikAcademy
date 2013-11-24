using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Library;

namespace _03_05.FindCustomers
{
    class Program
    {
        static void Main()
        {
            FindCustomers();
            Console.WriteLine();
            FindCustomersDBContext();
            Console.WriteLine();
            FindSales("RJ", DateTime.Parse("1995.05.10"), DateTime.Parse("2000.09.10"));
        }

        // 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        public static void FindCustomers()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                    .GroupBy(o => o.Customer.CompanyName);
                db.SaveChanges();
                foreach (var c in customers)
                {
                    Console.WriteLine("Customer name: {0}", c.Key);
                }
            }
        }

        // 4. Implement previous by using native SQL query and executing it through the DbContext.
        public static void FindCustomersDBContext()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var customers = db.Database.SqlQuery<string>(@"SELECT c.CompanyName FROM Orders o 
                                                                                JOIN Customers c 
                                                                                ON o.CustomerID = c.CustomerID
                                                                            WHERE YEAR(o.OrderDate) = 1997 AND o.ShipCountry = 'Canada'
                                                                            GROUP BY c.CompanyName");
                db.SaveChanges();
                foreach (var c in customers)
                {
                    Console.WriteLine("Customer name: {0}", c);
                }
            }
        }

        // 5. Write a method that finds all the sales by specified region and period (start / end dates).
        public static void FindSales(string region, DateTime startDate, DateTime endDate)
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                var sales = db.Orders
                    .Where(o => o.ShipRegion == region && o.OrderDate.HasValue && (o.OrderDate > startDate || o.OrderDate < endDate))
                    .GroupBy(o => o.ShipName);
                db.SaveChanges();
                foreach (var s in sales)
                {
                    Console.WriteLine(s.Key);                
                }
            }
        }
    }
}
