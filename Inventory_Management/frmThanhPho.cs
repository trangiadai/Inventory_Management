using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management
{
    public partial class frmThanhPho : Form
    {
        // Chuỗi kết nối 
        string strConnectionString = "Data Source=DESKTOP-2DJMJB9;Initial Catalog=inventory_management_db;Integrated Security = True";
        // Đối tượng kết nối 
        SqlConnection conn = null;

        // Đối tượng đưa dữ liệu vào DataTable dtThanhPho 
        SqlDataAdapter daThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtThanhPho = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;

        public frmThanhPho()
        {
            InitializeComponent();
        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                // Khởi động connection 
                conn = new SqlConnection(strConnectionString);

                // Vận chuyển dữ liệu vào DataTable dtThanhPho 
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                // Đưa dữ liệu lên DataGridView 
                dgvTHANHPHO.DataSource = dtThanhPho;

                // Xóa trống các đối tượng trong Panel 
                this.txtThanhPho.ResetText();
                this.txtTenThanhPho.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnThoat.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!! " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;

            // Xóa trống các đối tượng trong Panel 
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaNV
            this.txtThanhPho.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;

            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;

            // Thứ tự dòng hiện hành 
            int r = dgvTHANHPHO.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtThanhPho.Text =
            dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text =
            dgvTHANHPHO.Rows[r].Cells[1].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtThanhPho           
            this.txtThanhPho.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối 
            conn.Open();
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    // Lệnh Insert InTo 
                    cmd.CommandText = "Insert Into ThanhPho Values('" +
                        this.txtThanhPho.Text + "', N'" + 
                        this.txtTenThanhPho.Text + "')";

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    // Load lại dữ liệu trên DataGridView 
                    LoadData();

                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi! " + ex.Message);
                }
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    // Thứ tự dòng hiện hành 
                    int r = dgvTHANHPHO.CurrentCell.RowIndex;
                    // ThanhPho hiện hành 
                    string strThanhPho =
                    dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();

                    // Câu lệnh SQL 
                    cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho= N'" + 
                        this.txtTenThanhPho.Text.ToString() + "' Where ThanhPho = '" + strThanhPho + "'");

                    // Cập nhật 
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView

                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!" + ex.Message);
                }
            }
            // Đóng kết nối 
            conn.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
      
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối 
            conn.Open();

            try
            {
                // Thực hiện lệnh 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                // Lấy thứ tự record hiện hành 
                int r = dgvTHANHPHO.CurrentCell.RowIndex;
                // Lấy ThanhPho của record hiện hành 
                string strThanhPho =
                dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();

                // Viết câu lệnh SQL 
                cmd.CommandText = System.String.Concat("Delete From ThanhPho Where ThanhPho = '" + strThanhPho + "'");
                cmd.CommandType = CommandType.Text;

                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();

                // Cập nhật lại DataGridView 
                LoadData();

                // Thông báo 
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!" + ex.Message);
            }
            // Đóng kết nối 
            conn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn muốn thoát toàn bộ chương trình?", "Xác nhận",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                // Thoát ngay lập tức và hủy mọi Form đang ẩn
                Environment.Exit(0);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự không phải là số và không phải là phím xóa (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự đó lại, không cho hiện lên TextBox
            }
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap fNCC = new frmNhaCungCap();

            // 1. Ẩn form hiện tại
            this.Hide();

            // 2. Mở form con (Chương trình dừng tại đây đợi fNCC đóng)
            fNCC.ShowDialog();

            // 3. Khi fNCC đóng (do bấm X), code chạy đến đây:
            // Kiểm tra nếu Form chính chưa bị hủy thì mới hiện lại
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien fNV = new frmNhanVien();
            this.Hide();
            fNV.ShowDialog();
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            frmSanPham fSP = new frmSanPham();
            this.Hide();
            fSP.ShowDialog();
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }
    }
}
