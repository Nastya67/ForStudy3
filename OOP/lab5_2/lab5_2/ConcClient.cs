using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    public class ConcClient: Worker, Owner
    {
        public string name { get; }
        private string password;
        public ConcClient(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public void toDo(Command work)
        {
            Console.WriteLine(name + " working...\n"+work.nameWork+"\n");
        }
        
        public void commandToAnother(Worker w, Command work, string pass)
        {
            if (w.chekPass(pass))
                work.Executor = w;
            else
                Console.WriteLine("Wrong Password");
        }
        public bool chekPass(string pass)
        {
            return password == pass;
        }

    }
}
