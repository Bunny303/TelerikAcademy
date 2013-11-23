using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class Store
    {
        private static Store instance;
       
        private Store()
        {}

        public static Store Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Store();
                }
                return instance;
            }
        }

        private Dictionary<string, Article> articles;

        public Dictionary<string, Article> Articles
        {
            get
            {
                if (this.articles == null)
                {
                    this.articles = new Dictionary<string, Article>();
                }
                return this.articles;
            }
            set { this.articles = value; }
        }

        private List<Promotion> promotions;

        public List<Promotion> Promotions
        {
            get
            {
                if (this.promotions == null)
                {
                    this.promotions = new List<Promotion>();
                }
                return this.promotions;
            }
            set { this.promotions = value; }
        }

        public void Load(Article article)
        {
            var key = article.GetType().Name + " " + article.Model;

            var alreadyHave = this.Articles.FirstOrDefault(a => a.Key == key);
            if (alreadyHave.Key==null )
            {
                this.Articles.Add(key, article);
                this.Promotions.Add(new Promotion(DateTime.Now, 3, article, (article.Price - article.Price * 0.1m))); 
            }
            else
            {
                alreadyHave.Value.Count += article.Count;
            }
        }
                
        public void Sell(string type, string model) 
        {
            var key = type + " " + model;
            if (Articles.Count != 0)
            {
                var soldArticle = this.Articles.FirstOrDefault(a => a.Key == key);
                if (soldArticle.Key == null)
                {
                    throw new StoreException("The article is out of stock");
                }
                else
                {
                    if (soldArticle.Value.Count == 1)
                    {
                        this.Articles.Remove(key);
                    }
                    else
                    {
                        soldArticle.Value.Count--;
                    }
                }
            }
            else
            {
                throw new StoreException("Batman store is bankrupt!");
            }
        }

        private void AddPromotion(Promotion promotion)
        {
            this.Promotions.Add(promotion);
        }

        public void ShowAllPromotions()
        {
            foreach (var promotion in this.Promotions)
            {
                Console.WriteLine(promotion);
            }
        }

        public void GetQuantity(Article article)
        {
            var key = article.GetType().Name + " " + article.Model;
            Console.WriteLine("Article: {0}\nModel: {1}", article.GetType().Name, article.Model);
            Console.WriteLine("Quantity: {0}", this.Articles[key].Count);
        }
    }
}
