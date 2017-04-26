using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    
    public abstract class Fruit: GardenComponent
    {
        
        private float _ripeness;
        public float ripeness { get
            {
                return _ripeness;
            }
            set
            {
                if (value >= 0 && value <= 100)
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
        public virtual float ripen(float speed)
        {
            if (ripeness < 100)
            {
                weight += 0.1;
                return ripeness += speed;
            }
            return -1;
        }
        public virtual Fruit disWarm()
        {
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
            return 1;
        }
    }
    public abstract class DecorFruit: Fruit
    {
        protected Fruit fruit;
        public DecorFruit(Fruit fr)
        {
            fruit = fr;
        }
        public override float ripen(float speed)
        {
            if (fruit != null)
                return fruit.ripen(speed);
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
    public class WarmlyFruit: DecorFruit
    {
        public WarmlyFruit(Fruit fr) : base(fr) { }
        public override float ripen(float speed)
        {
            base.ripen(speed);
            fruit.weight -= 0.05;
            fruit.ripeness += 1;
            return fruit.ripeness;
        }
        public override Fruit disWarm()
        {
            return fruit;
        }
        public override bool isWarmly()
        {
            return true;
        }
    }
    public class Apple: Fruit
    {
        public AppleTree.SORT sort { get; protected set; }
        public Apple(AppleTree.SORT sort)
        {
            this.sort = sort;
        }
    }
    public class Plum : Fruit
    {
        public PlumTree.SORT sort { get; protected set; }
        public Plum(PlumTree.SORT sort)
        {
            this.sort = sort;
        }
    }
    public class Cherry : Fruit
    {
        public CherryTree.SORT sort { get; protected set; }
        public Cherry(CherryTree.SORT sort)
        {
            this.sort = sort;
        }
    }
    public class Pear : Fruit
    {
        public PearTree.SORT sort { get; protected set; }
        public Pear(PearTree.SORT sort)
        {
            this.sort = sort;
        }
    }
}
