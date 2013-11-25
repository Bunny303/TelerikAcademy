using System;
using SupermarketDB.Data;
using SupermarketDB.Models;

namespace SupermarketDB.Client
{
    class Program
    {
        static void Main()
        {
            var db = new SupermarketContext();
            var newVendor = new Vendor();
            newVendor.VendorName = "test";
            db.Vendors.Add(newVendor);
            db.SaveChanges();
        }
    }
}
