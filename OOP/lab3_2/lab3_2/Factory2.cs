using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Factory2: Factory
    {
        public Factory2()
        {
            
        }
        public override Juis create()
        {
            return new Juis(new Banana(), new Glass());
        }
    }
}
