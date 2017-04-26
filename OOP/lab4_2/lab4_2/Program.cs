using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm a = new Algorithm();
            Console.WriteLine("\n---Easy---");
            a.toDo(new EasyExercises());
            Console.WriteLine("\n---Normal---");
            a.toDo(new NormalExercises());
            Console.WriteLine("\n---Hard---");
            a.toDo(new HardExercises());
            Console.ReadKey();
        }
    }
}
