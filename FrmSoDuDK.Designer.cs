namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmSoDuDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoDuDK));
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuNo = new System.Windows.Forms.TextBox();
            this.cboMaTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.lbngaydauky = new System.Windows.Forms.Label();
            this.lbsodu = new System.Windows.Forms.Label();
            this.lbMaTKCT = new System.Windows.Forms.Label();
            this.txtDuCo = new System.Windows.Forms.TextBox();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgvSoDu = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLRBWDsSDDK = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSDDK();
            this.soDuDauKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soDuDauKyTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSDDKTableAdapters.SoDuDauKyTableAdapter();
            this.MaSDDKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTKCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSDDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDuDauKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(955, 303);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(306, 25);
            this.txtSLTon.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Số lượng tồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Dư Nợ";
            // 
            // txtDuNo
            // 
            this.txtDuNo.Location = new System.Drawing.Point(955, 173);
            this.txtDuNo.Name = "txtDuNo";
            this.txtDuNo.Size = new System.Drawing.Size(306, 22);
            this.txtDuNo.TabIndex = 107;
            // 
            // cboMaTK
            // 
            this.cboMaTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTK.FormattingEnabled = true;
            this.cboMaTK.Location = new System.Drawing.Point(955, 82);
            this.cboMaTK.Name = "cboMaTK";
            this.cboMaTK.Size = new System.Drawing.Size(306, 26);
            this.cboMaTK.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tên tài khoản";
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTK.Location = new System.Drawing.Point(955, 261);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(306, 25);
            this.txtLoaiTK.TabIndex = 100;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDK.Location = new System.Drawing.Point(955, 214);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayDK.TabIndex = 99;
            // 
            // lbngaydauky
            // 
            this.lbngaydauky.AutoSize = true;
            this.lbngaydauky.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaydauky.Location = new System.Drawing.Point(713, 219);
            this.lbngaydauky.Name = "lbngaydauky";
            this.lbngaydauky.Size = new System.Drawing.Size(108, 20);
            this.lbngaydauky.TabIndex = 98;
            this.lbngaydauky.Text = "Ngày đầu kỳ";
            // 
            // lbsodu
            // 
            this.lbsodu.AutoSize = true;
            this.lbsodu.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsodu.Location = new System.Drawing.Point(713, 130);
            this.lbsodu.Name = "lbsodu";
            this.lbsodu.Size = new System.Drawing.Size(54, 20);
            this.lbsodu.TabIndex = 97;
            this.lbsodu.Text = "Dư có";
            // 
            // lbMaTKCT
            // 
            this.lbMaTKCT.AutoSize = true;
            this.lbMaTKCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTKCT.Location = new System.Drawing.Point(713, 82);
            this.lbMaTKCT.Name = "lbMaTKCT";
            this.lbMaTKCT.Size = new System.Drawing.Size(198, 20);
            this.lbMaTKCT.TabIndex = 96;
            this.lbMaTKCT.Text = "Mã tài khoản chi tiết";
            // 
            // txtDuCo
            // 
            this.txtDuCo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuCo.Location = new System.Drawing.Point(955, 125);
            this.txtDuCo.Name = "txtDuCo";
            this.txtDuCo.Size = new System.Drawing.Size(306, 25);
            this.txtDuCo.TabIndex = 95;
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(202, 37);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(345, 33);
            this.lbDSSD.TabIndex = 94;
            this.lbDSSD.Text = "DANH SÁCH SỐ DƯ ĐẦU KỲ";
            // 
            // dgvSoDu
            // 
            this.dgvSoDu.AutoGenerateColumns = false;
            this.dgvSoDu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoDu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSDDKY,
            this.NgayDK,
            this.MaTKCT,
            this.TenTaiKhoan,
            this.DuNo,
            this.DuCo,
            this.SLTon});
            this.dgvSoDu.DataSource = this.soDuDauKyBindingSource;
            this.dgvSoDu.Location = new System.Drawing.Point(41, 82);
            this.dgvSoDu.Name = "dgvSoDu";
            this.dgvSoDu.RowHeadersWidth = 51;
            this.dgvSoDu.RowTemplate.Height = 24;
            this.dgvSoDu.Size = new System.Drawing.Size(634, 347);
            this.dgvSoDu.TabIndex = 93;
            this.dgvSoDu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoDu_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1119, 384);
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
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(906, 384);
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
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1009, 384);
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
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(802, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLRBWDsSDDK
            // 
            this.qLRBWDsSDDK.DataSetName = "QLRBWDsSDDK";
            this.qLRBWDsSDDK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soDuDauKyBindingSource
            // 
            this.soDuDauKyBindingSource.DataMember = "SoDuDauKy";
            this.soDuDauKyBindingSource.DataSource = this.qLRBWDsSDDK;
            // 
            // soDuDauKyTableAdapter
            // 
            this.soDuDauKyTableAdapter.ClearBeforeFill = true;
            // 
            // MaSDDKY
            // 
            this.MaSDDKY.DataPropertyName = "MaSDDKY";
            this.MaSDDKY.HeaderText = "MaSDDKY";
            this.MaSDDKY.MinimumWidth = 6;
            this.MaSDDKY.Name = "MaSDDKY";
            this.MaSDDKY.ReadOnly = true;
            this.MaSDDKY.Width = 125;
            // 
            // NgayDK
            // 
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "NgayDK";
            this.NgayDK.MinimumWidth = 6;
            this.NgayDK.Name = "NgayDK";
            this.NgayDK.Width = 125;
            // 
            // MaTKCT
            // 
            this.MaTKCT.DataPropertyName = "MaTKCT";
            this.MaTKCT.HeaderText = "MaTKCT";
            this.MaTKCT.MinimumWidth = 6;
            this.MaTKCT.Name = "MaTKCT";
            this.MaTKCT.Width = 125;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "TenTaiKhoan";
            this.TenTaiKhoan.MinimumWidth = 6;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 125;
            // 
            // DuNo
            // 
            this.DuNo.DataPropertyName = "DuNo";
            this.DuNo.HeaderText = "DuNo";
            this.DuNo.MinimumWidth = 6;
            this.DuNo.Name = "DuNo";
            this.DuNo.Width = 125;
            // 
            // DuCo
            // 
            this.DuCo.DataPropertyName = "DuCo";
            this.DuCo.HeaderText = "DuCo";
            this.DuCo.MinimumWidth = 6;
            this.DuCo.Name = "DuCo";
            this.DuCo.Width = 125;
            // 
            // SLTon
            // 
            this.SLTon.DataPropertyName = "SLTon";
            this.SLTon.HeaderText = "SLTon";
            this.SLTon.MinimumWidth = 6;
            this.SLTon.Name = "SLTon";
            this.SLTon.Width = 125;
            // 
            // FrmSoDuDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 492);
            this.Controls.Add(this.txtSLTon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuNo);
            this.Controls.Add(this.cboMaTK);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiTK);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.lbngaydauky);
            this.Controls.Add(this.lbsodu);
            this.Controls.Add(this.lbMaTKCT);
            this.Controls.Add(this.txtDuCo);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgvSoDu);
            this.Name = "FrmSoDuDK";
            this.Text = "FrmSoDuDK";
            this.Load += new System.EventHandler(this.FrmSoDuDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoDu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSDDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDuDauKyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuNo;
        private System.Windows.Forms.ComboBox cboMaTK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.Label lbngaydauky;
        private System.Windows.Forms.Label lbsodu;
        private System.Windows.Forms.Label lbMaTKCT;
        private System.Windows.Forms.TextBox txtDuCo;
        private System.Windows.Forms.Label lbDSSD;
        private System.Windows.Forms.DataGridView dgvSoDu;
        private QLRBWDsSDDK qLRBWDsSDDK;
        private System.Windows.Forms.BindingSource soDuDauKyBindingSource;
        private QLRBWDsSDDKTableAdapters.SoDuDauKyTableAdapter soDuDauKyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSDDKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTon;
    }
}