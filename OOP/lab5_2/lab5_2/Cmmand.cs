using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    public class Command
    {
        public string nameWork { get; }
        private Worker _exec;
        public Worker Executor
        {
            get
            {
                return _exec;
            }
            set
            {
                if (value != null)
                    _exec = value;
            }
        }

        public Command(string workName)
        {
            nameWork = workName;
        }

        public void toDo()
        {
            if(_exec != null)
                _exec.toDo(this);
        }
    }
}
