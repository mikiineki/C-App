using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int Amount { get; set; } 
        public virtual Team Team { get; set; } 
    }
}
