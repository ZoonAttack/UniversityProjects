using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Client
{
    internal class Client
    {
        public Client(int id, Socket socket)
        {
            Id = id;
            Socket = socket;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public Socket Socket { get; set; }
        //public static ClientHomePage homePage { get; set; }


        //public void ReceiveMessage(string message)
        //{

        //}
    }
}
