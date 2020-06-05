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
    public partial class TicketsBrowse : Form
    {
        mainForm myParent;
        public TicketsBrowse(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void LoadTickets()
        {
            DataTable dt = DataAccess.GetData("SELECT TicketID, DepartureAirport + ' - ' + ArrivalAirport + ' (' + CONVERT(VARCHAR(MAX), DepartureTime) + ')'AS TicketInfo FROM Ticket");

            UIUtilities.FillListControl(cmbTickets, "TicketInfo", "TicketID",dt ,true, "--- Choose a ticket ---");


        }

        private void TicketsBrowse_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void DisplayNumberOfCustomers()
        {
            myParent.toolStripStatusLabel6.Text = $"The current cticket has been booked by {dgvInfo.Rows.Count} customers |";
            myParent.toolStripStatusLabel6.ForeColor = Color.Black;
        }

        private void CmbTickets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbTickets.SelectedIndex == 0)
            {
                myParent.toolStripStatusLabel6.Text = $"Please choose a ticket.";
                myParent.toolStripStatusLabel6.ForeColor = Color.Red;
                dgvInfo.DataSource = null;
                lblAirlines.Text = "";
                lblAirports.Text = "";
                lblDescription.Text = "";
                lblPlaces.Text = "";
                lblQuantity.Text = "";
                lblSeat.Text = "";
                lblTime.Text = "";
            }
            else
            {
                string sqlDgv = $@"SELECT
	                            FirstName + ' ' + LastName AS CustomerName,
                                DateBooked, Subtotal AS TicketPrice, Tax, Total AS BookingPrice
                               FROM Customer
                               INNER JOIN Booking ON Customer.CustomerID = Booking.CustomerID
                               WHERE Booking.TicketID = {cmbTickets.SelectedValue}";
                sqlDgv = DataAccess.SQLCleaner(sqlDgv);

                DataTable dtDgv = DataAccess.GetData(sqlDgv);
                if (dtDgv.Rows.Count == 0)
                {
                    dgvInfo.DataSource = null;
                }
                else
                {
                    dgvInfo.DataSource = dtDgv;
                    dgvInfo.ReadOnly = true;
                    dgvInfo.AutoResizeColumns();
                    dgvInfo.AllowUserToAddRows = false;
                    dgvInfo.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvInfo.Columns[3].DefaultCellStyle.Format = "C2";
                    dgvInfo.Columns[4].DefaultCellStyle.Format = "C2";
                    dgvInfo.Columns[0].HeaderCell.Value = "Customer Name";
                    dgvInfo.Columns[1].HeaderCell.Value = "Booking Date";
                    dgvInfo.Columns[2].HeaderCell.Value = "Ticket Price";
                    dgvInfo.Columns[4].HeaderCell.Value = "Booking Price";
                    dgvInfo.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
                }

                string sqlTicketInfo = $"SELECT * FROM Ticket WHERE TicketID = {cmbTickets.SelectedValue}";
                DataTable dtTicket = DataAccess.GetData(sqlTicketInfo);
                DataRow row = dtTicket.Rows[0];
                lblTime.Text = $"{row["DepartureTime"].ToString()} - {row["ArrivalTime"].ToString()}";
                lblAirports.Text = $"{row["DepartureAirport"].ToString()} - {row["ArrivalAirport"].ToString()}";
                lblPlaces.Text = $"{row["StartPlace"].ToString()} - {row["Destination"].ToString()}";
                chkMeal.Checked = (bool)row["MealIncluded"];
                lblAirlines.Text = $"{row["AirlinesName"].ToString()}";
                lblSeat.Text = $"{row["SeatType"].ToString()}";
                lblQuantity.Text = row["QuantityLeft"].ToString();
                lblDescription.Text = row["Description"].ToString();

                DisplayNumberOfCustomers();
            }
          
           
        }

        private void DgvInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int isPaid = Convert.ToInt32(DataAccess.GetValue(DataAccess.SQLCleaner($@"SELECT IsPaid FROM Booking 
                                                                INNER JOIN Customer ON Booking.CustomerID = Customer.CustomerID 
                                                                WHERE FirstName + ' ' + LastName = '{dgvInfo.CurrentRow.Cells[0].Value.ToString().Trim()}'
                                                                AND Booking.TicketID = {cmbTickets.SelectedValue}")));
            if(isPaid == 0)
            {
                MessageBox.Show($"{dgvInfo.CurrentRow.Cells[0].Value.ToString()} has not paid for this ticket");
            }
            else
            {
                MessageBox.Show($"This ticket has been paid by {dgvInfo.CurrentRow.Cells[0].Value.ToString()}");
            }
            
        }

        private void TicketsBrowse_FormClosed(object sender, FormClosedEventArgs e)
        {
            myParent.toolStripStatusLabel6.Text = "";
        }
    }
}
