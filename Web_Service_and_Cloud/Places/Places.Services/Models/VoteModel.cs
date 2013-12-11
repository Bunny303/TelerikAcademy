using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Services.Models
{
    public class VoteModel
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Username { get; set; }
    }
}