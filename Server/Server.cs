using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public class Server
    {
        private Socket listener;
        public Server()
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
        }

        public void Start()
        {
            listener.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
        }

        public void Listen()
        {
            while (true) 
            {
                listener.Listen(5);
                Socket client = listener.Accept();
                ClientHandler clientHandler = new ClientHandler(client);
                Thread thread = new Thread(clientHandler.StartHandler);
                thread.Start();
            }
            
        }
    }
}
