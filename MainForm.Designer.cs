namespace QuanLyKhachSan
{
    partial class MainForm
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabRoomTypes = new System.Windows.Forms.TabPage();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.btnLogoutMain = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblCurrentEmployee = new System.Windows.Forms.Label();
            this.employeeForm = new QuanLyKhachSan.EmployeeForm();
            this.customerForm = new QuanLyKhachSan.CustomerForm();
            this.roomTypeForm = new QuanLyKhachSan.RoomTypeForm();
            this.roomForm = new QuanLyKhachSan.RoomForm();
            this.bookingForm = new QuanLyKhachSan.BookingForm();
            this.paymentForm = new QuanLyKhachSan.PaymentForm();
            
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabRoomTypes.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabRoomTypes);
            this.tabControl1.Controls.Add(this.tabRooms);
            this.tabControl1.Controls.Add(this.tabBookings);
            this.tabControl1.Controls.Add(this.tabPayment);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 621);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

            // tabLogin
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(976, 595);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Đăng nhập";
            this.tabLogin.UseVisualStyleBackColor = true;

            // tabEmployees
            this.tabEmployees.Controls.Add(this.employeeForm);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(976, 595);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Nhân viên";
            this.tabEmployees.UseVisualStyleBackColor = true;

            // tabCustomers
            this.tabCustomers.Controls.Add(this.customerForm);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(976, 595);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Khách hàng";
            this.tabCustomers.UseVisualStyleBackColor = true;

            // tabRoomTypes
            this.tabRoomTypes.Controls.Add(this.roomTypeForm);
            this.tabRoomTypes.Location = new System.Drawing.Point(4, 22);
            this.tabRoomTypes.Name = "tabRoomTypes";
            this.tabRoomTypes.Size = new System.Drawing.Size(976, 595);
            this.tabRoomTypes.TabIndex = 2;
            this.tabRoomTypes.Text = "Loại phòng";
            this.tabRoomTypes.UseVisualStyleBackColor = true;

            // tabRooms
            this.tabRooms.Controls.Add(this.roomForm);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Size = new System.Drawing.Size(976, 595);
            this.tabRooms.TabIndex = 3;
            this.tabRooms.Text = "Quản lý phòng";
            this.tabRooms.UseVisualStyleBackColor = true;

            // tabBookings
            this.tabBookings.Controls.Add(this.bookingForm);
            this.tabBookings.Location = new System.Drawing.Point(4, 22);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Size = new System.Drawing.Size(976, 595);
            this.tabBookings.TabIndex = 4;
            this.tabBookings.Text = "Đặt phòng";
            this.tabBookings.UseVisualStyleBackColor = true;

            // tabPayment
            this.tabPayment.Controls.Add(this.paymentForm);
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Size = new System.Drawing.Size(976, 595);
            this.tabPayment.TabIndex = 5;
            this.tabPayment.Text = "Thanh toán";
            this.tabPayment.UseVisualStyleBackColor = true;

            // employeeForm
            this.employeeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeForm.Location = new System.Drawing.Point(3, 3);
            this.employeeForm.Name = "employeeForm";
            this.employeeForm.Size = new System.Drawing.Size(970, 589);
            this.employeeForm.TabIndex = 0;

            // customerForm
            this.customerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerForm.Location = new System.Drawing.Point(3, 3);
            this.customerForm.Name = "customerForm";
            this.customerForm.Size = new System.Drawing.Size(970, 589);
            this.customerForm.TabIndex = 0;

            // roomTypeForm
            this.roomTypeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomTypeForm.Location = new System.Drawing.Point(0, 0);
            this.roomTypeForm.Name = "roomTypeForm";
            this.roomTypeForm.Size = new System.Drawing.Size(976, 595);
            this.roomTypeForm.TabIndex = 0;

            // roomForm
            this.roomForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomForm.Location = new System.Drawing.Point(0, 0);
            this.roomForm.Name = "roomForm";
            this.roomForm.Size = new System.Drawing.Size(976, 595);
            this.roomForm.TabIndex = 0;

            // bookingForm
            this.bookingForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingForm.Location = new System.Drawing.Point(0, 0);
            this.bookingForm.Name = "bookingForm";
            this.bookingForm.Size = new System.Drawing.Size(976, 595);
            this.bookingForm.TabIndex = 0;

            // paymentForm
            this.paymentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentForm.Location = new System.Drawing.Point(0, 0);
            this.paymentForm.Name = "paymentForm";
            this.paymentForm.Size = new System.Drawing.Size(976, 595);
            this.paymentForm.TabIndex = 0;

            // panelUserInfo
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelUserInfo.Controls.Add(this.lblCurrentEmployee);
            this.panelUserInfo.Controls.Add(this.btnLogoutMain);
            this.panelUserInfo.Controls.Add(this.lblUserInfo);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 621);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(984, 40);
            this.panelUserInfo.TabIndex = 1;
            this.panelUserInfo.Visible = false;

            // btnLogoutMain
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
            this.btnLogoutMain.Click += new System.EventHandler(this.btnLogoutMain_Click);

            // lblUserInfo
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(12, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 16);
            this.lblUserInfo.TabIndex = 0;

            // lblCurrentEmployee
            this.lblCurrentEmployee.AutoSize = true;
            this.lblCurrentEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEmployee.ForeColor = System.Drawing.Color.White;
            this.lblCurrentEmployee.Location = new System.Drawing.Point(700, 14);
            this.lblCurrentEmployee.Name = "lblCurrentEmployee";
            this.lblCurrentEmployee.Size = new System.Drawing.Size(0, 15);
            this.lblCurrentEmployee.TabIndex = 2;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelUserInfo);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabRoomTypes.ResumeLayout(false);
            this.tabRooms.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.tabPayment.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabRoomTypes;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Button btnLogoutMain;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.TabPage tabLogin;
        private EmployeeForm employeeForm;
        private CustomerForm customerForm;
        private RoomTypeForm roomTypeForm;
        private RoomForm roomForm;
        private BookingForm bookingForm;
        private PaymentForm paymentForm;
        private System.Windows.Forms.Label lblCurrentEmployee;
    }
}

