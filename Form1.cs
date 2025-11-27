using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối SQL Server
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private SqlConnection conn;

        // Biến lưu thông tin nhân viên đăng nhập
        private string currentEmployeeCode = "";
        private string currentEmployeeName = "";
        private string currentEmployeePosition = "";

        // Biến trạng thái form
        private bool isEditing = false;
        private string currentEditingId = "";

        public Form1()
        {
            InitializeComponent();
            InitializeConnection();
            SetupEventHandlers();
        }

        // Khởi tạo kết nối database
        private void InitializeConnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                
                // Tự động tạo bảng và dữ liệu mẫu
                InitializeDatabase();
                
                MessageBox.Show("Kết nối database thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thiết lập event handlers
        private void SetupEventHandlers()
        {
            // Login events
            btnLogin.Click += btnLogin_Click;
            btnLogout.Click += btnLogout_Click;
            txtPassword.KeyPress += txtPassword_KeyPress;

            // Employee events
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnEditEmployee.Click += btnEditEmployee_Click;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            btnRefreshEmployees.Click += btnRefreshEmployees_Click;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;

            // Customer events
            btnAddCustomer.Click += btnAddCustomer_Click;
            btnEditCustomer.Click += btnEditCustomer_Click;
            btnSaveCustomer.Click += btnSaveCustomer_Click;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            btnRefreshCustomers.Click += btnRefreshCustomers_Click;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;

            // Room events
            btnAddRoom.Click += btnAddRoom_Click;
            btnEditRoom.Click += btnEditRoom_Click;
            btnSaveRoom.Click += btnSaveRoom_Click;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            btnRefreshRooms.Click += btnRefreshRooms_Click;
            dgvRooms.SelectionChanged += dgvRooms_SelectionChanged;

            // Booking events
            btnAddBooking.Click += btnAddBooking_Click;
            btnEditBooking.Click += btnEditBooking_Click;
            btnSaveBooking.Click += btnSaveBooking_Click;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            btnRefreshBookings.Click += btnRefreshBookings_Click;
            dgvBookings.SelectionChanged += dgvBookings_SelectionChanged;

            // Logout main
            btnLogoutMain.Click += btnLogoutMain_Click;
        }

        // Phương thức lấy kết nối (sử dụng khi cần query)
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Tự động tạo bảng và dữ liệu mẫu
        private void InitializeDatabase()
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                
                // Tạo bảng NhanVien
                string createNhanVienTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'NhanVien')
                BEGIN
                    CREATE TABLE NhanVien (
                        MaNV NVARCHAR(10) PRIMARY KEY,
                        Ho NVARCHAR(50),
                        Ten NVARCHAR(50),
                        GioiTinh NVARCHAR(10),
                        NgaySinh DATE,
                        ChucVu NVARCHAR(50),
                        Email NVARCHAR(100) UNIQUE,
                        MatKhau NVARCHAR(100),
                        TrangThai NVARCHAR(20) DEFAULT 'active'
                    )
                END";

                // Đảm bảo cột TrangThai tồn tại trong bảng NhanVien
                string ensureTrangThaiColumn = @"
                IF NOT EXISTS (SELECT * FROM sys.columns 
                            WHERE object_id = OBJECT_ID('NhanVien') AND name = 'TrangThai')
                BEGIN
                    ALTER TABLE NhanVien ADD TrangThai NVARCHAR(20) DEFAULT 'active'
                END";
                ExecuteNonQuery(connection, ensureTrangThaiColumn);
                
                // Tạo bảng KhachHang
                string createKhachHangTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KhachHang')
                BEGIN
                    CREATE TABLE KhachHang (
                        MaKH NVARCHAR(10) PRIMARY KEY,
                        HoTen NVARCHAR(100),
                        SDT NVARCHAR(15),
                        CMND NVARCHAR(20),
                        NgayTao DATE DEFAULT GETDATE()
                    )
                END";
                
                // Tạo bảng LoaiPhong
                string createLoaiPhongTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LoaiPhong')
                BEGIN
                    CREATE TABLE LoaiPhong (
                        MaLoai NVARCHAR(10) PRIMARY KEY,
                        TenLoai NVARCHAR(50),
                        GiaTien DECIMAL(18,2),
                        MoTa NVARCHAR(MAX)
                    )
                END";
                
                // Tạo bảng Phong
                string createPhongTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Phong')
                BEGIN
                    CREATE TABLE Phong (
                        MaPhong NVARCHAR(10) PRIMARY KEY,
                        MaLoai NVARCHAR(10),
                        TrangThai NVARCHAR(50) DEFAULT 'trong',
                        GhiChu NVARCHAR(200),
                        FOREIGN KEY (MaLoai) REFERENCES LoaiPhong(MaLoai)
                    )
                END";
                
                // Tạo bảng DatPhong
                string createDatPhongTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DatPhong')
                BEGIN
                    CREATE TABLE DatPhong (
                        MaDat NVARCHAR(10) PRIMARY KEY,
                        MaKH NVARCHAR(10),
                        MaPhong NVARCHAR(10),
                        MaNV NVARCHAR(10),
                        NgayDat DATE,
                        NgayTra DATE,
                        TrangThai NVARCHAR(20) DEFAULT 'active',
                        NgayTao DATETIME DEFAULT GETDATE(),
                        FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
                        FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
                        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
                    )
                END";
                
                // Thực thi tạo bảng
                ExecuteNonQuery(connection, createNhanVienTable);
                ExecuteNonQuery(connection, createKhachHangTable);
                ExecuteNonQuery(connection, createLoaiPhongTable);
                ExecuteNonQuery(connection, createPhongTable);
                ExecuteNonQuery(connection, createDatPhongTable);
                
                // Thêm dữ liệu mẫu
                InsertSampleData(connection);
            }
        }
        
        // Thêm dữ liệu mẫu
        private void InsertSampleData(SqlConnection connection)
        {
            // Kiểm tra và thêm tài khoản admin
            string checkAdmin = "SELECT COUNT(*) FROM NhanVien WHERE Email = 'admin@khachsan.com'";
            SqlCommand cmd = new SqlCommand(checkAdmin, connection);
            int count = (int)cmd.ExecuteScalar();
            
            if (count == 0)
            {
                // Thêm tài khoản admin
                string insertAdmin = @"
                INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgaySinh, ChucVu, Email, MatKhau)
                VALUES ('NV001', N'Admin', N'System', N'Nam', '1990-01-01', N'truong phong', 'admin@khachsan.com', 'admin123')";
                ExecuteNonQuery(connection, insertAdmin);
                
                // Thêm nhân viên mẫu
                string insertEmployee = @"
                INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgaySinh, ChucVu, Email, MatKhau)
                VALUES ('NV002', N'Nguyễn Văn', N'An', N'Nam', '1995-05-15', N'nhan vien', 'an.nguyen@khachsan.com', '123456')";
                ExecuteNonQuery(connection, insertEmployee);
            }
            
            // Thêm loại phòng mẫu
            string checkLoaiPhong = "SELECT COUNT(*) FROM LoaiPhong";
            cmd = new SqlCommand(checkLoaiPhong, connection);
            count = (int)cmd.ExecuteScalar();
            
            if (count == 0)
            {
                string insertLoaiPhong = @"
                INSERT INTO LoaiPhong (MaLoai, TenLoai, GiaTien, MoTa) VALUES
                ('LP001', N'Phòng đơn', 500000, N'Phòng dành cho 1 người'),
                ('LP002', N'Phòng đôi', 800000, N'Phòng dành cho 2 người'),
                ('LP003', N'Phòng VIP', 1500000, N'Phòng cao cấp')";
                ExecuteNonQuery(connection, insertLoaiPhong);
                
                // Thêm phòng mẫu
                string insertPhong = @"
                INSERT INTO Phong (MaPhong, MaLoai, TrangThai, GhiChu) VALUES
                ('P101', 'LP001', N'trong', N''),
                ('P102', 'LP001', N'trong', N''),
                ('P201', 'LP002', N'trong', N''),
                ('P202', 'LP002', N'trong', N''),
                ('P301', 'LP003', N'trong', N'View biển')";
                ExecuteNonQuery(connection, insertPhong);

                // Thêm khách hàng mẫu
                string insertCustomer = @"
                INSERT INTO KhachHang (MaKH, HoTen, SDT, CMND) VALUES
                ('KH001', N'Nguyễn Văn A', '0123456789', '123456789'),
                ('KH002', N'Trần Thị B', '0987654321', '987654321')";
                ExecuteNonQuery(connection, insertCustomer);
            }
        }
        
        // Thực thi câu lệnh SQL không trả về dữ liệu
        private void ExecuteNonQuery(SqlConnection connection, string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi nếu bảng đã tồn tại
                if (!ex.Message.Contains("already an object"))
                {
                    MessageBox.Show("Lỗi khởi tạo database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Login Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaNV, Ho, Ten, ChucVu FROM NhanVien WHERE Email = @Email AND MatKhau = @Password AND TrangThai = 'active'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        // Đăng nhập thành công
                        currentEmployeeCode = reader["MaNV"].ToString();
                        currentEmployeeName = reader["Ho"].ToString() + " " + reader["Ten"].ToString();
                        currentEmployeePosition = reader["ChucVu"].ToString();
                        
                        reader.Close();
                        
                        // Cập nhật UI
                        lblUserInfo.Text = $"Nhân viên: {currentEmployeeName} ({currentEmployeePosition})";
                        lblCurrentEmployee.Text = currentEmployeeCode;
                        
                        // Chuyển sang tab quản lý
                        tabControl1.SelectedIndex = 1;
                        
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Load dữ liệu ban đầu
                        LoadEmployeesData();
                        LoadCustomersData();
                        LoadRoomsData();
                        LoadBookingsData();
                        UpdateButtonAccess();
                    }
                    else
                    {
                        MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
            MessageBox.Show("Đã đăng xuất. Vui lòng đăng nhập lại để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogoutMain_Click(object sender, EventArgs e)
        {
            // Reset thông tin user
            currentEmployeeCode = "";
            currentEmployeeName = "";
            currentEmployeePosition = "";
            
            // Clear form
            ClearAllForms();
            
            // Chuyển về tab đăng nhập
            tabControl1.SelectedIndex = 0;
            lblUserInfo.Text = "";
            
            MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Employee Management
        private void LoadEmployeesData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaNV, Ho, Ten, GioiTinh, NgaySinh, ChucVu, Email FROM NhanVien WHERE TrangThai = 'active'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEmployees.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể thêm nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtEmployeeCode.Text) || string.IsNullOrEmpty(txtFirstName.Text) || 
                string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmailEmp.Text) || 
                string.IsNullOrEmpty(txtPasswordEmp.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Kiểm tra mã nhân viên đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaNV", txtEmployeeCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm nhân viên mới
                    string insertQuery = @"
                    INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgaySinh, ChucVu, Email, MatKhau) 
                    VALUES (@MaNV, @Ho, @Ten, @GioiTinh, @NgaySinh, @ChucVu, @Email, @MatKhau)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaNV", txtEmployeeCode.Text);
                    cmd.Parameters.AddWithValue("@Ho", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", rdbMale.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@ChucVu", cmbPosition.SelectedItem?.ToString() ?? "nhan vien");
                    cmd.Parameters.AddWithValue("@Email", txtEmailEmp.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPasswordEmp.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeesData();
                    ClearEmployeeForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể sửa nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            txtEmployeeCode.Text = row.Cells["MaNV"].Value.ToString();
            txtEmployeeCode.Enabled = false; // Không cho sửa mã NV
            txtLastName.Text = row.Cells["Ho"].Value.ToString();
            txtFirstName.Text = row.Cells["Ten"].Value.ToString();
            
            string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }

            if (row.Cells["NgaySinh"].Value != DBNull.Value)
            {
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }

            cmbPosition.SelectedItem = row.Cells["ChucVu"].Value.ToString();
            txtEmailEmp.Text = row.Cells["Email"].Value.ToString();
            txtPasswordEmp.Clear();

            isEditing = true;
            currentEditingId = txtEmployeeCode.Text;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể lưu thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditing)
            {
                MessageBox.Show("Vui lòng chọn chế độ sửa trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE NhanVien SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, 
                                   NgaySinh = @NgaySinh, ChucVu = @ChucVu, Email = @Email";

                    // Chỉ cập nhật mật khẩu nếu có nhập
                    if (!string.IsNullOrEmpty(txtPasswordEmp.Text))
                    {
                        query += ", MatKhau = @MatKhau";
                    }

                    query += " WHERE MaNV = @MaNV";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Ho", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", rdbMale.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@ChucVu", cmbPosition.SelectedItem?.ToString() ?? "nhan vien");
                    cmd.Parameters.AddWithValue("@Email", txtEmailEmp.Text);
                    cmd.Parameters.AddWithValue("@MaNV", currentEditingId);

                    if (!string.IsNullOrEmpty(txtPasswordEmp.Text))
                    {
                        cmd.Parameters.AddWithValue("@MatKhau", txtPasswordEmp.Text);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeesData();
                    ClearEmployeeForm();
                    isEditing = false;
                    currentEditingId = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể xóa nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            string maNV = row.Cells["MaNV"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {maNV}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        // Xóa mềm bằng cách cập nhật trạng thái
                        string query = "UPDATE NhanVien SET TrangThai = 'inactive' WHERE MaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeesData();
                        ClearEmployeeForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployeesData();
            ClearEmployeeForm();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0 && !isEditing)
            {
                btnEditEmployee_Click(sender, e);
            }
        }

        private void ClearEmployeeForm()
        {
            txtEmployeeCode.Clear();
            txtEmployeeCode.Enabled = true;
            txtLastName.Clear();
            txtFirstName.Clear();
            rdbMale.Checked = true;
            dtpBirthDate.Value = DateTime.Now;
            cmbPosition.SelectedIndex = -1;
            txtEmailEmp.Clear();
            txtPasswordEmp.Clear();
            isEditing = false;
            currentEditingId = "";
        }
        #endregion

        #region Customer Management
        private void LoadCustomersData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KhachHang ORDER BY MaKH";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerCode.Text) || string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Kiểm tra mã khách hàng đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaKH", txtCustomerCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm khách hàng mới
                    string insertQuery = @"
                    INSERT INTO KhachHang (MaKH, HoTen, SDT, CMND) 
                    VALUES (@MaKH, @HoTen, @SDT, @CMND)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaKH", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomersData();
                    ClearCustomerForm();
                    LoadBookingsData(); // Refresh combo box in booking tab
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];
            txtCustomerCode.Text = row.Cells["MaKH"].Value.ToString();
            txtCustomerCode.Enabled = false;
            txtCustomerName.Text = row.Cells["HoTen"].Value.ToString();
            txtPhone.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtCMND.Text = row.Cells["CMND"].Value?.ToString() ?? "";

            isEditing = true;
            currentEditingId = txtCustomerCode.Text;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                MessageBox.Show("Vui lòng chọn chế độ sửa trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE KhachHang SET HoTen = @HoTen, SDT = @SDT, CMND = @CMND 
                                   WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@HoTen", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                    cmd.Parameters.AddWithValue("@MaKH", currentEditingId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomersData();
                    ClearCustomerForm();
                    isEditing = false;
                    currentEditingId = "";
                    LoadBookingsData(); // Refresh combo box in booking tab
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvCustomers.SelectedRows[0];
            string maKH = row.Cells["MaKH"].Value.ToString();

            // Kiểm tra xem khách hàng có đang đặt phòng không
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM DatPhong WHERE MaKH = @MaKH AND TrangThai = 'active'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaKH", maKH);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Không thể xóa khách hàng đang có đặt phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa khách hàng {maKH}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomersData();
                        ClearCustomerForm();
                        LoadBookingsData(); // Refresh combo box in booking tab
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomersData();
            ClearCustomerForm();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0 && !isEditing)
            {
                btnEditCustomer_Click(sender, e);
            }
        }

        private void ClearCustomerForm()
        {
            txtCustomerCode.Clear();
            txtCustomerCode.Enabled = true;
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtCMND.Clear();
            isEditing = false;
            currentEditingId = "";
        }
        #endregion

        #region Room Management
        private void LoadRoomsData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT P.MaPhong, L.TenLoai, L.GiaTien, P.TrangThai, P.GhiChu 
                                    FROM Phong P 
                                    INNER JOIN LoaiPhong L ON P.MaLoai = L.MaLoai
                                    ORDER BY P.MaPhong";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRooms.DataSource = dt;
                    
                    // Load loại phòng vào ComboBox
                    string queryLoaiPhong = "SELECT MaLoai, TenLoai FROM LoaiPhong";
                    SqlDataAdapter adapterLP = new SqlDataAdapter(queryLoaiPhong, connection);
                    DataTable dtLP = new DataTable();
                    adapterLP.Fill(dtLP);
                    cmbRoomType.DataSource = dtLP;
                    cmbRoomType.DisplayMember = "TenLoai";
                    cmbRoomType.ValueMember = "MaLoai";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể thêm phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtRoomCode.Text) || cmbRoomType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Kiểm tra mã phòng đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Phong WHERE MaPhong = @MaPhong";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaPhong", txtRoomCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm phòng mới
                    string insertQuery = @"
                    INSERT INTO Phong (MaPhong, MaLoai, TrangThai, GhiChu) 
                    VALUES (@MaPhong, @MaLoai, @TrangThai, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaPhong", txtRoomCode.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", cmbRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@TrangThai", cmbStatus.SelectedItem?.ToString() ?? "trong");
                    cmd.Parameters.AddWithValue("@GhiChu", txtNote.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomsData();
                    ClearRoomForm();
                    LoadBookingsData(); // Refresh combo box in booking tab
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể sửa phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvRooms.SelectedRows[0];
            txtRoomCode.Text = row.Cells["MaPhong"].Value.ToString();
            txtRoomCode.Enabled = false;

            // Tìm mã loại phòng từ tên loại phòng
            string tenLoai = row.Cells["TenLoai"].Value.ToString();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT MaLoai FROM LoaiPhong WHERE TenLoai = @TenLoai";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    cmbRoomType.SelectedValue = result.ToString();
                }
            }

            cmbStatus.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            txtNote.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            isEditing = true;
            currentEditingId = txtRoomCode.Text;
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể lưu thông tin phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditing)
            {
                MessageBox.Show("Vui lòng chọn chế độ sửa trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = @"UPDATE Phong SET MaLoai = @MaLoai, TrangThai = @TrangThai, GhiChu = @GhiChu 
                                   WHERE MaPhong = @MaPhong";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaLoai", cmbRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@TrangThai", cmbStatus.SelectedItem?.ToString() ?? "trong");
                    cmd.Parameters.AddWithValue("@GhiChu", txtNote.Text);
                    cmd.Parameters.AddWithValue("@MaPhong", currentEditingId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomsData();
                    ClearRoomForm();
                    isEditing = false;
                    currentEditingId = "";
                    LoadBookingsData(); // Refresh combo box in booking tab
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (currentEmployeePosition != "truong phong")
            {
                MessageBox.Show("Chỉ trưởng phòng có thể xóa phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvRooms.SelectedRows[0];
            string maPhong = row.Cells["MaPhong"].Value.ToString();

            // Kiểm tra xem phòng có đang được đặt không
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM DatPhong WHERE MaPhong = @MaPhong AND TrangThai = 'active'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Không thể xóa phòng đang được đặt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa phòng {maPhong}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsData();
                        ClearRoomForm();
                        LoadBookingsData(); // Refresh combo box in booking tab
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshRooms_Click(object sender, EventArgs e)
        {
            LoadRoomsData();
            ClearRoomForm();
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0 && !isEditing)
            {
                btnEditRoom_Click(sender, e);
            }
        }

        private void ClearRoomForm()
        {
            txtRoomCode.Clear();
            txtRoomCode.Enabled = true;
            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtNote.Clear();
            isEditing = false;
            currentEditingId = "";
        }
        #endregion

        #region Booking Management
        private void LoadBookingsData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT D.MaDat, K.HoTen, P.MaPhong, D.NgayDat, D.NgayTra, N.Ho + ' ' + N.Ten as NhanVien
                                    FROM DatPhong D
                                    INNER JOIN KhachHang K ON D.MaKH = K.MaKH
                                    INNER JOIN Phong P ON D.MaPhong = P.MaPhong
                                    INNER JOIN NhanVien N ON D.MaNV = N.MaNV
                                    WHERE D.TrangThai = 'active'
                                    ORDER BY D.NgayDat DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBookings.DataSource = dt;
                    
                    // Load khách hàng vào ComboBox
                    string queryKH = "SELECT MaKH, HoTen FROM KhachHang ORDER BY HoTen";
                    SqlDataAdapter adapterKH = new SqlDataAdapter(queryKH, connection);
                    DataTable dtKH = new DataTable();
                    adapterKH.Fill(dtKH);
                    cmbCustomer.DataSource = dtKH;
                    cmbCustomer.DisplayMember = "HoTen";
                    cmbCustomer.ValueMember = "MaKH";
                    
                    // Load phòng trống vào ComboBox
                    string queryPhong = "SELECT MaPhong FROM Phong WHERE TrangThai = N'trong' ORDER BY MaPhong";
                    SqlDataAdapter adapterPhong = new SqlDataAdapter(queryPhong, connection);
                    DataTable dtPhong = new DataTable();
                    adapterPhong.Fill(dtPhong);
                    cmbRoom.DataSource = dtPhong;
                    cmbRoom.DisplayMember = "MaPhong";
                    cmbRoom.ValueMember = "MaPhong";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingCode.Text) || cmbCustomer.SelectedValue == null || cmbRoom.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Kiểm tra mã đặt phòng đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM DatPhong WHERE MaDat = @MaDat";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaDat", txtBookingCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã đặt phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm đặt phòng mới
                    string insertQuery = @"
                    INSERT INTO DatPhong (MaDat, MaKH, MaPhong, MaNV, NgayDat, NgayTra) 
                    VALUES (@MaDat, @MaKH, @MaPhong, @MaNV, @NgayDat, @NgayTra)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaDat", txtBookingCode.Text);
                    cmd.Parameters.AddWithValue("@MaKH", cmbCustomer.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaPhong", cmbRoom.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNV", currentEmployeeCode);
                    cmd.Parameters.AddWithValue("@NgayDat", dtpCheckIn.Value);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpCheckOut.Value);

                    cmd.ExecuteNonQuery();

                    // Cập nhật trạng thái phòng
                    string updateRoomQuery = "UPDATE Phong SET TrangThai = N'đang thuê' WHERE MaPhong = @MaPhong";
                    SqlCommand updateCmd = new SqlCommand(updateRoomQuery, connection);
                    updateCmd.Parameters.AddWithValue("@MaPhong", cmbRoom.SelectedValue);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookingsData();
                    LoadRoomsData(); // Refresh room status
                    ClearBookingForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đặt phòng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvBookings.SelectedRows[0];
            txtBookingCode.Text = row.Cells["MaDat"].Value.ToString();
            txtBookingCode.Enabled = false;

            // Tìm mã khách hàng từ tên
            string hoTen = row.Cells["HoTen"].Value.ToString();
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT MaKH FROM KhachHang WHERE HoTen = @HoTen";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    cmbCustomer.SelectedValue = result.ToString();
                }
            }

            cmbRoom.SelectedValue = row.Cells["MaPhong"].Value.ToString();
            dtpCheckIn.Value = Convert.ToDateTime(row.Cells["NgayDat"].Value);
            dtpCheckOut.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);

            isEditing = true;
            currentEditingId = txtBookingCode.Text;
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                MessageBox.Show("Vui lòng chọn chế độ sửa trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Lấy phòng cũ để cập nhật trạng thái
                    string getOldRoomQuery = "SELECT MaPhong FROM DatPhong WHERE MaDat = @MaDat";
                    SqlCommand getOldRoomCmd = new SqlCommand(getOldRoomQuery, connection);
                    getOldRoomCmd.Parameters.AddWithValue("@MaDat", currentEditingId);
                    string oldRoom = getOldRoomCmd.ExecuteScalar()?.ToString();

                    string newRoom = cmbRoom.SelectedValue?.ToString();

                    // Cập nhật đặt phòng
                    string query = @"UPDATE DatPhong SET MaKH = @MaKH, MaPhong = @MaPhong, 
                                   NgayDat = @NgayDat, NgayTra = @NgayTra 
                                   WHERE MaDat = @MaDat";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MaKH", cmbCustomer.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaPhong", newRoom);
                    cmd.Parameters.AddWithValue("@NgayDat", dtpCheckIn.Value);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpCheckOut.Value);
                    cmd.Parameters.AddWithValue("@MaDat", currentEditingId);

                    cmd.ExecuteNonQuery();

                    // Cập nhật trạng thái phòng nếu thay đổi phòng
                    if (oldRoom != newRoom)
                    {
                        // Đặt lại trạng thái phòng cũ
                        string updateOldRoomQuery = "UPDATE Phong SET TrangThai = N'trong' WHERE MaPhong = @MaPhong";
                        SqlCommand updateOldCmd = new SqlCommand(updateOldRoomQuery, connection);
                        updateOldCmd.Parameters.AddWithValue("@MaPhong", oldRoom);
                        updateOldCmd.ExecuteNonQuery();

                        // Cập nhật trạng thái phòng mới
                        string updateNewRoomQuery = "UPDATE Phong SET TrangThai = N'đang thuê' WHERE MaPhong = @MaPhong";
                        SqlCommand updateNewCmd = new SqlCommand(updateNewRoomQuery, connection);
                        updateNewCmd.Parameters.AddWithValue("@MaPhong", newRoom);
                        updateNewCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookingsData();
                    LoadRoomsData(); // Refresh room status
                    ClearBookingForm();
                    isEditing = false;
                    currentEditingId = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đặt phòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvBookings.SelectedRows[0];
            string maDat = row.Cells["MaDat"].Value.ToString();
            string maPhong = row.Cells["MaPhong"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa đặt phòng {maDat}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = GetConnection())
                    {
                        connection.Open();
                        
                        // Xóa mềm đặt phòng
                        string query = "UPDATE DatPhong SET TrangThai = 'cancelled' WHERE MaDat = @MaDat";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaDat", maDat);
                        cmd.ExecuteNonQuery();

                        // Đặt lại trạng thái phòng
                        string updateRoomQuery = "UPDATE Phong SET TrangThai = N'trong' WHERE MaPhong = @MaPhong";
                        SqlCommand updateCmd = new SqlCommand(updateRoomQuery, connection);
                        updateCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookingsData();
                        LoadRoomsData(); // Refresh room status
                        ClearBookingForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshBookings_Click(object sender, EventArgs e)
        {
            LoadBookingsData();
            ClearBookingForm();
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0 && !isEditing)
            {
                btnEditBooking_Click(sender, e);
            }
        }

        private void ClearBookingForm()
        {
            txtBookingCode.Clear();
            txtBookingCode.Enabled = true;
            cmbCustomer.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
            isEditing = false;
            currentEditingId = "";
        }
        #endregion

        #region Utility Methods
        private void UpdateButtonAccess()
        {
            bool isManager = currentEmployeePosition == "truong phong";

            // Employee buttons
            btnAddEmployee.Enabled = isManager;
            btnEditEmployee.Enabled = isManager;
            btnDeleteEmployee.Enabled = isManager;

            // Room buttons
            btnAddRoom.Enabled = isManager;
            btnEditRoom.Enabled = isManager;
            btnDeleteRoom.Enabled = isManager;
        }

        private void ClearAllForms()
        {
            ClearEmployeeForm();
            ClearCustomerForm();
            ClearRoomForm();
            ClearBookingForm();
        }
        #endregion
    }
}