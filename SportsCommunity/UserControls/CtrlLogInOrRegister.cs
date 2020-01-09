using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsCommunity.DomainModel;

namespace SportsCommunity.UserControls
{
    public partial class CtrlLogInOrRegister : UserControl
    {
        private Form1 form;
        private DataProvider dataProvider= new DataProvider();
        
        public CtrlLogInOrRegister()
        {
            InitializeComponent();
        }

        public CtrlLogInOrRegister(Form1 form)
        {
            InitializeComponent();

            this.form = form;

        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {

            String user, pass;
            user = tbUsernameL.Text;
            pass = tbPasswordL.Text;

            if (!dataProvider.doesUsernameExist(user))
            {
                MessageBox.Show("Client with this username dosent exist!");
            }
            else
            {
                Client c = new Client();

                c = dataProvider.getClientByUsername(user);

                if (!(c.password == pass))
                {
                    MessageBox.Show("Wrong password!");
                }
                else
                {
                    MessageBox.Show(c.name + " Welcome to SportsCommunity!!!!!");
                    form.LogIn(c);

                    
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name,user, pass;
            user = tbUsernameR.Text;
            pass = tbPasswordR.Text;
            name = tbNameR.Text;


            if (dataProvider.doesUsernameExist(user))
            {
                MessageBox.Show("This username is alredy taken!");
            }
            else 
            {
                Client c = new Client();
                c=dataProvider.CreateClient(name, user, pass);
                MessageBox.Show(c.name + " Welcome to SportsCommunity!!!!!");
                form.LogIn(c);

            }
        }
    }
}
