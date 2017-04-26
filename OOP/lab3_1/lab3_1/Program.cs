using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetConect internetConnection = InternetConect.internetConection();
            internetConnection.newUser("Hradi");
            AbstractUser user = internetConnection.getUser("Hradi");
            Console.WriteLine(user.getName());
            Console.ReadKey();
        }
    }
}
