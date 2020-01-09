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
    public partial class CtrlFriends : UserControl
    {
        private Form1 form;
        private Client client;
        private List<Client> friends;
        private List<Event> friends_events;
        private DataProvider data = new DataProvider();
        public CtrlFriends(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            form.refreshClient();
            this.client = form.returnClient();
            this.friends = new List<Client>();
            this.friends = this.client.friend_list;

            foreach (Client f in friends)
            {
               // f = data.getClientByUsername(f.name);
                lbMyFriends.Items.Add(f.name);
            }
            
        }

        private void CtrlFriends_Load(object sender, EventArgs e)
        {

        }

        private void lbMyFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            int friendIndex = lbMyFriends.SelectedIndex;

            friends_events = new List<Event>();


            if (friendIndex < friends.Count)
            {
                friends[friendIndex].event_list = data.getClientEvents(friends[friendIndex].id);
                friends_events = friends[friendIndex].event_list;
            }


            lbFriendsEvents.Items.Clear();

            foreach (Event es in friends_events)
            {
                lbFriendsEvents.Items.Add(es.id+" "+es.name);
            } 
            
        }

        private void lbFriendsEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selected = friends_events[lbFriendsEvents.SelectedIndex];

            label.Text = "Selected Event:"
                                + "\r ID:                     " + selected.id
                                + "\r Name:               " + selected.name
                                + "\r Date and Time:  " + selected.dateTime
                                + "\r Address:             " + selected.location.address
                                + "\r City:                 " + selected.location.city.name
                                + "\r Event Type:         " + selected.eventType.name
                                + "\r Context:            " + selected.eventType.context;
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            CtrlAddFriend addfriend = new CtrlAddFriend(form);
            form.setUserControl(addfriend);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CtrlStart start = new CtrlStart(form);
            form.setUserControl(start);
        }
    }
}
