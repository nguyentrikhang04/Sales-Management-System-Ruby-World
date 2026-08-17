namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmButToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmButToan));
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.cbxTKCo = new System.Windows.Forms.ComboBox();
            this.cbxTKNo = new System.Windows.Forms.ComboBox();
            this.lbTKCo = new System.Windows.Forms.Label();
            this.lbTKNo = new System.Windows.Forms.Label();
            this.txtMaBT = new System.Windows.Forms.TextBox();
            this.lbMaBT = new System.Windows.Forms.Label();
            this.dgvButToan = new System.Windows.Forms.DataGridView();
            this.MaBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLRBWDsButtoan = new _4196_NguyenTriKhang_KLTN_.QLRBWDsButtoan();
            this.lbbt = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.buttoanTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsButtoanTableAdapters.ButtoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsButtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(218, 261);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(205, 96);
            this.txtNoiDung.TabIndex = 132;
            this.txtNoiDung.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 130;
            this.label2.Text = "Nội dung";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(44, 432);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(90, 20);
            this.lbTongtien.TabIndex = 129;
            this.lbTongtien.Text = "Tổng tiền";
            // 
            // cbxTKCo
            // 
            this.cbxTKCo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTKCo.FormattingEnabled = true;
            this.cbxTKCo.Location = new System.Drawing.Point(218, 203);
            this.cbxTKCo.Name = "cbxTKCo";
            this.cbxTKCo.Size = new System.Drawing.Size(205, 26);
            this.cbxTKCo.TabIndex = 127;
            // 
            // cbxTKNo
            // 
            this.cbxTKNo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTKNo.FormattingEnabled = true;
            this.cbxTKNo.Items.AddRange(new object[] {
            "111",
            "112",
            "131"});
            this.cbxTKNo.Location = new System.Drawing.Point(218, 134);
            this.cbxTKNo.Name = "cbxTKNo";
            this.cbxTKNo.Size = new System.Drawing.Size(205, 26);
            this.cbxTKNo.TabIndex = 126;
            // 
            // lbTKCo
            // 
            this.lbTKCo.AutoSize = true;
            this.lbTKCo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKCo.Location = new System.Drawing.Point(43, 204);
            this.lbTKCo.Name = "lbTKCo";
            this.lbTKCo.Size = new System.Drawing.Size(117, 20);
            this.lbTKCo.TabIndex = 125;
            this.lbTKCo.Text = "Tài khoản Có";
            // 
            // lbTKNo
            // 
            this.lbTKNo.AutoSize = true;
            this.lbTKNo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKNo.Location = new System.Drawing.Point(43, 140);
            this.lbTKNo.Name = "lbTKNo";
            this.lbTKNo.Size = new System.Drawing.Size(117, 20);
            this.lbTKNo.TabIndex = 124;
            this.lbTKNo.Text = "Tài khoản Nợ";
            // 
            // txtMaBT
            // 
            this.txtMaBT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBT.Location = new System.Drawing.Point(218, 80);
            this.txtMaBT.Name = "txtMaBT";
            this.txtMaBT.Size = new System.Drawing.Size(205, 25);
            this.txtMaBT.TabIndex = 121;
            // 
            // lbMaBT
            // 
            this.lbMaBT.AutoSize = true;
            this.lbMaBT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBT.Location = new System.Drawing.Point(44, 81);
            this.lbMaBT.Name = "lbMaBT";
            this.lbMaBT.Size = new System.Drawing.Size(108, 20);
            this.lbMaBT.TabIndex = 120;
            this.lbMaBT.Text = "Mã bút toán";
            // 
            // dgvButToan
            // 
            this.dgvButToan.AutoGenerateColumns = false;
            this.dgvButToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBT,
            this.NoiDung,
            this.TKNO,
            this.TKCO,
            this.SoLuong,
            this.DonGia});
            this.dgvButToan.DataSource = this.buttoanBindingSource;
            this.dgvButToan.Location = new System.Drawing.Point(488, 50);
            this.dgvButToan.Name = "dgvButToan";
            this.dgvButToan.RowHeadersWidth = 51;
            this.dgvButToan.RowTemplate.Height = 24;
            this.dgvButToan.Size = new System.Drawing.Size(660, 544);
            this.dgvButToan.TabIndex = 115;
            this.dgvButToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvButToan_CellClick);
            // 
            // MaBT
            // 
            this.MaBT.DataPropertyName = "MaBT";
            this.MaBT.HeaderText = "MaBT";
            this.MaBT.MinimumWidth = 6;
            this.MaBT.Name = "MaBT";
            this.MaBT.Width = 125;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "NoiDung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 125;
            // 
            // TKNO
            // 
            this.TKNO.DataPropertyName = "TKNO";
            this.TKNO.HeaderText = "TKNO";
            this.TKNO.MinimumWidth = 6;
            this.TKNO.Name = "TKNO";
            this.TKNO.Width = 125;
            // 
            // TKCO
            // 
            this.TKCO.DataPropertyName = "TKCO";
            this.TKCO.HeaderText = "TKCO";
            this.TKCO.MinimumWidth = 6;
            this.TKCO.Name = "TKCO";
            this.TKCO.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // buttoanBindingSource
            // 
            this.buttoanBindingSource.DataMember = "Buttoan";
            this.buttoanBindingSource.DataSource = this.qLRBWDsButtoan;
            // 
            // qLRBWDsButtoan
            // 
            this.qLRBWDsButtoan.DataSetName = "QLRBWDsButtoan";
            this.qLRBWDsButtoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbbt
            // 
            this.lbbt.AutoSize = true;
            this.lbbt.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbt.Location = new System.Drawing.Point(738, 14);
            this.lbbt.Name = "lbbt";
            this.lbbt.Size = new System.Drawing.Size(135, 33);
            this.lbbt.TabIndex = 119;
            this.lbbt.Text = "BÚT TOÁN";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(218, 382);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(131, 25);
            this.txtSoLuong.TabIndex = 134;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(218, 432);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(166, 25);
            this.txtDonGia.TabIndex = 135;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(43, 382);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(81, 20);
            this.lbSoLuong.TabIndex = 136;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(309, 496);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 140;
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
            this.btnXoa.Location = new System.Drawing.Point(135, 496);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 139;
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
            this.btnSua.Location = new System.Drawing.Point(222, 496);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 138;
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
            this.btnThem.Location = new System.Drawing.Point(48, 496);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 137;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // buttoanTableAdapter
            // 
            this.buttoanTableAdapter.ClearBeforeFill = true;
            // 
            // FrmButToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 606);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.cbxTKCo);
            this.Controls.Add(this.cbxTKNo);
            this.Controls.Add(this.lbTKCo);
            this.Controls.Add(this.lbTKNo);
            this.Controls.Add(this.txtMaBT);
            this.Controls.Add(this.lbMaBT);
            this.Controls.Add(this.dgvButToan);
            this.Controls.Add(this.lbbt);
            this.Name = "FrmButToan";
            this.Text = "FrmButToan";
            this.Load += new System.EventHandler(this.FrmButToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvButToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsButtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.ComboBox cbxTKCo;
        private System.Windows.Forms.ComboBox cbxTKNo;
        private System.Windows.Forms.Label lbTKCo;
        private System.Windows.Forms.Label lbTKNo;
        private System.Windows.Forms.TextBox txtMaBT;
        private System.Windows.Forms.Label lbMaBT;
        private System.Windows.Forms.DataGridView dgvButToan;
        private System.Windows.Forms.Label lbbt;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private QLRBWDsButtoan qLRBWDsButtoan;
        private System.Windows.Forms.BindingSource buttoanBindingSource;
        private QLRBWDsButtoanTableAdapters.ButtoanTableAdapter buttoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}