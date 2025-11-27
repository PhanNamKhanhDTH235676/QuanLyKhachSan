namespace QuanLyKhachSan
{
    partial class BookingForm
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
            this.panelBookingButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.grpBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBookingButtons
            // 
            this.panelBookingButtons.Controls.Add(this.btnRefreshBookings);
            this.panelBookingButtons.Controls.Add(this.btnDeleteBooking);
            this.panelBookingButtons.Controls.Add(this.btnSaveBooking);
            this.panelBookingButtons.Controls.Add(this.btnEditBooking);
            this.panelBookingButtons.Controls.Add(this.btnAddBooking);
            this.panelBookingButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookingButtons.Location = new System.Drawing.Point(0, 545);
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
            this.btnRefreshBookings.Click += new System.EventHandler(this.btnRefreshBookings_Click);
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
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
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
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
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
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
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
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(0, 148);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.Size = new System.Drawing.Size(970, 397);
            this.dgvBookings.TabIndex = 1;
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);
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
            this.grpBookingInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBookingInfo.Name = "grpBookingInfo";
            this.grpBookingInfo.Size = new System.Drawing.Size(970, 148);
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
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.panelBookingButtons);
            this.Controls.Add(this.grpBookingInfo);
            this.Name = "BookingForm";
            this.Size = new System.Drawing.Size(970, 592);
            this.panelBookingButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.grpBookingInfo.ResumeLayout(false);
            this.grpBookingInfo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelBookingButtons;
        private System.Windows.Forms.Button btnRefreshBookings;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.GroupBox grpBookingInfo;
        private System.Windows.Forms.Label lblCurrentEmployee;
        private System.Windows.Forms.Label lblEmployeeLabel;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtBookingCode;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblBookingCode;
    }
}