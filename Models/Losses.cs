﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Losses
    {
        public int Id { get; set; }
        public int LossesNumber { get; set; }
        public virtual Team Team { get; set; }
    }
}
