using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketBooking
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            ToolStripMenuItem m = (ToolStripMenuItem)sender;

            switch (m.Tag)
            {
                case "Customers":
                    childForm = new Customers(this);
                    break;
                case "Tickets":
                    childForm = new Tickets(this);
                    break;
                case "Bookings":
                    childForm = new Bookings(this);
                    break;
            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                        /*
                         This technique requires consideration taken on child forms that load data on form load. 
                         This will result in stale data if data is only retrieved on form load. Also consider loading data on form Activated event also.
                         See frmDataGridViewEvents, frmDataGridViewControls, frmDataGridViewCRUD
                         
                         */
                        f.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Splash splash = new Splash();
            //Login login = new Login();
            //splash.ShowDialog();
            //if (splash.DialogResult != DialogResult.OK)
            //{
            //    this.Close();
            //}
            //else
            //{
            //    login.ShowDialog();
            //    if (login.DialogResult != DialogResult.OK)
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        this.Show();
            //    }

            //}
            toolStripStatusLabel1.Text = "Login Date: " + DateTime.Now.ToShortDateString();
        }

      
    }
}
