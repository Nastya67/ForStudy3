using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class AvailableState: State
    {
        public AvailableState() { }
        public bool tryConect()
        {
            Console.WriteLine("Ok, you conected to server");
            return true;
        }
    }
}
