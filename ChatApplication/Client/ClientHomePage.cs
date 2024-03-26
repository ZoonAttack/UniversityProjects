
using System.Net;
using System.Net.Sockets;
using System.Text;
using ChatApplication.Classes;

namespace ChatApplication.Client
{
    public partial class ClientHomePage : Form
    {
        Socket clientSocket;
        IPEndPoint endPoint;
        public ClientHomePage()
        {
            InitializeComponent();
            LB_connectionStatus.Text = "Disconnected";
        }
        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (TB_PortNumber.Text is not "" && TB_Username.Text is not "" && TB_Username.Text is not "")
                {
                    endPoint = new IPEndPoint(IPAddress.Parse(TB_HostAddress.Text), int.Parse(TB_PortNumber.Text));
                    clientSocket.Connect(endPoint);
                    clientSocket.Send(Encoding.Unicode.GetBytes($"USERNAME|{TB_Username.Text}"));
                    if (Utility.SocketConnected(clientSocket))
                    {
                        LB_connectionStatus.Text = "Connected";
                        Thread readingThread = new Thread(ReadIncomingData) { IsBackground = true };
                        readingThread.Start();
                    }
                }
                else
                    MessageBox.Show("Write a proper username, address, and port number");
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
                if (Utility.SocketConnected(clientSocket))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = 0;
                    do
                    {
                        bytesRead = clientSocket.Receive(buffer);
                        UpdateUI(Encoding.Unicode.GetString(buffer, 0, bytesRead));
                    } while (bytesRead > 0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void BTN_SendMessage_Click(object sender, EventArgs e)
        {
            string message = "MESSAGE|" + TB_MessageBox.Text;
            clientSocket.Send(Encoding.Unicode.GetBytes(message));
            TB_MessageBox.Text = string.Empty;
            TB_MessageBox.SelectionStart = 0;
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

        private void LBL_Name_Click(object sender, EventArgs e)
        {

        }

        private void TB_MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SendMessage.PerformClick();
            }
        }
    }
}
