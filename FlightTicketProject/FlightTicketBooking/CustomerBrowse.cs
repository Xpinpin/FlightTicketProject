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
    public partial class CustomerBrowse : Form
    {
        mainForm myParent;
        public CustomerBrowse(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            DataTable dt = DataAccess.GetData("SELECT CustomerID, FirstName + ' ' + LastName AS CustomerName FROM Customer");
            UIUtilities.FillListControl(cmbCustomers, "CustomerName", "CustomerID", dt, true, "--- Choose a customer ---");
        }

        private void CustomerBrowse_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void DisplayNumberOfTickets()
        {
            myParent.toolStripStatusLabel5.Text = $"The current customer has {dgvInfo.Rows.Count} tickets |";
            myParent.toolStripStatusLabel5.ForeColor = Color.Black;
        }

        private void CmbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbCustomers.SelectedIndex == 0)
            {
                myParent.toolStripStatusLabel5.Text = $"Please choose a customer.";
                myParent.toolStripStatusLabel5.ForeColor = Color.Red;
                dgvInfo.DataSource = null;
                lblAddress.Text = "";
                lblContactNum.Text = "";
                lblEmail.Text = "";
                lblHomeNum.Text = "";
            }
            else
            {
                string sqlDgv = $@"SELECT  
	                            DepartureAirport + ' - ' + ArrivalAirport + ' (' + CONVERT(VARCHAR(MAX),DepartureTime) + ')'AS TicketInfo,
	                            Booking.DateBooked,
	                            Booking.Total
                               FROM Booking
                               INNER JOIN Ticket ON Booking.TicketID = Ticket.TicketID
                               WHERE Booking.CustomerID = {cmbCustomers.SelectedValue}
                               ORDER BY DateBooked";
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
                    dgvInfo.Columns[0].HeaderCell.Value = "Ticket Information";
                    dgvInfo.Columns[1].HeaderCell.Value = "Booking Date";
                    dgvInfo.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
                }

                string sqlCustomerInfo = $"SELECT * FROM Customer WHERE CustomerID = {cmbCustomers.SelectedValue}";
                DataTable dtCustomer = DataAccess.GetData(sqlCustomerInfo);
                DataRow row = dtCustomer.Rows[0];
                lblAddress.Text = $"{row["StreetNumber"].ToString()}, {row["StreetName"].ToString()}, {row["City"].ToString()} {row["Province"].ToString()} {row["Country"].ToString()}, {row["PostalCode"].ToString()} ";
                lblContactNum.Text = $"{row["CellNumber"].ToString()}";
                lblHomeNum.Text = $"{row["HomeNumber"].ToString()}";
                lblEmail.Text = $"{row["Email"].ToString()}";

                DisplayNumberOfTickets();
            }
            
        }

        private void DgvInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal totalPrice = 0;
            for(int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(dgvInfo.Rows[i].Cells["Total"].Value.ToString());
            }
            MessageBox.Show($"The total money this customer has spent for booking tickets is {totalPrice.ToString("c")}");
        }

        private void CustomerBrowse_FormClosed(object sender, FormClosedEventArgs e)
        {
            myParent.toolStripStatusLabel5.Text = "";
        }
    }
}
