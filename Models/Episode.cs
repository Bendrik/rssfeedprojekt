﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Episode : Media
    {

        public string Description { get; set; }

        public Episode()
        {
            string description = Description;
        }

        public override string mediaType()
        {
            return "Episode";
        }
    }
}
