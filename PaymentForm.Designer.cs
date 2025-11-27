namespace QuanLyKhachSan
{
    partial class PaymentForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnRefreshPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbBookingCode = new System.Windows.Forms.ComboBox();
            this.txtPaymentCode = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBookingCode = new System.Windows.Forms.Label();
            this.lblPaymentCode = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.grpPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnRefreshPayment);
            this.panelButtons.Controls.Add(this.btnDeletePayment);
            this.panelButtons.Controls.Add(this.btnAddPayment);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 545);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(970, 47);
            this.panelButtons.TabIndex = 2;
            // 
            // btnRefreshPayment
            // 
            this.btnRefreshPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPayment.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPayment.Location = new System.Drawing.Point(200, 10);
            this.btnRefreshPayment.Name = "btnRefreshPayment";
            this.btnRefreshPayment.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshPayment.TabIndex = 2;
            this.btnRefreshPayment.Text = "Làm mới";
            this.btnRefreshPayment.UseVisualStyleBackColor = false;
            this.btnRefreshPayment.Click += new System.EventHandler(this.btnRefreshPayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePayment.ForeColor = System.Drawing.Color.White;
            this.btnDeletePayment.Location = new System.Drawing.Point(100, 10);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(80, 30);
            this.btnDeletePayment.TabIndex = 1;
            this.btnDeletePayment.Text = "Xóa";
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.Location = new System.Drawing.Point(0, 10);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(80, 30);
            this.btnAddPayment.TabIndex = 0;
            this.btnAddPayment.Text = "Thêm";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayment.Location = new System.Drawing.Point(0, 188);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.Size = new System.Drawing.Size(970, 357);
            this.dgvPayment.TabIndex = 1;
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentInfo.Controls.Add(this.txtNote);
            this.grpPaymentInfo.Controls.Add(this.txtTotalAmount);
            this.grpPaymentInfo.Controls.Add(this.txtCheckOutDate);
            this.grpPaymentInfo.Controls.Add(this.txtCheckInDate);
            this.grpPaymentInfo.Controls.Add(this.txtRoomCode);
            this.grpPaymentInfo.Controls.Add(this.txtCustomerName);
            this.grpPaymentInfo.Controls.Add(this.cmbBookingCode);
            this.grpPaymentInfo.Controls.Add(this.txtPaymentCode);
            this.grpPaymentInfo.Controls.Add(this.lblNote);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentDate);
            this.grpPaymentInfo.Controls.Add(this.lblTotalAmount);
            this.grpPaymentInfo.Controls.Add(this.lblCheckOutDate);
            this.grpPaymentInfo.Controls.Add(this.lblCheckInDate);
            this.grpPaymentInfo.Controls.Add(this.lblRoomCode);
            this.grpPaymentInfo.Controls.Add(this.lblCustomerName);
            this.grpPaymentInfo.Controls.Add(this.lblBookingCode);
            this.grpPaymentInfo.Controls.Add(this.lblPaymentCode);
            this.grpPaymentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPaymentInfo.Location = new System.Drawing.Point(0, 0);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(970, 188);
            this.grpPaymentInfo.TabIndex = 0;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Thông tin thanh toán";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(700, 90);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(150, 20);
            this.dtpPaymentDate.TabIndex = 17;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(100, 125);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(750, 50);
            this.txtNote.TabIndex = 16;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(380, 90);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(150, 20);
            this.txtTotalAmount.TabIndex = 15;
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Location = new System.Drawing.Point(700, 55);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.ReadOnly = true;
            this.txtCheckOutDate.Size = new System.Drawing.Size(150, 20);
            this.txtCheckOutDate.TabIndex = 14;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Location = new System.Drawing.Point(380, 55);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.Size = new System.Drawing.Size(150, 20);
            this.txtCheckInDate.TabIndex = 13;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Location = new System.Drawing.Point(100, 90);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.ReadOnly = true;
            this.txtRoomCode.Size = new System.Drawing.Size(120, 20);
            this.txtRoomCode.TabIndex = 12;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(700, 25);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(250, 20);
            this.txtCustomerName.TabIndex = 11;
            // 
            // cmbBookingCode
            // 
            this.cmbBookingCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingCode.FormattingEnabled = true;
            this.cmbBookingCode.Location = new System.Drawing.Point(380, 25);
            this.cmbBookingCode.Name = "cmbBookingCode";
            this.cmbBookingCode.Size = new System.Drawing.Size(150, 21);
            this.cmbBookingCode.TabIndex = 10;
            this.cmbBookingCode.SelectedIndexChanged += new System.EventHandler(this.cmbBookingCode_SelectedIndexChanged);
            // 
            // txtPaymentCode
            // 
            this.txtPaymentCode.Location = new System.Drawing.Point(100, 25);
            this.txtPaymentCode.Name = "txtPaymentCode";
            this.txtPaymentCode.Size = new System.Drawing.Size(120, 20);
            this.txtPaymentCode.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(20, 128);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(47, 13);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(580, 93);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(93, 13);
            this.lblPaymentDate.TabIndex = 7;
            this.lblPaymentDate.Text = "Ngày thanh toán:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(260, 93);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(95, 13);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Tổng tiền (VNĐ):";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(580, 58);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(52, 13);
            this.lblCheckOutDate.TabIndex = 5;
            this.lblCheckOutDate.Text = "Ngày trả:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(260, 58);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(51, 13);
            this.lblCheckInDate.TabIndex = 4;
            this.lblCheckInDate.Text = "Ngày đặt:";
            // 
            // lblRoomCode
            // 
            this.lblRoomCode.AutoSize = true;
            this.lblRoomCode.Location = new System.Drawing.Point(20, 93);
            this.lblRoomCode.Name = "lblRoomCode";
            this.lblRoomCode.Size = new System.Drawing.Size(41, 13);
            this.lblRoomCode.TabIndex = 3;
            this.lblRoomCode.Text = "Phòng:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(580, 28);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Khách hàng:";
            // 
            // lblBookingCode
            // 
            this.lblBookingCode.AutoSize = true;
            this.lblBookingCode.Location = new System.Drawing.Point(260, 28);
            this.lblBookingCode.Name = "lblBookingCode";
            this.lblBookingCode.Size = new System.Drawing.Size(88, 13);
            this.lblBookingCode.TabIndex = 1;
            this.lblBookingCode.Text = "Mã đặt phòng:";
            // 
            // lblPaymentCode
            // 
            this.lblPaymentCode.AutoSize = true;
            this.lblPaymentCode.Location = new System.Drawing.Point(20, 28);
            this.lblPaymentCode.Name = "lblPaymentCode";
            this.lblPaymentCode.Size = new System.Drawing.Size(42, 13);
            this.lblPaymentCode.TabIndex = 0;
            this.lblPaymentCode.Text = "Mã TT:";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpPaymentInfo);
            this.Name = "PaymentForm";
            this.Size = new System.Drawing.Size(970, 592);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRefreshPayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtCheckOutDate;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbBookingCode;
        private System.Windows.Forms.TextBox txtPaymentCode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBookingCode;
        private System.Windows.Forms.Label lblPaymentCode;
    }
}