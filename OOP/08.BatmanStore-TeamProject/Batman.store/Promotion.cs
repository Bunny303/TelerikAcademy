using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class Promotion
    {
        public DateTime Start { get; set; }
        public byte Days { get; set; }
        public Article PromotedArticle { get; set; }
        public decimal NewPrice { get; private set; }

        public Promotion(DateTime start, byte days, Article promotedArticle, decimal newPrice)
        {
            this.Start = start;
            this.Days = days;
            this.PromotedArticle = promotedArticle;
            this.NewPrice = newPrice;
        }

        public override string ToString()
        {
            StringBuilder printPromotion = new StringBuilder();
            printPromotion.AppendLine("Start date:" + this.Start);
            printPromotion.AppendLine("End Date: " + this.Start.AddDays(this.Days));
            printPromotion.AppendLine("Promoted article: " + this.PromotedArticle);
            printPromotion.AppendLine("Old price: " + PromotedArticle.Price);
            printPromotion.AppendLine("New price: " + this.NewPrice);

            return printPromotion.ToString();
        } 
    }
}
