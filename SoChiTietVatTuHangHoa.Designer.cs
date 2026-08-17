namespace _4196_NguyenTriKhang_KLTN_
{
    partial class SoChiTietVatTuHangHoa
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
            this.txtTenTKC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaTKC = new System.Windows.Forms.ComboBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbngaykt = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lbngaybd = new System.Windows.Forms.Label();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.prSCTVTHHDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLRBWDsSCTVTHH = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSCTVTHH();
            this.pr_SCT_VTHH_DetailTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSCTVTHHTableAdapters.pr_SCT_VTHH_DetailTableAdapter();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanDoiUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSCTVTHHDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSCTVTHH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTKC
            // 
            this.txtTenTKC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTKC.Location = new System.Drawing.Point(543, 73);
            this.txtTenTKC.Name = "txtTenTKC";
            this.txtTenTKC.Size = new System.Drawing.Size(520, 25);
            this.txtTenTKC.TabIndex = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 161;
            this.label1.Text = "Tên tài khoản";
            // 
            // cboMaTKC
            // 
            this.cboMaTKC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTKC.FormattingEnabled = true;
            this.cboMaTKC.Location = new System.Drawing.Point(202, 73);
            this.cboMaTKC.Name = "cboMaTKC";
            this.cboMaTKC.Size = new System.Drawing.Size(170, 26);
            this.cboMaTKC.TabIndex = 160;
            this.cboMaTKC.SelectedIndexChanged += new System.EventHandler(this.cboMaTKC_SelectedIndexChanged);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1037, 25);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 159;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(892, 123);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayKT.TabIndex = 158;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(721, 126);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 157;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(386, 123);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 156;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(223, 126);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 155;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(411, 25);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(420, 33);
            this.lbDSSD.TabIndex = 154;
            this.lbDSSD.Text = "SỔ CHI TIẾT VẬT TƯ HÀNG HÓA";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.SoCT,
            this.DienGiai,
            this.DonGia,
            this.TaiKhoanDoiUng,
            this.SoLuongNhap,
            this.ThanhTienNhap,
            this.SoLuongXuat,
            this.ThanhTienXuat});
            this.dgv.DataSource = this.prSCTVTHHDetailBindingSource;
            this.dgv.Location = new System.Drawing.Point(15, 163);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1241, 486);
            this.dgv.TabIndex = 153;
            // 
            // prSCTVTHHDetailBindingSource
            // 
            this.prSCTVTHHDetailBindingSource.DataMember = "pr_SCT_VTHH_Detail";
            this.prSCTVTHHDetailBindingSource.DataSource = this.qLRBWDsSCTVTHH;
            // 
            // qLRBWDsSCTVTHH
            // 
            this.qLRBWDsSCTVTHH.DataSetName = "QLRBWDsSCTVTHH";
            this.qLRBWDsSCTVTHH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_SCT_VTHH_DetailTableAdapter
            // 
            this.pr_SCT_VTHH_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // SoCT
            // 
            this.SoCT.DataPropertyName = "SoCT";
            this.SoCT.HeaderText = "SoCT";
            this.SoCT.MinimumWidth = 6;
            this.SoCT.Name = "SoCT";
            this.SoCT.Width = 125;
            // 
            // DienGiai
            // 
            this.DienGiai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "DienGiai";
            this.DienGiai.MinimumWidth = 6;
            this.DienGiai.Name = "DienGiai";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // TaiKhoanDoiUng
            // 
            this.TaiKhoanDoiUng.DataPropertyName = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.HeaderText = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.MinimumWidth = 6;
            this.TaiKhoanDoiUng.Name = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.ReadOnly = true;
            this.TaiKhoanDoiUng.Width = 125;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "SoLuongNhap";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            this.SoLuongNhap.Width = 125;
            // 
            // ThanhTienNhap
            // 
            this.ThanhTienNhap.DataPropertyName = "ThanhTienNhap";
            this.ThanhTienNhap.HeaderText = "ThanhTienNhap";
            this.ThanhTienNhap.MinimumWidth = 6;
            this.ThanhTienNhap.Name = "ThanhTienNhap";
            this.ThanhTienNhap.ReadOnly = true;
            this.ThanhTienNhap.Width = 125;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.DataPropertyName = "SoLuongXuat";
            this.SoLuongXuat.HeaderText = "SoLuongXuat";
            this.SoLuongXuat.MinimumWidth = 6;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.ReadOnly = true;
            this.SoLuongXuat.Width = 125;
            // 
            // ThanhTienXuat
            // 
            this.ThanhTienXuat.DataPropertyName = "ThanhTienXuat";
            this.ThanhTienXuat.HeaderText = "ThanhTienXuat";
            this.ThanhTienXuat.MinimumWidth = 6;
            this.ThanhTienXuat.Name = "ThanhTienXuat";
            this.ThanhTienXuat.ReadOnly = true;
            this.ThanhTienXuat.Width = 125;
            // 
            // SoChiTietVatTuHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 675);
            this.Controls.Add(this.txtTenTKC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaTKC);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgv);
            this.Name = "SoChiTietVatTuHangHoa";
            this.Text = "SoChiTietVatTuHangHoa";
            this.Load += new System.EventHandler(this.SoChiTietVatTuHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSCTVTHHDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSCTVTHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTKC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaTKC;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lbngaykt;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lbngaybd;
        private System.Windows.Forms.Label lbDSSD;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource prSCTVTHHDetailBindingSource;
        private QLRBWDsSCTVTHH qLRBWDsSCTVTHH;
        private QLRBWDsSCTVTHHTableAdapters.pr_SCT_VTHH_DetailTableAdapter pr_SCT_VTHH_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanDoiUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienXuat;
    }
}