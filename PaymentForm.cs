using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class PaymentForm : UserControl
    {
        private string connectionString = "Server=localhost;Database=QuanLyKhachSan2;User Id=sa;Password=123;";

        public PaymentForm()
        {
            InitializeComponent();
            LoadPaymentData();
            LoadBookingComboBox();
        }

        private void LoadBookingComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT D.MaDat, K.HoTen, P.MaPhong, D.NgayDat, D.NgayTra, L.GiaTien
                                    FROM DatPhong D
                                    INNER JOIN KhachHang K ON D.MaKH = K.MaKH
                                    INNER JOIN Phong P ON D.MaPhong = P.MaPhong
                                    INNER JOIN LoaiPhong L ON P.MaLoai = L.MaLoai
                                    WHERE D.TrangThai = 'active'
                                    AND D.MaDat NOT IN (SELECT MaDat FROM ThanhToan)
                                    ORDER BY D.NgayDat DESC";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    cmbBookingCode.DataSource = dt;
                    cmbBookingCode.DisplayMember = "MaDat";
                    cmbBookingCode.ValueMember = "MaDat";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load danh sách đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadPaymentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT T.MaThanhToan, T.MaDat, K.HoTen, L.TenLoai, 
                                           D.NgayDat, D.NgayTra, T.TongTien, T.NgayThanhToan, T.GhiChu
                                    FROM ThanhToan T
                                    INNER JOIN DatPhong D ON T.MaDat = D.MaDat
                                    INNER JOIN KhachHang K ON D.MaKH = K.MaKH
                                    INNER JOIN Phong P ON D.MaPhong = P.MaPhong
                                    INNER JOIN LoaiPhong L ON P.MaLoai = L.MaLoai
                                    ORDER BY T.NgayThanhToan DESC";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayment.DataSource = dt;

                    // Format cột tiền
                    if (dgvPayment.Columns["TongTien"] != null)
                    {
                        dgvPayment.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                        dgvPayment.Columns["TongTien"].HeaderText = "Tổng tiền (VNĐ)";
                    }

                    // Đặt tên cột
                    if (dgvPayment.Columns["MaThanhToan"] != null)
                        dgvPayment.Columns["MaThanhToan"].HeaderText = "Mã TT";
                    if (dgvPayment.Columns["MaDat"] != null)
                        dgvPayment.Columns["MaDat"].HeaderText = "Mã đặt";
                    if (dgvPayment.Columns["HoTen"] != null)
                        dgvPayment.Columns["HoTen"].HeaderText = "Khách hàng";
                    if (dgvPayment.Columns["TenLoai"] != null)
                        dgvPayment.Columns["TenLoai"].HeaderText = "Loại phòng";
                    if (dgvPayment.Columns["NgayDat"] != null)
                        dgvPayment.Columns["NgayDat"].HeaderText = "Ngày đặt";
                    if (dgvPayment.Columns["NgayTra"] != null)
                        dgvPayment.Columns["NgayTra"].HeaderText = "Ngày trả";
                    if (dgvPayment.Columns["NgayThanhToan"] != null)
                        dgvPayment.Columns["NgayThanhToan"].HeaderText = "Ngày thanh toán";
                    if (dgvPayment.Columns["GhiChu"] != null)
                        dgvPayment.Columns["GhiChu"].HeaderText = "Ghi chú";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbBookingCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBookingCode.SelectedValue == null || cmbBookingCode.SelectedIndex < 0)
                return;

            DataRowView drv = cmbBookingCode.SelectedItem as DataRowView;
            if (drv != null)
            {
                txtCustomerName.Text = drv["HoTen"].ToString();
                txtRoomCode.Text = drv["MaPhong"].ToString();
                
                DateTime ngayDat = Convert.ToDateTime(drv["NgayDat"]);
                DateTime ngayTra = Convert.ToDateTime(drv["NgayTra"]);
                
                txtCheckInDate.Text = ngayDat.ToString("dd/MM/yyyy");
                txtCheckOutDate.Text = ngayTra.ToString("dd/MM/yyyy");
                
                // Tính tổng tiền
                int soNgay = (ngayTra - ngayDat).Days;
                if (soNgay <= 0) soNgay = 1;
                
                decimal giaTien = Convert.ToDecimal(drv["GiaTien"]);
                decimal tongTien = soNgay * giaTien;
                
                txtTotalAmount.Text = tongTien.ToString("N0");
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentCode.Text) || cmbBookingCode.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra mã thanh toán đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM ThanhToan WHERE MaThanhToan = @MaThanhToan";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@MaThanhToan", txtPaymentCode.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã thanh toán đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thêm thanh toán mới
                    string insertQuery = @"
                    INSERT INTO ThanhToan (MaThanhToan, MaDat, TongTien, NgayThanhToan, GhiChu) 
                    VALUES (@MaThanhToan, @MaDat, @TongTien, @NgayThanhToan, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@MaThanhToan", txtPaymentCode.Text);
                    cmd.Parameters.AddWithValue("@MaDat", cmbBookingCode.SelectedValue);
                    cmd.Parameters.AddWithValue("@TongTien", decimal.Parse(txtTotalAmount.Text.Replace(",", "")));
                    cmd.Parameters.AddWithValue("@NgayThanhToan", dtpPaymentDate.Value);
                    cmd.Parameters.AddWithValue("@GhiChu", txtNote.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPaymentData();
                    LoadBookingComboBox();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thanh toán cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPayment.SelectedRows[0];
            string maThanhToan = row.Cells["MaThanhToan"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa thanh toán {maThanhToan}?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM ThanhToan WHERE MaThanhToan = @MaThanhToan";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaThanhToan", maThanhToan);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPaymentData();
                        LoadBookingComboBox();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshPayment_Click(object sender, EventArgs e)
        {
            LoadPaymentData();
            LoadBookingComboBox();
            ClearForm();
        }

        private void ClearForm()
        {
            txtPaymentCode.Clear();
            cmbBookingCode.SelectedIndex = -1;
            txtCustomerName.Clear();
            txtRoomCode.Clear();
            txtCheckInDate.Clear();
            txtCheckOutDate.Clear();
            txtTotalAmount.Clear();
            dtpPaymentDate.Value = DateTime.Now;
            txtNote.Clear();
        }
    }
}