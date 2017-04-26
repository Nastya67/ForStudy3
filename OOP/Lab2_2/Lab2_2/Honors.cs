using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public abstract class Honors
    {
        protected int place;
        protected String name;

        abstract public void generateHonors(String name, int place);

    }
}
