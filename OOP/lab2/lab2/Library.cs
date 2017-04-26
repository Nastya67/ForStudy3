using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Library: Ilibrary
    {
        public void giveDataForSearching(Man m)
        {
            Console.WriteLine("Ok, "+m.name+"! You can search");
        }
    }
}
