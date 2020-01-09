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
    public partial class CtrlAddEvent : UserControl
    {
        private Form1 form;
        private Client client;
        private List<Event> list;
        private DataProvider data = new DataProvider();
        private Event selected;
        public CtrlAddEvent(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            client = this.form.returnClient();
            list = data.GetAllEvents();


            foreach (Event events in list)
            {
                lbMyEvents.Items.Add(events.id + " " + events.name);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CtrlEvents events = new CtrlEvents(form);
            form.setUserControl(events);
        }

        private void lbMyEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = list[lbMyEvents.SelectedIndex];
            button1.Enabled = true;

            labelEvent.Text = "Selected Event:"
                                + "\r ID:                     " + selected.id
                                + "\r Name:               " + selected.name
                                + "\r Date and Time:  " + selected.dateTime
                                + "\r Address:             " + selected.location.address
                                + "\r City:                 " + selected.location.city.name
                                + "\r Event Type:         " + selected.eventType.name
                                + "\r Context:            " + selected.eventType.context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.AddClientToEvent(client,selected);
            form.refreshClient();
            MessageBox.Show("Succesfully added event!");
        }
    }
}
