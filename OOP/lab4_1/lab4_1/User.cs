using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class User
    {
        public string name { get; private set; }
        public User(string name)
        {
            this.name = name;
        }
    }
}
