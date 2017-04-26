using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Strawberry: Fruit
    {
        public Strawberry()
        {
            cost = 10;
        }
        public override string getName()
        {
            return "Straberry";
        }
    }
}
