using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupermarketDB.Models
{
    public class Vendor
    {
        private IList<Product> products;

        public Vendor()
        {
            this.products = new List<Product>();
        }

        [Key]
        public int VendorID { get; set; }

        public string VendorName { get; set; }

        public virtual IList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}
