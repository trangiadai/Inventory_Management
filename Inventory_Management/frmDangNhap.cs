using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "admin") && (this.txtPass.Text == "123"))
            {
                this.DialogResult = DialogResult.OK; // Đánh dấu thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu!", "Thông báo");
                this.txtUser.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.txtUser.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đánh dấu hủy
            this.Close();
        }
    }
}
