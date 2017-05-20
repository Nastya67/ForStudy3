using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseWork
{
    [Serializable]
    public abstract class GardenState
    {
        public abstract void addComponent(List<GardenComponent> l, GardenComponent component);
    }
    [Serializable]
    public class NotFullGardenState: GardenState
    {
        public override void addComponent(List<GardenComponent> l, GardenComponent component)
        {
            l.Add(component);
        }
    }
    [Serializable]
    public class FullGardenState : GardenState
    {
        public override void addComponent(List<GardenComponent> l, GardenComponent component) { }
    }
    [Serializable]
    public abstract class GardenComponent : ICloneable
    {
        public enum respond { OK, IMRIPE, IMWARMLY }
        [NonSerialized]
        public Sprite sprite;
        [NonSerialized]
        public SFML.System.Vector2f position;
        public int fallenFruit;
        protected float posX;
        protected float posY;
        public GardenComponent() { }
        public abstract void add(GardenComponent component);
        public abstract void remove(GardenComponent component);
        public abstract double getWeight();
        public abstract int getFruits();
        public abstract void display(RenderWindow app);
        public abstract respond refresh();
        public abstract void getFruitList(List<Fruit> l);
        public abstract void init();
        public virtual object Clone()
        {
            return (GardenComponent)this.MemberwiseClone();
        }
    }
    [Serializable]
    public class Garden: GardenComponent
    {
        public List<GardenComponent> trees;
        GardenState currState;
        NotFullGardenState notFull = new NotFullGardenState();
        FullGardenState full = new FullGardenState();
        public Garden()
        {
            currState = notFull;
            trees = new List<GardenComponent>();
        }
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
        public override void display(RenderWindow app)
        {

            foreach (GardenComponent tr in trees)
            {
                tr.display(app);
            }
        }
        public override respond refresh()
        {
            foreach (GardenComponent tr in trees)
            {
                tr.refresh();
            }
            return respond.OK;
        }
        public override void getFruitList(List<Fruit> l)
        {
            foreach(GardenComponent g in trees)
                g.getFruitList(l);
        }
        public override void init()
        {
            foreach (GardenComponent g in trees)
                g.init();
        }
        public int getFallenFruits()
        {
            fallenFruit = 0;
            foreach (GardenComponent g in trees)
                fallenFruit += g.fallenFruit;
            return fallenFruit;
        }
    }
    public class Herbs: GardenComponent
    {
        //[NonSerialized]
        public List<GardenComponent> trees = new List<GardenComponent>();
        private int maxPlace;
        public Herbs(int mp, SFML.System.Vector2f pos)
        {
            string rootFolder = "D:\\Nastya\\ForStudy3\\OOP\\CorseWork\\";
            int id = Shop.idSort["Herbs " + mp.ToString()];
            sprite = new Sprite(new Texture(rootFolder + "tree" + id.ToString() + ".png"));
            position = pos;
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
        public override void display(RenderWindow app)
        {
            app.Draw(sprite);

            foreach (GardenComponent tr in trees)
            {
                tr.display(app);
            }
        }
        public override respond refresh()
        {
            foreach (GardenComponent tr in trees)
            {
                tr.refresh();
            }
            return respond.OK;
        }
        public override void getFruitList(List<Fruit> l)
        {
            foreach (GardenComponent g in trees)
                g.getFruitList(l);
        }
        public override void init()
        {
            foreach (GardenComponent g in trees)
                g.init();
        }
    }
}
