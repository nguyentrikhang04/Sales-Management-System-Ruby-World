namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCC));
            this.label1 = new System.Windows.Forms.Label();
            this.gbTK = new System.Windows.Forms.GroupBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbmasoncc = new System.Windows.Forms.Label();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lbDiaChiNCC = new System.Windows.Forms.Label();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbDSNCC = new System.Windows.Forms.Label();
            this.lbSDTNCC = new System.Windows.Forms.Label();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.qLRBWDsNhaCungCap = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNhaCungCap();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNhaCungCapTableAdapters.NhaCungCapTableAdapter();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiachiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTKCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // gbTK
            // 
            this.gbTK.Controls.Add(this.btnTimkiem);
            this.gbTK.Controls.Add(this.txtTK);
            this.gbTK.Controls.Add(this.lbmasoncc);
            this.gbTK.Location = new System.Drawing.Point(12, 27);
            this.gbTK.Name = "gbTK";
            this.gbTK.Size = new System.Drawing.Size(421, 119);
            this.gbTK.TabIndex = 117;
            this.gbTK.TabStop = false;
            this.gbTK.Text = "Tìm Kiếm";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(206, 42);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(205, 25);
            this.txtTK.TabIndex = 1;
            // 
            // lbmasoncc
            // 
            this.lbmasoncc.AutoSize = true;
            this.lbmasoncc.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasoncc.Location = new System.Drawing.Point(8, 43);
            this.lbmasoncc.Name = "lbmasoncc";
            this.lbmasoncc.Size = new System.Drawing.Size(144, 20);
            this.lbmasoncc.TabIndex = 0;
            this.lbmasoncc.Text = "Mã nhà cung cấp";
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNCC.Location = new System.Drawing.Point(218, 376);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(205, 25);
            this.txtSDTNCC.TabIndex = 116;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(218, 308);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(205, 25);
            this.txtDiaChiNCC.TabIndex = 115;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(218, 241);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(205, 25);
            this.txtTenNCC.TabIndex = 114;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(218, 178);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(205, 25);
            this.txtMaNCC.TabIndex = 113;
            // 
            // lbDiaChiNCC
            // 
            this.lbDiaChiNCC.AutoSize = true;
            this.lbDiaChiNCC.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChiNCC.Location = new System.Drawing.Point(19, 309);
            this.lbDiaChiNCC.Name = "lbDiaChiNCC";
            this.lbDiaChiNCC.Size = new System.Drawing.Size(72, 20);
            this.lbDiaChiNCC.TabIndex = 111;
            this.lbDiaChiNCC.Text = "Địa Chỉ";
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNCC.Location = new System.Drawing.Point(19, 242);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(153, 20);
            this.lbTenNCC.TabIndex = 110;
            this.lbTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lbDSNCC
            // 
            this.lbDSNCC.AutoSize = true;
            this.lbDSNCC.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSNCC.Location = new System.Drawing.Point(631, 15);
            this.lbDSNCC.Name = "lbDSNCC";
            this.lbDSNCC.Size = new System.Drawing.Size(345, 33);
            this.lbDSNCC.TabIndex = 108;
            this.lbDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // lbSDTNCC
            // 
            this.lbSDTNCC.AutoSize = true;
            this.lbSDTNCC.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTNCC.Location = new System.Drawing.Point(20, 377);
            this.lbSDTNCC.Name = "lbSDTNCC";
            this.lbSDTNCC.Size = new System.Drawing.Size(36, 20);
            this.lbSDTNCC.TabIndex = 112;
            this.lbSDTNCC.Text = "SDT";
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhaCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiachiNCC,
            this.SdtNCC,
            this.MaTKCT});
            this.dgvNhaCC.DataSource = this.nhaCungCapBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaCC.Location = new System.Drawing.Point(464, 67);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.Size = new System.Drawing.Size(682, 405);
            this.dgvNhaCC.TabIndex = 107;
            this.dgvNhaCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCC_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(342, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 121;
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
            this.btnXoa.Location = new System.Drawing.Point(141, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 120;
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
            this.btnSua.Location = new System.Drawing.Point(241, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 119;
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
            this.btnThem.Location = new System.Drawing.Point(44, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 118;
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
            this.btnTimkiem.Location = new System.Drawing.Point(280, 73);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 29);
            this.btnTimkiem.TabIndex = 17;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // qLRBWDsNhaCungCap
            // 
            this.qLRBWDsNhaCungCap.DataSetName = "QLRBWDsNhaCungCap";
            this.qLRBWDsNhaCungCap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.qLRBWDsNhaCungCap;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "MaNCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 125;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "TenNCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 125;
            // 
            // DiachiNCC
            // 
            this.DiachiNCC.DataPropertyName = "DiachiNCC";
            this.DiachiNCC.HeaderText = "DiachiNCC";
            this.DiachiNCC.MinimumWidth = 6;
            this.DiachiNCC.Name = "DiachiNCC";
            this.DiachiNCC.Width = 125;
            // 
            // SdtNCC
            // 
            this.SdtNCC.DataPropertyName = "SdtNCC";
            this.SdtNCC.HeaderText = "SdtNCC";
            this.SdtNCC.MinimumWidth = 6;
            this.SdtNCC.Name = "SdtNCC";
            this.SdtNCC.Width = 125;
            // 
            // MaTKCT
            // 
            this.MaTKCT.DataPropertyName = "MaTKCT";
            this.MaTKCT.HeaderText = "MaTKCT";
            this.MaTKCT.MinimumWidth = 6;
            this.MaTKCT.Name = "MaTKCT";
            this.MaTKCT.Width = 125;
            // 
            // FrmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 509);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTK);
            this.Controls.Add(this.txtSDTNCC);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lbDiaChiNCC);
            this.Controls.Add(this.lbTenNCC);
            this.Controls.Add(this.lbDSNCC);
            this.Controls.Add(this.lbSDTNCC);
            this.Controls.Add(this.dgvNhaCC);
            this.Name = "FrmNhaCC";
            this.Text = "FrmNhaCC";
            this.Load += new System.EventHandler(this.FrmNhaCC_Load);
            this.gbTK.ResumeLayout(false);
            this.gbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTK;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbmasoncc;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lbDiaChiNCC;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbDSNCC;
        private System.Windows.Forms.Label lbSDTNCC;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private QLRBWDsNhaCungCap qLRBWDsNhaCungCap;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QLRBWDsNhaCungCapTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiachiNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKCT;
    }
}