using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    public class InternetConect
    {
        private static InternetConect _internetConect;
        private static Hashtable users = new Hashtable();
        private static AbstractUser prototipUser = new AbstractUser();

        protected InternetConect() { }

        public static InternetConect internetConection()
        {
            if (_internetConect == null)
                _internetConect = new InternetConect();
            return _internetConect;
        }

        public AbstractUser getUser(String username)
        {
            AbstractUser user = (AbstractUser)users[username];
            return user;
        }
        
        public void newUser(String username)
        {
            AbstractUser user = (AbstractUser)prototipUser.Clone();
            user.username = username;
            users[username] = user;
        }
    }
}
