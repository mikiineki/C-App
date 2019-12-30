using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public virtual Team Team { get; set; }
    }
}
