using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SportsCommunity.UserControls
{
    public partial class CtrlStart : UserControl
    {
        private Form1 form;
        public CtrlStart(Form1 form)
        {
            InitializeComponent();
            this.form = form;


        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            CtrlEvents ctrl = new CtrlEvents(form);
            form.setUserControl(ctrl);
            
        }



        private void btnFriends_Click(object sender, EventArgs e)
        {
            CtrlFriends ctrl = new CtrlFriends(form);
            form.setUserControl(ctrl);
        }
    }
}
