namespace Inventory_Management
{
    partial class frmNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNHACUNGCAP = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhPho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTenCty = new System.Windows.Forms.Label();
            this.labelMaNCC = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCty = new System.Windows.Forms.TextBox();
            this.cbThanhPho = new System.Windows.Forms.ComboBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.btnQLTP = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHACUNGCAP)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNHACUNGCAP
            // 
            this.dgvNHACUNGCAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNHACUNGCAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenCty,
            this.DiaChi,
            this.ThanhPho,
            this.DienThoai});
            this.dgvNHACUNGCAP.Location = new System.Drawing.Point(12, 216);
            this.dgvNHACUNGCAP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNHACUNGCAP.Name = "dgvNHACUNGCAP";
            this.dgvNHACUNGCAP.ReadOnly = true;
            this.dgvNHACUNGCAP.RowHeadersWidth = 51;
            this.dgvNHACUNGCAP.RowTemplate.Height = 24;
            this.dgvNHACUNGCAP.Size = new System.Drawing.Size(1226, 230);
            this.dgvNHACUNGCAP.TabIndex = 0;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 130;
            // 
            // TenCty
            // 
            this.TenCty.DataPropertyName = "TenCty";
            this.TenCty.HeaderText = "Tên Cty";
            this.TenCty.MinimumWidth = 6;
            this.TenCty.Name = "TenCty";
            this.TenCty.ReadOnly = true;
            this.TenCty.Width = 280;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 397;
            // 
            // ThanhPho
            // 
            this.ThanhPho.DataPropertyName = "ThanhPho";
            this.ThanhPho.HeaderText = "Thành Phố";
            this.ThanhPho.MinimumWidth = 6;
            this.ThanhPho.Name = "ThanhPho";
            this.ThanhPho.ReadOnly = true;
            this.ThanhPho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThanhPho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ThanhPho.Width = 185;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 180;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 463);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(95, 47);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 528);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 47);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(185, 463);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 47);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(185, 528);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 47);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(355, 463);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 47);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(355, 528);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 47);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1133, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.labelTenCty);
            this.panel.Controls.Add(this.labelMaNCC);
            this.panel.Controls.Add(this.txtDienThoai);
            this.panel.Controls.Add(this.txtDiaChi);
            this.panel.Controls.Add(this.txtTenCty);
            this.panel.Controls.Add(this.cbThanhPho);
            this.panel.Controls.Add(this.txtMaNCC);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1226, 197);
            this.panel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(905, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Thành Phố:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa Chỉ:";
            // 
            // labelTenCty
            // 
            this.labelTenCty.AutoSize = true;
            this.labelTenCty.Location = new System.Drawing.Point(40, 129);
            this.labelTenCty.Name = "labelTenCty";
            this.labelTenCty.Size = new System.Drawing.Size(73, 20);
            this.labelTenCty.TabIndex = 10;
            this.labelTenCty.Text = "Tên Cty:";
            // 
            // labelMaNCC
            // 
            this.labelMaNCC.AutoSize = true;
            this.labelMaNCC.Location = new System.Drawing.Point(40, 42);
            this.labelMaNCC.Name = "labelMaNCC";
            this.labelMaNCC.Size = new System.Drawing.Size(79, 20);
            this.labelMaNCC.TabIndex = 9;
            this.labelMaNCC.Text = "Mã NCC:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(561, 121);
            this.txtDienThoai.MaxLength = 10;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(241, 28);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(561, 34);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(291, 28);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtTenCty
            // 
            this.txtTenCty.Location = new System.Drawing.Point(125, 121);
            this.txtTenCty.Name = "txtTenCty";
            this.txtTenCty.Size = new System.Drawing.Size(247, 28);
            this.txtTenCty.TabIndex = 2;
            // 
            // cbThanhPho
            // 
            this.cbThanhPho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThanhPho.FormattingEnabled = true;
            this.cbThanhPho.Location = new System.Drawing.Point(1018, 34);
            this.cbThanhPho.Name = "cbThanhPho";
            this.cbThanhPho.Size = new System.Drawing.Size(176, 28);
            this.cbThanhPho.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(125, 34);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(175, 28);
            this.txtMaNCC.TabIndex = 0;
            // 
            // btnQLTP
            // 
            this.btnQLTP.Location = new System.Drawing.Point(769, 465);
            this.btnQLTP.Name = "btnQLTP";
            this.btnQLTP.Size = new System.Drawing.Size(135, 85);
            this.btnQLTP.TabIndex = 14;
            this.btnQLTP.Text = "Quản Lý \r\nDanh Sách \r\nThành Phố";
            this.btnQLTP.UseVisualStyleBackColor = true;
            this.btnQLTP.Click += new System.EventHandler(this.btnQLTP_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Location = new System.Drawing.Point(588, 523);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(134, 52);
            this.btnQLSP.TabIndex = 13;
            this.btnQLSP.Text = "Quản Lý\r\nSản Phẩm\r\n";
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(588, 454);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(134, 53);
            this.btnQLNV.TabIndex = 12;
            this.btnQLNV.Text = "Quán Lý\r\nNhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 587);
            this.Controls.Add(this.btnQLTP);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvNHACUNGCAP);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHACUNGCAP)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNHACUNGCAP;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbThanhPho;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTenCty;
        private System.Windows.Forms.Label labelMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn ThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.Button btnQLTP;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Button btnQLNV;
    }
}