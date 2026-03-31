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
    public partial class frmSanPham : Form
    {
        // Chuỗi kết nối 
        string strConnectionString = "Data Source=DESKTOP-2DJMJB9;Initial Catalog=inventory_management_db;Integrated Security = True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtSanPham 
        SqlDataAdapter daSanPham = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtSanPham = null;

        // Đối tượng đưa dữ liệu vào DataTable dtNhaCungCap 
        SqlDataAdapter daNhaCungCap = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtNhaCungCap = null;

        // Đối tượng đưa dữ liệu vào DataTable dtNhanVien 
        SqlDataAdapter daNhanVien = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtNhanVien = null;

        // Đối tượng đưa dữ liệu vào DataTable dtThanhPho 
        SqlDataAdapter daThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtThanhPho = null;


        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
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

                // Vận chuyển dữ liệu vào DataTable dtNhaCungCap 
                daNhaCungCap = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", conn);
                dtNhaCungCap = new DataTable();
                dtNhaCungCap.Clear();
                daNhaCungCap.Fill(dtNhaCungCap);
                // Đưa dữ liệu lên ComboBox trong DataGridView  
                (dgvSANPHAM.Columns["NhaCungCap"] as
                    DataGridViewComboBoxColumn).DataSource = dtNhaCungCap;
                (dgvSANPHAM.Columns["NhaCungCap"] as
                    DataGridViewComboBoxColumn).DisplayMember = "TenCty";
                (dgvSANPHAM.Columns["NhaCungCap"] as
                    DataGridViewComboBoxColumn).ValueMember = "MaNCC";

                // Vận chuyển dữ liệu vào DataTable dtNhanVien 
                daNhanVien = new SqlDataAdapter("SELECT * FROM NHANVIEN", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);

                // Đưa dữ liệu lên ComboBox trong DataGridView  
                (dgvSANPHAM.Columns["NhanVienNhap"] as
                    DataGridViewComboBoxColumn).DataSource = dtNhanVien;
                (dgvSANPHAM.Columns["NhanVienNhap"] as
                    DataGridViewComboBoxColumn).DisplayMember = "HoTen"; //thông tin hiện ra trên List để người dùng chọn
                (dgvSANPHAM.Columns["NhanVienNhap"] as
                    DataGridViewComboBoxColumn).ValueMember = "MaNV"; //thông tin sẽ lưu vào DB dựa vào giá trị mà người dùng đã chọn

                // Vận chuyển dữ liệu vào DataTable dtSanPham 
                daSanPham = new SqlDataAdapter("SELECT * FROM SANPHAM", conn);
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                daSanPham.Fill(dtSanPham);
                // Đưa dữ liệu lên DataGridView 
                dgvSANPHAM.DataSource = dtSanPham;

                // Xóa trống các đối tượng trong Panel 
                this.txtMaSP.ResetText();
                this.txtTenSP.ResetText();
                this.txtSoLuong.ResetText();
                this.txtDonVi.ResetText();
                this.txtGiaNhap.ResetText();
                this.txtInputDate.ResetText();
                //XÓA TRỐNG COMBOBOX
                this.cbNhaCungCap.SelectedIndex = -1;
                this.cbNhanVien.SelectedIndex = -1;
                this.txtMoTa.ResetText();

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
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM.Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;

            // Xóa trống các đối tượng trong Panel 
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtSoLuong.ResetText();
            this.txtDonVi.ResetText();
            this.txtGiaNhap.ResetText();
            this.txtInputDate.ResetText();
            this.txtMoTa.ResetText();

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
            this.cbNhaCungCap.DataSource = dtNhaCungCap;
            this.cbNhaCungCap.DisplayMember = "TenCty";
            this.cbNhaCungCap.ValueMember = "MaNCC";

            
            this.cbNhanVien.DataSource = dtNhanVien;
            this.cbNhanVien.DisplayMember = "HoTen";
            this.cbNhanVien.ValueMember = "MaNV";

            // Đưa con trỏ đến TextField txtMaKH 
            this.txtMaSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;

            // Đưa dữ liệu lên ComboBox 
            this.cbNhaCungCap.DataSource = dtNhaCungCap;
            this.cbNhaCungCap.DisplayMember = "TenCty";
            this.cbNhaCungCap.ValueMember = "MaNCC";

            //// Đưa dữ liệu lên ComboBox 
            this.cbNhanVien.DataSource = dtNhanVien;
            this.cbNhanVien.DisplayMember = "HoTen";
            this.cbNhanVien.ValueMember = "MaNV";

            // Cho phép thao tác trên Panel 
            this.panel.Enabled = true;

            // Thứ tự dòng hiện hành 
            int r = dgvSANPHAM.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaSP.Text =
            dgvSANPHAM.Rows[r].Cells[0].Value.ToString();
            this.txtTenSP.Text =
            dgvSANPHAM.Rows[r].Cells[1].Value.ToString();
            this.txtSoLuong.Text =
            dgvSANPHAM.Rows[r].Cells[2].Value.ToString();
            this.txtDonVi.Text =
            dgvSANPHAM.Rows[r].Cells[3].Value.ToString();
            this.txtGiaNhap.Text =
            dgvSANPHAM.Rows[r].Cells[4].Value.ToString();
            this.txtInputDate.Text =
            dgvSANPHAM.Rows[r].Cells[5].Value.ToString();
            this.cbNhaCungCap.SelectedValue =
            dgvSANPHAM.Rows[r].Cells[6].Value.ToString();
            this.cbNhanVien.SelectedValue =
            dgvSANPHAM.Rows[r].Cells[7].Value.ToString();
            this.txtMoTa.Text =
            dgvSANPHAM.Rows[r].Cells[8].Value.ToString();

            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnThoat.Enabled = false;

            // Đưa con trỏ đến TextField txtMaSP            
            this.txtMaSP.Focus();
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
                    cmd.CommandText = "Insert Into SanPham Values('" +
                    this.txtMaSP.Text.Trim() + "', N'" + 
                    this.txtTenSP.Text.Trim() + "', " +
                    this.txtSoLuong.Text.Trim() + ", N'" + 
                    this.txtDonVi.Text.Trim() + "', " +
                    this.txtGiaNhap.Text.Trim() + ", '" +
                    this.txtInputDate.Text.Trim() + "', '" +
                    this.cbNhaCungCap.SelectedValue.ToString() + "', '" +
                    this.cbNhanVien.SelectedValue.ToString() + "', N'" + // Thêm N cho Mô tả
                    this.txtMoTa.Text.Trim() + "')";

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
                    int r = dgvSANPHAM.CurrentCell.RowIndex;
                    // MaSP hiện hành 
                    string strMASP =
                    dgvSANPHAM.Rows[r].Cells[0].Value.ToString();

                    // Câu lệnh SQL 
                    cmd.CommandText = "Update SanPham Set TenSP = N'" +
                     this.txtTenSP.Text.Trim() + "', SoLuong = " + 
                     this.txtSoLuong.Text.Trim() + ", DonViTinh = N'" + // Thêm N
                     this.txtDonVi.Text.Trim() + "', GiaNhap = " +
                     this.txtGiaNhap.Text.Trim() + ", NgayCapNhat = '" +
                     this.txtInputDate.Text.Trim() + "', MaNCC = '" +
                     this.cbNhaCungCap.SelectedValue.ToString() + "', MaNVNhap = '" +
                     this.cbNhanVien.SelectedValue.ToString() + "', MoTa = N'" + // Thêm N
                     this.txtMoTa.Text.Trim() + "' Where MaSP = '" + strMASP + "'";

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
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtSoLuong.ResetText();
            this.txtDonVi.ResetText();
            this.txtGiaNhap.ResetText();
            this.txtInputDate.ResetText();
            //XÓA TRỐNG COMBOBOX
            this.cbNhaCungCap.SelectedIndex = -1;
            this.cbNhanVien.SelectedIndex = -1;
            this.txtMoTa.ResetText();
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
                int r = dgvSANPHAM.CurrentCell.RowIndex;
                // Lấy MaSP của record hiện hành 
                string strMASP =
                dgvSANPHAM.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                cmd.CommandText = System.String.Concat("Delete From SanPham Where MaSP = '" + strMASP + "'");
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

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự không phải là số và không phải là phím xóa (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự đó lại, không cho hiện lên TextBox
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Cho phép các ký tự điều khiển (như Backspace, Ctrl+C, Ctrl+V)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            // 2. Cho phép nhập số
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            
            // 3. Cho phép nhập duy nhất một dấu chấm thập phân (.)
            if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                return;
            }

            // 4. Nếu không rơi vào các trường hợp trên thì chặn lại (không hiện lên TextBox)
            e.Handled = true;

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
