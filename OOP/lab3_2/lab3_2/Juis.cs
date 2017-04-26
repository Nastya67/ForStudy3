using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public class Juis
    {
        Fruit fruit;
        Cover cover;
        public Juis(Fruit fruit, Cover cover) {
            this.fruit = fruit;
            this.cover = cover;
        }
        public string show()
        {
            return "Juice made of " + fruit.getName() + " packed in "+cover.getName();
        }
    }
}
