using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----DOGS-----\n");
            Console.WriteLine("Decorator\n");
            Decorator cutT = new CutTail();
            
            List<Dog> listDog = new List<Dog>();
            listDog.Add(new smalDog());
            listDog.Add(new smalDog());
            listDog.Add(new bigDog());
            listDog.Add(new smalDog());
            Dog d1 = new bigDog();
            cutT.cut(d1);
            listDog.Add(cutT);
            Console.WriteLine("Command: wag tail");
            foreach (Dog dog in listDog)
                dog.wagTail();
            

            Console.WriteLine("\nBridge (Abstract Dog)");

            Console.WriteLine("\nCommand: voice");
            foreach (Dog dog in listDog)
                dog.voice();
            Console.WriteLine("\nCommand: please owner");
            foreach (Dog dog in listDog)
                dog.pleaseOwner();

           


            ////////
            Console.WriteLine("\n\n----SCHOOL-----\n");
            Department school = new Department("№284");
            Department math = new Department("Math");
            school.Add(math);
            Department languege = new Department("lengueges");
            school.Add(languege);
            Department eng = new Department("Eng");
            Department ukr = new Department("Ukr");
            languege.Add(eng);
            languege.Add(ukr);
            Teacher galina = new Teacher("Galina Evgenivna", 4500);
            Teacher irina = new Teacher("Irina Sergeevna", 5000);
            Teacher tamara = new Teacher("Tamara Vitalievna", 2300);
            Teacher tatiana = new Teacher("Tatiana Victorovna", 3400);
            Teacher olena = new Teacher("Elene Bronislavovna", 5400);
            math.Add(galina);
            math.Add(tatiana);
            eng.Add(olena);
            ukr.Add(irina);
            ukr.Add(tamara);

            school.getBudget();
            school.Display(2);

            Console.ReadKey();
        }
    }
}
