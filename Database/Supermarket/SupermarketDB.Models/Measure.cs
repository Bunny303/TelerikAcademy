using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupermarketDB.Models
{
    public class Measure
    {
        private IList<Product> products;

        public Measure()
        {
            this.products = new List<Product>();
        }

        [Key]
        public int MeasureID { get; set; }

        public string MeasureName { get; set; }

        public virtual IList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}
