namespace EmployeesProfile
{
    partial class PersonalInfo
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSSN1 = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSSN2 = new System.Windows.Forms.TextBox();
            this.txtSSN3 = new System.Windows.Forms.TextBox();
            this.tbcPersonalInfo = new System.Windows.Forms.TabControl();
            this.tbpBio = new System.Windows.Forms.TabPage();
            this.tbpInterests = new System.Windows.Forms.TabPage();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lsbMovies = new System.Windows.Forms.ListBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnClearMovies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.tbcPersonalInfo.SuspendLayout();
            this.tbpBio.SuspendLayout();
            this.tbpInterests.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 42);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(91, 35);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(91, 61);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(168, 20);
            this.txtMiddleName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(13, 68);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOB";
            // 
            // txtSSN1
            // 
            this.txtSSN1.Location = new System.Drawing.Point(91, 139);
            this.txtSSN1.MaxLength = 3;
            this.txtSSN1.Name = "txtSSN1";
            this.txtSSN1.PasswordChar = '*';
            this.txtSSN1.Size = new System.Drawing.Size(48, 20);
            this.txtSSN1.TabIndex = 11;
            this.txtSSN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSN1_KeyPress);
            this.txtSSN1.Leave += new System.EventHandler(this.txtSSN1_Leave);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(13, 146);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 8;
            this.lblSSN.Text = "SSN";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(91, 165);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(168, 20);
            this.txtPhoneNumber.TabIndex = 13;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 172);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(91, 114);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 16;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.Enter += new System.EventHandler(this.rdoMale_Enter);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(146, 114);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 17;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.Enter += new System.EventHandler(this.rdoFemale_Enter);
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(91, 88);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(33, 20);
            this.nudMonth.TabIndex = 18;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(130, 88);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(32, 20);
            this.nudDay.TabIndex = 19;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(168, 86);
            this.nudYear.Maximum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(91, 20);
            this.nudYear.TabIndex = 20;
            this.nudYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSSN2
            // 
            this.txtSSN2.Location = new System.Drawing.Point(146, 139);
            this.txtSSN2.MaxLength = 2;
            this.txtSSN2.Name = "txtSSN2";
            this.txtSSN2.PasswordChar = '*';
            this.txtSSN2.Size = new System.Drawing.Size(35, 20);
            this.txtSSN2.TabIndex = 22;
            this.txtSSN2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSSN2_KeyDown);
            this.txtSSN2.Leave += new System.EventHandler(this.txtSSN2_Leave);
            // 
            // txtSSN3
            // 
            this.txtSSN3.Location = new System.Drawing.Point(187, 139);
            this.txtSSN3.MaxLength = 4;
            this.txtSSN3.Name = "txtSSN3";
            this.txtSSN3.PasswordChar = '*';
            this.txtSSN3.Size = new System.Drawing.Size(72, 20);
            this.txtSSN3.TabIndex = 23;
            this.txtSSN3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSSN3_KeyDown);
            this.txtSSN3.Leave += new System.EventHandler(this.txtSSN3_Leave);
            // 
            // tbcPersonalInfo
            // 
            this.tbcPersonalInfo.Controls.Add(this.tbpBio);
            this.tbcPersonalInfo.Controls.Add(this.tbpInterests);
            this.tbcPersonalInfo.Location = new System.Drawing.Point(12, 12);
            this.tbcPersonalInfo.Name = "tbcPersonalInfo";
            this.tbcPersonalInfo.SelectedIndex = 0;
            this.tbcPersonalInfo.Size = new System.Drawing.Size(279, 261);
            this.tbcPersonalInfo.TabIndex = 24;
            // 
            // tbpBio
            // 
            this.tbpBio.Controls.Add(this.txtMiddleName);
            this.tbpBio.Controls.Add(this.txtSSN3);
            this.tbpBio.Controls.Add(this.lblFirstName);
            this.tbpBio.Controls.Add(this.txtSSN2);
            this.tbpBio.Controls.Add(this.txtFirstName);
            this.tbpBio.Controls.Add(this.lblLastName);
            this.tbpBio.Controls.Add(this.nudYear);
            this.tbpBio.Controls.Add(this.txtLastName);
            this.tbpBio.Controls.Add(this.nudDay);
            this.tbpBio.Controls.Add(this.lblMiddleName);
            this.tbpBio.Controls.Add(this.nudMonth);
            this.tbpBio.Controls.Add(this.label1);
            this.tbpBio.Controls.Add(this.rdoFemale);
            this.tbpBio.Controls.Add(this.lblSSN);
            this.tbpBio.Controls.Add(this.rdoMale);
            this.tbpBio.Controls.Add(this.txtSSN1);
            this.tbpBio.Controls.Add(this.lblGender);
            this.tbpBio.Controls.Add(this.lblPhoneNumber);
            this.tbpBio.Controls.Add(this.txtEmail);
            this.tbpBio.Controls.Add(this.txtPhoneNumber);
            this.tbpBio.Controls.Add(this.lblEmail);
            this.tbpBio.Location = new System.Drawing.Point(4, 22);
            this.tbpBio.Name = "tbpBio";
            this.tbpBio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBio.Size = new System.Drawing.Size(271, 235);
            this.tbpBio.TabIndex = 0;
            this.tbpBio.Text = "Biographic";
            this.tbpBio.UseVisualStyleBackColor = true;
            // 
            // tbpInterests
            // 
            this.tbpInterests.Controls.Add(this.btnClearMovies);
            this.tbpInterests.Controls.Add(this.btnAddMovie);
            this.tbpInterests.Controls.Add(this.txtMovieName);
            this.tbpInterests.Controls.Add(this.lsbMovies);
            this.tbpInterests.Controls.Add(this.lblMovies);
            this.tbpInterests.Location = new System.Drawing.Point(4, 22);
            this.tbpInterests.Name = "tbpInterests";
            this.tbpInterests.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInterests.Size = new System.Drawing.Size(271, 235);
            this.tbpInterests.TabIndex = 1;
            this.tbpInterests.Text = "Interest";
            this.tbpInterests.UseVisualStyleBackColor = true;
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(7, 7);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(41, 13);
            this.lblMovies.TabIndex = 0;
            this.lblMovies.Text = "Movies";
            // 
            // lsbMovies
            // 
            this.lsbMovies.FormattingEnabled = true;
            this.lsbMovies.Location = new System.Drawing.Point(10, 24);
            this.lsbMovies.Name = "lsbMovies";
            this.lsbMovies.Size = new System.Drawing.Size(132, 199);
            this.lsbMovies.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(149, 24);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(110, 20);
            this.txtMovieName.TabIndex = 2;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(159, 50);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(90, 23);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnClearMovies
            // 
            this.btnClearMovies.Location = new System.Drawing.Point(159, 79);
            this.btnClearMovies.Name = "btnClearMovies";
            this.btnClearMovies.Size = new System.Drawing.Size(90, 23);
            this.btnClearMovies.TabIndex = 4;
            this.btnClearMovies.Text = "Clear Movies";
            this.btnClearMovies.UseVisualStyleBackColor = true;
            this.btnClearMovies.Click += new System.EventHandler(this.btnClearMovies_Click);
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 324);
            this.Controls.Add(this.tbcPersonalInfo);
            this.Controls.Add(this.btnSave);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "PersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Info";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.tbcPersonalInfo.ResumeLayout(false);
            this.tbpBio.ResumeLayout(false);
            this.tbpBio.PerformLayout();
            this.tbpInterests.ResumeLayout(false);
            this.tbpInterests.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSSN1;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSSN2;
        private System.Windows.Forms.TextBox txtSSN3;
        private System.Windows.Forms.TabControl tbcPersonalInfo;
        private System.Windows.Forms.TabPage tbpBio;
        private System.Windows.Forms.TabPage tbpInterests;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.ListBox lsbMovies;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Button btnClearMovies;
    }
}

