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
        public string Category { get; set; }

        public List<Episode> Episodes { get; set; }
        
        public Pod (string name) : base (name)
        {
            string frequency = Frequency;
            string category = Category;

        }

    }
}
