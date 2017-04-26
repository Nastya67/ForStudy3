using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Diploma : Honors
    {
        public override void generateHonors(string name, int place)
        {
            Console.WriteLine("------Diploma------");
            Console.WriteLine("Congratulations to " + name+"!\n\n");
        }
    }
}
