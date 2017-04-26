using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("b1");
            Book b2 = new Book("b2");
            Book b3 = new Book("b3");
            Man m1 = new Man("Charly");
            m1.get_book(b1);
            m1.get_book(b2);
            m1.get_book(b3);
            m1.giveBack_book(b2);
            Man m2 = new Man("Karl");
            Ilibrary p = new ProgForLibrary();
            p.giveDataForSearching(m1);
            p.giveDataForSearching(m2);
            Console.ReadKey();
        }
    }
}
