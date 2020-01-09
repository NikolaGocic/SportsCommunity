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
    public partial class CtrlCreateEvent : UserControl
    {
        private Form1 form;
        private List<City> citys;
        private List<EventType> types;
        private List<Location> locations;
        private DataProvider data = new DataProvider();
        public CtrlCreateEvent(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy  hh:mm:ss";

            this.SetData();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CtrlEvents events = new CtrlEvents(form);
            form.setUserControl(events);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String name = tbName.Text;           
            int  locationIndex = cbLocations.SelectedIndex;
            DateTime datetime = dateTimePicker1.Value;
            String eventType = cbEventTypes.Text;

            

            EventType et = new EventType();
            foreach (EventType type in types)
            {
                if (type.name == eventType)
                    et = type;
            }



            data.CreateEvent(name,datetime,et,locations[locationIndex]);

            MessageBox.Show("Sucessfuly created Event!!");
           



        }

        private void btnCreateLocation_Click(object sender, EventArgs e)
        {
            String address = tbAddress.Text;
            String city = cbCitys.Text;

            data.CreateLocation(address, city);

            this.Refresh();

        }


        private void btnCreateCity_Click(object sender, EventArgs e)
        {
            String name = tbCityName.Text;

            data.CreateCity(name);

            this.Refresh();
        }

        private void btnCreateEventType_Click(object sender, EventArgs e)
        {
            String name = tbEventType.Text;
            String context = tbEventContext.Text;

            data.CreateEventType(name, context);

            this.Refresh();
        }

        public void Refresh()
        {

            cbCitys.Items.Clear();
            cbEventTypes.Items.Clear();
            cbLocations.Items.Clear();
            this.SetData();
        }

        public void SetData()
        {
            citys = data.GetAllCitys();
            types = data.GetAllEventTypes();
            locations = data.GetAllLocations();


            foreach (Location l in locations)
            {
                cbLocations.Items.Add(l.address + " " + l.city.name);
            }


            foreach (EventType e in types)
            {
                cbEventTypes.Items.Add(e.name);
            }


            foreach (City c in citys)
            {
                cbCitys.Items.Add(c.name);
            }
        }

    }
}
