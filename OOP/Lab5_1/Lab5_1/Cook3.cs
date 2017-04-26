﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Cook3 : Cook
    {
        public string name { get; }
        public Cook3(string Name)
        {
            name = Name;

        }
        public override void toCook(Dishes[] dishes)
        {
            foreach (Dishes d in dishes)
            {
                if (d.typeDishes == Dishes.TypeOfDishes.DESSERT)
                {
                    Console.WriteLine(name + " cooked dessert: " + d.name);
                }
            }
            if (_next_cook != null)
            {
                _next_cook.toCook(dishes);
            }
        }
    }
}
