using System;
using SupermarketDB.Data;
using SupermarketDB.Data.Migrations;
using SupermarketDB.Models;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using SupermarketModelMySql;

namespace SupermarketDB.Client
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SupermarketContext, Configuration>());

            var db = new SupermarketContext();
            string conStr = "Server=localhost; Port=3306; Database=supermarketdb; Uid=root; Pwd=6okolad; pooling=true";
            SupermarketModel mySqlDB = new SupermarketModel(conStr);

            TransferData(mySqlDB, db);
        }

        // Copy data from auto-generates MySql classes to code first made classes for MS SQL Database
        public static void TransferData(SupermarketModel mySQL, SupermarketContext msSQL)
        {
            //msSQL.Database.Delete();
            using (msSQL)
            {
                foreach (var product in mySQL.Products)
                {
                    var newProduct = new SupermarketDB.Models.Product
                    {
                        ProductID = product.ProductID,
                        VendorID = product.VendorID,
                        MeasureID = product.MeasureID,
                        ProductName = product.ProductName,
                        BasePrice = product.BasePrice
                    };

                    msSQL.Products.Add(newProduct);
                    msSQL.SaveChanges();
                }

                //foreach (var measure in mySQL.Measures)
                //{
                //    var newMeasure = new SupermarketDB.Models.Measure
                //    {
                //        MeasureID = measure.MeasureID,
                //        MeasureName = measure.MeasureName
                //    };

                //    msSQL.Measures.Add(newMeasure);
                //    msSQL.SaveChanges();
                //}

                //foreach (var vendor in mySQL.Vendors)
                //{
                //    var newVendor = new SupermarketDB.Models.Vendor
                //    {
                //        VendorID = vendor.VendorID,
                //        VendorName = vendor.VendorName
                //    };

                //    msSQL.Vendors.Add(newVendor);
                //    msSQL.SaveChanges();
                //}


            }
        }
        
    }
}
