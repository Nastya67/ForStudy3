using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class HonorsFactory
    {
        private Dictionary<String, Honors> dict = new Dictionary<String, Honors>();
        public Honors getHonors(String s)
        {
            Honors h = null;
            if (dict.ContainsKey(s))
                h = dict[s];
            else
            {
                switch (s)
                {
                    case "Diploma":
                        h = new Diploma();
                        break;
                    case "Charter":
                        h = new Сharter();
                        break;
                }
                dict.Add(s, h);
            }
            return h;

        }
    }
}
