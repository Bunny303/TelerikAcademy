using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public class ArticleEventArgs : EventArgs
    {
        public Article Article { get; private set; }

        public ArticleEventArgs(Article article)
        {
            Article = article;
        }
    }
}
