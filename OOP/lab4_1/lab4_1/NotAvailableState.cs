using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class NotAvailableState: State
    {
        public NotAvailableState() { }
        public bool tryConect()
        {
            Console.WriteLine("Server is full. You can't conect");
            return false;
        }
    }
}
