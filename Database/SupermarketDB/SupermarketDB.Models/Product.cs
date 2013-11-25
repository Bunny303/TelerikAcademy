using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketDB.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        //[ForeignKey("Vedor")]
        public int VendorID { get; set; }

        //[ForeignKey("Measure")]
        public int MeasureID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal BasePrice { get; set; }
    }
}
