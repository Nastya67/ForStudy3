using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Banana: Fruit
    {
        public Banana()
        {
            cost = 25;
        }
        public override string getName()
        {
            return "Banana";
        }
    }
}
