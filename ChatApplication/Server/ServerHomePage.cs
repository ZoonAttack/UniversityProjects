using ChatApplication.Client;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ChatApplication.Server
{
    public partial class ServerHomePage : Form
    {
        Socket serverSocket;
        List<Client.Client> clients = new List<Client.Client> ();
        bool flag;
        public ServerHomePage()
        {
            InitializeComponent();
        }

        private void ServerHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the server
            flag = false;
        }

        private void BTN_ServerStart_Click(object sender, EventArgs e)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(0, 8888));
            MessageBox.Show("Server started");
            Thread serverThread = new Thread(Listening) { IsBackground = true };
            serverThread.Start();
            flag = true;
        }

        private void Listening()
        {
            int number = 1;
            while(flag)
            {
                serverSocket.Listen(0);
                Socket clientSocket = serverSocket.Accept();

                Client.Client client = new Client.Client(number, clientSocket);
                clients.Add(client);
                Thread clientThread = new Thread(() => clientConnection(client));
                clientThread.Start();
                BroadcastMessage(client, $"Someone has joined the chat!!");
            }
            serverSocket.Close();
        }
        private void clientConnection(Client.Client client)
        {

            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                do
                {
                    if (Utility.SocketConnected(client.Socket))
                    {
                        bytesRead = client.Socket.Receive(buffer);
                        string[] messageReceived = Encoding.Unicode.GetString(buffer, 0, bytesRead).Split('|');
                        //MessageBox.Show(messageReceived[1]);
                        switch (messageReceived[0])
                        {
                            case "MESSAGE":
                                BroadcastMessage(client, $"({client.Name}) sent: {messageReceived[1]}");
                                break;
                            case "USERNAME":
                                client.Name = messageReceived[1];
                                break;
                            default:
                                MessageBox.Show("Something went wrong..");
                                break;
                        }
                    }
                    else 
                        BroadcastMessage(client, $"({client.Name}) Has disconnected");

                } while (bytesRead > 0);
            }
            catch(Exception ex)
            {
                client.Socket.Disconnect(true);
                clients.Remove(client);
                BroadcastMessage(client, $"({client.Name}) Has disconnected");
            }
        }
        private void BroadcastMessage(Client.Client sender, string message)
        {
            foreach(var client in clients)
            {
                //string messageWithNumber = sender.Id + message;
                if (client == sender && client.Name is not null)
                {
                    string senderMessage = message.Replace(sender.Name, "me");
                    client.Socket.Send(Encoding.Unicode.GetBytes(senderMessage));
                }
                else
                    client.Socket.Send(Encoding.Unicode.GetBytes(message));
                //MessageBox.Show("From server: " + message);
            }
        }

    }
}
