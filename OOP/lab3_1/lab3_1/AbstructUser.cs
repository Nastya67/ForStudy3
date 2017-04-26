using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    public class AbstractUser : ICloneable
    {
        public String username;
        public AbstractUser() { }
        public Object Clone()
        {
            Object clone = null;
            try
            {
                clone = this.MemberwiseClone();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return clone;
        }
        public String getName()
        {
            return this.username;
        }
    }
}
