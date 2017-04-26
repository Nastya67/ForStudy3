using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Factory1: Factory
    {
        public Factory1()
        {
            
        }
        public override Juis create()
        {
            return new Juis(new Apple(), new Glass());
        }
    }
}
