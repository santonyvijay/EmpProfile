namespace EmployeesProfile
{
    partial class EmploymentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblHiredDate = new System.Windows.Forms.Label();
            this.dtpHiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblSkillSet = new System.Windows.Forms.Label();
            this.lsbSkillSet = new System.Windows.Forms.ListBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(10, 18);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(96, 10);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeID.TabIndex = 1;
            this.txtEmployeeID.Text = "123456";
            // 
            // lblHiredDate
            // 
            this.lblHiredDate.AutoSize = true;
            this.lblHiredDate.Location = new System.Drawing.Point(10, 43);
            this.lblHiredDate.Name = "lblHiredDate";
            this.lblHiredDate.Size = new System.Drawing.Size(58, 13);
            this.lblHiredDate.TabIndex = 2;
            this.lblHiredDate.Text = "Hired Date";
            // 
            // dtpHiredDate
            // 
            this.dtpHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiredDate.Location = new System.Drawing.Point(96, 36);
            this.dtpHiredDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHiredDate.Name = "dtpHiredDate";
            this.dtpHiredDate.Size = new System.Drawing.Size(176, 20);
            this.dtpHiredDate.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(10, 70);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Accounting Manager",
            "CEO",
            "CFO",
            "Developer 1",
            "Developer 2",
            "Developer 3",
            "Developer 4",
            "Development Manager",
            "HR Manager",
            "HR Specialist",
            "Operator"});
            this.cmbPosition.Location = new System.Drawing.Point(96, 62);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(176, 21);
            this.cmbPosition.Sorted = true;
            this.cmbPosition.TabIndex = 6;
            this.cmbPosition.Text = "Developer 1";
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // lblSkillSet
            // 
            this.lblSkillSet.AutoSize = true;
            this.lblSkillSet.Location = new System.Drawing.Point(10, 98);
            this.lblSkillSet.Name = "lblSkillSet";
            this.lblSkillSet.Size = new System.Drawing.Size(45, 13);
            this.lblSkillSet.TabIndex = 7;
            this.lblSkillSet.Text = "Skill Set";
            // 
            // lsbSkillSet
            // 
            this.lsbSkillSet.FormattingEnabled = true;
            this.lsbSkillSet.Items.AddRange(new object[] {
            "ASP.NET",
            "C#",
            "C++",
            "HTML",
            "Java",
            "JavaScript",
            "JSON",
            "Python",
            "XML"});
            this.lsbSkillSet.Location = new System.Drawing.Point(96, 89);
            this.lsbSkillSet.Name = "lsbSkillSet";
            this.lsbSkillSet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbSkillSet.Size = new System.Drawing.Size(176, 82);
            this.lsbSkillSet.Sorted = true;
            this.lsbSkillSet.TabIndex = 8;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(10, 185);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 9;
            this.lblBranch.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "HQ",
            "NY",
            "HOU",
            "DAL",
            "LA"});
            this.cmbBranch.Location = new System.Drawing.Point(96, 177);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(176, 21);
            this.cmbBranch.TabIndex = 10;
            this.cmbBranch.Text = "HQ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EmploymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lsbSkillSet);
            this.Controls.Add(this.lblSkillSet);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.dtpHiredDate);
            this.Controls.Add(this.lblHiredDate);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Name = "EmploymentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employment Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblHiredDate;
        private System.Windows.Forms.DateTimePicker dtpHiredDate;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblSkillSet;
        private System.Windows.Forms.ListBox lsbSkillSet;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnSave;
    }
}