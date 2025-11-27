using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class CustomerForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private bool isEditing = false;
        private string currentEditingId = "";

        public CustomerForm()
        {
            InitializeComponent();
        }

        public void LoadCustomersData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomersData();
                        ClearCustomerForm();
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
            // Có thể giữ lại nếu muốn tự động load dữ liệu khi chọn row
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
    }
}