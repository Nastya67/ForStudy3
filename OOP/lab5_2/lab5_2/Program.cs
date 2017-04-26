using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner first = new ConcClient("first", "1111");
            Worker second = new ConcClient("second", "222");
            Command c = new Command("to cook");
            first.commandToAnother(second, c, "222");
            c.toDo();
            Console.ReadKey();
        }
    }
}
