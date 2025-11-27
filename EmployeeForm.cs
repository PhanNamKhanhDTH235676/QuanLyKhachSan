using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class EmployeeForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        private bool isEditing = false;
        private string currentEditingId = "";

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public void LoadEmployeesData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        public void UpdateButtonAccess(bool isManager)
        {
            btnAddEmployee.Enabled = isManager;
            btnEditEmployee.Enabled = isManager;
            btnDeleteEmployee.Enabled = isManager;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeCode.Text) || string.IsNullOrEmpty(txtFirstName.Text) || 
                string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmailEmp.Text) || 
                string.IsNullOrEmpty(txtPasswordEmp.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvEmployees.SelectedRows[0];
            txtEmployeeCode.Text = row.Cells["MaNV"].Value.ToString();
            txtEmployeeCode.Enabled = false;
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
                    using (SqlConnection connection = new SqlConnection(connectionString))
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
            // Có thể giữ lại nếu muốn tự động load dữ liệu khi chọn row
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
    }
}