using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    public abstract class Tree: GardenComponent, ICloneable
    {
        protected float speed;        
        public int maxFruit { get; }
        protected List<GardenComponent> fruits = new List<GardenComponent>();
        public override void add(GardenComponent t)
        {
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

        public override object Clone()
        {
            return (Tree)this.MemberwiseClone();
        }
        public override int getFruits()
        {
            int sum = 0;
            foreach (Fruit fr in fruits)
            {
                if(fr.ripeness > 80)
                {
                    sum++;
                    fruits.Remove(fr);
                }
            }
            return sum;
        }
    }
    public class AppleTree: Tree
    {
        public enum SORT { GOLDEN, AMERICAN };
        public SORT sort;
        public AppleTree(SORT s)
        {
            sort = s;
        }
        public override Fruit newFruit()
        {
            return new Apple(sort);
        }
    }
    public class PlumTree : Tree
    {
        public enum SORT { BIG, BLUE };
        public SORT sort;
        public PlumTree(SORT s)
        {
            sort = s;
        }
        public override Fruit newFruit()
        {
            return new Plum(sort);
        }
    }
    public class CherryTree : Tree
    {
        public enum SORT { QEEN, CHINE };
        public SORT sort;
        public CherryTree(SORT s)
        {
            sort = s;
        }
        public override Fruit newFruit()
        {
            return new Cherry(sort);
        }
    }
    public class PearTree : Tree
    {
        public enum SORT { WILD, GOLD };
        public SORT sort;
        public PearTree(SORT s)
        {
            sort = s;
        }
        public override Fruit newFruit()
        {
            return new Pear(sort);
        }
    }

}
