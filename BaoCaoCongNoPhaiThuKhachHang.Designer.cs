namespace _4196_NguyenTriKhang_KLTN_
{
    partial class BaoCaoCongNoPhaiThuKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbngaykt = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lbngaybd = new System.Windows.Forms.Label();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgvSoNhatKyThuTien = new System.Windows.Forms.DataGridView();
            this.qLRBWDsCNPTKH = new _4196_NguyenTriKhang_KLTN_.QLRBWDsCNPTKH();
            this.prCongNoPhaiThuDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_CongNoPhaiThu_DetailTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsCNPTKHTableAdapters.pr_CongNoPhaiThu_DetailTableAdapter();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanCongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoDauKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinhCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsCNPTKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prCongNoPhaiThuDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1046, 24);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 149;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(889, 85);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayKT.TabIndex = 148;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(718, 88);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 147;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(383, 85);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 146;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(220, 88);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 145;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(377, 24);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(540, 33);
            this.lbDSSD.TabIndex = 144;
            this.lbDSSD.Text = "BÁO CÁO CÔNG NỢ PHẢI THU KHÁCH HÀNG";
            // 
            // dgvSoNhatKyThuTien
            // 
            this.dgvSoNhatKyThuTien.AutoGenerateColumns = false;
            this.dgvSoNhatKyThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoNhatKyThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKhachHang,
            this.TaiKhoanCongNo,
            this.NoDauKy,
            this.CoDauKy,
            this.PhatSinhNo,
            this.PhatSinhCo,
            this.NoCuoiKy,
            this.CoCuoiKy});
            this.dgvSoNhatKyThuTien.DataSource = this.prCongNoPhaiThuDetailBindingSource;
            this.dgvSoNhatKyThuTien.Location = new System.Drawing.Point(12, 125);
            this.dgvSoNhatKyThuTien.Name = "dgvSoNhatKyThuTien";
            this.dgvSoNhatKyThuTien.RowHeadersWidth = 51;
            this.dgvSoNhatKyThuTien.RowTemplate.Height = 24;
            this.dgvSoNhatKyThuTien.Size = new System.Drawing.Size(1241, 486);
            this.dgvSoNhatKyThuTien.TabIndex = 143;
            // 
            // qLRBWDsCNPTKH
            // 
            this.qLRBWDsCNPTKH.DataSetName = "QLRBWDsCNPTKH";
            this.qLRBWDsCNPTKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prCongNoPhaiThuDetailBindingSource
            // 
            this.prCongNoPhaiThuDetailBindingSource.DataMember = "pr_CongNoPhaiThu_Detail";
            this.prCongNoPhaiThuDetailBindingSource.DataSource = this.qLRBWDsCNPTKH;
            // 
            // pr_CongNoPhaiThu_DetailTableAdapter
            // 
            this.pr_CongNoPhaiThu_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 188;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "TenKhachHang";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // TaiKhoanCongNo
            // 
            this.TaiKhoanCongNo.DataPropertyName = "TaiKhoanCongNo";
            this.TaiKhoanCongNo.HeaderText = "TaiKhoanCongNo";
            this.TaiKhoanCongNo.MinimumWidth = 6;
            this.TaiKhoanCongNo.Name = "TaiKhoanCongNo";
            this.TaiKhoanCongNo.Width = 125;
            // 
            // NoDauKy
            // 
            this.NoDauKy.DataPropertyName = "NoDauKy";
            this.NoDauKy.HeaderText = "NoDauKy";
            this.NoDauKy.MinimumWidth = 6;
            this.NoDauKy.Name = "NoDauKy";
            this.NoDauKy.ReadOnly = true;
            this.NoDauKy.Width = 125;
            // 
            // CoDauKy
            // 
            this.CoDauKy.DataPropertyName = "CoDauKy";
            this.CoDauKy.HeaderText = "CoDauKy";
            this.CoDauKy.MinimumWidth = 6;
            this.CoDauKy.Name = "CoDauKy";
            this.CoDauKy.ReadOnly = true;
            this.CoDauKy.Width = 125;
            // 
            // PhatSinhNo
            // 
            this.PhatSinhNo.DataPropertyName = "PhatSinhNo";
            this.PhatSinhNo.HeaderText = "PhatSinhNo";
            this.PhatSinhNo.MinimumWidth = 6;
            this.PhatSinhNo.Name = "PhatSinhNo";
            this.PhatSinhNo.ReadOnly = true;
            this.PhatSinhNo.Width = 125;
            // 
            // PhatSinhCo
            // 
            this.PhatSinhCo.DataPropertyName = "PhatSinhCo";
            this.PhatSinhCo.HeaderText = "PhatSinhCo";
            this.PhatSinhCo.MinimumWidth = 6;
            this.PhatSinhCo.Name = "PhatSinhCo";
            this.PhatSinhCo.ReadOnly = true;
            this.PhatSinhCo.Width = 125;
            // 
            // NoCuoiKy
            // 
            this.NoCuoiKy.DataPropertyName = "NoCuoiKy";
            this.NoCuoiKy.HeaderText = "NoCuoiKy";
            this.NoCuoiKy.MinimumWidth = 6;
            this.NoCuoiKy.Name = "NoCuoiKy";
            this.NoCuoiKy.ReadOnly = true;
            this.NoCuoiKy.Width = 125;
            // 
            // CoCuoiKy
            // 
            this.CoCuoiKy.DataPropertyName = "CoCuoiKy";
            this.CoCuoiKy.HeaderText = "CoCuoiKy";
            this.CoCuoiKy.MinimumWidth = 6;
            this.CoCuoiKy.Name = "CoCuoiKy";
            this.CoCuoiKy.ReadOnly = true;
            this.CoCuoiKy.Width = 125;
            // 
            // BaoCaoCongNoPhaiThuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 668);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgvSoNhatKyThuTien);
            this.Name = "BaoCaoCongNoPhaiThuKhachHang";
            this.Text = "BaoCaoCongNoPhaiThuKhachHang";
            this.Load += new System.EventHandler(this.BaoCaoCongNoPhaiThuKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsCNPTKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prCongNoPhaiThuDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lbngaykt;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lbngaybd;
        private System.Windows.Forms.Label lbDSSD;
        private System.Windows.Forms.DataGridView dgvSoNhatKyThuTien;
        private System.Windows.Forms.BindingSource prCongNoPhaiThuDetailBindingSource;
        private QLRBWDsCNPTKH qLRBWDsCNPTKH;
        private QLRBWDsCNPTKHTableAdapters.pr_CongNoPhaiThu_DetailTableAdapter pr_CongNoPhaiThu_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoDauKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinhCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoCuoiKy;
    }
}