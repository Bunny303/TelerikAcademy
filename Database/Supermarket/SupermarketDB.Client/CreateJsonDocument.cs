using Newtonsoft.Json;
using SupermarketDB.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SupermarketDB.Client
{
    public class CreateJsonDocument
    {
        private static List<ProductReport> getAllReports(SupermarketContext db) 
        {
            var reports = new List<ProductReport>();

            foreach (var product in db.Products)
            {
                int totalQuantitySold = 0;
                var foundProduct = db.SalesReports.FirstOrDefault(x => x.ProductID == product.ProductID);
                if(foundProduct!=null)
                {
                    totalQuantitySold = db.SalesReports.Where(x => x.ProductID == product.ProductID)
                                        .Sum(x => x.Quantity);
                }
                
                ProductReport report = new ProductReport()
                {
                    productId = product.ProductID,
                    productName = product.ProductName,
                    vendorName = product.Vendor.VendorName,
                    totalQuantitySold = totalQuantitySold,
                    totalIncomes = product.BasePrice * totalQuantitySold
                };

                reports.Add(report);
            }

            return reports;
        }

        public static void saveJsonFiles(string path, SupermarketContext db)
        {
            var directory = Directory.CreateDirectory(path);
            var reports = getAllReports(db);

            foreach (ProductReport report in reports)
            {
                string currentPath = path + "/" + report.productId.ToString() + ".json";

                using (StreamWriter writer = new StreamWriter(currentPath))
                {
                    writer.Write(JsonConvert.SerializeObject(report));
                }
            }
        }

        public static void saveReportsToMongoDB(SupermarketContext db)
        {
            var mongoClient = new MongoClient("mongodb://admin:qwerty@dharma.mongohq.com:10068/Supermarket");
            var mongoServer = mongoClient.GetServer();
            var supermarketDB = mongoServer.GetDatabase("Supermarket");
            var reportsCollection = supermarketDB.GetCollection("Reports");
            var reports = getAllReports(db);

            foreach (ProductReport report in reports)
            {
                reportsCollection.Insert(report);
            }
        }
    }
}
