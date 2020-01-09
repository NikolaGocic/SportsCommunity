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
    public partial class CtrlAddFriend : UserControl
    {
        private Form1 form;
        private Client client;
        private List<Client> allClients;
        private DataProvider data = new DataProvider();
        public CtrlAddFriend(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.client = this.form.returnClient();

            allClients = data.GetAllClients();

            foreach (Client cl in allClients)
            {
                lbAllClients.Items.Add(cl.name + " " + cl.username);
            }
                


        }

        private void tbSerch_TextChanged(object sender, EventArgs e)
        {
            allClients = data.GetClientLike(tbSerch.Text);
            lbAllClients.Items.Clear();

            foreach (Client cl in allClients)
            {
                lbAllClients.Items.Add(cl.name + " " + cl.username);
            }


        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            
            data.makeFriends(client, allClients[lbAllClients.SelectedIndex]);
            
            client = data.getClientByUsername(client.username);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CtrlFriends start = new CtrlFriends(form);
            form.setUserControl(start);

        }
    }
}
