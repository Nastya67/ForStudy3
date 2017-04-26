using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f1 = new Factory1();
            Factory f2 = new Factory2();
            Factory f3 = new Factory3();
            Console.WriteLine("1 factory: "+ f1.create().show());
            Console.WriteLine("2 factory: " + f2.create().show());
            Console.WriteLine("3 factory: " + f3.create().show());

         


            Console.ReadKey();
        }
    }
}
                                                             