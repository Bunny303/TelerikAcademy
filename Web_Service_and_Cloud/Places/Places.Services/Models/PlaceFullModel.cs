using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Services.Models
{
    public class PlaceFullModel:PlaceModel
    {
        public string Description { get; set; }
        public virtual IEnumerable<CategoryModel> Categories { get; set; }
        public virtual IEnumerable<VoteModel> Votes { get; set; }
        public virtual IEnumerable<CommentModel> Comments { get; set; }
    }
}