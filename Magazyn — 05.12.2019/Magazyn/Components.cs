﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    abstract class Components
    {
        public string name;
        public double price;

        public Components(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
