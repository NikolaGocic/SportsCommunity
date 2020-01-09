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
    public partial class CtrlEvents : UserControl
    {
        private Form1 form;
        private Client client;
        private DataProvider data = new DataProvider();
        private List<City> citys;
        private List<EventType> types;
        private List<Event> list;

        public CtrlEvents(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            client = this.form.returnClient();
            list = client.event_list;


            foreach (Event events in list)
            {
                lbMyEvents.Items.Add(events.id + " " + events.name);
            }

            citys = data.GetAllCitys();
            types = data.GetAllEventTypes();

            
            
            foreach (City c in citys)
            {
                cbCitys.Items.Add(c.name);
            }



            foreach (EventType e in types)
            {
                cbEventTypes.Items.Add(e.name);
            }



        }



        private void lbMyEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Event selected = list[lbMyEvents.SelectedIndex];

            labelEvent.Text = "Selected Event:"
                                + "\r ID:                     " + selected.id
                                + "\r Name:               " + selected.name
                                + "\r Date and Time:  " + selected.dateTime
                                + "\r Address:             " + selected.location.address
                                + "\r City:                 " + selected.location.city.name
                                + "\r Event Type:         " + selected.eventType.name
                                + "\r Context:            " + selected.eventType.context;
        }

        private void BtnTimeSort_Click(object sender, EventArgs e)
        {

            list = client.event_list;
            
            list.Sort((x,y)=>DateTime.Compare(y.dateTime,x.dateTime));
            

            lbMyEvents.Items.Clear();
            foreach (Event events in list)
            {
                lbMyEvents.Items.Add(events.id + " " + events.name);
            }

        }

        private void btnLocationSort_Click(object sender, EventArgs e)
        {
            String city = cbCitys.SelectedItem.ToString();
          
            lbMyEvents.Items.Clear();
            list = new List<Event>();
            

            foreach (Event es in client.event_list)
            {
                if (String.Equals(es.location.city.name, city))
                {
                    list.Add(es);
                    lbMyEvents.Items.Add(es.id + " " + es.name);
                }
            }
        }

        private void btnEventTypeSort_Click(object sender, EventArgs e)
        {

            String type = cbEventTypes.SelectedItem.ToString();

            lbMyEvents.Items.Clear();

            list = new List<Event>();

            foreach (Event es in client.event_list)
            {
                if (String.Equals(es.eventType.name, type))
                {
                    list.Add(es);
                    lbMyEvents.Items.Add(es.id + " " + es.name);
                }
            }
        }

        private void cbCitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLocationSort.Enabled = true;
        }

        private void cbEventTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEventTypeSort.Enabled = true;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            CtrlAddEvent control = new CtrlAddEvent(form);
            form.setUserControl(control);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CtrlStart start = new CtrlStart(form);
            form.setUserControl(start);
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CtrlCreateEvent es= new CtrlCreateEvent(form);
            form.setUserControl(es);

        }
    }
}
