using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupermarketDB.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public int? VendorID { get; set; }

        public int? MeasureID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal BasePrice { get; set; }
    }
}
