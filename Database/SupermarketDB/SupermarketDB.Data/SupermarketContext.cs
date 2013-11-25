﻿using System;
using SupermarketDB.Models;
using System.Data.Entity;

namespace SupermarketDB.Data
{
    public class SupermarketContext :DbContext
    {
        public SupermarketContext():base("SupermarketDataBase")
        { }

        public DbSet<Measure> Measures { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
