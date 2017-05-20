using CorseWork;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    [Serializable]
    public abstract class Fruit: GardenComponent
    {
        protected static string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
        private Dictionary<string, int> lastTime;
        public float speed;
        public int idSort;
        private float _ripeness;
        public float ripeness { get
            {
                return _ripeness;
            }
            set
            {
                 _ripeness = value;
            }
        }
        private double _weight;
        public double weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    _weight = value;
            }
        }
        public virtual float ripen()
        {
            if (ripeness < 100)
            {
                weight += 0.1;
                return ripeness += (float)0.01*speed;
            }
            return -1;
        }
        private void initTime()
        {
            lastTime = new Dictionary<string, int>();
            lastTime.Add("min", DateTime.Now.Minute);
            lastTime.Add("sec", DateTime.Now.Second);
        }
        public Fruit(SFML.System.Vector2f pos, float speed)
        {
            position = pos;
            posX = pos.X;
            posY = pos.Y;
            this.speed = speed;
            initTime();
        }
        private bool checkTime()
        {
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            if ((min * 60 + sec) - (lastTime["min"] * 60 + lastTime["sec"]) > 10)
            {
                lastTime["min"] = min;
                lastTime["sec"] = sec;
                return true;
            }
            return false;
        }
        public virtual Fruit disWarm()
        {
            initTime();
            return this;
        }
        public override void add(GardenComponent t) { }
        public override void remove(GardenComponent t){ }
        public override double getWeight()
        {
            return _weight;
        }
        public virtual bool isWarmly()
        {
            return false;
        }
        public override int getFruits()
        {
            if (ripeness >= 80)
            {
                if (isWarmly())
                    return -1;
                return 1;
            }
            return 0;
        }
        public override void display(RenderWindow app)
        {
            app.Draw(sprite);
        }
        public override respond refresh()
        {
            if (ripen() == -1)
                return respond.IMRIPE;
            if(checkTime())
                return respond.IMWARMLY;
            return respond.OK;
        }
        public override void getFruitList(List<Fruit> l)
        {
            if (isWarmly())
                l.Add(this);
        }
        public override void init()
        {
            position = new SFML.System.Vector2f(posX, posY);
        }
    }
    [Serializable]
    public abstract class DecorFruit: Fruit
    {
        protected Fruit fruit;
        public DecorFruit(Fruit fr):base(fr.position, fr.speed)
        {
            fruit = fr;
            
        }
        public override float ripen()
        {
            if (fruit != null)
                return fruit.ripen();
            return -1;
        }
        public override Fruit disWarm()
        {
            return base.disWarm();
        }
        public override bool isWarmly()
        {
            return base.isWarmly();
        }
    }
    [Serializable]
    public class WarmlyFruit: DecorFruit
    {
        public WarmlyFruit(Fruit fr) : base(fr)
        {
            sprite = new Sprite(new Texture(rootFolder + "fruit" + fr.idSort.ToString() + "W.png"));
            sprite.Position = fr.sprite.Position;
        }
        public override float ripen()
        {
            base.ripen();
            fruit.weight -= 0.05;
            fruit.ripeness += (float)0.1;
            return fruit.ripeness;
        }
        public override Fruit disWarm()
        {
            //Console.WriteLine("--idSort: "+fruit.idSort.ToString());
            sprite = new Sprite(new Texture(rootFolder + "fruit" + fruit.idSort.ToString() + ".png"));
            sprite.Position = fruit.position;

            Console.WriteLine("disWarm: " + fruit.idSort.ToString());
            return fruit;
        }
        public override bool isWarmly()
        {
            return true;
        }
    }
    [Serializable]
    public class Apple: Fruit
    {
        public AppleTree.SORT sort { get; protected set; }
        public Apple(AppleTree.SORT sort, SFML.System.Vector2f pos, float speed):base(pos, speed)
        {
            this.sort = sort;
            idSort = Shop.idSort["Apple " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "fruit" + idSort.ToString() + ".png"));
            sprite.Position = position;
        }
    }
    [Serializable]
    public class Plum : Fruit
    {
        public PlumTree.SORT sort { get; protected set; }
        public Plum(PlumTree.SORT sort, SFML.System.Vector2f pos, float speed) : base(pos, speed)
    {
            this.sort = sort;
            idSort = Shop.idSort["Plum " + sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "fruit" + idSort.ToString() + ".png"));
            sprite.Position = position;
        }
    }
    [Serializable]
    public class Cherry : Fruit
    {
        public CherryTree.SORT sort { get; protected set; }
        public Cherry(CherryTree.SORT sort, SFML.System.Vector2f pos, float speed) : base(pos, speed)
        {
            this.sort = sort;
            idSort = Shop.idSort["Cherry " + sort.ToString()];
            Console.WriteLine("Constructor: "+idSort.ToString());
            sprite = new Sprite(new Texture(rootFolder + "fruit" + idSort.ToString() + ".png"));
            sprite.Position = position;
        }
    }
    [Serializable]
    public class Pear : Fruit
    {
        public PearTree.SORT sort { get; protected set; }
        public Pear(PearTree.SORT sort, SFML.System.Vector2f pos, float speed) : base(pos, speed)
        {
            this.sort = sort;
            idSort = Shop.idSort["Pear "+sort.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "fruit" + idSort.ToString() + ".png"));
            sprite.Position = position;
        }
    }
}
