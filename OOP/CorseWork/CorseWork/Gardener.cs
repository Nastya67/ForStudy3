using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    public class DisWarm
    {
        public List<Fruit> exec;
        public void killWarm()
        {
            for(int i = 0; i < exec.Count; i++)
            {
                exec[i] = exec[i].disWarm();
            }
        }
    }
    public class Gardener
    {
        private static Gardener _gardener;
        public string name { get; private set; }
        DisWarm disWarmComand = new DisWarm();
        public Garden garden;


        private Gardener (string name)
        {
            this.name = name;
        }
        public static Gardener gardener(string name)
        {
            if (_gardener == null)
                _gardener = new Gardener(name);
            return _gardener;
        }
        public void killWarms()
        {
            disWarmComand.killWarm();
        }
        public void refreshGarden()
        {

        }
        public int getFruits()
        {
            return garden.getFruits();
        }
    }
}
