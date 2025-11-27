namespace QuanLyKhachSan
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.panelEmployeeButtons = new System.Windows.Forms.Panel();
            this.btnRefreshEmployees = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.txtPasswordEmp = new System.Windows.Forms.TextBox();
            this.lblPasswordEmp = new System.Windows.Forms.Label();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.lblEmailEmp = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.panelEmployeeButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.grpEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmployeeButtons
            // 
            this.panelEmployeeButtons.Controls.Add(this.btnRefreshEmployees);
            this.panelEmployeeButtons.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnSaveEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnEditEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeeButtons.Location = new System.Drawing.Point(0, 545);
            this.panelEmployeeButtons.Name = "panelEmployeeButtons";
            this.panelEmployeeButtons.Size = new System.Drawing.Size(970, 47);
            this.panelEmployeeButtons.TabIndex = 2;
            // 
            // btnRefreshEmployees
            // 
            this.btnRefreshEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshEmployees.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmployees.Location = new System.Drawing.Point(400, 10);
            this.btnRefreshEmployees.Name = "btnRefreshEmployees";
            this.btnRefreshEmployees.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshEmployees.TabIndex = 4;
            this.btnRefreshEmployees.Text = "Làm mới";
            this.btnRefreshEmployees.UseVisualStyleBackColor = false;
            this.btnRefreshEmployees.Click += new System.EventHandler(this.btnRefreshEmployees_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(300, 10);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSaveEmployee.Location = new System.Drawing.Point(200, 10);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(80, 30);
            this.btnSaveEmployee.TabIndex = 2;
            this.btnSaveEmployee.Text = "Lưu";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployee.Location = new System.Drawing.Point(100, 10);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(80, 30);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Sửa";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 10);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(80, 30);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 148);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(970, 397);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // grpEmployeeInfo
            // 
            this.grpEmployeeInfo.Controls.Add(this.txtPasswordEmp);
            this.grpEmployeeInfo.Controls.Add(this.lblPasswordEmp);
            this.grpEmployeeInfo.Controls.Add(this.txtEmailEmp);
            this.grpEmployeeInfo.Controls.Add(this.lblEmailEmp);
            this.grpEmployeeInfo.Controls.Add(this.cmbPosition);
            this.grpEmployeeInfo.Controls.Add(this.dtpBirthDate);
            this.grpEmployeeInfo.Controls.Add(this.rdbFemale);
            this.grpEmployeeInfo.Controls.Add(this.rdbMale);
            this.grpEmployeeInfo.Controls.Add(this.txtLastName);
            this.grpEmployeeInfo.Controls.Add(this.txtFirstName);
            this.grpEmployeeInfo.Controls.Add(this.txtEmployeeCode);
            this.grpEmployeeInfo.Controls.Add(this.lblPosition);
            this.grpEmployeeInfo.Controls.Add(this.lblBirthDate);
            this.grpEmployeeInfo.Controls.Add(this.lblGender);
            this.grpEmployeeInfo.Controls.Add(this.lblLastName);
            this.grpEmployeeInfo.Controls.Add(this.lblFirstName);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeCode);
            this.grpEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(970, 148);
            this.grpEmployeeInfo.TabIndex = 0;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "Thông tin nhân viên";
            // 
            // txtPasswordEmp
            // 
            this.txtPasswordEmp.Location = new System.Drawing.Point(680, 95);
            this.txtPasswordEmp.Name = "txtPasswordEmp";
            this.txtPasswordEmp.PasswordChar = '*';
            this.txtPasswordEmp.Size = new System.Drawing.Size(200, 20);
            this.txtPasswordEmp.TabIndex = 16;
            // 
            // lblPasswordEmp
            // 
            this.lblPasswordEmp.AutoSize = true;
            this.lblPasswordEmp.Location = new System.Drawing.Point(580, 98);
            this.lblPasswordEmp.Name = "lblPasswordEmp";
            this.lblPasswordEmp.Size = new System.Drawing.Size(55, 13);
            this.lblPasswordEmp.TabIndex = 15;
            this.lblPasswordEmp.Text = "Password:";
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Location = new System.Drawing.Point(680, 60);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(200, 20);
            this.txtEmailEmp.TabIndex = 14;
            // 
            // lblEmailEmp
            // 
            this.lblEmailEmp.AutoSize = true;
            this.lblEmailEmp.Location = new System.Drawing.Point(580, 63);
            this.lblEmailEmp.Name = "lblEmailEmp";
            this.lblEmailEmp.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEmp.TabIndex = 13;
            this.lblEmailEmp.Text = "Email:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "truong phong",
            "nhan vien"});
            this.cmbPosition.Location = new System.Drawing.Point(680, 25);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(150, 21);
            this.cmbPosition.TabIndex = 12;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(350, 95);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(120, 20);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(420, 60);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(39, 17);
            this.rdbFemale.TabIndex = 10;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(350, 60);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(47, 17);
            this.rdbMale.TabIndex = 9;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(350, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 60);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(100, 25);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(80, 20);
            this.txtEmployeeCode.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(580, 28);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(50, 13);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(280, 98);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Ngày sinh:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(280, 63);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(280, 28);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(42, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Họ lót:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 63);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Tên:";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(20, 28);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(45, 13);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Mã số:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelEmployeeButtons);
            this.Controls.Add(this.grpEmployeeInfo);
            this.Name = "EmployeeForm";
            this.Size = new System.Drawing.Size(970, 592);
            this.panelEmployeeButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelEmployeeButtons;
        private System.Windows.Forms.Button btnRefreshEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.TextBox txtPasswordEmp;
        private System.Windows.Forms.Label lblPasswordEmp;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label lblEmailEmp;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeCode;
    }
}