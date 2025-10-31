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
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan;User Id=sa;Password=123;";
        private SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            InitializeConnection();
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
                        MatKhau NVARCHAR(100)
                    )
                END";
                
                // Tạo bảng KhachHang
                string createKhachHangTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'KhachHang')
                BEGIN
                    CREATE TABLE KhachHang (
                        MaKH NVARCHAR(10) PRIMARY KEY,
                        HoTen NVARCHAR(100),
                        SDT NVARCHAR(15),
                        CMND NVARCHAR(20)
                    )
                END";
                
                // Tạo bảng LoaiPhong
                string createLoaiPhongTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'LoaiPhong')
                BEGIN
                    CREATE TABLE LoaiPhong (
                        MaLoai NVARCHAR(10) PRIMARY KEY,
                        TenLoai NVARCHAR(50),
                        GiaTien DECIMAL(18,2)
                    )
                END";
                
                // Tạo bảng Phong
                string createPhongTable = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Phong')
                BEGIN
                    CREATE TABLE Phong (
                        MaPhong NVARCHAR(10) PRIMARY KEY,
                        MaLoai NVARCHAR(10),
                        TrangThai NVARCHAR(50),
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
                INSERT INTO LoaiPhong (MaLoai, TenLoai, GiaTien) VALUES
                ('LP001', N'Phòng đơn', 500000),
                ('LP002', N'Phòng đôi', 800000),
                ('LP003', N'Phòng VIP', 1500000)";
                ExecuteNonQuery(connection, insertLoaiPhong);
                
                // Thêm phòng mẫu
                string insertPhong = @"
                INSERT INTO Phong (MaPhong, MaLoai, TrangThai, GhiChu) VALUES
                ('P101', 'LP001', N'trong', N''),
                ('P102', 'LP001', N'trong', N''),
                ('P201', 'LP002', N'trong', N''),
                ('P301', 'LP003', N'trong', N'View biển')";
                ExecuteNonQuery(connection, insertPhong);
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
                MessageBox.Show("Lỗi khởi tạo database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Biến lưu thông tin nhân viên đăng nhập
        private string currentEmployeeCode = "";
        private string currentEmployeeName = "";
        private string currentEmployeePosition = "";
        
        // Xử lý đăng nhập
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
                    string query = "SELECT MaNV, Ho, Ten, ChucVu FROM NhanVien WHERE Email = @Email AND MatKhau = @Password";
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
        
        // Load dữ liệu nhân viên
        private void LoadEmployeesData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaNV, Ho, Ten, GioiTinh, NgaySinh, ChucVu, Email FROM NhanVien";
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
        
        // Load dữ liệu khách hàng
        private void LoadCustomersData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KhachHang";
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
        
        // Load dữ liệu phòng
        private void LoadRoomsData()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT P.MaPhong, L.TenLoai, P.TrangThai, P.GhiChu, L.GiaTien
                                    FROM Phong P 
                                    INNER JOIN LoaiPhong L ON P.MaLoai = L.MaLoai";
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
        
        // Load dữ liệu đặt phòng
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
                                    INNER JOIN NhanVien N ON D.MaNV = N.MaNV";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBookings.DataSource = dt;
                    
                    // Load khách hàng vào ComboBox
                    string queryKH = "SELECT MaKH, HoTen FROM KhachHang";
                    SqlDataAdapter adapterKH = new SqlDataAdapter(queryKH, connection);
                    DataTable dtKH = new DataTable();
                    adapterKH.Fill(dtKH);
                    cmbCustomer.DataSource = dtKH;
                    cmbCustomer.DisplayMember = "HoTen";
                    cmbCustomer.ValueMember = "MaKH";
                    
                    // Load phòng trống vào ComboBox
                    string queryPhong = "SELECT MaPhong FROM Phong WHERE TrangThai = N'trong'";
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
    }
}