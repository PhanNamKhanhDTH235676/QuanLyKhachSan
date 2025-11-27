using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Khởi tạo database
            DatabaseHelper dbHelper = new DatabaseHelper();
            try
            {
                dbHelper.InitializeDatabase();
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo database: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}