namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.lbDSLCT = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.gbTK = new System.Windows.Forms.GroupBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbmasoncc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaLoaiCT = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.qLRBWDsTaiKhoanDN = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTaiKhoanDN();
            this.taiKhoanDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanDNTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTaiKhoanDNTableAdapters.TaiKhoanDNTableAdapter();
            this.Taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.gbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTaiKhoanDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSLCT
            // 
            this.lbDSLCT.AutoSize = true;
            this.lbDSLCT.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSLCT.Location = new System.Drawing.Point(564, 1);
            this.lbDSLCT.Name = "lbDSLCT";
            this.lbDSLCT.Size = new System.Drawing.Size(300, 33);
            this.lbDSLCT.TabIndex = 115;
            this.lbDSLCT.Text = "Danh sách Tài khoản";
            // 
            // dgvTK
            // 
            this.dgvTK.AutoGenerateColumns = false;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Taikhoan,
            this.MatKhau});
            this.dgvTK.DataSource = this.taiKhoanDNBindingSource;
            this.dgvTK.Location = new System.Drawing.Point(398, 46);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(636, 266);
            this.dgvTK.TabIndex = 114;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(159, 177);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(205, 25);
            this.txtMK.TabIndex = 113;
            // 
            // gbTK
            // 
            this.gbTK.Controls.Add(this.btnTimkiem);
            this.gbTK.Controls.Add(this.txtTK);
            this.gbTK.Controls.Add(this.lbmasoncc);
            this.gbTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTK.Location = new System.Drawing.Point(3, 12);
            this.gbTK.Name = "gbTK";
            this.gbTK.Size = new System.Drawing.Size(380, 103);
            this.gbTK.TabIndex = 109;
            this.gbTK.TabStop = false;
            this.gbTK.Text = "Tìm Kiếm";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(156, 34);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(205, 25);
            this.txtTK.TabIndex = 1;
            // 
            // lbmasoncc
            // 
            this.lbmasoncc.AutoSize = true;
            this.lbmasoncc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasoncc.Location = new System.Drawing.Point(6, 35);
            this.lbmasoncc.Name = "lbmasoncc";
            this.lbmasoncc.Size = new System.Drawing.Size(117, 20);
            this.lbmasoncc.TabIndex = 0;
            this.lbmasoncc.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Mật khẩu";
            // 
            // lbMaLoaiCT
            // 
            this.lbMaLoaiCT.AutoSize = true;
            this.lbMaLoaiCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiCT.Location = new System.Drawing.Point(9, 134);
            this.lbMaLoaiCT.Name = "lbMaLoaiCT";
            this.lbMaLoaiCT.Size = new System.Drawing.Size(117, 20);
            this.lbMaLoaiCT.TabIndex = 110;
            this.lbMaLoaiCT.Text = "Mã tài khoản";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.Location = new System.Drawing.Point(159, 133);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(205, 25);
            this.txtMaTK.TabIndex = 111;
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(286, 240);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 29);
            this.btnLuu.TabIndex = 119;
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
            this.btnXoa.Location = new System.Drawing.Point(108, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 118;
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
            this.btnSua.Location = new System.Drawing.Point(202, 240);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 29);
            this.btnSua.TabIndex = 117;
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
            this.btnThem.Location = new System.Drawing.Point(21, 240);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 116;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(217, 65);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 29);
            this.btnTimkiem.TabIndex = 17;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // qLRBWDsTaiKhoanDN
            // 
            this.qLRBWDsTaiKhoanDN.DataSetName = "QLRBWDsTaiKhoanDN";
            this.qLRBWDsTaiKhoanDN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanDNBindingSource
            // 
            this.taiKhoanDNBindingSource.DataMember = "TaiKhoanDN";
            this.taiKhoanDNBindingSource.DataSource = this.qLRBWDsTaiKhoanDN;
            // 
            // taiKhoanDNTableAdapter
            // 
            this.taiKhoanDNTableAdapter.ClearBeforeFill = true;
            // 
            // Taikhoan
            // 
            this.Taikhoan.DataPropertyName = "Taikhoan";
            this.Taikhoan.HeaderText = "Taikhoan";
            this.Taikhoan.MinimumWidth = 6;
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.Width = 125;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 397);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbDSLCT);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.gbTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaLoaiCT);
            this.Controls.Add(this.txtMaTK);
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.gbTK.ResumeLayout(false);
            this.gbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTaiKhoanDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDNBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDSLCT;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.GroupBox gbTK;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbmasoncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaLoaiCT;
        private System.Windows.Forms.TextBox txtMaTK;
        private QLRBWDsTaiKhoanDN qLRBWDsTaiKhoanDN;
        private System.Windows.Forms.BindingSource taiKhoanDNBindingSource;
        private QLRBWDsTaiKhoanDNTableAdapters.TaiKhoanDNTableAdapter taiKhoanDNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}