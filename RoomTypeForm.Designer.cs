namespace QuanLyKhachSan
{
    partial class RoomTypeForm
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
            this.btnRefreshRoomTypes = new System.Windows.Forms.Button();
            this.btnDeleteRoomType = new System.Windows.Forms.Button();
            this.btnSaveRoomType = new System.Windows.Forms.Button();
            this.btnEditRoomType = new System.Windows.Forms.Button();
            this.btnAddRoomType = new System.Windows.Forms.Button();
            this.dgvRoomTypes = new System.Windows.Forms.DataGridView();
            this.grpRoomTypeInfo = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoomTypeName = new System.Windows.Forms.TextBox();
            this.txtRoomTypeCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomTypeName = new System.Windows.Forms.Label();
            this.lblRoomTypeCode = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchRoomType = new System.Windows.Forms.Button();
            this.txtSearchRoomType = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).BeginInit();
            this.grpRoomTypeInfo.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnRefreshRoomTypes);
            this.panelButtons.Controls.Add(this.btnDeleteRoomType);
            this.panelButtons.Controls.Add(this.btnSaveRoomType);
            this.panelButtons.Controls.Add(this.btnEditRoomType);
            this.panelButtons.Controls.Add(this.btnAddRoomType);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 545);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(970, 47);
            this.panelButtons.TabIndex = 2;
            // 
            // btnRefreshRoomTypes
            // 
            this.btnRefreshRoomTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRefreshRoomTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRoomTypes.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRoomTypes.Location = new System.Drawing.Point(400, 10);
            this.btnRefreshRoomTypes.Name = "btnRefreshRoomTypes";
            this.btnRefreshRoomTypes.Size = new System.Drawing.Size(80, 30);
            this.btnRefreshRoomTypes.TabIndex = 4;
            this.btnRefreshRoomTypes.Text = "Làm mới";
            this.btnRefreshRoomTypes.UseVisualStyleBackColor = false;
            this.btnRefreshRoomTypes.Click += new System.EventHandler(this.btnRefreshRoomTypes_Click);
            // 
            // btnDeleteRoomType
            // 
            this.btnDeleteRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoomType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoomType.Location = new System.Drawing.Point(300, 10);
            this.btnDeleteRoomType.Name = "btnDeleteRoomType";
            this.btnDeleteRoomType.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteRoomType.TabIndex = 3;
            this.btnDeleteRoomType.Text = "Xóa";
            this.btnDeleteRoomType.UseVisualStyleBackColor = false;
            this.btnDeleteRoomType.Click += new System.EventHandler(this.btnDeleteRoomType_Click);
            // 
            // btnSaveRoomType
            // 
            this.btnSaveRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSaveRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoomType.ForeColor = System.Drawing.Color.White;
            this.btnSaveRoomType.Location = new System.Drawing.Point(200, 10);
            this.btnSaveRoomType.Name = "btnSaveRoomType";
            this.btnSaveRoomType.Size = new System.Drawing.Size(80, 30);
            this.btnSaveRoomType.TabIndex = 2;
            this.btnSaveRoomType.Text = "Lưu";
            this.btnSaveRoomType.UseVisualStyleBackColor = false;
            this.btnSaveRoomType.Click += new System.EventHandler(this.btnSaveRoomType_Click);
            // 
            // btnEditRoomType
            // 
            this.btnEditRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEditRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoomType.ForeColor = System.Drawing.Color.White;
            this.btnEditRoomType.Location = new System.Drawing.Point(100, 10);
            this.btnEditRoomType.Name = "btnEditRoomType";
            this.btnEditRoomType.Size = new System.Drawing.Size(80, 30);
            this.btnEditRoomType.TabIndex = 1;
            this.btnEditRoomType.Text = "Sửa";
            this.btnEditRoomType.UseVisualStyleBackColor = false;
            this.btnEditRoomType.Click += new System.EventHandler(this.btnEditRoomType_Click);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAddRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoomType.ForeColor = System.Drawing.Color.White;
            this.btnAddRoomType.Location = new System.Drawing.Point(0, 10);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(80, 30);
            this.btnAddRoomType.TabIndex = 0;
            this.btnAddRoomType.Text = "Thêm";
            this.btnAddRoomType.UseVisualStyleBackColor = false;
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // dgvRoomTypes
            // 
            this.dgvRoomTypes.AllowUserToAddRows = false;
            this.dgvRoomTypes.AllowUserToDeleteRows = false;
            this.dgvRoomTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomTypes.Location = new System.Drawing.Point(0, 178);
            this.dgvRoomTypes.Name = "dgvRoomTypes";
            this.dgvRoomTypes.ReadOnly = true;
            this.dgvRoomTypes.Size = new System.Drawing.Size(970, 367);
            this.dgvRoomTypes.TabIndex = 1;
            this.dgvRoomTypes.SelectionChanged += new System.EventHandler(this.dgvRoomTypes_SelectionChanged);
            // 
            // grpRoomTypeInfo
            // 
            this.grpRoomTypeInfo.Controls.Add(this.txtDescription);
            this.grpRoomTypeInfo.Controls.Add(this.txtPrice);
            this.grpRoomTypeInfo.Controls.Add(this.txtRoomTypeName);
            this.grpRoomTypeInfo.Controls.Add(this.txtRoomTypeCode);
            this.grpRoomTypeInfo.Controls.Add(this.lblDescription);
            this.grpRoomTypeInfo.Controls.Add(this.lblPrice);
            this.grpRoomTypeInfo.Controls.Add(this.lblRoomTypeName);
            this.grpRoomTypeInfo.Controls.Add(this.lblRoomTypeCode);
            this.grpRoomTypeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRoomTypeInfo.Location = new System.Drawing.Point(0, 0);
            this.grpRoomTypeInfo.Name = "grpRoomTypeInfo";
            this.grpRoomTypeInfo.Size = new System.Drawing.Size(970, 118);
            this.grpRoomTypeInfo.TabIndex = 0;
            this.grpRoomTypeInfo.TabStop = false;
            this.grpRoomTypeInfo.Text = "Thông tin loại phòng";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(800, 25);
            this.txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(350, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(350, 25);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(250, 20);
            this.txtRoomTypeName.TabIndex = 5;
            // 
            // txtRoomTypeCode
            // 
            this.txtRoomTypeCode.Location = new System.Drawing.Point(100, 25);
            this.txtRoomTypeCode.Name = "txtRoomTypeCode";
            this.txtRoomTypeCode.Size = new System.Drawing.Size(100, 20);
            this.txtRoomTypeCode.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Mô tả:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(240, 53);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá tiền (VNĐ):";
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.AutoSize = true;
            this.lblRoomTypeName.Location = new System.Drawing.Point(240, 28);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.Size = new System.Drawing.Size(48, 13);
            this.lblRoomTypeName.TabIndex = 1;
            this.lblRoomTypeName.Text = "Tên loại:";
            // 
            // lblRoomTypeCode
            // 
            this.lblRoomTypeCode.AutoSize = true;
            this.lblRoomTypeCode.Location = new System.Drawing.Point(20, 28);
            this.lblRoomTypeCode.Name = "lblRoomTypeCode";
            this.lblRoomTypeCode.Size = new System.Drawing.Size(44, 13);
            this.lblRoomTypeCode.TabIndex = 0;
            this.lblRoomTypeCode.Text = "Mã loại:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearchRoomType);
            this.grpSearch.Controls.Add(this.txtSearchRoomType);
            this.grpSearch.Controls.Add(this.lblSearchKeyword);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 118);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(970, 60);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // btnSearchRoomType
            // 
            this.btnSearchRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSearchRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoomType.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoomType.Location = new System.Drawing.Point(380, 22);
            this.btnSearchRoomType.Name = "btnSearchRoomType";
            this.btnSearchRoomType.Size = new System.Drawing.Size(80, 25);
            this.btnSearchRoomType.TabIndex = 2;
            this.btnSearchRoomType.Text = "Tìm kiếm";
            this.btnSearchRoomType.UseVisualStyleBackColor = false;
            this.btnSearchRoomType.Click += new System.EventHandler(this.btnSearchRoomType_Click);
            // 
            // txtSearchRoomType
            // 
            this.txtSearchRoomType.Location = new System.Drawing.Point(100, 24);
            this.txtSearchRoomType.Name = "txtSearchRoomType";
            this.txtSearchRoomType.Size = new System.Drawing.Size(250, 20);
            this.txtSearchRoomType.TabIndex = 1;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(20, 27);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(53, 13);
            this.lblSearchKeyword.TabIndex = 0;
            this.lblSearchKeyword.Text = "Từ khóa:";
            // 
            // RoomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRoomTypes);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpRoomTypeInfo);
            this.Name = "RoomTypeForm";
            this.Size = new System.Drawing.Size(970, 592);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).EndInit();
            this.grpRoomTypeInfo.ResumeLayout(false);
            this.grpRoomTypeInfo.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRefreshRoomTypes;
        private System.Windows.Forms.Button btnDeleteRoomType;
        private System.Windows.Forms.Button btnSaveRoomType;
        private System.Windows.Forms.Button btnEditRoomType;
        private System.Windows.Forms.Button btnAddRoomType;
        private System.Windows.Forms.DataGridView dgvRoomTypes;
        private System.Windows.Forms.GroupBox grpRoomTypeInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomTypeName;
        private System.Windows.Forms.TextBox txtRoomTypeCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomTypeName;
        private System.Windows.Forms.Label lblRoomTypeCode;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearchRoomType;
        private System.Windows.Forms.TextBox txtSearchRoomType;
        private System.Windows.Forms.Label lblSearchKeyword;
    }
}