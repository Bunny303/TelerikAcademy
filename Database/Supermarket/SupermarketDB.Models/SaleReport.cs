using System;
using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;

namespace SupermarketDB.Models
{
    public class SaleReport
    {
        private IList<Product> products;

        public SaleReport()
        {
            this.products = new List<Product>();
        }

        [Key]
        public int SaleReportID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Sum { get; set; }

        public string SupermarketName { get; set; }

        public DateTime ReportDate { get; set; }

        public virtual IList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}
