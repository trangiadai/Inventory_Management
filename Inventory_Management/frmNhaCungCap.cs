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
    public partial class frmNhaCungCap : Form
    {
        // Chuỗi kết nối 
        string strConnectionString = "Data Source=DESKTOP-2DJMJB9;Initial Catalog=inventory_management_db;Integrated Security = True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtNhaCungCap 
        SqlDataAdapter daNhaCungCap = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtNhaCungCap = null;

        // Đối tượng đưa dữ liệu vào DataTable dtThanhPho 
        SqlDataAdapter daThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtThanhPho = null;

        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
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

                // Đưa dữ liệu lên ComboBox trong DataGridView  
                (dgvNHACUNGCAP.Columns["ThanhPho"] as
                    DataGridViewComboBoxColumn).DataSource = dtThanhPho;
                (dgvNHACUNGCAP.Columns["ThanhPho"] as
                    DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho"; //thông tin hiện ra trên List để người dùng chọn
                (dgvNHACUNGCAP.Columns["ThanhPho"] as
                    DataGridViewComboBoxColumn).ValueMember = "ThanhPho"; //thông tin sẽ lưu vào DB dựa vào giá trị mà người dùng đã chọn

                // Vận chuyển dữ liệu vào DataTable dtNhaCungCap 
                daNhaCungCap = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", conn);
                dtNhaCungCap = new DataTable();
                dtNhaCungCap.Clear();
                daNhaCungCap.Fill(dtNhaCungCap);
                // Đưa dữ liệu lên DataGridView 
                dgvNHACUNGCAP.DataSource = dtNhaCungCap;

                // Xóa trống các đối tượng trong Panel 
                this.txtMaNCC.ResetText();
                this.txtTenCty.ResetText();
                this.txtDiaChi.ResetText();
                //XÓA TRỐNG COMBOBOX
                this.cbThanhPho.SelectedIndex = -1;
                this.txtDienThoai.ResetText();

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
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHACUNGCAP. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;

            // Xóa trống các đối tượng trong Panel 
            this.txtMaNCC.ResetText();
            this.txtTenCty.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            // Đưa dữ liệu lên ComboBox 
            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";

            // Đưa con trỏ đến TextField txtMaNCC
            this.txtMaNCC.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;

            // Đưa dữ liệu lên ComboBox 
            this.cbThanhPho.DataSource = dtThanhPho;
            this.cbThanhPho.DisplayMember = "TenThanhPho";
            this.cbThanhPho.ValueMember = "ThanhPho";

            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;

            // Thứ tự dòng hiện hành 
            int r = dgvNHACUNGCAP.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNCC.Text =
            dgvNHACUNGCAP.Rows[r].Cells[0].Value.ToString();
            this.txtTenCty.Text =
            dgvNHACUNGCAP.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            dgvNHACUNGCAP.Rows[r].Cells[2].Value.ToString();
            this.cbThanhPho.SelectedValue =
            dgvNHACUNGCAP.Rows[r].Cells[3].Value.ToString();
            this.txtDienThoai.Text =
            dgvNHACUNGCAP.Rows[r].Cells[4].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaNCC           
            this.txtMaNCC.Focus();
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
                    cmd.CommandText = "Insert Into NhaCungCap Values('" +
                        this.txtMaNCC.Text + "', N'" + // Thêm N cho Tên Công ty
                        this.txtTenCty.Text + "', N'" + // Thêm N cho Địa chỉ
                        this.txtDiaChi.Text + "','" +
                        this.cbThanhPho.SelectedValue.ToString() + "','" +
                        this.txtDienThoai.Text + "')";

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
                    int r = dgvNHACUNGCAP.CurrentCell.RowIndex;
                    // MaNCC hiện hành 
                    string strMANCC =
                    dgvNHACUNGCAP.Rows[r].Cells[0].Value.ToString();

                    // Câu lệnh SQL 
                    cmd.CommandText = System.String.Concat("Update NhaCungCap Set TenCty= N'" + // Thêm N cho Tên Cty
                        this.txtTenCty.Text.ToString() + "', DiaChi = N'" + // Thêm N cho Địa chỉ
                        this.txtDiaChi.Text.ToString() + "', ThanhPho = '" +
                        this.cbThanhPho.SelectedValue.ToString() + "', DienThoai = '" +
                        this.txtDienThoai.Text.ToString() + "' Where MaNCC = '" + strMANCC + "'");

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
            this.txtMaNCC.ResetText();
            this.txtTenCty.ResetText();
            this.txtDiaChi.ResetText();
            //XÓA TRỐNG COMBOBOX
            this.cbThanhPho.SelectedIndex = -1;
            this.txtDienThoai.ResetText();
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
                int r = dgvNHACUNGCAP.CurrentCell.RowIndex;
                // Lấy MaNCC của record hiện hành 
                string strMANCC =
                dgvNHACUNGCAP.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                cmd.CommandText = System.String.Concat("Delete From NhaCungCap Where MaNCC = '" + strMANCC + "'");
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

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmSanPham fSP = new frmSanPham();
            this.Hide();
            fSP.ShowDialog();
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void btnQLTP_Click(object sender, EventArgs e)
        {
            frmThanhPho fTP = new frmThanhPho();
            this.Hide();
            fTP.ShowDialog();
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }
    }
}
