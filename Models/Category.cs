﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category ///////denna kanske bara kan ärva av media ist och då behövs inte category controller/repository men vet inte hur det blir med xmlen då
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
