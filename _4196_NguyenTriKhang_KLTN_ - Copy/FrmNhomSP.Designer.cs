namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmNhomSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhomSP));
            this.lbDSLCT = new System.Windows.Forms.Label();
            this.dgvNhomSP = new System.Windows.Forms.DataGridView();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lbTenloaiCT = new System.Windows.Forms.Label();
            this.lbMaLoaiCT = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLRBWDsNhomSP = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNhomSP();
            this.nhomSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomSPTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNhomSPTableAdapters.NhomSPTableAdapter();
            this.MaNhomSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNhomSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSLCT
            // 
            this.lbDSLCT.AutoSize = true;
            this.lbDSLCT.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSLCT.Location = new System.Drawing.Point(574, 24);
            this.lbDSLCT.Name = "lbDSLCT";
            this.lbDSLCT.Size = new System.Drawing.Size(360, 33);
            this.lbDSLCT.TabIndex = 124;
            this.lbDSLCT.Text = "Danh sách Nhóm sản phẩm";
            // 
            // dgvNhomSP
            // 
            this.dgvNhomSP.AutoGenerateColumns = false;
            this.dgvNhomSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhomSP,
            this.TenNhom});
            this.dgvNhomSP.DataSource = this.nhomSPBindingSource;
            this.dgvNhomSP.Location = new System.Drawing.Point(437, 70);
            this.dgvNhomSP.Name = "dgvNhomSP";
            this.dgvNhomSP.RowHeadersWidth = 51;
            this.dgvNhomSP.RowTemplate.Height = 24;
            this.dgvNhomSP.Size = new System.Drawing.Size(620, 202);
            this.dgvNhomSP.TabIndex = 123;
            this.dgvNhomSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCV_CellClick);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(124, 148);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(205, 25);
            this.txtTenNhom.TabIndex = 122;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Location = new System.Drawing.Point(124, 95);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(205, 25);
            this.txtMaNhom.TabIndex = 121;
            // 
            // lbTenloaiCT
            // 
            this.lbTenloaiCT.AutoSize = true;
            this.lbTenloaiCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenloaiCT.Location = new System.Drawing.Point(24, 149);
            this.lbTenloaiCT.Name = "lbTenloaiCT";
            this.lbTenloaiCT.Size = new System.Drawing.Size(81, 20);
            this.lbTenloaiCT.TabIndex = 120;
            this.lbTenloaiCT.Text = "Tên nhóm";
            // 
            // lbMaLoaiCT
            // 
            this.lbMaLoaiCT.AutoSize = true;
            this.lbMaLoaiCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiCT.Location = new System.Drawing.Point(24, 96);
            this.lbMaLoaiCT.Name = "lbMaLoaiCT";
            this.lbMaLoaiCT.Size = new System.Drawing.Size(72, 20);
            this.lbMaLoaiCT.TabIndex = 119;
            this.lbMaLoaiCT.Text = "Mã nhóm";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(309, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 128;
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
            this.btnXoa.Location = new System.Drawing.Point(135, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 127;
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
            this.btnSua.Location = new System.Drawing.Point(222, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 126;
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
            this.btnThem.Location = new System.Drawing.Point(48, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 125;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLRBWDsNhomSP
            // 
            this.qLRBWDsNhomSP.DataSetName = "QLRBWDsNhomSP";
            this.qLRBWDsNhomSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomSPBindingSource
            // 
            this.nhomSPBindingSource.DataMember = "NhomSP";
            this.nhomSPBindingSource.DataSource = this.qLRBWDsNhomSP;
            // 
            // nhomSPTableAdapter
            // 
            this.nhomSPTableAdapter.ClearBeforeFill = true;
            // 
            // MaNhomSP
            // 
            this.MaNhomSP.DataPropertyName = "MaNhomSP";
            this.MaNhomSP.HeaderText = "MaNhomSP";
            this.MaNhomSP.MinimumWidth = 6;
            this.MaNhomSP.Name = "MaNhomSP";
            this.MaNhomSP.Width = 125;
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            // 
            // FrmNhomSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 487);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbDSLCT);
            this.Controls.Add(this.dgvNhomSP);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.lbTenloaiCT);
            this.Controls.Add(this.lbMaLoaiCT);
            this.Name = "FrmNhomSP";
            this.Text = "FrmNhomSP";
            this.Load += new System.EventHandler(this.FrmNhomSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNhomSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomSPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDSLCT;
        private System.Windows.Forms.DataGridView dgvNhomSP;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label lbTenloaiCT;
        private System.Windows.Forms.Label lbMaLoaiCT;
        private QLRBWDsNhomSP qLRBWDsNhomSP;
        private System.Windows.Forms.BindingSource nhomSPBindingSource;
        private QLRBWDsNhomSPTableAdapters.NhomSPTableAdapter nhomSPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}