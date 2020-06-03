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
    public partial class Bookings : Form
    {
        mainForm myParent;
        public Bookings(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            DataTable dtCustomers = DataAccess.GetData("SELECT CustomerID,FirstName + ' ' + LastName AS CustomerName FROM Customer");

            UIUtilities.FillListControl(cmbCustomers, "CustomerName", "CustomerID", dtCustomers, true, "");
        }
        private void LoadTickets()
        {
            DataTable dtTickets = DataAccess.GetData("SELECT TicketID, DepartureAirport + ' - ' + ArrivalAirport + ' (' + CONVERT(VARCHAR(MAX), DepartureTime) + ')'AS TicketInfo FROM Ticket");
            UIUtilities.FillListControl(cmbTickets, "TicketInfo", "TicketID", dtTickets, true, "");
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadTickets();
        }
    }
}
