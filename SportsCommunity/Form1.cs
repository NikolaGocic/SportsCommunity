using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsCommunity.DomainModel;
using SportsCommunity.UserControls;


namespace SportsCommunity
{
    public partial class Form1 : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private Client client = new Client();

        public Form1()
        {
            InitializeComponent();

            CtrlLogInOrRegister ctrlLogInOrRegister = new CtrlLogInOrRegister(this);
            Panel.Controls.Clear();
            Panel.Controls.Add(ctrlLogInOrRegister);



        }


        public Client returnClient()
        {
            return this.client;
        }

        public void refreshClient()
        {
            this.client = dataProvider.getClientByUsername(client.username);
        }

        public void setUserControl(UserControl userControl)
        {
            Panel.Controls.Clear();
            Panel.Controls.Add(userControl);
        }


        public void LogIn(Client c)
        {
            this.client = c;
            this.refreshClient();

            labelLogIn.Text = "Loged in as " + this.client.name;

            this.LoadStartPage();


        }

        public void LoadStartPage()
        {
            CtrlStart ctrlStart = new CtrlStart(this);
            Panel.Controls.Clear();
            Panel.Controls.Add(ctrlStart);

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            client = null;
            CtrlLogInOrRegister ctrlLogInOrRegister = new CtrlLogInOrRegister(this);
            Panel.Controls.Clear();
            Panel.Controls.Add(ctrlLogInOrRegister);
            labelLogIn.Text = "";
        }
    }
}
