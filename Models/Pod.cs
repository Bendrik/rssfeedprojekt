using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class Pod : Media
    {
        //public string Name { get; set; }
        public string PodUrl { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }

        public List<Episode> Episodes { get; set; }
        
        public Pod (string name, string podUrl, string frequency, string category, List<Episode> episodes) : base (name)
        {
            Name = name;
            PodUrl = podUrl;
            Frequency = frequency;
            Category = category;
            Episodes = episodes;

        }
        public Pod()
        { 
        }

    }
}
