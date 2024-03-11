
using System.Net;
using System.Net.Sockets;
using System.Text;
using ChatApplication.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChatApplication.Client
{
    public partial class ClientHomePage : Form
    {
        Socket clientSocket;
        IPEndPoint endPoint;
        public ClientHomePage()
        {
            InitializeComponent();
        }
        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                endPoint = new IPEndPoint(IPAddress.Parse(TB_HostAddress.Text), int.Parse(TB_PortNumber.Text));
                clientSocket.Connect(endPoint);
                if (clientSocket.Connected)
                {
                    MessageBox.Show("Connected to server!");
                }
                Thread readingThread = new Thread(ReadIncomingData) { IsBackground = true };
                readingThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReadIncomingData()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                do
                {
                    bytesRead = clientSocket.Receive(buffer);
                    UpdateUI(Encoding.Unicode.GetString(buffer, 0, bytesRead));
                } while (bytesRead > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BTN_SendMessage_Click(object sender, EventArgs e)
        {
            string message = "MESSAGE|" + TB_MessageBox.Text;
            clientSocket.Send(Encoding.Unicode.GetBytes(message));
            //TB_ChatBox.AppendText(TB_MessageBox.Text + "\n");
            // MessageBox.Show(TB_MessageBox.Text);
        }

        private void TB_MessageBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void TB_ChatBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClientHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientSocket.Close();
        }
        public void UpdateUI(string text)
        {
            if (TB_ChatBox.InvokeRequired)
            {
                // If this is not the UI thread, invoke the method on the UI thread
                TB_ChatBox.Invoke(new Action(() => UpdateUI(text)));
            }
            else
            {
                // If this is the UI thread, update the UI directly
                TB_ChatBox.AppendText($"{text}{Environment.NewLine}");
            }
        }
    }
}
