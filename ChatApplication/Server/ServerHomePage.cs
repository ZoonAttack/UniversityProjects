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
                OnReceiveMessage($"Client({client.Id}) has joined the chat!!");
                Thread clientThread = new Thread(() => clientConnection(client));
                clientThread.Start();
                number++;
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
                    if (client.Socket.Connected)
                    {
                        bytesRead = client.Socket.Receive(buffer);
                        string[] messageReceived = Encoding.Unicode.GetString(buffer, 0, bytesRead).Split('|');
                        //MessageBox.Show(messageReceived[1]);
                        switch(messageReceived[0])
                        {
                            case "MESSAGE":
                                OnReceiveMessage($"Client({client.Id}) sent: {messageReceived[1]}");
                                break;
                            //case "USERNAME":
                            //    client.Name = messageReceived[1];
                            //    break;
                            default:
                                MessageBox.Show("Something went wrong..");
                                break;
                        }
                    }
                } while (bytesRead > 0);
            }
            catch(Exception ex)
            {
                client.Socket.Disconnect(true);
            }
        }
        private void OnReceiveMessage(string message)
        {
            foreach(var client in clients)
            {
                //string messageWithNumber = sender.Id + message;
                client.Socket.Send(Encoding.Unicode.GetBytes(message));
                //MessageBox.Show("From server: " + message);
            }
        }

    }
}
