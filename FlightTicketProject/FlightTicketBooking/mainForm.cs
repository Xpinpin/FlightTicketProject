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
                case "CustomersBrowse":
                    childForm = new CustomerBrowse(this);
                    break;
                case "TicketsBrowse":
                    childForm = new TicketsBrowse(this);
                    break;

            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {
                       
                        f.Activate();
                        return;
                    }
                }

                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void ToolStrip_ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = null;
            ToolStripButton m = (ToolStripButton)sender;

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
                case "CustomersBrowse":
                    childForm = new CustomerBrowse(this);
                    break;
                case "TicketsBrowse":
                    childForm = new TicketsBrowse(this);
                    break;

            }

            if (childForm != null)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.GetType() == childForm.GetType())
                    {

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
            Splash splash = new Splash();
            Login login = new Login();
            splash.ShowDialog();
            if (splash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                login.ShowDialog();
                if (login.DialogResult != DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }

            }
            toolStripStatusLabel1.Text = "Login Date: " + DateTime.Now.ToShortDateString() + " |";
        }

        private void DefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpers = "PLACES: \r\n" +
                             "NRT - Narita Airport (Tokyo) \r\n" +
                             "HND - Haneda Airport (Tokyo) \r\n" +
                             "ITM - Osaka International Airport (Osaka) \r\n" +
                             "YYZ - Pearson Internation Airport (Toronto) \r\n" +
                             "YUL - Pierre Elliott Trudeau Internation Airport (Montreal) \r\n" +
                             "YVR - Vancouver International Airport (Vancouver)\r\n" +
                             "YQM - Greater Moncton Roméo LeBlanc International Airport (Moncton)\r\n" +
                             "YHZ - Halifax Stanfield International Airport (Halifax)\r\n" +
                             "-----------------------------------------------------------------------------\r\n" +
                             "AIRLINES: \r\n" +
                             "AC - Air Canada \r\n" +
                             "WJA - Westjet Airlines \r\n" +
                             "ANA - All Nippon Airlines \r\n" +
                             "EVA - Eva Airlines";
            MessageBox.Show(helpers,"Definition",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon.");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName} \r\n" +
                            $"{Application.ProductVersion} \r\n" +
                            $"{Application.CompanyName}","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
