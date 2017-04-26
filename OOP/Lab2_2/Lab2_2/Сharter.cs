using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Сharter : Honors
    {
        
        public override void generateHonors(string name, int place)
        {
            Console.WriteLine("------Сharter------");
            Console.WriteLine("Congratulations to "+name+" with "+place.ToString()+" place");
            Console.WriteLine("In the competition of pianists\n\n");
        }
    }
}
