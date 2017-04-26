using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook first = new Cook1("First cook");
            Cook second = new Cook2("Second cook");
            first.setNextCook(second);
            Cook third = new Cook3("Konditer");
            second.setNextCook(third);
            Dishes[] dishes = {new Dishes(Dishes.TypeOfDishes.FIRST, "Sup"),
                                new Dishes(Dishes.TypeOfDishes.SECOND, "Kasha"),
                                new Dishes(Dishes.TypeOfDishes.FIRST, "Borshch"),
                                new Dishes(Dishes.TypeOfDishes.DESSERT, "ice-cream")};
            first.toCook(dishes);
            Console.ReadKey();
        }
    }
}
