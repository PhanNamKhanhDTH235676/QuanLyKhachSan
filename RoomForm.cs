using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class RoomForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private bool isEditing = false;
        private string currentEditingId = "";

        public RoomForm()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaLoai, TenLoai, GiaTien FROM LoaiPhong ORDER BY TenLoai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    cmbRoomType.DataSource = dt;
                    cmbRoomType.DisplayMember = "TenLoai";
                    cmbRoomType.ValueMember = "MaLoai";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load loại phòng: " + ex.Message);
                }
            }
        }

        public void LoadRoomsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

                    // Format cột giá tiền
                    if (dgvRooms.Columns["GiaTien"] != null)
                    {
                        dgvRooms.Columns["GiaTien"].DefaultCellStyle.Format = "N0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateButtonAccess(bool isManager)
        {
            btnAddRoom.Enabled = isManager;
            btnEditRoom.Enabled = isManager;
            btnDeleteRoom.Enabled = isManager;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomCode.Text) || cmbRoomType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsData();
                        ClearRoomForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchRoom.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT P.MaPhong, L.TenLoai, L.GiaTien, P.TrangThai, P.GhiChu 
                                    FROM Phong P 
                                    INNER JOIN LoaiPhong L ON P.MaLoai = L.MaLoai
                                    WHERE P.MaPhong LIKE @Keyword 
                                       OR L.TenLoai LIKE @Keyword 
                                       OR P.TrangThai LIKE @Keyword
                                    ORDER BY P.MaPhong";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRooms.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy phòng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshRooms_Click(object sender, EventArgs e)
        {
            LoadRoomsData();
            ClearRoomForm();
            txtSearchRoom.Clear();
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            // Có thể giữ lại nếu muốn tự động load dữ liệu khi chọn row
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị giá phòng khi chọn loại phòng
            if (cmbRoomType.SelectedValue != null && cmbRoomType.SelectedIndex >= 0)
            {
                DataRowView drv = cmbRoomType.SelectedItem as DataRowView;
                if (drv != null)
                {
                    decimal gia = Convert.ToDecimal(drv["GiaTien"]);
                    lblRoomPrice.Text = string.Format("{0:N0} VNĐ", gia);
                }
            }
        }

        private void ClearRoomForm()
        {
            txtRoomCode.Clear();
            txtRoomCode.Enabled = true;
            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            txtNote.Clear();
            lblRoomPrice.Text = "";
            isEditing = false;
            currentEditingId = "";
        }
    }
}