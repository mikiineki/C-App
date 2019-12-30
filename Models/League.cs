using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
    }
}
