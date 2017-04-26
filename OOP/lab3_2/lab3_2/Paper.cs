using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Paper: Cover
    {
        public Paper()
        {
            cost = 5;
        }
        public override string getName()
        {
            return "Paper";
        }
    }
}
