using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Man
    {
        public String name;
        public List<Book> taken;
        public Man(String name)
        {
            this.name = name;
            taken = new List<Book>();
        }
        public void get_book(Book book)
        {
            taken.Add(book);
        }
        public void giveBack_book(Book book)
        {
            taken.Remove(book);
        }
    }
}
