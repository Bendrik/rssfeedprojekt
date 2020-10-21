using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Media
    {
        //public int EpisodeAmount { get; set; }
        public string Name { get; set; }

        public Media(string name)
        {
            //EpisodeAmount = episodeAmount;
            Name = name;
        }
      
    }
}
