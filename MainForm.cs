using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MainForm : Form
    {
        private string currentEmployeeCode = "";
        private string currentEmployeeName = "";
        private string currentEmployeePosition = "";

        public MainForm()
        {
            InitializeComponent();
            InitializeLoginTab();
            HideAllTabsExceptLogin();
        }

        private void InitializeLoginTab()
        {
            // Tạo UI Login trực tiếp trong tab
            Panel loginPanel = new Panel();
            loginPanel.BackColor = System.Drawing.Color.White;
            loginPanel.Dock = DockStyle.Fill;
            
            Label lblTitle = new Label();
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            lblTitle.Location = new System.Drawing.Point(300, 80);
            lblTitle.Size = new System.Drawing.Size(370, 50);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new System.Drawing.Point(300, 150);
            lblEmail.Size = new System.Drawing.Size(100, 20);
            
            TextBox txtEmail = new TextBox();
            txtEmail.Location = new System.Drawing.Point(400, 150);
            txtEmail.Size = new System.Drawing.Size(250, 20);
            txtEmail.Name = "txtLoginEmail";
            
            Label lblPassword = new Label();
            lblPassword.Text = "Mật khẩu:";
            lblPassword.Location = new System.Drawing.Point(300, 190);
            lblPassword.Size = new System.Drawing.Size(100, 20);
            
            TextBox txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(400, 190);
            txtPassword.Size = new System.Drawing.Size(250, 20);
            txtPassword.PasswordChar = '*';
            txtPassword.Name = "txtLoginPassword";
            
            Button btnLogin = new Button();
            btnLogin.Text = "Đăng nhập";
            btnLogin.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new System.Drawing.Point(400, 240);
            btnLogin.Size = new System.Drawing.Size(120, 35);
            
            Label lblHint = new Label();
            lblHint.Text = "Tài khoản mặc định: admin@khachsan.com / admin123";
            lblHint.ForeColor = System.Drawing.Color.Gray;
            lblHint.Location = new System.Drawing.Point(300, 290);
            lblHint.Size = new System.Drawing.Size(400, 20);
            
            // Xử lý sự kiện đăng nhập
            btnLogin.Click += (sender, e) =>
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT MaNV, Ho, Ten, ChucVu FROM NhanVien WHERE Email = @Email AND MatKhau = @Password AND TrangThai = 'active'";
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        
                        System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
                        
                        if (reader.Read())
                        {
                            currentEmployeeCode = reader["MaNV"].ToString();
                            currentEmployeeName = reader["Ho"].ToString() + " " + reader["Ten"].ToString();
                            currentEmployeePosition = reader["ChucVu"].ToString();
                            reader.Close();

                            lblUserInfo.Text = $"Nhân viên: {currentEmployeeName} ({currentEmployeePosition})";
                            lblCurrentEmployee.Text = currentEmployeeCode;
                            panelUserInfo.Visible = true;
                            
                            ShowAllTabs();
                            LoadAllData();
                            UpdateButtonAccess();
                            
                            tabControl1.SelectedTab = tabEmployees;
                            
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
            };
            
            // Thêm các control vào panel
            loginPanel.Controls.Add(lblTitle);
            loginPanel.Controls.Add(lblEmail);
            loginPanel.Controls.Add(txtEmail);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(lblHint);
            
            tabLogin.Controls.Add(loginPanel);
        }

        private void HideAllTabsExceptLogin()
        {
            for (int i = 1; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.TabPages[i].Parent = null;
            }
        }

        private void ShowAllTabs()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabLogin);
            tabControl1.TabPages.Add(tabEmployees);
            tabControl1.TabPages.Add(tabCustomers);
            tabControl1.TabPages.Add(tabRoomTypes);
            tabControl1.TabPages.Add(tabRooms);
            tabControl1.TabPages.Add(tabBookings);
            tabControl1.TabPages.Add(tabPayment);
        }

        private void LoadAllData()
        {
            // Load dữ liệu cho các form con
            employeeForm.LoadEmployeesData();
            customerForm.LoadCustomersData();
            roomTypeForm.LoadRoomTypesData();
            roomForm.LoadRoomsData();
            
            // Truyền mã nhân viên cho BookingForm
            bookingForm.CurrentEmployeeCode = currentEmployeeCode;
            bookingForm.LoadBookingsData();

            // Load dữ liệu thanh toán
            paymentForm.LoadPaymentData();
        }

        private void UpdateButtonAccess()
        {
            bool isManager = currentEmployeePosition == "truong phong";
            employeeForm.UpdateButtonAccess(isManager);
            roomTypeForm.UpdateButtonAccess(isManager);
            roomForm.UpdateButtonAccess(isManager);
        }

        private void btnLogoutMain_Click(object sender, EventArgs e)
        {
            currentEmployeeCode = "";
            currentEmployeeName = "";
            currentEmployeePosition = "";
            
            lblUserInfo.Text = "";
            lblCurrentEmployee.Text = "";
            panelUserInfo.Visible = false;
            
            HideAllTabsExceptLogin();
            tabControl1.SelectedTab = tabLogin;
            
            // Clear login fields
            foreach (Control ctrl in tabLogin.Controls)
            {
                if (ctrl is Panel)
                {
                    foreach (Control innerCtrl in ctrl.Controls)
                    {
                        if (innerCtrl is TextBox)
                        {
                            innerCtrl.Text = "";
                        }
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh data when switching tabs
            if (tabControl1.SelectedTab == tabEmployees)
            {
                employeeForm.LoadEmployeesData();
            }
            else if (tabControl1.SelectedTab == tabCustomers)
            {
                customerForm.LoadCustomersData();
            }
            else if (tabControl1.SelectedTab == tabRoomTypes)
            {
                roomTypeForm.LoadRoomTypesData();
            }
            else if (tabControl1.SelectedTab == tabRooms)
            {
                roomForm.LoadRoomsData();
            }
            else if (tabControl1.SelectedTab == tabBookings)
            {
                bookingForm.LoadBookingsData();
            }
            else if (tabControl1.SelectedTab == tabPayment)
            {
                paymentForm.LoadPaymentData();
            }
        }
    }
}