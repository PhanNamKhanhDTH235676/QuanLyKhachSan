using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class RoomTypeForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private bool isEditing = false;
        private string currentEditingId = "";

        public RoomTypeForm()
        {
            InitializeComponent();
        }

        public void LoadRoomTypesData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaLoai, TenLoai, GiaTien, MoTa FROM LoaiPhong ORDER BY MaLoai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRoomTypes.DataSource = dt;

                    // Format cột giá tiền
                    if (dgvRoomTypes.Columns["GiaTien"] != null)
                    {
                        dgvRoomTypes.Columns["GiaTien"].DefaultCellStyle.Format = "N0";
                        dgvRoomTypes.Columns["GiaTien"].HeaderText = "Giá tiền (VNĐ)";
                    }
                    if (dgvRoomTypes.Columns["MaLoai"] != null)
                        dgvRoomTypes.Columns["MaLoai"].HeaderText = "Mã loại";
                    if (dgvRoomTypes.Columns["TenLoai"] != null)
                        dgvRoomTypes.Columns["TenLoai"].HeaderText = "Tên loại";
                    if (dgvRoomTypes.Columns["MoTa"] != null)
                        dgvRoomTypes.Columns["MoTa"].HeaderText = "Mô tả";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateButtonAccess(bool isManager)
        {
            btnAddRoomType.Enabled = isManager;
            btnEditRoomType.Enabled = isManager;
            btnDeleteRoomType.Enabled = isManager;
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomTypeCode.Text) || string.IsNullOrEmpty(txtRoomTypeName.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate giá tiền
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra mã loại đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM LoaiPhong WHERE MaLoai = @MaLoai";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaLoai", txtRoomTypeCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã loại phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm loại phòng mới
                    string insertQuery = @"
                    INSERT INTO LoaiPhong (MaLoai, TenLoai, GiaTien, MoTa) 
                    VALUES (@MaLoai, @TenLoai, @GiaTien, @MoTa)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaLoai", txtRoomTypeCode.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", txtRoomTypeName.Text);
                    cmd.Parameters.AddWithValue("@GiaTien", price);
                    cmd.Parameters.AddWithValue("@MoTa", txtDescription.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomTypesData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditRoomType_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvRoomTypes.SelectedRows[0];
            txtRoomTypeCode.Text = row.Cells["MaLoai"].Value.ToString();
            txtRoomTypeCode.Enabled = false;
            txtRoomTypeName.Text = row.Cells["TenLoai"].Value.ToString();
            txtPrice.Text = row.Cells["GiaTien"].Value.ToString();
            txtDescription.Text = row.Cells["MoTa"].Value?.ToString() ?? "";

            isEditing = true;
            currentEditingId = txtRoomTypeCode.Text;
        }

        private void btnSaveRoomType_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                MessageBox.Show("Vui lòng chọn chế độ sửa trước khi lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate giá tiền
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Giá tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE LoaiPhong SET TenLoai = @TenLoai, GiaTien = @GiaTien, MoTa = @MoTa 
                                   WHERE MaLoai = @MaLoai";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TenLoai", txtRoomTypeName.Text);
                    cmd.Parameters.AddWithValue("@GiaTien", price);
                    cmd.Parameters.AddWithValue("@MoTa", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", currentEditingId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomTypesData();
                    ClearForm();
                    isEditing = false;
                    currentEditingId = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {
            if (dgvRoomTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvRoomTypes.SelectedRows[0];
            string maLoai = row.Cells["MaLoai"].Value.ToString();

            // Kiểm tra xem loại phòng có đang được sử dụng không
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Phong WHERE MaLoai = @MaLoai";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaLoai", maLoai);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Không thể xóa loại phòng đang được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa loại phòng {maLoai}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM LoaiPhong WHERE MaLoai = @MaLoai";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomTypesData();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshRoomTypes_Click(object sender, EventArgs e)
        {
            LoadRoomTypesData();
            ClearForm();
        }

        private void dgvRoomTypes_SelectionChanged(object sender, EventArgs e)
        {
            // Có thể giữ lại nếu muốn tự động load dữ liệu khi chọn row
        }

        private void ClearForm()
        {
            txtRoomTypeCode.Clear();
            txtRoomTypeCode.Enabled = true;
            txtRoomTypeName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            isEditing = false;
            currentEditingId = "";
        }
    }
}