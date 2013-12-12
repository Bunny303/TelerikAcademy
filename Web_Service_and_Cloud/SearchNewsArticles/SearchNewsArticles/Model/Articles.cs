using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNewsArticles.Model
{
    public class Articles
    {
        public List<Article> articles { get; set; }
        public string description { get; set; }
        public string syndication_url { get; set; }
        public string title { get; set; }
    }
}
