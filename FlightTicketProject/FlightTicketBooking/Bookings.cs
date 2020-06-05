using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int currentTicket;
        private int currentCustomer;

        private int firstTicket;
        private int firstCustomer;

        private int? previousTicket;
        private int? previousCustomer;

        private int? nextTicket;
        private int? nextCustomer;

        private int lastTicket;
        private int lastCustomer;

        private int currentRecord;

        private const decimal TAX_RATE = 0.15m;
        public Bookings(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void LoadPaymentMethods()
        {
            string[] methods = new string[] {"","By Cash", "Debit Card", "Credit Card", "PayPal" };
            cmbMethod.DataSource = methods;
        }

        private void DisplayCurrentPosition()
        {
            int totalRecord = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Booking"));
            myParent.toolStripStatusLabel4.Text = $"Displaying booking {currentRecord} of {totalRecord} | ";
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
            LoadPaymentMethods();
            LoadFirstBooking();
        }

        private void LoadFirstBooking()
        {
            DataTable firstBooking = DataAccess.GetData("SELECT TOP 1 TicketID, CustomerID FROM Booking ORDER BY TicketID");
            if(firstBooking.Rows.Count > 0)
            {
                currentTicket = Convert.ToInt32(firstBooking.Rows[0]["TicketID"]);
                currentCustomer = Convert.ToInt32(firstBooking.Rows[0]["CustomerID"]);

                firstTicket = currentTicket;
                firstCustomer = currentCustomer;

                LoadBookingDetails();
            }
        }

        private void LoadBookingDetails()
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Booking WHERE TicketID = {currentTicket} AND CustomerID = {currentCustomer}",
                $@"SELECT	(SELECT TOP 1 TicketID FROM Booking ORDER BY TicketID) AS FirstTicket ,
		                    (SELECT TOP 1 CustomerID FROM Booking ORDER BY TicketID)  AS FirstCustomer,
		                    b.PreviousTicket,
		                    b.PreviousCustomer,
	                        b.NextTicket,
		                    b.NextCustomer,
		                    (SELECT TOP 1 TicketID  FROM Booking ORDER BY TicketID DESC) AS LastTicket,
		                    (SELECT TOP 1 CustomerID FROM Booking ORDER BY TicketID DESC) AS LastCustomer,
		                    b.RowNumber
                            FROM
                            (
                                SELECT CustomerID, TicketID,
		                        LEAD(TicketID) OVER (ORDER BY TicketID) AS NextTicket,
		                        LAG(TicketID) OVER (ORDER BY TicketID) AS PreviousTicket,
		                        LEAD(CustomerID) OVER (ORDER BY TicketID) AS NextCustomer,
		                        LAG(CustomerID) OVER (ORDER BY TicketID) AS PreviousCustomer,
		                        ROW_NUMBER() OVER (ORDER BY TicketID) AS RowNumber
                                FROM Booking
                            ) AS b
                            WHERE b.TicketID = {currentTicket} AND b.CustomerID = {currentCustomer}
                            ORDER BY b.TicketID, b.CustomerID"
            };

            DataSet ds = DataAccess.GetData(sqlStatements);

            if(ds.Tables[0].Rows.Count == 1)
            {
                DataRow selectedBooking = ds.Tables[0].Rows[0];
                cmbCustomers.SelectedValue = selectedBooking["CustomerID"];
                cmbTickets.SelectedValue = selectedBooking["TicketID"];
                dtpDate.Value = Convert.ToDateTime(selectedBooking["DateBooked"]);
                txtSub.Text = selectedBooking["Subtotal"].ToString();
                txtTax.Text = selectedBooking["Tax"].ToString();
                txtTotal.Text = selectedBooking["Total"].ToString();
                cmbMethod.SelectedItem = selectedBooking["PaymentMethod"];
                txtDescription.Text = selectedBooking["Description"].ToString();
                chkPaid.Checked = (bool)selectedBooking["IsPaid"];

                firstTicket = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstTicket"]);
                firstCustomer = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstCustomer"]);

                lastTicket = Convert.ToInt32(ds.Tables[1].Rows[0]["LastTicket"]);
                lastCustomer = Convert.ToInt32(ds.Tables[1].Rows[0]["LastCustomer"]);

                previousTicket = ds.Tables[1].Rows[0]["PreviousTicket"] != DBNull.Value
                    ? Convert.ToInt32(ds.Tables[1].Rows[0]["PreviousTicket"]) : (int?)null;
                previousCustomer = ds.Tables[1].Rows[0]["PreviousCustomer"] != DBNull.Value
                    ? Convert.ToInt32(ds.Tables[1].Rows[0]["PreviousCustomer"]) : (int?)null;

                nextTicket = ds.Tables[1].Rows[0]["NextTicket"] != DBNull.Value
                   ? Convert.ToInt32(ds.Tables[1].Rows[0]["NextTicket"]) : (int?)null;
                nextCustomer = ds.Tables[1].Rows[0]["NextCustomer"] != DBNull.Value
                    ? Convert.ToInt32(ds.Tables[1].Rows[0]["NextCustomer"]) : (int?)null;

                currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

                NextPreviousButtonManagement();
                DisplayCurrentPosition();
            }
            else
            {
                MessageBox.Show("This booking does not exist");
                LoadFirstBooking();
            }
        }

       private void NavigationHandler(object sender, EventArgs e)
       {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFirst":
                    currentTicket = firstTicket;
                    currentCustomer = firstCustomer;
                    break;
                case "btnPrevious":
                    currentTicket = previousTicket.Value;
                    currentCustomer = previousCustomer.Value;
                    break;
                case "btnNext":
                    currentTicket = nextTicket.Value;
                    currentCustomer = nextCustomer.Value;
                    break;
                case "btnLast":
                    currentTicket = lastTicket;
                    currentCustomer = lastCustomer;
                    break;
            }
            LoadBookingDetails();
       }
        private void NextPreviousButtonManagement()
        {
            btnNext.Enabled = nextCustomer != null;
            btnPrevious.Enabled = previousCustomer != null;
        }

        private void NavigationState(bool state)
        {
            btnFirst.Enabled = state;
            btnNext.Enabled = state;
            btnPrevious.Enabled = state;
            btnLast.Enabled = state;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UIUtilities.ClearControls(this.grpCustomerTicket.Controls);
            UIUtilities.ClearControls(this.grpPayment.Controls);

            cmbCustomers.Enabled = true;
            cmbTickets.Enabled = true;
            NavigationState(false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Text = "Save";
            btnCancel.Text = "Cancel";
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string errMsg = null;
            string cmbName = cmb.Tag.ToString();

            if(cmb.SelectedIndex == 0)
            {
                errMsg = $"{cmbName} is required.";
                e.Cancel = true;
            }
            errProvider.SetError(cmb, errMsg);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (btnCancel.Text == "Cancel")
                    {
                        CreateBooking();
                        cmbCustomers.Enabled = false;
                        cmbTickets.Enabled = false;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to update this booking?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            UpdateBooking();
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("This booking has already been created");
                UIUtilities.ClearControls(this.grpCustomerTicket.Controls);
                UIUtilities.ClearControls(this.grpPayment.Controls);
            }
        }

        private void CreateBooking()
        {
           
                decimal subtotal = Convert.ToDecimal(DataAccess.GetValue($"SELECT InitialPrice FROM Ticket WHERE TicketID = {cmbTickets.SelectedValue}"));
                decimal tax = subtotal * TAX_RATE;
                decimal total = subtotal + tax;
                string description;
                if (txtDescription.Text == string.Empty)
                {
                    description = "NULL";
                }
                else
                {
                    description = $"'{txtDescription.Text.Trim()}'";
                }

                string sqlInsertBooking = $@"INSERT INTO Booking
                                        (CustomerID, TicketID, Subtotal, Tax, Total, DateBooked, PaymentMethod, IsPaid, Description)
                                        VALUES
                                        (
                                            {cmbCustomers.SelectedValue},
                                            {cmbTickets.SelectedValue},
                                            {subtotal},
                                            {tax},
                                            {total},
                                            '{dtpDate.Value.ToString()}',
                                            '{cmbMethod.SelectedItem.ToString()}',
                                            {(chkPaid.Checked == true ? 1 : 0)},
                                            {description}
                                        )";

                sqlInsertBooking = DataAccess.SQLCleaner(sqlInsertBooking);
                int rowsAffected = DataAccess.SendData(sqlInsertBooking);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("The booking is created");
                    LoadFirstBooking();
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The database records no rows affected");
                }
                NextPreviousButtonManagement();
                NavigationState(true);
            
            
        }

        private void UpdateBooking()
        {
            decimal subtotal = Convert.ToDecimal(DataAccess.GetValue($"SELECT InitialPrice FROM Ticket WHERE TicketID = {cmbTickets.SelectedValue}"));
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;
            string description;
            if (txtDescription.Text == string.Empty)
            {
                description = "NULL";
            }
            else
            {
                description = $"'{txtDescription.Text.Trim()}'";
            }

            string sqlUpdateBooking = $@"UPDATE Booking
                                         SET DateBooked = '{dtpDate.Value.ToString()}',
                                             Description = {description},
                                            IsPaid = {(chkPaid.Checked == true ? 1 : 0)},
                                            PaymentMethod = '{cmbMethod.SelectedItem.ToString()}'
                                         WHERE TicketID = {cmbTickets.SelectedValue} AND CustomerID = {cmbCustomers.SelectedValue}";

            sqlUpdateBooking = DataAccess.SQLCleaner(sqlUpdateBooking);
            int rowsAffected = DataAccess.SendData(sqlUpdateBooking);
            if(rowsAffected == 1)
            {
                MessageBox.Show("The booking updated");

            }
            else
            {
                MessageBox.Show("The database does not record any rows affected");
            }
        }

        private void Bookings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(btnUpdate.Text == "Save")
            {
                NavigationState(true);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Text = "Update";
                btnCancel.Text = "Exit";
                LoadBookingDetails();
                cmbCustomers.Enabled = false;
                cmbTickets.Enabled = false;
                errProvider.Clear();

            }
            else
            {
                this.Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this booking?","Deletion",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteBooking();
            }
        }

        private void DeleteBooking()
        {
            string sqlDeleteBooking = $"DELETE Booking WHERE CustomerID = {cmbCustomers.SelectedValue} AND TicketID = {cmbTickets.SelectedValue}";
            sqlDeleteBooking = DataAccess.SQLCleaner(sqlDeleteBooking);
            int rowsAffected = DataAccess.SendData(sqlDeleteBooking);

            if(rowsAffected == 1)
            {
                MessageBox.Show("The booking is deleted successfully");
                LoadFirstBooking();
            }
            else
            {
                MessageBox.Show("The database records no rows affected.");
            }
        }

        private void Bookings_FormClosed(object sender, FormClosedEventArgs e)
        {
            myParent.toolStripStatusLabel4.Text = "";
        }
    }
}
