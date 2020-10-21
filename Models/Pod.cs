using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pod : Media
    {
        public string Frequency { get; set; }
        public int EpisodeAmount { get; set; }
        public string Category { get; set; }
        public Pod (string name) : base (name)
        {
            string frequency = Frequency;
            int episodeAmount = EpisodeAmount;
            string category = Category;
        }

    }
}
