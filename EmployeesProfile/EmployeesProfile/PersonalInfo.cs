using Composition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesProfile
{
    public partial class PersonalInfo : Form
    {
        private int _employeRowID;
        // Create private _dbContext object to connect to database 
        private EmployeesProfileDataContext _dbContext = new EmployeesProfileDataContext();

        public PersonalInfo()
        {
            InitializeComponent();
        }

        public PersonalInfo(string employeeName) {
            InitializeComponent();
            txtFirstName.Text = employeeName.Split(' ')[0];
            txtLastName.Text = employeeName.Split(' ')[1];
        }

        public PersonalInfo(int employeRowID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            _employeRowID = employeRowID;
            // Use FirstOrDefault to get the first object of the query
            var employee = (from emp in _dbContext.Employees
                           where emp.Id == employeRowID
                           select emp).FirstOrDefault();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtMiddleName.Text = employee.MiddleName;

            // populate numberic up/down control for birthday
            if (employee.DOB != null) {
                nudMonth.Value = ((DateTime)employee.DOB).Month;
                nudDay.Value = ((DateTime)employee.DOB).Day;
                nudYear.Value = ((DateTime)employee.DOB).Year;
            }

            // populate gender
            if (employee.Gender != null)
            {
                if (employee.Gender.ToUpper() == "M")
                    rdoMale.Checked = true;
                else if (employee.Gender.ToUpper() == "F")
                    rdoFemale.Checked = true;
            }
            
            // populate SSN
            if (employee.SSN != null) {
                txtSSN1.Text = employee.SSN.Substring(0, 3);
                txtSSN2.Text = employee.SSN.Substring(3, 2);
                txtSSN3.Text = employee.SSN.Substring(5, 4);
            }

            // populate phone number
            txtPhoneNumber.Text = employee.PhoneNumber;
            
            // populdate email
            txtEmail.Text = employee.Email;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDOB())
            {
                Employee employee;
                if (_employeRowID == 0)
                {
                    // New employee
                    employee = new Employee();  // create a new employee object
                    // add new employee object to database context to be save when submit change
                    _dbContext.Employees.InsertOnSubmit(employee);  
                }
                else
                {
                    // Look for the existing employee row in database to update the value
                    employee = (from emp in _dbContext.Employees
                                    where emp.Id == _employeRowID
                                    select emp).FirstOrDefault();
                }
                // update employee properties
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.MiddleName = txtMiddleName.Text;

                employee.DOB = new DateTime((int)(nudYear.Value), (int) (nudMonth.Value), (int) (nudDay.Value));
                if (rdoMale.Checked)
                    employee.Gender = "M";
                else if (rdoFemale.Checked)
                    employee.Gender = "F";
                employee.SSN = txtSSN1.Text + txtSSN2.Text + txtSSN3.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.Email = txtEmail.Text;

                // commit the changes to database
                _dbContext.SubmitChanges();

                Program.frmEmployeeList.LoadlsbEmployeeList();
                this.Close();
            }
        }

        private void rdoMale_Enter(object sender, EventArgs e)
        {
            ValidateDOB();
        }        

        private void rdoFemale_Enter(object sender, EventArgs e)
        {
            ValidateDOB();
        }

        private bool ValidateDOB()
        {
            try
            {
                Date dDOB = new Date((int)nudMonth.Value, (int)nudDay.Value, (int)nudYear.Value);
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Wrong birthday");
                nudMonth.Focus();
                return false;
            }
        }        

        private void txtSSN1_KeyDown(object sender, KeyEventArgs e)
        {                 
            if (e.KeyValue < 48 || e.KeyValue > 57)
            {
                txtSSN1.Text = txtSSN1.Text.Substring(txtSSN1.Text.Length - 1);
            }            
        }

        private void txtSSN2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSSN3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSSN1_Leave(object sender, EventArgs e)
        {
            if (txtSSN1.Text.Length < 3)
                txtSSN1.Focus();
        }

        private void txtSSN2_Leave(object sender, EventArgs e)
        {
            if (txtSSN2.Text.Length < 2)
                txtSSN1.Focus();
        }

        private void txtSSN3_Leave(object sender, EventArgs e)
        {
            if (txtSSN2.Text.Length < 4)
                txtSSN1.Focus();
        }

        private void txtSSN1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((e.KeyChar < '1' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }      

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (txtMovieName.Text.Trim() != "") {
                lsbMovies.Items.Add(txtMovieName.Text);
            }
        }

        private void btnClearMovies_Click(object sender, EventArgs e)
        {
            lsbMovies.Items.Clear();
        }
    }
}
