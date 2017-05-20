using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
    [Serializable]
    public class Gardener
    {
        private static Gardener _gardener;
        public string name { get; private set; }
        [NonSerialized]
        DisWarm disWarmComand = new DisWarm();
        public Garden garden;
        public int numGetFruit = 0;
        private Gardener ()
        {
        }
        public static Gardener gardener()
        {
            if (_gardener == null)
                _gardener = new Gardener();
            return _gardener;
        }
        
        public void loadGarden()
        {
            var formatter = new BinaryFormatter();
            Stream stream2 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read);
            Gardener gardener = (Gardener)formatter.Deserialize(stream2);
            stream2.Close();
            garden.init();
        }
        public void killWarms()
        {
            List<Fruit> l = new List<Fruit>();
            garden.getFruitList(l);
            disWarmComand.exec = l;
            disWarmComand.killWarm();
        }
        public void refreshGarden()
        {
            garden.refresh();
        }
        public void display(RenderWindow app)
        {
            garden.display(app);
        }
        public int getFruits()
        {
            numGetFruit +=  garden.getFruits();
            return numGetFruit;
        }
        public GardenComponent bought(int id)
        {
            return Shop.bought(Shop.names[id]);
        }
        public void AddNewElementToGarden(GardenComponent elem)
        {
            garden.add(elem);
        }
        public int getFallenFruit()
        {
            return garden.getFallenFruits();
        }
    }
}
