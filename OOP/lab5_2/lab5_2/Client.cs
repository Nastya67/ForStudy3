using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    public interface Worker
    {        
        void toDo(Command work);
        bool chekPass(string pass);
    }
    public interface Owner
    {
        void commandToAnother(Worker w, Command work, string pass);
    }
}
