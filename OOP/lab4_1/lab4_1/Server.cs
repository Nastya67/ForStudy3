using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class Server
    {
        private List<User> users = new List<User>();
        public int countUsers {get{ return users.Count; } }
        private State curState;
        private State availableState = new AvailableState();
        private State notAvailableState = new NotAvailableState();
        private int maxConection;
        public Server(int n)
        {
            curState = availableState;
            maxConection = n;
        }
        public bool conect(User user)
        {
            if (curState.tryConect())
            {
                users.Add(user);
                checkState();
                return true;
            }
            return false;
            
        }
        private void checkState()
        {
            if(users.Count == maxConection && curState == availableState)
            {
                curState = notAvailableState;
            }
            else if(users.Count < maxConection && curState == notAvailableState)
            {
                curState = availableState;
            }

        }
    }
}
