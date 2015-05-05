namespace EmployeesProfile
{
    partial class EmployeeList
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
            this.lsbEmployeesList = new System.Windows.Forms.ListBox();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbEmployeesList
            // 
            this.lsbEmployeesList.FormattingEnabled = true;
            this.lsbEmployeesList.Location = new System.Drawing.Point(12, 38);
            this.lsbEmployeesList.Name = "lsbEmployeesList";
            this.lsbEmployeesList.Size = new System.Drawing.Size(346, 329);
            this.lsbEmployeesList.TabIndex = 0;
            this.lsbEmployeesList.DoubleClick += new System.EventHandler(this.lsbEmployeesList_DoubleClick);
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(9, 9);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(77, 13);
            this.lblEmployeeList.TabIndex = 1;
            this.lblEmployeeList.Text = "Employees List";
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 385);
            this.Controls.Add(this.lblEmployeeList);
            this.Controls.Add(this.lsbEmployeesList);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbEmployeesList;
        private System.Windows.Forms.Label lblEmployeeList;
    }
}