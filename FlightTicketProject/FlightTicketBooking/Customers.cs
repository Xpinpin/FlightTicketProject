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
    public partial class Customers : Form
    {
        mainForm myParent;
        int currentCustomer = 0;
        int firstCustomer = 0;
        int lastCustomer = 0;
        int? previousCustomer = 0;
        int? nextCustomer = 0;
        int currentRecord = 0;

        public Customers(mainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadFirstCustomer();
        }

        private void DisplayCurrentPosition()
        {
            int totalRecord = Convert.ToInt32(DataAccess.GetValue("SELECT COUNT(*) FROM Customer"));
            myParent.toolStripStatusLabel2.Text = $"Display customer {currentRecord} of {totalRecord}";
        }

        /// <summary>
        /// Load the first customer in the database. Order by FirstMame, LastName
        /// </summary>
        private void LoadFirstCustomer()
        {
            object firstID = DataAccess.GetValue("SELECT TOP 1 CustomerID FROM Customer ORDER BY FirstName, LastName");

            currentCustomer = Convert.ToInt32(firstID);
            LoadCustomerDetails();
            

        }

        private void LoadCustomerDetails()
        {
            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM Customer WHERE CustomerID = {currentCustomer}",
                $@"SELECT 
                    (	SELECT TOP 1 CustomerID FROM Customer ORDER BY FirstName, LastName) AS FirstCustomerID,
                    c.PreviousCustomerID,
                    c.NextCustomerID,
                    (	SELECT TOP 1 CustomerID FROM Customer ORDER BY FirstName DESC, LastName DESC) AS LastCustomerID,
                    c.RowNumber

                    FROM (
                            SELECT CustomerID, FirstName, LastName,
	                        LEAD(CustomerID) OVER(ORDER BY FirstName, LastName) AS NextCustomerID,
	                        LAG(CustomerID) OVER(ORDER BY FirstName, LastName) AS PreviousCustomerID,
	                        ROW_NUMBER() OVER (ORDER BY FirstName, LastName) AS RowNumber
	                        FROM Customer
                    ) AS c
                    WHERE c.CustomerID = {currentCustomer}  
                    ORDER BY c.FirstName, c.LastName"

            };

            DataSet dt = DataAccess.GetData(sqlStatements);

            if(dt.Tables[0].Rows.Count == 1)
            {
                DataRow row = dt.Tables[0].Rows[0];
                txtID.Text = row["CustomerID"].ToString();
                txtFirstName.Text = row["FirstName"].ToString();
                txtMiddleName.Text = row["MiddleName"].ToString();
                txtLastName.Text = row["LastName"].ToString();
                txtStreetNum.Text = row["StreetNumber"].ToString();
                txtStreetName.Text = row["StreetName"].ToString();
                txtCity.Text = row["City"].ToString();
                txtProvince.Text = row["Province"].ToString();
                txtCountry.Text = row["Country"].ToString();
                txtPostalCode.Text = row["PostalCode"].ToString();
                txtCellNum.Text = row["CellNumber"].ToString();
                txtHomeNum.Text = row["HomeNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();

                firstCustomer = Convert.ToInt32(dt.Tables[1].Rows[0]["FirstCustomerID"]);
                previousCustomer = dt.Tables[1].Rows[0]["PreviousCustomerID"] != DBNull.Value
                    ? Convert.ToInt32(dt.Tables[1].Rows[0]["PreviousCustomerID"]) : (int?)null;
                nextCustomer = dt.Tables[1].Rows[0]["NextCustomerID"] != DBNull.Value
                    ? Convert.ToInt32(dt.Tables[1].Rows[0]["NextCustomerID"]) : (int?)null;
                lastCustomer = Convert.ToInt32(dt.Tables[1].Rows[0]["LastCustomerID"]);
                currentRecord = Convert.ToInt32(dt.Tables[1].Rows[0]["RowNumber"]);
                NextPreviousButtonManagement();
                DisplayCurrentPosition();
            }
            else
            {
                MessageBox.Show("The customer does not exist");
                LoadFirstCustomer();
            }
        }

        private void NavigationHandler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnFirst":
                    currentCustomer = firstCustomer;
                    break;
                case "btnNext":
                    currentCustomer = nextCustomer.Value;
                    break;
                case "btnPrevious":
                    currentCustomer = previousCustomer.Value;
                    break;
                case "btnLast":
                    currentCustomer = lastCustomer;
                    break;
            }
            LoadCustomerDetails();
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
            UIUtilities.ClearControls(this.grpAddress.Controls);
            UIUtilities.ClearControls(this.grpName.Controls);
            UIUtilities.ClearControls(this.grpContact.Controls);
            txtID.Text = "";
            NavigationState(false);
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Text = "Save";
            btnCancel.Text = "Cancel";

        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string errMsg = null;
            string txtName = txt.Tag.ToString();

            if(txt.Text == string.Empty)
            {
                errMsg = $"{txtName} is required.";
                e.Cancel = true;
            }

            if(txt.Name == "txtStreetNum")
            {
                if(!int.TryParse(txt.Text, out int c))
                {
                    errMsg = $"{txtName} is not a valid number";
                    e.Cancel = true;
                }
            }
           

            errProvider.SetError(txt, errMsg);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if(txtID.Text == string.Empty)
                {
                    AddNewCustomer();

                }
                else
                {
                    if(MessageBox.Show("Are you sure want to update?","Update",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UpdateCustomer();

                    }
                }
            }
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
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
                LoadCustomerDetails();
                errProvider.Clear();
            }
            else
            {
                this.Close();
            }
            
        }

        private void AddNewCustomer()
        {
            string middleName = "";
            string province = "";
            string postalCode = "";
            if(txtMiddleName.Text == string.Empty)
            {
                middleName = "NULL";
            }
            else
            {
                middleName = $"'{txtMiddleName.Text.Trim()}'";
            }

            if (txtProvince.Text == string.Empty)
            {
                province = "NULL";
            }
            else
            {
                province = $"'{txtProvince.Text.Trim()}'";
            }

            if (txtPostalCode.Text == string.Empty)
            {
                postalCode = "NULL";
            }
            else
            {
                postalCode = $"'{txtPostalCode.Text.Trim()}'";
            }
            string sqlInserterCustomer = $@"
                INSERT INTO Customer
                (FirstName, MiddleName, LastName, StreetNumber, StreetName, City, Province, Country, PostalCode, CellNumber, HomeNumber, Email)
                VALUES
                (
                    '{txtFirstName.Text.Trim()}',
                    {middleName},
                    '{txtLastName.Text.Trim()}',
                    {txtStreetNum.Text.Trim()},
                    '{txtStreetName.Text.Trim()}',
                    '{txtCity.Text.Trim()}',
                    {province},
                    '{txtCountry.Text.Trim()}',
                    {postalCode},
                    '{txtCellNum.Text.Trim()}',
                    '{txtHomeNum.Text.Trim()}',
                    '{txtEmail.Text.Trim()}'
                )";

            sqlInserterCustomer = DataAccess.SQLCleaner(sqlInserterCustomer);
            int rowsAffected = DataAccess.SendData(sqlInserterCustomer);
            if(rowsAffected == 1)
            {
                MessageBox.Show("A customer is added");
                LoadFirstCustomer();
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("The database records no row affected");
            }
            NextPreviousButtonManagement();
            NavigationState(true);
        }
        private void UpdateCustomer()
        {
            string middleName = "";
            string province = "";
            string postalCode = "";
            if (txtMiddleName.Text == string.Empty)
            {
                middleName = "NULL";
            }
            else
            {
                middleName = $"'{txtMiddleName.Text.Trim()}'";
            }

            if (txtProvince.Text == string.Empty)
            {
                province = "NULL";
            }
            else
            {
                province = $"'{txtProvince.Text.Trim()}'";
            }

            if (txtPostalCode.Text == string.Empty)
            {
                postalCode = "NULL";
            }
            else
            {
                postalCode = $"'{txtPostalCode.Text.Trim()}'";
            }

            string sqlUpdateCustomer = $@"
                UPDATE Customer
                SET FirstName = '{txtFirstName.Text.Trim()}',
                    MiddleName = {middleName},
                    LastName = '{txtLastName.Text.Trim()}',
                    StreetNumber = {txtStreetNum.Text.Trim()},
                    StreetName = '{txtStreetName.Text.Trim()}',
                    City = '{txtCity.Text.Trim()}',
                    Province = {province},
                    Country = '{txtCountry.Text.Trim()}',
                    PostalCode = {postalCode},
                    CellNumber = '{txtCellNum.Text.Trim()}',
                    HomeNumber = '{txtHomeNum.Text.Trim()}',
                    Email = '{txtEmail.Text.Trim()}'
                WHERE CustomerID = {txtID.Text}";

            sqlUpdateCustomer = DataAccess.SQLCleaner(sqlUpdateCustomer);
            int rowsAffected = DataAccess.SendData(sqlUpdateCustomer);
            if(rowsAffected == 1)
            {
                MessageBox.Show("Customer updated.");
            }
            else
            {
                MessageBox.Show("The database records no rows affected");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?","Deletion",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteCustomer();
            }
        }

        private void DeleteCustomer()
        {
            string sqlDeleteCustomer = $"DELETE FROM Customer WHERE CustomerID = {txtID.Text}";

            int rowsAffected = DataAccess.SendData(sqlDeleteCustomer);
            if(rowsAffected == 1)
            {
                MessageBox.Show("Customer deleted");
                LoadFirstCustomer();
            }
            else
            {
                MessageBox.Show("The database records no rows affected");
            }
        }
    }
}
