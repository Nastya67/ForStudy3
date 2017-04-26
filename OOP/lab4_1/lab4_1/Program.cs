using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server(4);
            s.conect(new User("Yana"));
            s.conect(new User("Lusia"));
            s.conect(new User("Nastya"));
            s.conect(new User("Vania"));
            s.conect(new User("Ania"));
            s.conect(new User("Dima"));
            Console.ReadKey();
        }
    }
}
