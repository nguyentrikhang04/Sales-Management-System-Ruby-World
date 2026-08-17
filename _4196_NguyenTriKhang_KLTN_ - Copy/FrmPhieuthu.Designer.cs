namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmPhieuthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuthu));
            this.lbDSCT = new System.Windows.Forms.Label();
            this.lbHoTenKH = new System.Windows.Forms.Label();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.gbPT = new System.Windows.Forms.GroupBox();
            this.txtMaBT = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtLCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoCT = new System.Windows.Forms.TextBox();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbngaylap = new System.Windows.Forms.Label();
            this.lbSoCT = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.lbmkh = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.lbtkno = new System.Windows.Forms.Label();
            this.txttkno = new System.Windows.Forms.TextBox();
            this.txttkco = new System.Windows.Forms.TextBox();
            this.lbtkco = new System.Windows.Forms.Label();
            this.gbKhac = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUNGTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLRBWDsPhieuThu = new _4196_NguyenTriKhang_KLTN_.QLRBWDsPhieuThu();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cHUNGTUTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsPhieuThuTableAdapters.CHUNGTUTableAdapter();
            this.gbsp = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bnthemsp = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnMaBT = new System.Windows.Forms.Button();
            this.txtPTTT = new System.Windows.Forms.TextBox();
            this.gbPT.SuspendLayout();
            this.gbKhac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDSCT
            // 
            this.lbDSCT.AutoSize = true;
            this.lbDSCT.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSCT.Location = new System.Drawing.Point(480, 9);
            this.lbDSCT.Name = "lbDSCT";
            this.lbDSCT.Size = new System.Drawing.Size(150, 33);
            this.lbDSCT.TabIndex = 108;
            this.lbDSCT.Text = "PHIẾU THU";
            // 
            // lbHoTenKH
            // 
            this.lbHoTenKH.AutoSize = true;
            this.lbHoTenKH.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenKH.Location = new System.Drawing.Point(13, 78);
            this.lbHoTenKH.Name = "lbHoTenKH";
            this.lbHoTenKH.Size = new System.Drawing.Size(162, 20);
            this.lbHoTenKH.TabIndex = 109;
            this.lbHoTenKH.Text = "Họ tên Khách hàng";
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(230, 29);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(235, 26);
            this.cboKH.TabIndex = 110;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // gbPT
            // 
            this.gbPT.Controls.Add(this.btnMaBT);
            this.gbPT.Controls.Add(this.txtMaBT);
            this.gbPT.Controls.Add(this.txtMaCT);
            this.gbPT.Controls.Add(this.dtpNgayLap);
            this.gbPT.Controls.Add(this.txtLCT);
            this.gbPT.Controls.Add(this.txtPTTT);
            this.gbPT.Controls.Add(this.label2);
            this.gbPT.Controls.Add(this.txtMoTa);
            this.gbPT.Controls.Add(this.label3);
            this.gbPT.Controls.Add(this.txtSoCT);
            this.gbPT.Controls.Add(this.lbMaNCC);
            this.gbPT.Controls.Add(this.lbngaylap);
            this.gbPT.Controls.Add(this.lbSoCT);
            this.gbPT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPT.Location = new System.Drawing.Point(12, 45);
            this.gbPT.Name = "gbPT";
            this.gbPT.Size = new System.Drawing.Size(532, 406);
            this.gbPT.TabIndex = 114;
            this.gbPT.TabStop = false;
            this.gbPT.Text = "Thông tin Phiếu thu";
            // 
            // txtMaBT
            // 
            this.txtMaBT.Location = new System.Drawing.Point(306, 373);
            this.txtMaBT.Name = "txtMaBT";
            this.txtMaBT.Size = new System.Drawing.Size(205, 25);
            this.txtMaBT.TabIndex = 119;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(406, 34);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(120, 25);
            this.txtMaCT.TabIndex = 117;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(156, 131);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayLap.TabIndex = 116;
            // 
            // txtLCT
            // 
            this.txtLCT.Location = new System.Drawing.Point(156, 80);
            this.txtLCT.Name = "txtLCT";
            this.txtLCT.Size = new System.Drawing.Size(205, 25);
            this.txtLCT.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Phương thức thanh toán";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(156, 182);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(306, 96);
            this.txtMoTa.TabIndex = 61;
            this.txtMoTa.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Loại chứng từ";
            // 
            // txtSoCT
            // 
            this.txtSoCT.Location = new System.Drawing.Point(156, 33);
            this.txtSoCT.Name = "txtSoCT";
            this.txtSoCT.Size = new System.Drawing.Size(205, 25);
            this.txtSoCT.TabIndex = 37;
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCC.Location = new System.Drawing.Point(10, 182);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(54, 20);
            this.lbMaNCC.TabIndex = 36;
            this.lbMaNCC.Text = "Mô tả";
            // 
            // lbngaylap
            // 
            this.lbngaylap.AutoSize = true;
            this.lbngaylap.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaylap.Location = new System.Drawing.Point(10, 131);
            this.lbngaylap.Name = "lbngaylap";
            this.lbngaylap.Size = new System.Drawing.Size(81, 20);
            this.lbngaylap.TabIndex = 33;
            this.lbngaylap.Text = "Ngày lập";
            // 
            // lbSoCT
            // 
            this.lbSoCT.AutoSize = true;
            this.lbSoCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoCT.Location = new System.Drawing.Point(10, 34);
            this.lbSoCT.Name = "lbSoCT";
            this.lbSoCT.Size = new System.Drawing.Size(108, 20);
            this.lbSoCT.TabIndex = 32;
            this.lbSoCT.Text = "Số chứng từ";
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(230, 76);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(235, 25);
            this.txtKH.TabIndex = 60;
            // 
            // lbmkh
            // 
            this.lbmkh.AutoSize = true;
            this.lbmkh.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmkh.Location = new System.Drawing.Point(13, 30);
            this.lbmkh.Name = "lbmkh";
            this.lbmkh.Size = new System.Drawing.Size(126, 20);
            this.lbmkh.TabIndex = 59;
            this.lbmkh.Text = "Mã khách hàng";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(13, 122);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(90, 20);
            this.lbMaNV.TabIndex = 35;
            this.lbMaNV.Text = "Nhân viên";
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(230, 121);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(235, 26);
            this.cbNV.TabIndex = 115;
            this.cbNV.SelectedIndexChanged += new System.EventHandler(this.cbNV_SelectedIndexChanged);
            // 
            // lbtkno
            // 
            this.lbtkno.AutoSize = true;
            this.lbtkno.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtkno.Location = new System.Drawing.Point(13, 173);
            this.lbtkno.Name = "lbtkno";
            this.lbtkno.Size = new System.Drawing.Size(117, 20);
            this.lbtkno.TabIndex = 117;
            this.lbtkno.Text = "Tài khoản nợ";
            // 
            // txttkno
            // 
            this.txttkno.Location = new System.Drawing.Point(230, 168);
            this.txttkno.Name = "txttkno";
            this.txttkno.Size = new System.Drawing.Size(235, 25);
            this.txttkno.TabIndex = 118;
            // 
            // txttkco
            // 
            this.txttkco.Location = new System.Drawing.Point(230, 218);
            this.txttkco.Name = "txttkco";
            this.txttkco.Size = new System.Drawing.Size(235, 25);
            this.txttkco.TabIndex = 119;
            // 
            // lbtkco
            // 
            this.lbtkco.AutoSize = true;
            this.lbtkco.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtkco.Location = new System.Drawing.Point(13, 218);
            this.lbtkco.Name = "lbtkco";
            this.lbtkco.Size = new System.Drawing.Size(117, 20);
            this.lbtkco.TabIndex = 120;
            this.lbtkco.Text = "Tài khoản có";
            // 
            // gbKhac
            // 
            this.gbKhac.Controls.Add(this.txtMaNV);
            this.gbKhac.Controls.Add(this.txttkco);
            this.gbKhac.Controls.Add(this.cboKH);
            this.gbKhac.Controls.Add(this.lbtkco);
            this.gbKhac.Controls.Add(this.lbHoTenKH);
            this.gbKhac.Controls.Add(this.lbmkh);
            this.gbKhac.Controls.Add(this.txtKH);
            this.gbKhac.Controls.Add(this.txttkno);
            this.gbKhac.Controls.Add(this.lbMaNV);
            this.gbKhac.Controls.Add(this.lbtkno);
            this.gbKhac.Controls.Add(this.cbNV);
            this.gbKhac.Font = new System.Drawing.Font("Consolas", 9F);
            this.gbKhac.Location = new System.Drawing.Point(573, 45);
            this.gbKhac.Name = "gbKhac";
            this.gbKhac.Size = new System.Drawing.Size(689, 259);
            this.gbKhac.TabIndex = 121;
            this.gbKhac.TabStop = false;
            this.gbKhac.Text = "Thông tin Khác";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(517, 122);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(117, 25);
            this.txtMaNV.TabIndex = 129;
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AutoGenerateColumns = false;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.NgayLap,
            this.SoCT,
            this.Mota,
            this.PTTT,
            this.MaKH,
            this.MaNV,
            this.MaLCT,
            this.MaBT});
            this.dgvPhieuThu.DataSource = this.cHUNGTUBindingSource;
            this.dgvPhieuThu.Location = new System.Drawing.Point(12, 458);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.RowHeadersWidth = 51;
            this.dgvPhieuThu.RowTemplate.Height = 24;
            this.dgvPhieuThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThu.Size = new System.Drawing.Size(688, 260);
            this.dgvPhieuThu.TabIndex = 122;
            this.dgvPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellClick);
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "MaCT";
            this.MaCT.HeaderText = "MaCT";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.Width = 125;
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
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mota";
            this.Mota.MinimumWidth = 6;
            this.Mota.Name = "Mota";
            this.Mota.Width = 125;
            // 
            // PTTT
            // 
            this.PTTT.DataPropertyName = "PTTT";
            this.PTTT.HeaderText = "PTTT";
            this.PTTT.MinimumWidth = 6;
            this.PTTT.Name = "PTTT";
            this.PTTT.Width = 125;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // MaLCT
            // 
            this.MaLCT.DataPropertyName = "MaLCT";
            this.MaLCT.HeaderText = "MaLCT";
            this.MaLCT.MinimumWidth = 6;
            this.MaLCT.Name = "MaLCT";
            this.MaLCT.Width = 125;
            // 
            // MaBT
            // 
            this.MaBT.DataPropertyName = "MaBT";
            this.MaBT.HeaderText = "MaBT";
            this.MaBT.MinimumWidth = 6;
            this.MaBT.Name = "MaBT";
            this.MaBT.Width = 125;
            // 
            // cHUNGTUBindingSource
            // 
            this.cHUNGTUBindingSource.DataMember = "CHUNGTU";
            this.cHUNGTUBindingSource.DataSource = this.qLRBWDsPhieuThu;
            // 
            // qLRBWDsPhieuThu
            // 
            this.qLRBWDsPhieuThu.DataSetName = "QLRBWDsPhieuThu";
            this.qLRBWDsPhieuThu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(723, 458);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(539, 260);
            this.dgvCart.TabIndex = 123;
            // 
            // cHUNGTUTableAdapter
            // 
            this.cHUNGTUTableAdapter.ClearBeforeFill = true;
            // 
            // gbsp
            // 
            this.gbsp.Controls.Add(this.label5);
            this.gbsp.Controls.Add(this.lblTotal);
            this.gbsp.Controls.Add(this.bnthemsp);
            this.gbsp.Controls.Add(this.txtDonGia);
            this.gbsp.Controls.Add(this.label1);
            this.gbsp.Controls.Add(this.txtSoLuong);
            this.gbsp.Controls.Add(this.cbSP);
            this.gbsp.Controls.Add(this.label4);
            this.gbsp.Controls.Add(this.label6);
            this.gbsp.Font = new System.Drawing.Font("Consolas", 9F);
            this.gbsp.Location = new System.Drawing.Point(573, 310);
            this.gbsp.Name = "gbsp";
            this.gbsp.Size = new System.Drawing.Size(689, 97);
            this.gbsp.TabIndex = 122;
            this.gbsp.TabStop = false;
            this.gbsp.Text = "Thông tin Sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(646, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 131;
            this.label5.Text = "VNĐ";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(498, 67);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 130;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(314, 65);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(166, 25);
            this.txtDonGia.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(108, 65);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(67, 25);
            this.txtSoLuong.TabIndex = 111;
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(187, 23);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(235, 26);
            this.cbSP.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số lượng";
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaAll.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAll.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaAll.Image")));
            this.btnXoaAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaAll.Location = new System.Drawing.Point(1096, 733);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(166, 30);
            this.btnXoaAll.TabIndex = 130;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(723, 733);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(221, 30);
            this.btnXoaSP.TabIndex = 129;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1090, 421);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 128;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(863, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 127;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bnthemsp
            // 
            this.bnthemsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnthemsp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnthemsp.Image = ((System.Drawing.Image)(resources.GetObject("bnthemsp.Image")));
            this.bnthemsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnthemsp.Location = new System.Drawing.Point(523, 21);
            this.bnthemsp.Name = "bnthemsp";
            this.bnthemsp.Size = new System.Drawing.Size(143, 29);
            this.bnthemsp.TabIndex = 129;
            this.bnthemsp.Text = "Thêm SP";
            this.bnthemsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnthemsp.UseVisualStyleBackColor = true;
            this.bnthemsp.Click += new System.EventHandler(this.bnthemsp_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(667, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 30);
            this.btnXoa.TabIndex = 126;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(760, 422);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 30);
            this.btnSua.TabIndex = 125;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(573, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 30);
            this.btnThem.TabIndex = 124;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMaBT
            // 
            this.btnMaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaBT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaBT.Image = ((System.Drawing.Image)(resources.GetObject("btnMaBT.Image")));
            this.btnMaBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaBT.Location = new System.Drawing.Point(14, 370);
            this.btnMaBT.Name = "btnMaBT";
            this.btnMaBT.Size = new System.Drawing.Size(223, 30);
            this.btnMaBT.TabIndex = 131;
            this.btnMaBT.Text = "Lấy Mã Bút Toán";
            this.btnMaBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaBT.UseVisualStyleBackColor = true;
            this.btnMaBT.Click += new System.EventHandler(this.btnMaBT_Click);
            // 
            // txtPTTT
            // 
            this.txtPTTT.Location = new System.Drawing.Point(257, 313);
            this.txtPTTT.Name = "txtPTTT";
            this.txtPTTT.Size = new System.Drawing.Size(205, 25);
            this.txtPTTT.TabIndex = 63;
            // 
            // FrmPhieuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 814);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gbsp);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvPhieuThu);
            this.Controls.Add(this.gbKhac);
            this.Controls.Add(this.gbPT);
            this.Controls.Add(this.lbDSCT);
            this.Name = "FrmPhieuthu";
            this.Text = "Phieuthu";
            this.Load += new System.EventHandler(this.Phieuthu_Load);
            this.gbPT.ResumeLayout(false);
            this.gbPT.PerformLayout();
            this.gbKhac.ResumeLayout(false);
            this.gbKhac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbsp.ResumeLayout(false);
            this.gbsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSCT;
        private System.Windows.Forms.Label lbHoTenKH;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.GroupBox gbPT;
        private System.Windows.Forms.TextBox txtLCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label lbmkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoCT;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbngaylap;
        private System.Windows.Forms.Label lbSoCT;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lbtkno;
        private System.Windows.Forms.TextBox txttkno;
        private System.Windows.Forms.TextBox txttkco;
        private System.Windows.Forms.Label lbtkco;
        private System.Windows.Forms.GroupBox gbKhac;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private QLRBWDsPhieuThu qLRBWDsPhieuThu;
        private System.Windows.Forms.BindingSource cHUNGTUBindingSource;
        private QLRBWDsPhieuThuTableAdapters.CHUNGTUTableAdapter cHUNGTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBT;
        private System.Windows.Forms.GroupBox gbsp;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnthemsp;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.TextBox txtMaBT;
        private System.Windows.Forms.Button btnMaBT;
        private System.Windows.Forms.TextBox txtPTTT;
    }
}