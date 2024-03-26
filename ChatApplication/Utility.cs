using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    internal class Utility
    {
        public static bool SocketConnected(Socket s)
        {
            bool poll = s.Poll(0, SelectMode.SelectRead);
            bool available = (s.Available == 0);
            return (poll && available) ? false : true;
        }
    }
}
