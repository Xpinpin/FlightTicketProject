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
    public partial class Tickets : Form
    {
        mainForm myParent;
        int currentTicket;
        int firstTicket;
        int? previousTicket;
        int? nextTicket;
        int lastTicket;
        int currentRecord;

        public Tickets(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        /// <summary>
        /// Assigning Business Rules: Certain Places, Certain Seat Type, Certain Airlines
        /// </summary>
        private void LoadComboBox()
        {
            string[] startPlaces = new string[] {"","Toronto", "Moncton", "Montreal", "Vancouver", "Halifax", "Tokyo", "Osaka" };
            string[] destination = new string[] {"","Toronto","Moncton","Montreal","Vancouver","Halifax","Tokyo","Osaka"};
            cmbStart.DataSource = startPlaces;
            cmbDestination.DataSource = destination;
            string[] seatType = new string[] { "", "Business", "First Class", "Economy", "Premium Economy" };
            cmbSeat.DataSource = seatType;
            string[] airlinesName = new string[] { "", "AC", "WJA", "ANA", "EVA" };
            cmbAirlines.DataSource = airlinesName;

        }

        #region Events
        private void Tickets_Load(object sender, EventArgs e)
        {
            dtpDeparture.Format = DateTimePickerFormat.Custom;
            dtpDeparture.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpArrival.Format = DateTimePickerFormat.Custom;
            dtpArrival.CustomFormat = "dd/MM/yyyy HH:mm";

            LoadFirstTicket();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UIUtilities.ClearControls(this.groupBox1.Controls);
            UIUtilities.ClearControls(this.groupBox2.Controls);
            txtID.Text = "";

            btnAdd.Enabled = false;
            btnUpdate.Text = "Save";
            btnCancel.Text = "Cancel";
            btnDelete.Enabled = false;
            NavigationState(false);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtID.Text == string.Empty)
                {
                    AddNewTickets();
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this ticket?", "Update!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateTicket();

                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Save")
            {
                NavigationState(true);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Text = "Update";
                btnCancel.Text = "Exit";
                LoadTicketDetails();
                errProvider.Clear();
            }
            else
            {
                this.Close();
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this ticket?", "Deletion!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteTicket();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("This ticket is currently being booked. You can not delete this.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void Tickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            myParent.toolStripStatusLabel3.Text = "";
        }
        #endregion

        #region Retrieves
        private void DisplayCurrentPostition()
        {
            int totalRecord = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Ticket"));

            myParent.toolStripStatusLabel3.Text = $"Displaying Ticket {currentRecord} out of {totalRecord} |";
        }

        private void LoadFirstTicket()
        {
            object firstID = DataAccess.GetValue("SELECT TOP 1 TicketID FROM Ticket ORDER BY DepartureTime");
            currentTicket = Convert.ToInt32(firstID);
            LoadComboBox();
            LoadTicketDetails();
        }

        private void LoadTicketDetails()
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Ticket WHERE TicketID = {currentTicket}",
                $@"
                    SELECT (SELECT TOP 1 TicketID FROM Ticket ORDER BY DepartureTime) AS FirstTicketID,
		                    t.PreviousTicketID,
		                    t.NextTicketID,
		                    (SELECT TOP 1 TicketID FROM Ticket ORDER BY DepartureTime DESC) AS LastTicketID,
		                    t.RowNumber

                    FROM (
                            SELECT	TicketID, DepartureTime,
		                    LEAD(TicketID) OVER (ORDER BY DepartureTime) AS NextTicketID,
		                    LAG(TicketID) OVER (ORDER BY DepartureTime) AS PreviousTicketID,
		                    ROW_NUMBER() OVER (ORDER BY DepartureTime) AS RowNumber
                            FROM Ticket
                    ) AS t
                    WHERE t.TicketID = {currentTicket}
                    ORDER BY t.DepartureTime"
            };


            DataSet dt = DataAccess.GetData(sqlStatements);

            if (dt.Tables[0].Rows.Count == 1)
            {
                DataRow row = dt.Tables[0].Rows[0];
                txtID.Text = row["TicketID"].ToString();
                dtpDeparture.Value = Convert.ToDateTime(row["DepartureTime"]);
                dtpArrival.Value = Convert.ToDateTime(row["ArrivalTime"]);
                txtDepAirport.Text = row["DepartureAirport"].ToString();
                txtArrAirport.Text = row["ArrivalAirport"].ToString();
                cmbStart.SelectedItem = row["StartPlace"];
                cmbDestination.SelectedItem = row["Destination"];
                cmbSeat.SelectedItem = row["SeatType"];
                cmbAirlines.SelectedItem = row["AirlinesName"];
                txtPrice.Text = row["InitialPrice"].ToString();
                txtQuantity.Text = row["QuantityLeft"].ToString();
                txtDescription.Text = row["Description"].ToString();
                chkMeal.Checked = (bool)(row["MealIncluded"]);

                firstTicket = Convert.ToInt32(dt.Tables[1].Rows[0]["FirstTicketID"]);
                previousTicket = dt.Tables[1].Rows[0]["PreviousTicketID"] != DBNull.Value
                    ? Convert.ToInt32(dt.Tables[1].Rows[0]["PreviousTicketID"]) : (int?)null;
                nextTicket = dt.Tables[1].Rows[0]["NextTicketID"] != DBNull.Value
                    ? Convert.ToInt32(dt.Tables[1].Rows[0]["NextTicketID"]) : (int?)null;
                lastTicket = Convert.ToInt32(dt.Tables[1].Rows[0]["LastTicketID"]);
                currentRecord = Convert.ToInt32(dt.Tables[1].Rows[0]["RowNumber"]);

                NextPreviousButtonManagement();
                DisplayCurrentPostition();
            }
            else
            {
                MessageBox.Show("This ticket does not exist","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                LoadFirstTicket();
            }
        }
        #endregion

        #region Non-Queries
        private void AddNewTickets()
        {
            //Assign Business Rules 09: EVA Airlines does not have Premium Economy Seat Type.
            if(cmbAirlines.SelectedItem.ToString() == "EVA" && cmbSeat.SelectedItem.ToString() == "Premium Economy")
            {
                MessageBox.Show("EVA Airlines does not have Premium Economy Seat Type. Please choose other types.","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cmbSeat.SelectedIndex = 0;
                return;
            }
            string description;
            if (txtDescription.Text == string.Empty)
            {
                description = "NULL";
            }
            else
            {
                description = $"'{txtDescription.Text.Trim()}'";
            }

            string sqlInsertTicket = $@"
                INSERT INTO Ticket
                (DepartureTime, ArrivalTime, DepartureAirport, ArrivalAirport, StartPlace, Destination, SeatType, AirlinesName, InitialPrice, Description, QuantityLeft, MealIncluded)
                VALUES
                (
                    '{dtpDeparture.Value.ToString()}',
                    '{dtpArrival.Value.ToString()}',
                    '{txtDepAirport.Text.Trim()}',
                    '{txtArrAirport.Text.Trim()}',
                    '{cmbStart.SelectedItem.ToString()}',
                    '{cmbDestination.SelectedItem.ToString()}',
                    '{cmbSeat.SelectedItem.ToString()}',
                    '{cmbAirlines.SelectedItem.ToString()}',
                    {txtPrice.Text.Trim()},
                    {description},
                    {txtQuantity.Text.Trim()},
                    {(chkMeal.Checked == true ? 1 : 0)}
                )";

            sqlInsertTicket = DataAccess.SQLCleaner(sqlInsertTicket);
            int rowsAffected = DataAccess.SendData(sqlInsertTicket);
            if (rowsAffected == 1)
            {
                MessageBox.Show("A ticket has been created","Successful!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadFirstTicket();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                MessageBox.Show("The database records no rows affected","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            NextPreviousButtonManagement();
            NavigationState(true);
        }

        private void UpdateTicket()
        {
            string description;
            if (txtDescription.Text == string.Empty)
            {
                description = "NULL";
            }
            else
            {
                description = $"'{txtDescription.Text.Trim()}'";
            }

            string sqlUpdateTicket = $@"
            UPDATE Ticket
            SET DepartureTime = '{dtpDeparture.Value.ToString()}',
                ArrivalTime = '{dtpArrival.Value.ToString()}',
                DepartureAirport = '{txtDepAirport.Text.Trim()}',
                ArrivalAirport = '{txtArrAirport.Text.Trim()}',
                StartPlace = '{cmbStart.SelectedItem.ToString()}',
                Destination = '{cmbDestination.SelectedItem.ToString()}',
                SeatType = '{cmbSeat.SelectedItem.ToString()}',
                AirlinesName = '{cmbAirlines.SelectedItem.ToString()}',
                InitialPrice = {txtPrice.Text.Trim()},
                Description = {description},
                QuantityLeft = {txtQuantity.Text.Trim()},
                MealIncluded = {(chkMeal.Checked == true ? 1 : 0)}
            WHERE TicketID = {txtID.Text}";
            sqlUpdateTicket = DataAccess.SQLCleaner(sqlUpdateTicket);

            int rowsAffected = DataAccess.SendData(sqlUpdateTicket);
            if (rowsAffected == 1)
            {
                MessageBox.Show("The ticket has been updated","Successful!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The database records no rows affected","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DeleteTicket()
        {
            string sqlDeleteTicket = $"DELETE Ticket WHERE TicketID = {txtID.Text}";

            int rowsAffected = DataAccess.SendData(sqlDeleteTicket);
            if (rowsAffected == 1)
            {
                MessageBox.Show("Delete the ticket successfully","Successful!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadFirstTicket();
            }
            else
            {
                MessageBox.Show("The database records no rows affected","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Navigation
        private void NavigationHandler(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFirst":
                    currentTicket = firstTicket;
                    break;
                case "btnNext":
                    currentTicket = nextTicket.Value;
                    break;
                case "btnPrevious":
                    currentTicket = previousTicket.Value;
                    break;
                case "btnLast":
                    currentTicket = lastTicket;
                    break;
            }
            LoadTicketDetails();
        }

        private void NextPreviousButtonManagement()
        {
            btnNext.Enabled = nextTicket != null;
            btnPrevious.Enabled = previousTicket != null;
        }

        private void NavigationState(bool state)
        {
            btnFirst.Enabled = state;
            btnNext.Enabled = state;
            btnPrevious.Enabled = state;
            btnLast.Enabled = state;
        }
        #endregion

        #region Validating
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string errMsg = null;
            string txtName = txt.Tag.ToString();

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtName} is required.";
                e.Cancel = true;
            }

            if (txt.Name == "txtQuantity")
            {
                if (!int.TryParse(txt.Text, out int c))
                {
                    errMsg = $"{txtName} is not a valid number";
                    e.Cancel = true;
                }
            }

            if (txt.Name == "txtPrice")
            {
                if (!decimal.TryParse(txt.Text, out decimal c))
                {
                    errMsg = $"{txtName} is not a valid number";
                    e.Cancel = true;
                }
            }

            errProvider.SetError(txt, errMsg);
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string errMsg = null;
            string cmbName = cmb.Tag.ToString();
            if (cmb.SelectedIndex == 0)
            {
                errMsg = $"You have to select a valid {cmbName}";
                e.Cancel = true;
            }

            errProvider.SetError(cmb, errMsg);
        }

        private void dtp_Validating(object sender, CancelEventArgs e)
        {
            string errMsg = null;
            if (dtpArrival.Value == dtpDeparture.Value)
            {
                errMsg = $"You need to set the Departure and Arrival date and time";
                e.Cancel = true;
            }

            errProvider.SetError(dtpArrival, errMsg);
            errProvider.SetError(dtpDeparture, errMsg);
        }
        #endregion












    }
}
