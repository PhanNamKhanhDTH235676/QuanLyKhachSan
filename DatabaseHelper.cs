using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void InitializeDatabase()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
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
                            TrangThai NVARCHAR(50) DEFAULT N'trong',
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

                    // Tạo bảng ThanhToan
                    string createThanhToanTable = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ThanhToan')
                    BEGIN
                        CREATE TABLE ThanhToan (
                            MaThanhToan NVARCHAR(10) PRIMARY KEY,
                            MaDat NVARCHAR(10),
                            TongTien DECIMAL(18,2),
                            NgayThanhToan DATETIME DEFAULT GETDATE(),
                            GhiChu NVARCHAR(MAX),
                            FOREIGN KEY (MaDat) REFERENCES DatPhong(MaDat)
                        )
                    END";
                    
                    // Thực thi tạo bảng
                    ExecuteNonQuery(connection, createNhanVienTable);
                    ExecuteNonQuery(connection, createKhachHangTable);
                    ExecuteNonQuery(connection, createLoaiPhongTable);
                    ExecuteNonQuery(connection, createPhongTable);
                    ExecuteNonQuery(connection, createDatPhongTable);
                    ExecuteNonQuery(connection, createThanhToanTable);
                    
                    // Thêm dữ liệu mẫu
                    InsertSampleData(connection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khởi tạo database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
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
                    throw new Exception("Lỗi thực thi query: " + ex.Message);
                }
            }
        }
    }
}