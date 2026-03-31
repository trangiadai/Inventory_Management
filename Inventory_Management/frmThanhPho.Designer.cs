namespace Inventory_Management
{
    partial class frmThanhPho
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
            this.dgvTHANHPHO = new System.Windows.Forms.DataGridView();
            this.ThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelThanhPho = new System.Windows.Forms.Label();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTHANHPHO
            // 
            this.dgvTHANHPHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANHPHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThanhPho,
            this.TenThanhPho});
            this.dgvTHANHPHO.Location = new System.Drawing.Point(12, 168);
            this.dgvTHANHPHO.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTHANHPHO.Name = "dgvTHANHPHO";
            this.dgvTHANHPHO.ReadOnly = true;
            this.dgvTHANHPHO.RowHeadersWidth = 51;
            this.dgvTHANHPHO.RowTemplate.Height = 24;
            this.dgvTHANHPHO.Size = new System.Drawing.Size(1340, 228);
            this.dgvTHANHPHO.TabIndex = 0;
            // 
            // ThanhPho
            // 
            this.ThanhPho.DataPropertyName = "ThanhPho";
            this.ThanhPho.HeaderText = "Mã TP";
            this.ThanhPho.MinimumWidth = 6;
            this.ThanhPho.Name = "ThanhPho";
            this.ThanhPho.ReadOnly = true;
            this.ThanhPho.Width = 400;
            // 
            // TenThanhPho
            // 
            this.TenThanhPho.DataPropertyName = "TenThanhPho";
            this.TenThanhPho.HeaderText = "Tên Thành Phố";
            this.TenThanhPho.MinimumWidth = 6;
            this.TenThanhPho.Name = "TenThanhPho";
            this.TenThanhPho.ReadOnly = true;
            this.TenThanhPho.Width = 887;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 432);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(93, 52);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 505);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 52);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 432);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 52);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(166, 505);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 52);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(353, 432);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 52);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(353, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 52);
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
            this.panel.Controls.Add(this.labelHoTen);
            this.panel.Controls.Add(this.labelThanhPho);
            this.panel.Controls.Add(this.txtTenThanhPho);
            this.panel.Controls.Add(this.txtThanhPho);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1340, 127);
            this.panel.TabIndex = 8;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(29, 81);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(128, 20);
            this.labelHoTen.TabIndex = 10;
            this.labelHoTen.Text = "Tên Thành Phố:";
            // 
            // labelThanhPho
            // 
            this.labelThanhPho.AutoSize = true;
            this.labelThanhPho.Location = new System.Drawing.Point(29, 23);
            this.labelThanhPho.Name = "labelThanhPho";
            this.labelThanhPho.Size = new System.Drawing.Size(123, 20);
            this.labelThanhPho.TabIndex = 9;
            this.labelThanhPho.Text = "Mã Thành Phố:";
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(172, 78);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(247, 28);
            this.txtTenThanhPho.TabIndex = 2;
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(172, 20);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(175, 28);
            this.txtThanhPho.TabIndex = 0;
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(770, 443);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(135, 85);
            this.btnSP.TabIndex = 14;
            this.btnSP.Text = "Quản Lý \r\nSản Phẩm";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(589, 501);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(134, 52);
            this.btnQLNV.TabIndex = 13;
            this.btnQLNV.Text = "Quản Lý\r\nNhân Viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.Location = new System.Drawing.Point(589, 432);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(134, 53);
            this.btnQLNCC.TabIndex = 12;
            this.btnQLNCC.Text = "Quán Lý\r\nNhà Cung Cấp";
            this.btnQLNCC.UseVisualStyleBackColor = true;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // frmThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 587);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnQLNV);
            this.Controls.Add(this.btnQLNCC);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvTHANHPHO);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhPho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thành Phố";
            this.Load += new System.EventHandler(this.frmThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTHANHPHO;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhPho;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLNCC;
    }
}