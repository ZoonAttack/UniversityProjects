using ChatApplication.Client;
using ChatApplication.Server;

namespace ChatApplication
{
    public partial class Home : Form
    {
        ClientHomePage clientHomePage = new ClientHomePage();
        public Home()
        {
            InitializeComponent();
        }

        private void BTN_Server_Click(object sender, EventArgs e)
        {
            ServerHomePage serverHomePage = new ServerHomePage();
            serverHomePage.Show();
        }

        private void BTN_Client_Click(object sender, EventArgs e)
        {
            clientHomePage.Show();
            //this.Close();
        }
    }
}