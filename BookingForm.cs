using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class BookingForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private bool isEditing = false;
        private string currentEditingId = "";

        public string CurrentEmployeeCode { get; set; }

        public BookingForm()
        {
            InitializeComponent();
        }

        public void LoadBookingsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    cmd.Parameters.AddWithValue("@MaNV", CurrentEmployeeCode);
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
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
            // Có thể giữ lại nếu muốn tự động load dữ liệu khi chọn row
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
    }
}