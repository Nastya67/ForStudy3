using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Factory3: Factory
    {
        public Factory3()
        {
            
        }
        public override Juis create()
        {
            return new Juis(new Strawberry(), new Paper());
        }
    }
}
