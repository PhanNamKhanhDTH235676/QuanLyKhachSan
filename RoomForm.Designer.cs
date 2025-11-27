namespace QuanLyKhachSan
{
    partial class RoomForm
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
            this.panelRoomButtons = new System.Windows.Forms.Panel();
            this.btnRefreshRooms = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.btnEditRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelRoomButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.grpRoomInfo.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoomButtons
            // 
            this.panelRoomButtons.Controls.Add(this.btnRefreshRooms);
            this.panelRoomButtons.Controls.Add(this.btnDeleteRoom);
            this.panelRoomButtons.Controls.Add(this.btnSaveRoom);
            this.panelRoomButtons.Controls.Add(this.btnEditRoom);
            this.panelRoomButtons.Controls.Add(this.btnAddRoom);
            this.panelRoomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRoomButtons.Location = new System.Drawing.Point(0, 545);
            this.panelRoomButtons.Name = "panelRoomButtons";
            this.panelRoomButtons.Size = new System.Drawing.Size(970, 47);
            this.panelRoomButtons.TabIndex = 3;
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
            this.btnRefreshRooms.Click += new System.EventHandler(this.btnRefreshRooms_Click);
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
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
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
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
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
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
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
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.Location = new System.Drawing.Point(0, 148);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(970, 397);
            this.dgvRooms.TabIndex = 2;
            this.dgvRooms.SelectionChanged += new System.EventHandler(this.dgvRooms_SelectionChanged);
            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Controls.Add(this.lblRoomPrice);
            this.grpRoomInfo.Controls.Add(this.lblPriceLabel);
            this.grpRoomInfo.Controls.Add(this.txtNote);
            this.grpRoomInfo.Controls.Add(this.cmbStatus);
            this.grpRoomInfo.Controls.Add(this.cmbRoomType);
            this.grpRoomInfo.Controls.Add(this.txtRoomCode);
            this.grpRoomInfo.Controls.Add(this.lblNote);
            this.grpRoomInfo.Controls.Add(this.lblStatus);
            this.grpRoomInfo.Controls.Add(this.lblRoomType);
            this.grpRoomInfo.Controls.Add(this.lblRoomCode);
            this.grpRoomInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(970, 98);
            this.grpRoomInfo.TabIndex = 0;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Thông tin phòng";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.BackColor = System.Drawing.Color.LightYellow;
            this.lblRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRoomPrice.Location = new System.Drawing.Point(680, 25);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(150, 20);
            this.lblRoomPrice.TabIndex = 9;
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Location = new System.Drawing.Point(580, 28);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(62, 13);
            this.lblPriceLabel.TabIndex = 8;
            this.lblPriceLabel.Text = "Giá phòng:";
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
            "đang thuê",
            "bảo trì",
            "đang dọn dẹp"});
            this.cmbStatus.Location = new System.Drawing.Point(100, 55);
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
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
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
            this.lblStatus.Location = new System.Drawing.Point(20, 58);
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
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearchRoom);
            this.grpSearch.Controls.Add(this.txtSearchRoom);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 98);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(970, 50);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm phòng";
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoom.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoom.Location = new System.Drawing.Point(380, 15);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(80, 25);
            this.btnSearchRoom.TabIndex = 2;
            this.btnSearchRoom.Text = "Tìm";
            this.btnSearchRoom.UseVisualStyleBackColor = false;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Location = new System.Drawing.Point(100, 17);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(250, 20);
            this.txtSearchRoom.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Từ khóa:";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panelRoomButtons);
            this.Controls.Add(this.grpRoomInfo);
            this.Name = "RoomForm";
            this.Size = new System.Drawing.Size(970, 592);
            this.panelRoomButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelRoomButtons;
        private System.Windows.Forms.Button btnRefreshRooms;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Button btnEditRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Label lblSearch;
    }
}