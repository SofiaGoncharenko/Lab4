﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class CompareName : IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }
}
