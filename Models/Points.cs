﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Points
    {
        public int Id { get; set; }
        public int NumberOfPoints { get; set; }
        public virtual Team Team { get; set; }
    }
}
