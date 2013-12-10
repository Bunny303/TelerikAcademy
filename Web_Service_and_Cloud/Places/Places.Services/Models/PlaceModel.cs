﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Places.Services.Models
{
    public class PlaceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }
    }
}
