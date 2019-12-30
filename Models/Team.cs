using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Team
    {
        public Team()
        {
            Wins = new List<Wins>();
            Losses = new List<Losses>();
            Draws = new List<Draws>();
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Wins> Wins { get; set; }
        public virtual IList<Losses> Losses { get; set; }
        public virtual IList<Draws> Draws { get; set; }
        public virtual IList<Player> Players { get; set; }
    }
}
