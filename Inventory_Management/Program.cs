using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
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

            frmDangNhap login = new frmDangNhap();
            // Hiện login dưới dạng Dialog
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Nếu nhấn nút Đăng nhập (OK) thì mới chạy Form chính
                Application.Run(new frmSanPham());
            }
            else
            {
                // Nếu nhấn Thoát (Cancel) hoặc đóng X, ứng dụng kết thúc
                Application.Exit();
            }
        }
    }
}
