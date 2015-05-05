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
    public partial class EmployeeList : Form
    {
        
        public EmployeeList()
        {
            InitializeComponent();            
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadlsbEmployeeList();                     
        }        

        private void lsbEmployeesList_DoubleClick(object sender, EventArgs e)
        {
            // Convert selected item value to record id of Employees table
            int employeRowID = int.Parse(lsbEmployeesList.SelectedValue.ToString());
            PersonalInfo piInfo = new PersonalInfo(employeRowID);
            // set parent to current form's parent so that they have the same parent
            piInfo.MdiParent = this.MdiParent;  
            piInfo.Show();
            EmploymentInfo eiInfo = new EmploymentInfo(employeRowID);
            eiInfo.MdiParent = this.MdiParent;
            eiInfo.Show();
        }

        public void LoadlsbEmployeeList() {
            // Create the database context to query data from database
            EmployeesProfileDataContext dbContext = new EmployeesProfileDataContext();

            // Use LINQ to query all employee from Employees table of database context
            var employeeList = from emp in dbContext.Employees orderby emp.Id
                               select emp;

            // Bind employee data source to list of employee
            lsbEmployeesList.DataSource = employeeList;

            // Set the Display Member of Employee List Box to Last Name            
            lsbEmployeesList.DisplayMember = "FullInfo";
            
            

            // Set the Value Member of List Box to Id column. 
            // This will define the value of ListBox SelectedValue;
            lsbEmployeesList.ValueMember = "Id";
        }
    }
}
