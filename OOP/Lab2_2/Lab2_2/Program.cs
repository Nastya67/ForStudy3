using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HonorsFactory hf = new HonorsFactory();
            String str = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            int randC = 0;
            
            for(int i = 0; i < 10; i++)
            {
                Honors h = null;
                randC = r.Next() % 2;
                if (randC == 0)
                    h = hf.getHonors("Diploma");
                if (randC == 1)
                    h = hf.getHonors("Charter");
                h.generateHonors(str[i].ToString(), i);
            }
            Console.ReadKey();

        }
    }
}
