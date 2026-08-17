namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmChiTietChungTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietChungTu));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETCHUNGTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLRBWDsCTTT = new _4196_NguyenTriKhang_KLTN_.QLRBWDsCTTT();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.txtSlgSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.lbDVT = new System.Windows.Forms.Label();
            this.gbTK = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbmact = new System.Windows.Forms.Label();
            this.lbCTTT = new System.Windows.Forms.Label();
            this.cHITIETCHUNGTUTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsCTTTTableAdapters.CHITIETCHUNGTUTableAdapter();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDgSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUNGTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsCTTT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCT,
            this.MaSP,
            this.NgayLap,
            this.SlSP,
            this.DGSP});
            this.dgvSanPham.DataSource = this.cHITIETCHUNGTUBindingSource;
            this.dgvSanPham.Location = new System.Drawing.Point(538, 48);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(703, 457);
            this.dgvSanPham.TabIndex = 106;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "MaCT";
            this.MaCT.HeaderText = "MaCT";
            this.MaCT.MinimumWidth = 6;
            this.MaCT.Name = "MaCT";
            this.MaCT.Width = 125;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // SlSP
            // 
            this.SlSP.DataPropertyName = "SlSP";
            this.SlSP.HeaderText = "SlSP";
            this.SlSP.MinimumWidth = 6;
            this.SlSP.Name = "SlSP";
            this.SlSP.Width = 125;
            // 
            // DGSP
            // 
            this.DGSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGSP.DataPropertyName = "DGSP";
            this.DGSP.HeaderText = "DGSP";
            this.DGSP.MinimumWidth = 6;
            this.DGSP.Name = "DGSP";
            // 
            // cHITIETCHUNGTUBindingSource
            // 
            this.cHITIETCHUNGTUBindingSource.DataMember = "CHITIETCHUNGTU";
            this.cHITIETCHUNGTUBindingSource.DataSource = this.qLRBWDsCTTT;
            // 
            // qLRBWDsCTTT
            // 
            this.qLRBWDsCTTT.DataSetName = "QLRBWDsCTTT";
            this.qLRBWDsCTTT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(398, 417);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(159, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 104;
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
            this.btnSua.Location = new System.Drawing.Point(275, 417);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 103;
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
            this.btnThem.Location = new System.Drawing.Point(40, 417);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDgSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.lbTenSP);
            this.groupBox1.Controls.Add(this.txtSlgSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lbSoluong);
            this.groupBox1.Controls.Add(this.lbDVT);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 282);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Chứng từ";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(262, 35);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(205, 25);
            this.txtMaCT.TabIndex = 36;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(18, 76);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(108, 20);
            this.lbTenSP.TabIndex = 28;
            this.lbTenSP.Text = "Mã Sản Phẩm";
            // 
            // txtSlgSP
            // 
            this.txtSlgSP.Location = new System.Drawing.Point(262, 168);
            this.txtSlgSP.Name = "txtSlgSP";
            this.txtSlgSP.Size = new System.Drawing.Size(205, 25);
            this.txtSlgSP.TabIndex = 41;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(262, 71);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(205, 25);
            this.txtMaSP.TabIndex = 37;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.Location = new System.Drawing.Point(18, 121);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(81, 20);
            this.lbSoluong.TabIndex = 47;
            this.lbSoluong.Text = "Ngày Lập";
            // 
            // lbDVT
            // 
            this.lbDVT.AutoSize = true;
            this.lbDVT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Location = new System.Drawing.Point(18, 169);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(162, 20);
            this.lbDVT.TabIndex = 32;
            this.lbDVT.Text = "Số lượng Sản phẩm";
            // 
            // gbTK
            // 
            this.gbTK.Controls.Add(this.btnTimkiem);
            this.gbTK.Controls.Add(this.txtTK);
            this.gbTK.Controls.Add(this.lbmact);
            this.gbTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTK.Location = new System.Drawing.Point(12, 12);
            this.gbTK.Name = "gbTK";
            this.gbTK.Size = new System.Drawing.Size(501, 97);
            this.gbTK.TabIndex = 99;
            this.gbTK.TabStop = false;
            this.gbTK.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(224, 55);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 29);
            this.btnTimkiem.TabIndex = 17;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(150, 24);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(205, 25);
            this.txtTK.TabIndex = 1;
            // 
            // lbmact
            // 
            this.lbmact.AutoSize = true;
            this.lbmact.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmact.Location = new System.Drawing.Point(10, 25);
            this.lbmact.Name = "lbmact";
            this.lbmact.Size = new System.Drawing.Size(108, 20);
            this.lbmact.TabIndex = 0;
            this.lbmact.Text = "Mã Chứng Từ";
            // 
            // lbCTTT
            // 
            this.lbCTTT.AutoSize = true;
            this.lbCTTT.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCTTT.Location = new System.Drawing.Point(693, 12);
            this.lbCTTT.Name = "lbCTTT";
            this.lbCTTT.Size = new System.Drawing.Size(270, 33);
            this.lbCTTT.TabIndex = 98;
            this.lbCTTT.Text = "Chi tiết Chứng từ";
            // 
            // cHITIETCHUNGTUTableAdapter
            // 
            this.cHITIETCHUNGTUTableAdapter.ClearBeforeFill = true;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Location = new System.Drawing.Point(150, 118);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(317, 25);
            this.dtpNgayLap.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Đơn giá Sản phẩm";
            // 
            // txtDgSP
            // 
            this.txtDgSP.Location = new System.Drawing.Point(262, 221);
            this.txtDgSP.Name = "txtDgSP";
            this.txtDgSP.Size = new System.Drawing.Size(205, 25);
            this.txtDgSP.TabIndex = 119;
            // 
            // FrmChiTietChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 550);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTK);
            this.Controls.Add(this.lbCTTT);
            this.Name = "FrmChiTietChungTu";
            this.Text = "FrmChiTietChungTu";
            this.Load += new System.EventHandler(this.FrmChiTietChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETCHUNGTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsCTTT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTK.ResumeLayout(false);
            this.gbTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.TextBox txtSlgSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.Label lbDVT;
        private System.Windows.Forms.GroupBox gbTK;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbmact;
        private System.Windows.Forms.Label lbCTTT;
        private QLRBWDsCTTT qLRBWDsCTTT;
        private System.Windows.Forms.BindingSource cHITIETCHUNGTUBindingSource;
        private QLRBWDsCTTTTableAdapters.CHITIETCHUNGTUTableAdapter cHITIETCHUNGTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGSP;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtDgSP;
        private System.Windows.Forms.Label label2;
    }
}