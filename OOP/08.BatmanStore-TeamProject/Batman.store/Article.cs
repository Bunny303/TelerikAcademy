using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public abstract class Article 
    {
        public Guid Id { get; private set; } 
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; private set; } 
        public uint Count { get; set; }

        protected Article(string manufacturer, string model, decimal price, uint count)
        {
            this.Id = Guid.NewGuid();
            this.Manufacturer = manufacturer;
            this.Model = model;
            if (price>=0)
            {
                this.Price = price;
            }
            else 
            {
                throw new StoreException("Price must be non negative");
            }
            this.Count = count;
        }

        public override string ToString()
        {
            string printArticle = GetType().Name + " " + this.Manufacturer + " " + this.Model;
            
            return printArticle;
        } 
    }
}
