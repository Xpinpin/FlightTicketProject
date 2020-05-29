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
        }
    }
}
