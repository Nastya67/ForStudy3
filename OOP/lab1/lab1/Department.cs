using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Department : PartDepartment
    {
        private List<PartDepartment> _children = new List<PartDepartment>();

        public Department(string name):base(name) { }
        public override void Add(PartDepartment pd)
        {
            _children.Add(pd);
        }
        public override void Remove(PartDepartment pd)
        {
            _children.Remove(pd);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + budget.ToString());
            foreach (PartDepartment pd in _children)
                pd.Display(depth + 2);
        }
        public override int getBudget()
        {
            budget = 0;
            foreach (PartDepartment pd in _children)
                budget += pd.getBudget();
            return budget;
        }
    }
    public abstract class PartDepartment
    {
        protected string name;
        protected int budget;

        public PartDepartment(string name)
        {
            this.name = name;
            budget = 0;
        }
        public abstract void Add(PartDepartment pd);
        public abstract void Remove(PartDepartment pd);
        public abstract int getBudget();
        public abstract void Display(int depth);

    }

    public class Teacher: PartDepartment
    {
        public Teacher(string name, int zp) : base(name)
        {
            budget = zp;
        }

        public override void Add(PartDepartment pd)
        {
            Console.WriteLine("Can't to do this");
        }
        public override void Remove(PartDepartment pd)
        {
            Console.WriteLine("Can't to do this");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + budget.ToString());
            
        }
        public override int getBudget()
        {
            
            return budget;
        }
    }
}
