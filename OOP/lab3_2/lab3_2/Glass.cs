﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Glass: Cover
    {
        public Glass()
        {
            cost = 20;
        }
        public override string getName()
        {
            return "Glass";
        }
    }
}
