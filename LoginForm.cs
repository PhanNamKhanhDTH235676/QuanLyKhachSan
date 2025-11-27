using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
        public event EventHandler<LoginSuccessEventArgs> LoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                        string employeeCode = reader["MaNV"].ToString();
                        string employeeName = reader["Ho"].ToString() + " " + reader["Ten"].ToString();
                        string employeePosition = reader["ChucVu"].ToString();
                        reader.Close();

                        LoginSuccess?.Invoke(this, new LoginSuccessEventArgs 
                        { 
                            EmployeeCode = employeeCode,
                            EmployeeName = employeeName,
                            EmployeePosition = employeePosition
                        });
                        
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        public void ClearFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }
    }

    public class LoginSuccessEventArgs : EventArgs
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
    }
}