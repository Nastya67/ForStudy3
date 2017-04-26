using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Dishes
    {
        public string name { get; }
        public enum TypeOfDishes {FIRST, SECOND, DESSERT }
        public TypeOfDishes typeDishes; 
        public Dishes(TypeOfDishes td, string name)
        {
            this.name = name;
            typeDishes = td;
        }
    }
}
