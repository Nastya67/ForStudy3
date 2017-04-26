using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    public abstract class GardenState
    {
        public abstract void addComponent(List<GardenComponent> l, GardenComponent component);
    }
    public class NotFullGardenState: GardenState
    {
        public override void addComponent(List<GardenComponent> l, GardenComponent component)
        {
            l.Add(component);
        }
    }
    public class FullGardenState : GardenState
    {
        public override void addComponent(List<GardenComponent> l, GardenComponent component) { }
    }
    public abstract class GardenComponent: ICloneable
    {
        public GardenComponent() { }
        public abstract void add(GardenComponent component);
        public abstract void remove(GardenComponent component);
        public abstract double getWeight();
        public abstract int getFruits();
        public virtual object Clone()
        {
            return (GardenComponent)this.MemberwiseClone();
        }
    }
    public class Garden: GardenComponent
    {
        public List<GardenComponent> trees = new List<GardenComponent>();
        GardenState currState;
        NotFullGardenState notFull = new NotFullGardenState();
        FullGardenState full = new FullGardenState();
        public override void add(GardenComponent t)
        {
            currState.addComponent(trees, t);
            checkState();
        }
        public override void remove(GardenComponent t)
        {
            trees.Remove(t);
            checkState();
        }
        private void checkState()
        {
            if (trees.Count >= 6 && currState == notFull)
                currState = full;
            else if (trees.Count < 6 && currState == full)
                currState = notFull;

        }
        public override double getWeight()
        {
            double sum = 0.0;
            foreach (GardenComponent tr in trees)
            {
                sum += tr.getWeight();
            }
            return sum;
        }
        public override int getFruits()
        {
            int sum = 0;
            foreach (GardenComponent tr in trees)
            {
                sum += tr.getFruits();
            }
            return sum;
        }
    }
    public class Herbs: GardenComponent
    {
        public List<GardenComponent> trees = new List<GardenComponent>();
        private int maxPlace;
        public Herbs(int mp)
        {
            maxPlace = mp;
        }
        public override void add(GardenComponent t)
        {
            if(trees.Count < maxPlace)
                trees.Add(t);
        }
        public override void remove(GardenComponent t)
        {
            trees.Remove(t);
        }
        public override double getWeight()
        {
            double sum = 0.0;
            foreach(GardenComponent tr in trees)
            {
                sum += tr.getWeight();
            }
            return sum * 2;
        }
        public override object Clone()
        {
            return (Herbs)this.MemberwiseClone();
        }
        public override int getFruits()
        {
            int sum = 0;
            foreach (GardenComponent tr in trees)
            {
                sum += tr.getFruits();
            }
            return sum;
        }
    }
}
