namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmTKCT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTKCT));
            this.txtTenTKCT = new System.Windows.Forms.RichTextBox();
            this.cboMaC2 = new System.Windows.Forms.ComboBox();
            this.lbMaTKTH = new System.Windows.Forms.Label();
            this.lbTenTKCT = new System.Windows.Forms.Label();
            this.lbTKCT = new System.Windows.Forms.Label();
            this.txtMaTKCT = new System.Windows.Forms.TextBox();
            this.lbDSTKTH = new System.Windows.Forms.Label();
            this.dgvTietKhoan = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLRBWDsTKCT = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTKCT();
            this.taiKhoanCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanCTTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTKCTTableAdapters.TaiKhoanCTTableAdapter();
            this.MaTKCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTKCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanCTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTKCT
            // 
            this.txtTenTKCT.Location = new System.Drawing.Point(855, 218);
            this.txtTenTKCT.Name = "txtTenTKCT";
            this.txtTenTKCT.Size = new System.Drawing.Size(304, 96);
            this.txtTenTKCT.TabIndex = 104;
            this.txtTenTKCT.Text = "";
            // 
            // cboMaC2
            // 
            this.cboMaC2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaC2.FormattingEnabled = true;
            this.cboMaC2.Location = new System.Drawing.Point(855, 160);
            this.cboMaC2.Name = "cboMaC2";
            this.cboMaC2.Size = new System.Drawing.Size(304, 26);
            this.cboMaC2.TabIndex = 99;
            // 
            // lbMaTKTH
            // 
            this.lbMaTKTH.AutoSize = true;
            this.lbMaTKTH.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaTKTH.Location = new System.Drawing.Point(577, 161);
            this.lbMaTKTH.Name = "lbMaTKTH";
            this.lbMaTKTH.Size = new System.Drawing.Size(171, 20);
            this.lbMaTKTH.TabIndex = 98;
            this.lbMaTKTH.Text = "Mã tài khoản cấp 2";
            // 
            // lbTenTKCT
            // 
            this.lbTenTKCT.AutoSize = true;
            this.lbTenTKCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTKCT.Location = new System.Drawing.Point(577, 232);
            this.lbTenTKCT.Name = "lbTenTKCT";
            this.lbTenTKCT.Size = new System.Drawing.Size(207, 20);
            this.lbTenTKCT.TabIndex = 97;
            this.lbTenTKCT.Text = "Tên tài khoản chi tiết";
            // 
            // lbTKCT
            // 
            this.lbTKCT.AutoSize = true;
            this.lbTKCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKCT.Location = new System.Drawing.Point(577, 92);
            this.lbTKCT.Name = "lbTKCT";
            this.lbTKCT.Size = new System.Drawing.Size(198, 20);
            this.lbTKCT.TabIndex = 96;
            this.lbTKCT.Text = "Mã Tài khoản chi tiết";
            // 
            // txtMaTKCT
            // 
            this.txtMaTKCT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTKCT.Location = new System.Drawing.Point(855, 87);
            this.txtMaTKCT.Name = "txtMaTKCT";
            this.txtMaTKCT.Size = new System.Drawing.Size(304, 25);
            this.txtMaTKCT.TabIndex = 95;
            // 
            // lbDSTKTH
            // 
            this.lbDSTKTH.AutoSize = true;
            this.lbDSTKTH.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSTKTH.Location = new System.Drawing.Point(64, 32);
            this.lbDSTKTH.Name = "lbDSTKTH";
            this.lbDSTKTH.Size = new System.Drawing.Size(435, 33);
            this.lbDSTKTH.TabIndex = 94;
            this.lbDSTKTH.Text = "DANH SÁCH TÀI KHOẢN CHI TIẾT";
            // 
            // dgvTietKhoan
            // 
            this.dgvTietKhoan.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTietKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTietKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTietKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTKCT,
            this.MaTK1,
            this.TenTKCT});
            this.dgvTietKhoan.DataSource = this.taiKhoanCTBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTietKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTietKhoan.Location = new System.Drawing.Point(12, 68);
            this.dgvTietKhoan.Name = "dgvTietKhoan";
            this.dgvTietKhoan.RowHeadersWidth = 51;
            this.dgvTietKhoan.RowTemplate.Height = 24;
            this.dgvTietKhoan.Size = new System.Drawing.Size(549, 310);
            this.dgvTietKhoan.TabIndex = 93;
            this.dgvTietKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTietKhoan_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(996, 349);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 103;
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
            this.btnXoa.Location = new System.Drawing.Point(822, 349);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 102;
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
            this.btnSua.Location = new System.Drawing.Point(909, 349);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 101;
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
            this.btnThem.Location = new System.Drawing.Point(735, 349);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 100;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLRBWDsTKCT
            // 
            this.qLRBWDsTKCT.DataSetName = "QLRBWDsTKCT";
            this.qLRBWDsTKCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanCTBindingSource
            // 
            this.taiKhoanCTBindingSource.DataMember = "TaiKhoanCT";
            this.taiKhoanCTBindingSource.DataSource = this.qLRBWDsTKCT;
            // 
            // taiKhoanCTTableAdapter
            // 
            this.taiKhoanCTTableAdapter.ClearBeforeFill = true;
            // 
            // MaTKCT
            // 
            this.MaTKCT.DataPropertyName = "MaTKCT";
            this.MaTKCT.HeaderText = "MaTKCT";
            this.MaTKCT.MinimumWidth = 6;
            this.MaTKCT.Name = "MaTKCT";
            this.MaTKCT.Width = 125;
            // 
            // MaTK1
            // 
            this.MaTK1.DataPropertyName = "MaTK1";
            this.MaTK1.HeaderText = "MaTK1";
            this.MaTK1.MinimumWidth = 6;
            this.MaTK1.Name = "MaTK1";
            this.MaTK1.Width = 125;
            // 
            // TenTKCT
            // 
            this.TenTKCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTKCT.DataPropertyName = "TenTKCT";
            this.TenTKCT.HeaderText = "TenTKCT";
            this.TenTKCT.MinimumWidth = 6;
            this.TenTKCT.Name = "TenTKCT";
            // 
            // FrmTKCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 472);
            this.Controls.Add(this.txtTenTKCT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMaC2);
            this.Controls.Add(this.lbMaTKTH);
            this.Controls.Add(this.lbTenTKCT);
            this.Controls.Add(this.lbTKCT);
            this.Controls.Add(this.txtMaTKCT);
            this.Controls.Add(this.lbDSTKTH);
            this.Controls.Add(this.dgvTietKhoan);
            this.Name = "FrmTKCT";
            this.Text = "FrmTKCT";
            this.Load += new System.EventHandler(this.FrmTKCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTKCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanCTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTenTKCT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaC2;
        private System.Windows.Forms.Label lbMaTKTH;
        private System.Windows.Forms.Label lbTenTKCT;
        private System.Windows.Forms.Label lbTKCT;
        private System.Windows.Forms.TextBox txtMaTKCT;
        private System.Windows.Forms.Label lbDSTKTH;
        private System.Windows.Forms.DataGridView dgvTietKhoan;
        private QLRBWDsTKCT qLRBWDsTKCT;
        private System.Windows.Forms.BindingSource taiKhoanCTBindingSource;
        private QLRBWDsTKCTTableAdapters.TaiKhoanCTTableAdapter taiKhoanCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKCT;
    }
}