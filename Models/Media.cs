using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Media
    {
        public string Name { get; set; }

        public Media(string name)
        {
            Name = name;
        }

        public Media()
        {

        }

        public virtual string mediaType()
        {
            return "Media";
        }
      
    }
}
