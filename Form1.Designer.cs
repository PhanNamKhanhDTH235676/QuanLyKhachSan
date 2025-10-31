namespace QuanLyKhachSan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLoginHint = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.tabEmployees = new System.Windows.Forms.TabPage();
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
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.panelCustomerButtons = new System.Windows.Forms.Panel();
            this.btnRefreshCustomers = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.panelRoomButtons = new System.Windows.Forms.Panel();
            this.btnRefreshRooms = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.panelBookingButtons = new System.Windows.Forms.Panel();
            this.btnRefreshBookings = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.grpBookingInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrentEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeLabel = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtBookingCode = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblBookingCode = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.btnLogoutMain = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.panelEmployeeButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.grpEmployeeInfo.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.panelCustomerButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.panelRoomButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.grpRoomInfo.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.panelBookingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.grpBookingInfo.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabRooms);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabLogin.Controls.Add(this.panelLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(976, 595);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Đăng nhập";
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lblLoginHint);
            this.panelLogin.Controls.Add(this.btnLogout);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.lblLoginTitle);
            this.panelLogin.Location = new System.Drawing.Point(250, 100);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(450, 350);
            this.panelLogin.TabIndex = 0;
            // 
            // lblLoginHint
            // 
            this.lblLoginHint.AutoSize = true;
            this.lblLoginHint.ForeColor = System.Drawing.Color.Gray;
            this.lblLoginHint.Location = new System.Drawing.Point(75, 250);
            this.lblLoginHint.Name = "lblLoginHint";
            this.lblLoginHint.Size = new System.Drawing.Size(300, 13);
            this.lblLoginHint.TabIndex = 7;
            this.lblLoginHint.Text = "Tài khoản mặc định: admin@khachsan.com / admin123";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(240, 190);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(90, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(150, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(150, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(50, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(448, 50);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.panelEmployeeButtons);
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Controls.Add(this.grpEmployeeInfo);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(976, 595);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Nhân viên";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // panelEmployeeButtons
            // 
            this.panelEmployeeButtons.Controls.Add(this.btnRefreshEmployees);
            this.panelEmployeeButtons.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnSaveEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnEditEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeeButtons.Location = new System.Drawing.Point(3, 545);
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
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 148);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(970, 444);
            this.dgvEmployees.TabIndex = 1;
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
            this.grpEmployeeInfo.Location = new System.Drawing.Point(3, 3);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(970, 145);
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
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.panelCustomerButtons);
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Controls.Add(this.grpCustomerInfo);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(976, 595);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Khách hàng";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // panelCustomerButtons
            // 
            this.panelCustomerButtons.Controls.Add(this.btnRefreshCustomers);
            this.panelCustomerButtons.Controls.Add(this.btnDeleteCustomer);
            this.panelCustomerButtons.Controls.Add(this.btnSaveCustomer);
            this.panelCustomerButtons.Controls.Add(this.btnEditCustomer);
            this.panelCustomerButtons.Controls.Add(this.btnAddCustomer);
            this.panelCustomerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCustomerButtons.Location = new System.Drawing.Point(3, 545);
            this.panelCustomerButtons.Name = "panelCustomerButtons";
            this.panelCustomerButtons.Size = new System.Drawing.Size(970, 47);
            this.panelCustomerButtons.TabIndex = 2;
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCustomers.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCustomers.Location = new System.Drawing.Point(400, 10);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshCustomers.TabIndex = 4;
            this.btnRefreshCustomers.Text = "Làm mới";
            this.btnRefreshCustomers.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(300, 10);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSaveCustomer.Location = new System.Drawing.Point(200, 10);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(80, 30);
            this.btnSaveCustomer.TabIndex = 2;
            this.btnSaveCustomer.Text = "Lưu";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(100, 10);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(80, 30);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Sửa";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(0, 10);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(80, 30);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 98);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(970, 494);
            this.dgvCustomers.TabIndex = 1;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.txtCMND);
            this.grpCustomerInfo.Controls.Add(this.txtPhone);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerCode);
            this.grpCustomerInfo.Controls.Add(this.lblCMND);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerCode);
            this.grpCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCustomerInfo.Location = new System.Drawing.Point(3, 3);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(970, 95);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(680, 55);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(120, 20);
            this.txtCMND.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(680, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(350, 25);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(100, 25);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(80, 20);
            this.txtCustomerCode.TabIndex = 4;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(580, 58);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(42, 13);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "CMND:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(580, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(32, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "SĐT:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(280, 28);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(42, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Họ tên:";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(20, 28);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(45, 13);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Mã KH:";
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.panelRoomButtons);
            this.tabRooms.Controls.Add(this.dgvRooms);
            this.tabRooms.Controls.Add(this.grpRoomInfo);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(976, 595);
            this.tabRooms.TabIndex = 3;
            this.tabRooms.Text = "Quản lý phòng";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // panelRoomButtons
            // 
            this.panelRoomButtons.Controls.Add(this.btnRefreshRooms);
            this.panelRoomButtons.Controls.Add(this.btnDeleteRoom);
            this.panelRoomButtons.Controls.Add(this.btnSaveRoom);
            this.panelRoomButtons.Controls.Add(this.btnEditRoom);
            this.panelRoomButtons.Controls.Add(this.btnAddRoom);
            this.panelRoomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRoomButtons.Location = new System.Drawing.Point(3, 545);
            this.panelRoomButtons.Name = "panelRoomButtons";
            this.panelRoomButtons.Size = new System.Drawing.Size(970, 47);
            this.panelRoomButtons.TabIndex = 2;
            // 
            // btnRefreshRooms
            // 
            this.btnRefreshRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRooms.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRooms.Location = new System.Drawing.Point(400, 10);
            this.btnRefreshRooms.Name = "btnRefreshRooms";
            this.btnRefreshRooms.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshRooms.TabIndex = 4;
            this.btnRefreshRooms.Text = "Làm mới";
            this.btnRefreshRooms.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(300, 10);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteRoom.TabIndex = 3;
            this.btnDeleteRoom.Text = "Xóa";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoom.ForeColor = System.Drawing.Color.White;
            this.btnSaveRoom.Location = new System.Drawing.Point(200, 10);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(80, 30);
            this.btnSaveRoom.TabIndex = 2;
            this.btnSaveRoom.Text = "Lưu";
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoom.ForeColor = System.Drawing.Color.White;
            this.btnEditRoom.Location = new System.Drawing.Point(100, 10);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(80, 30);
            this.btnEditRoom.TabIndex = 1;
            this.btnEditRoom.Text = "Sửa";
            this.btnEditRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(0, 10);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(80, 30);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(3, 98);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(970, 494);
            this.dgvRooms.TabIndex = 1;
            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Controls.Add(this.txtNote);
            this.grpRoomInfo.Controls.Add(this.cmbStatus);
            this.grpRoomInfo.Controls.Add(this.cmbRoomType);
            this.grpRoomInfo.Controls.Add(this.txtRoomCode);
            this.grpRoomInfo.Controls.Add(this.lblNote);
            this.grpRoomInfo.Controls.Add(this.lblStatus);
            this.grpRoomInfo.Controls.Add(this.lblRoomType);
            this.grpRoomInfo.Controls.Add(this.lblRoomCode);
            this.grpRoomInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRoomInfo.Location = new System.Drawing.Point(3, 3);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(970, 95);
            this.grpRoomInfo.TabIndex = 0;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Thông tin phòng";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(350, 55);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(400, 20);
            this.txtNote.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "trong",
            "dang thue",
            "bao tri",
            "dang don dep"});
            this.cmbStatus.Location = new System.Drawing.Point(680, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(120, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(350, 25);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(200, 21);
            this.cmbRoomType.TabIndex = 5;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Location = new System.Drawing.Point(100, 25);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(80, 20);
            this.txtRoomCode.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(280, 58);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(47, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(580, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(280, 28);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(64, 13);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Loại phòng:";
            // 
            // lblRoomCode
            // 
            this.lblRoomCode.AutoSize = true;
            this.lblRoomCode.Location = new System.Drawing.Point(20, 28);
            this.lblRoomCode.Name = "lblRoomCode";
            this.lblRoomCode.Size = new System.Drawing.Size(55, 13);
            this.lblRoomCode.TabIndex = 0;
            this.lblRoomCode.Text = "Mã phòng:";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.panelBookingButtons);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.grpBookingInfo);
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(976, 595);
            this.tabBookings.TabIndex = 4;
            this.tabBookings.Text = "Đặt phòng";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // panelBookingButtons
            // 
            this.panelBookingButtons.Controls.Add(this.btnRefreshBookings);
            this.panelBookingButtons.Controls.Add(this.btnDeleteBooking);
            this.panelBookingButtons.Controls.Add(this.btnSaveBooking);
            this.panelBookingButtons.Controls.Add(this.btnEditBooking);
            this.panelBookingButtons.Controls.Add(this.btnAddBooking);
            this.panelBookingButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookingButtons.Location = new System.Drawing.Point(3, 545);
            this.panelBookingButtons.Name = "panelBookingButtons";
            this.panelBookingButtons.Size = new System.Drawing.Size(970, 47);
            this.panelBookingButtons.TabIndex = 2;
            // 
            // btnRefreshBookings
            // 
            this.btnRefreshBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBookings.ForeColor = System.Drawing.Color.White;
            this.btnRefreshBookings.Location = new System.Drawing.Point(400, 10);
            this.btnRefreshBookings.Name = "btnRefreshBookings";
            this.btnRefreshBookings.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshBookings.TabIndex = 4;
            this.btnRefreshBookings.Text = "Làm mới";
            this.btnRefreshBookings.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Location = new System.Drawing.Point(300, 10);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteBooking.TabIndex = 3;
            this.btnDeleteBooking.Text = "Xóa";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSaveBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBooking.ForeColor = System.Drawing.Color.White;
            this.btnSaveBooking.Location = new System.Drawing.Point(200, 10);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(80, 30);
            this.btnSaveBooking.TabIndex = 2;
            this.btnSaveBooking.Text = "Lưu";
            this.btnSaveBooking.UseVisualStyleBackColor = false;
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBooking.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.Location = new System.Drawing.Point(100, 10);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(80, 30);
            this.btnEditBooking.TabIndex = 1;
            this.btnEditBooking.Text = "Sửa";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Location = new System.Drawing.Point(0, 10);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(80, 30);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Thêm";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(3, 148);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.Size = new System.Drawing.Size(970, 444);
            this.dgvBookings.TabIndex = 1;
            // 
            // grpBookingInfo
            // 
            this.grpBookingInfo.Controls.Add(this.lblCurrentEmployee);
            this.grpBookingInfo.Controls.Add(this.lblEmployeeLabel);
            this.grpBookingInfo.Controls.Add(this.dtpCheckOut);
            this.grpBookingInfo.Controls.Add(this.dtpCheckIn);
            this.grpBookingInfo.Controls.Add(this.cmbRoom);
            this.grpBookingInfo.Controls.Add(this.cmbCustomer);
            this.grpBookingInfo.Controls.Add(this.txtBookingCode);
            this.grpBookingInfo.Controls.Add(this.lblCheckOut);
            this.grpBookingInfo.Controls.Add(this.lblCheckIn);
            this.grpBookingInfo.Controls.Add(this.lblRoom);
            this.grpBookingInfo.Controls.Add(this.lblCustomer);
            this.grpBookingInfo.Controls.Add(this.lblBookingCode);
            this.grpBookingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBookingInfo.Location = new System.Drawing.Point(3, 3);
            this.grpBookingInfo.Name = "grpBookingInfo";
            this.grpBookingInfo.Size = new System.Drawing.Size(970, 145);
            this.grpBookingInfo.TabIndex = 0;
            this.grpBookingInfo.TabStop = false;
            this.grpBookingInfo.Text = "Thông tin đặt phòng";
            // 
            // lblCurrentEmployee
            // 
            this.lblCurrentEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentEmployee.Location = new System.Drawing.Point(680, 90);
            this.lblCurrentEmployee.Name = "lblCurrentEmployee";
            this.lblCurrentEmployee.Size = new System.Drawing.Size(120, 20);
            this.lblCurrentEmployee.TabIndex = 11;
            this.lblCurrentEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeLabel
            // 
            this.lblEmployeeLabel.AutoSize = true;
            this.lblEmployeeLabel.Location = new System.Drawing.Point(580, 93);
            this.lblEmployeeLabel.Name = "lblEmployeeLabel";
            this.lblEmployeeLabel.Size = new System.Drawing.Size(78, 13);
            this.lblEmployeeLabel.TabIndex = 10;
            this.lblEmployeeLabel.Text = "Nhân viên tạo:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(350, 90);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckOut.TabIndex = 9;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(100, 90);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(120, 20);
            this.dtpCheckIn.TabIndex = 8;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(680, 55);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 21);
            this.cmbRoom.TabIndex = 7;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(350, 55);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cmbCustomer.TabIndex = 6;
            // 
            // txtBookingCode
            // 
            this.txtBookingCode.Location = new System.Drawing.Point(100, 55);
            this.txtBookingCode.Name = "txtBookingCode";
            this.txtBookingCode.Size = new System.Drawing.Size(80, 20);
            this.txtBookingCode.TabIndex = 5;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(280, 93);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(52, 13);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Ngày trả:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(20, 93);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(51, 13);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "Ngày đặt:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(580, 58);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(41, 13);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Phòng:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(280, 58);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 13);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Khách hàng:";
            // 
            // lblBookingCode
            // 
            this.lblBookingCode.AutoSize = true;
            this.lblBookingCode.Location = new System.Drawing.Point(20, 58);
            this.lblBookingCode.Name = "lblBookingCode";
            this.lblBookingCode.Size = new System.Drawing.Size(48, 13);
            this.lblBookingCode.TabIndex = 0;
            this.lblBookingCode.Text = "Mã đặt:";
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelUserInfo.Controls.Add(this.btnLogoutMain);
            this.panelUserInfo.Controls.Add(this.lblUserInfo);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(984, 40);
            this.panelUserInfo.TabIndex = 1;
            // 
            // btnLogoutMain
            // 
            this.btnLogoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogoutMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutMain.ForeColor = System.Drawing.Color.White;
            this.btnLogoutMain.Location = new System.Drawing.Point(870, 5);
            this.btnLogoutMain.Name = "btnLogoutMain";
            this.btnLogoutMain.Size = new System.Drawing.Size(100, 30);
            this.btnLogoutMain.TabIndex = 1;
            this.btnLogoutMain.Text = "Đăng xuất";
            this.btnLogoutMain.UseVisualStyleBackColor = false;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(12, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 16);
            this.lblUserInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelUserInfo);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.panelEmployeeButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.panelCustomerButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.tabRooms.ResumeLayout(false);
            this.panelRoomButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.panelBookingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.grpBookingInfo.ResumeLayout(false);
            this.grpBookingInfo.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLoginHint;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panelEmployeeButtons;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnRefreshEmployees;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label lblEmailEmp;
        private System.Windows.Forms.TextBox txtPasswordEmp;
        private System.Windows.Forms.Label lblPasswordEmp;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel panelCustomerButtons;
        private System.Windows.Forms.Button btnRefreshCustomers;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Panel panelRoomButtons;
        private System.Windows.Forms.Button btnRefreshRooms;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grpBookingInfo;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Panel panelBookingButtons;
        private System.Windows.Forms.Button btnRefreshBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label lblBookingCode;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtBookingCode;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCurrentEmployee;
        private System.Windows.Forms.Label lblEmployeeLabel;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnLogoutMain;
    }
}