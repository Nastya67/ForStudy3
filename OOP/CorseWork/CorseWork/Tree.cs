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
    [Serializable]
    public abstract class Tree : GardenComponent, ICloneable
    {   
        Random ran = new Random();
        private Dictionary<string, int> lastFruit;
        protected float speed;        
        public int maxFruit { get; protected set; }
        protected List<GardenComponent> fruits;
        public Tree(SFML.System.Vector2f pos)
        {
            initTime();
            position = pos;
            posX = pos.X;
            posY = pos.Y;
            fruits = new List<GardenComponent>();
        }
        private bool checkTime()
        {
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            if ((min*60 + sec)-(lastFruit["min"]*60+lastFruit["sec"]) > 25)
            {
                lastFruit["min"] = min;
                lastFruit["sec"] = sec;
                return true;
            }
            return false;
        }
        public override void add(GardenComponent t)
        {
            Console.WriteLine("CountFruit: "+fruits.Count.ToString());
            if(fruits.Count < maxFruit)
                fruits.Add(t);
        }
        public override void remove(GardenComponent t)
        {
            fruits.Remove(t);
        }
        public override double getWeight()
        {
            double sum = 0.0;
            foreach (GardenComponent tr in fruits)
            {
                sum += tr.getWeight();
            }
            return sum;
        }
        public abstract Fruit newFruit();
        private void initTime()
        {
            lastFruit = new Dictionary<string, int>();
            lastFruit.Add("min", DateTime.Now.Minute);
            lastFruit.Add("sec", DateTime.Now.Second);
        }
        public override void init()
        {
            foreach (GardenComponent g in fruits)
                g.init();
            position = new SFML.System.Vector2f(posX, posY);
        }
        public override object Clone()
        {
            using (var ms = new MemoryStream())
            {
                Console.WriteLine("CloneTree");
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                Tree t = (Tree)formatter.Deserialize(ms);
                t.sprite = new Sprite(sprite.Texture);
                t.sprite.Position = new SFML.System.Vector2f(0, 0);
                t.fruits = new List<GardenComponent>();
                t.initTime();
                return t;
            }
        }
        public override int getFruits()
        {
            int sum = 0;
            for(int i = 0; i < fruits.Count; i ++)
            {
                int r = fruits[i].getFruits();
                if (Math.Abs(r) == 1)
                {
                    sum += r;
                    fruits.Remove(fruits[i]);
                    i--;
                }
            }
            return sum;
        }
        public override void display(RenderWindow app)
        {
            app.Draw(sprite);
            
            foreach (GardenComponent tr in fruits)
            {
                tr.display(app);
            }
        }
        protected SFML.System.Vector2f getRandPos()
        {
            
            int x = ran.Next(200) + (int)sprite.Position.X;
            int y = ran.Next(150) + (int)sprite.Position.Y;

            
            return new SFML.System.Vector2f(x, y);
        }
        public override respond refresh()
        {
            if(fruits.Count < maxFruit)
            {
                if (checkTime())
                    add(newFruit());
            }
            for(int i = 0; i < fruits.Count; i++)
            {
                respond r = fruits[i].refresh();
                if (r== respond.IMRIPE)
                {

                    fallenFruit++;
                    remove(fruits[i]);
                    i--;
                }
                if (r == respond.IMWARMLY)
                    fruits[i] = new WarmlyFruit((Fruit)fruits[i]);
            }
            return respond.OK;
        }
        public override void getFruitList(List<Fruit> l)
        {
            foreach (GardenComponent g in fruits)
                g.getFruitList(l);
        }
    }
    [Serializable]
    public class AppleTree: Tree
    {
        public enum SORT { GOLDEN, AMERICAN };
        public SORT sort;
        public AppleTree(SORT s, SFML.System.Vector2f pos) :base(pos)
        {
            maxFruit = 8;
            speed = (float)2.5;
            sort = s;
            string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
            int id = Shop.idSort["Apple " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "tree" + id.ToString() + ".png"));
            sprite.Position = pos;
        }
        public override Fruit newFruit()
        {
            return new Apple(sort, getRandPos(), speed);
        }
        
    }
    [Serializable]
    public class PlumTree : Tree
    {
        public enum SORT { BIG, BLUE };
        public SORT sort;
        public PlumTree(SORT s, SFML.System.Vector2f pos) : base(pos)
        {
            maxFruit = 15;
            speed = (float)2;
            sort = s;
            string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
            int id = Shop.idSort["Plum " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "tree"+id.ToString()+".png"));
            sprite.Position = pos;
        }
        public override Fruit newFruit()
        {
            return new Plum(sort, getRandPos(), speed);
        }
        
    }
    [Serializable]
    public class CherryTree : Tree
    {
        public enum SORT { QEEN, CHINE };
        public SORT sort;
        public CherryTree(SORT s, SFML.System.Vector2f pos) : base(pos)
        {
            maxFruit = 12;
            speed = (float)1.5;
            sort = s;
            string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
            int id = Shop.idSort["Cherry " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "tree" + id.ToString() + ".png"));
            sprite.Position = pos;
        }
        public override Fruit newFruit()
        {
            return new Cherry(sort, getRandPos(), speed);
        }
        
    }
    [Serializable]
    public class PearTree : Tree
    {
        public enum SORT { WILD, GOLD };
        public SORT sort;
        public PearTree(SORT s, SFML.System.Vector2f pos) : base(pos)
        {
            maxFruit = 10;
            speed = 1;
            sort = s;
            string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
            int id = Shop.idSort["Pear " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "tree" + id.ToString() + ".png"));
            sprite.Position = pos;
        }
        public override Fruit newFruit()
        {
            return new Pear(sort, getRandPos(), speed);
        }
       
    }

}
