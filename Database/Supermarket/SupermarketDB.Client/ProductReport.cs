using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDB.Client
{
    public class ProductReport
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string vendorName { get; set; }
        public int totalQuantitySold { get; set; }
        public decimal totalIncomes { get; set; }
    }
}
