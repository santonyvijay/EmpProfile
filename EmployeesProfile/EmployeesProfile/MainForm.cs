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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfo piInfo = new PersonalInfo();
            piInfo.MdiParent = this;
            piInfo.Show();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Program.frmEmployeeList.MdiParent = this;
            Program.frmEmployeeList.Show();
        }
    }
}
