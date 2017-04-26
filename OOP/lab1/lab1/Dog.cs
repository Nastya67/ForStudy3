using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   
    

   
    public abstract class Dog
    {
        int height;
        int weight;
        int age;
        string kind;
        string owner;

        protected Dog()
        {

            height = 0;
            weight = 0;
            age = 0;
            kind = "";
            owner = "";
        }
        public Dog(int height,  int weight,  int age,  string kind,  string owner)
        {
            this.height = height;
            this.weight = weight;
            this.age = age;
            this.kind = kind;
            this.owner = owner;
        }
        public virtual void voice()
        {
            Console.WriteLine("Gav");
        }
        public virtual void wagTail(){
            Console.WriteLine("Wag the tail");
        }

        public virtual void pleaseOwner()
        {
            Console.WriteLine("Please Owner");
        }
    }
    public class smalDog: Dog
    {
        public smalDog() : base(){}
        public smalDog(int height, int weight, int age, string kind, string owner) : 
            base(height,weight, age, kind, owner) { }
        public override void voice()
        {
            Console.WriteLine("Tiaf");
        }

        public override void pleaseOwner()
        {
           Console.WriteLine("Jump on hind legs.");
        }
    }
    public class bigDog : Dog
    {
        public bigDog() : base() { }
        public bigDog(int height, int weight, int age, string kind, string owner) :
            base(height, weight, age, kind, owner)
        { }
        public override void voice()
        {
            Console.WriteLine("R-R-G-GAV");
        }
        public void security()
        {
            Console.WriteLine("This dog guards.");
        }

        public override void pleaseOwner()
        {
            Random rand = new Random();
            int randNum = rand.Next() % 2;
            switch (randNum)
            {
                case 0:
                    Console.WriteLine("Bring a stick");
                    break;
                case 1:
                    Console.WriteLine("Give a paw");
                    break;
                default:
                    Console.WriteLine("To do samething else");
                    break;
            }
        }
    }
    public abstract class Decorator: Dog
    {
        protected Dog d;
        public void cut(Dog dog)
        {
            d = dog;
        }
        public override void voice()
        {
            if(d != null)
            {
                d.voice();
            }
        }
        public override void pleaseOwner()
        {
            if (d != null)
            {
                d.pleaseOwner();
            }
        }

    }
    public class CutTail: Decorator
    {
        public override void voice()
        {
            base.voice();
        }
        public override void pleaseOwner()
        {
            base.pleaseOwner();
        }
        public override void wagTail()
        {
            Console.WriteLine("Can't wag the tail");
        }
    }

}
