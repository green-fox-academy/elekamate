﻿using System;
using System.Collections.Generic;

namespace Exam_Orientation_Macrotis.Models
{
    public partial class Attraction
    {
        public int Id { get; set; }
        public string AttrName { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public double? Longitude { get; set; }
        public double? Lattitude { get; set; }
        public double? RecommendedAge { get; set; }
        public int? Duration { get; set; }
    }
}
