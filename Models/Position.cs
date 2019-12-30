using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Position
    {
        public int Id { get; set; }
        public int TeamPosition { get; set; }
        public virtual Team Team { get; set; }
    }
}
