using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Services.Models
{
    public class CommentFullModel:CommentModel 
    {
        public PlaceModel Place { get; set; }
    }
}