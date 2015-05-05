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
    public partial class EmploymentInfo : Form
    {
        private int employeRowID;
        private EmployeesProfileDataContext _dbContext = new EmployeesProfileDataContext();

        public EmploymentInfo()
        {
            InitializeComponent();
        }

        public EmploymentInfo(int employeRowID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.employeRowID = employeRowID;
             var employee = (from emp in _dbContext.Employees 
                             where emp.Id == employeRowID select emp).FirstOrDefault();
             txtEmployeeID.Text = employee.EmployeeID;
             dtpHiredDate.Text = employee.HiredDate.ToString();
             if (employee.Position != null)
             {
                 cmbPosition.Text = employee.Position;
             }
            if(employee.Branch !=null)
            {
                 cmbBranch.Text = employee.Branch;
            }
            if(employee.SkillSet != null)
            {
            string lsbSkills = employee.SkillSet;
                 string[] skill = lsbSkills.Split(',');
                 int i = lsbSkillSet.Items.Count;


                 if (skill != null)
                 {
                     foreach (string s in skill)
                     {
                         for (int j = 0; j < i; j++)
                         {
                             string l = lsbSkillSet.Items[j].ToString();
                             if (s == l)
                             {
                                 lsbSkillSet.SetSelected(j, true);
                             }
                         }
                     }
                 }

             }
        
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee;
            employee = (from emp in _dbContext.Employees
                        where emp.Id == employeRowID
                        select emp).FirstOrDefault();

            employee.EmployeeID = txtEmployeeID.Text;
            employee.HiredDate = dtpHiredDate.Value;
            employee.Position = cmbPosition.Text;
            employee.Branch = cmbBranch.Text;
            //employee.SkillSet = lsbSkillSet.Text;
            int k = lsbSkillSet.Items.Count;
            string skill = "";
            for (int j = 0; j < k; j++)
            {
                skill += lsbSkillSet.Items[j];
            }

            string strMessage = "";

            strMessage = "Employee ID: " + txtEmployeeID.Text;
            DateTime hiredDate = (DateTime)dtpHiredDate.Value;

            strMessage += "\nHired Date: " + hiredDate.Date.ToShortDateString();
            strMessage += "\nPosition: " + cmbPosition.SelectedItem;
            strMessage += "\nSkill set: ";

            // Skill Set: C++, Java, ...
            if (lsbSkillSet.SelectedIndex != -1)
            {
                for (int i = 0; i < lsbSkillSet.SelectedItems.Count; i++)
                {
                    strMessage += lsbSkillSet.SelectedItems[i].ToString() + ",";
                    employee.SkillSet += lsbSkillSet.SelectedItems[i].ToString() + ",";
                }
            }

            strMessage += "\nBranch: " + cmbBranch.SelectedItem;

            MessageBox.Show(strMessage);
            _dbContext.SubmitChanges();

        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbSkillSet.Items.Clear();
            cmbBranch.Items.Clear();
            switch (cmbPosition.SelectedItem.ToString()) { 
                case "Accounting Manager":
                    lsbSkillSet.Items.Add("CPA");
                    lsbSkillSet.Items.Add("Payroll");
                    lsbSkillSet.Items.Add("Management");
                    cmbBranch.Items.Add("HQ");
                    cmbBranch.Items.Add("NY");                    
                    break;
                case "CEO":
                case "CFO":
                    lsbSkillSet.Items.Add("Project Management");
                    lsbSkillSet.Items.Add("Public Speaking");
                    lsbSkillSet.Items.Add("Management");
                    lsbSkillSet.Items.Add("Planning");
                    cmbBranch.Items.Add("HQ");                    
                    break;
                case "Developer 1":
                case "Developer 2":
                case "Developer 3":
                case "Developer 4":
                case "Development Manager":
                    lsbSkillSet.Items.Add("ASP.NET");
                    lsbSkillSet.Items.Add("C#");
                    lsbSkillSet.Items.Add("C++");
                    lsbSkillSet.Items.Add("HTML");
                    lsbSkillSet.Items.Add("Java");
                    lsbSkillSet.Items.Add("JavaScript");
                    lsbSkillSet.Items.Add("JSON");
                    lsbSkillSet.Items.Add("Python");
                    lsbSkillSet.Items.Add("XML");

                    cmbBranch.Items.Add("HOU");
                    cmbBranch.Items.Add("DAL");
                    break;
                case "HR Manager":
                case "HR Specialist":
                    lsbSkillSet.Items.Add("Salary Evaluation");
                    lsbSkillSet.Items.Add("Employment Policy");
                    lsbSkillSet.Items.Add("Employment Law");
                    lsbSkillSet.Items.Add("PeopleSoft");
                    cmbBranch.Items.Add("HQ");
                    cmbBranch.Items.Add("NY");     
                    break;
                case "Operator":
                    lsbSkillSet.Items.Add("Time Management");
                    lsbSkillSet.Items.Add("Bachelor Degree");
                    lsbSkillSet.Items.Add("Microsoft Office");                    
                    cmbBranch.Items.Add("HOU");
                    cmbBranch.Items.Add("DAL");
                    cmbBranch.Items.Add("NY");  
                    break;
                default:
                    break;                
            }
            cmbBranch.Text = cmbBranch.Items[0].ToString();
        }
    }
}

