using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ProgForLibrary : Ilibrary
    {
        Library library = new Library();
        public void giveDataForSearching(Man m)
        {
            if (m.taken.Count == 0)
                library.giveDataForSearching(m);
            else
                Console.WriteLine("Sory, "+m.name+"! You must give back your books firstly");
        }
    }
}
