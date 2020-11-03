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
        public string PodUrl { get; set; }
        public string Frequency { get; set; }
        public string Category { get; set; }
        public DateTime NextUpdate { get; set; }
        public List<Episode> Episodes { get; set; }
        
        public Pod (string name, string podUrl, string frequency, string category, DateTime nextUpdate, List<Episode> episodes) : base (name)
        {
            Name = name;
            PodUrl = podUrl;
            Frequency = frequency;
            Category = category;
            NextUpdate = nextUpdate;
            Episodes = episodes;

        }

        public bool podUpdate
        {

            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }
        public Pod()
        { 
        }

        public override string mediaType()
        {
            return "Podcast";
        }

    }
}
