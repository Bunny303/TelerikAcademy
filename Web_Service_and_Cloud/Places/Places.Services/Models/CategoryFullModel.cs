using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Services.Models
{
    public class CategoryFullModel : CategoryModel
    {
        public IEnumerable<PlaceModel> Places { get; set; }
    }
}