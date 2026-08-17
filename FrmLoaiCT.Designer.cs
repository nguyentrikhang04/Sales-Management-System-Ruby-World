namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmLoaiCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiCT));
            this.lbDSLCT = new System.Windows.Forms.Label();
            this.dgvLoaiCT = new System.Windows.Forms.DataGridView();
            this.txtTenLoaiCT = new System.Windows.Forms.TextBox();
            this.txtMaLoaiCT = new System.Windows.Forms.TextBox();
            this.lbTenloaiCT = new System.Windows.Forms.Label();
            this.lbMaLoaiCT = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLRBWDsLoaiChungTu = new _4196_NguyenTriKhang_KLTN_.QLRBWDsLoaiChungTu();
            this.lOAICHUNGTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAICHUNGTUTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsLoaiChungTuTableAdapters.LOAICHUNGTUTableAdapter();
            this.MaLCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsLoaiChungTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUNGTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSLCT
            // 
            this.lbDSLCT.AutoSize = true;
            this.lbDSLCT.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSLCT.Location = new System.Drawing.Point(586, 32);
            this.lbDSLCT.Name = "lbDSLCT";
            this.lbDSLCT.Size = new System.Drawing.Size(360, 33);
            this.lbDSLCT.TabIndex = 95;
            this.lbDSLCT.Text = "DANH SÁCH LOẠI CHỨNG TỪ";
            // 
            // dgvLoaiCT
            // 
            this.dgvLoaiCT.AutoGenerateColumns = false;
            this.dgvLoaiCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLCT,
            this.TenCT});
            this.dgvLoaiCT.DataSource = this.lOAICHUNGTUBindingSource;
            this.dgvLoaiCT.Location = new System.Drawing.Point(462, 78);
            this.dgvLoaiCT.Name = "dgvLoaiCT";
            this.dgvLoaiCT.RowHeadersWidth = 51;
            this.dgvLoaiCT.RowTemplate.Height = 24;
            this.dgvLoaiCT.Size = new System.Drawing.Size(609, 292);
            this.dgvLoaiCT.TabIndex = 94;
            this.dgvLoaiCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiCT_CellClick);
            // 
            // txtTenLoaiCT
            // 
            this.txtTenLoaiCT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiCT.Location = new System.Drawing.Point(203, 130);
            this.txtTenLoaiCT.Name = "txtTenLoaiCT";
            this.txtTenLoaiCT.Size = new System.Drawing.Size(205, 25);
            this.txtTenLoaiCT.TabIndex = 93;
            // 
            // txtMaLoaiCT
            // 
            this.txtMaLoaiCT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiCT.Location = new System.Drawing.Point(203, 77);
            this.txtMaLoaiCT.Name = "txtMaLoaiCT";
            this.txtMaLoaiCT.Size = new System.Drawing.Size(205, 25);
            this.txtMaLoaiCT.TabIndex = 92;
            // 
            // lbTenloaiCT
            // 
            this.lbTenloaiCT.AutoSize = true;
            this.lbTenloaiCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenloaiCT.Location = new System.Drawing.Point(12, 131);
            this.lbTenloaiCT.Name = "lbTenloaiCT";
            this.lbTenloaiCT.Size = new System.Drawing.Size(162, 20);
            this.lbTenloaiCT.TabIndex = 91;
            this.lbTenloaiCT.Text = "Tên loại chứng từ";
            // 
            // lbMaLoaiCT
            // 
            this.lbMaLoaiCT.AutoSize = true;
            this.lbMaLoaiCT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiCT.Location = new System.Drawing.Point(12, 78);
            this.lbMaLoaiCT.Name = "lbMaLoaiCT";
            this.lbMaLoaiCT.Size = new System.Drawing.Size(153, 20);
            this.lbMaLoaiCT.TabIndex = 90;
            this.lbMaLoaiCT.Text = "Mã loại chứng từ";
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(311, 203);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 99;
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
            this.btnXoa.Location = new System.Drawing.Point(129, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 98;
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
            this.btnSua.Location = new System.Drawing.Point(219, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 97;
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
            this.btnThem.Location = new System.Drawing.Point(39, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 96;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLRBWDsLoaiChungTu
            // 
            this.qLRBWDsLoaiChungTu.DataSetName = "QLRBWDsLoaiChungTu";
            this.qLRBWDsLoaiChungTu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAICHUNGTUBindingSource
            // 
            this.lOAICHUNGTUBindingSource.DataMember = "LOAICHUNGTU";
            this.lOAICHUNGTUBindingSource.DataSource = this.qLRBWDsLoaiChungTu;
            // 
            // lOAICHUNGTUTableAdapter
            // 
            this.lOAICHUNGTUTableAdapter.ClearBeforeFill = true;
            // 
            // MaLCT
            // 
            this.MaLCT.DataPropertyName = "MaLCT";
            this.MaLCT.HeaderText = "MaLCT";
            this.MaLCT.MinimumWidth = 6;
            this.MaLCT.Name = "MaLCT";
            this.MaLCT.ReadOnly = true;
            this.MaLCT.Width = 125;
            // 
            // TenCT
            // 
            this.TenCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCT.DataPropertyName = "TenCT";
            this.TenCT.HeaderText = "TenCT";
            this.TenCT.MinimumWidth = 6;
            this.TenCT.Name = "TenCT";
            // 
            // FrmLoaiCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 424);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbDSLCT);
            this.Controls.Add(this.dgvLoaiCT);
            this.Controls.Add(this.txtTenLoaiCT);
            this.Controls.Add(this.txtMaLoaiCT);
            this.Controls.Add(this.lbTenloaiCT);
            this.Controls.Add(this.lbMaLoaiCT);
            this.Name = "FrmLoaiCT";
            this.Text = "FrmLoaiCT";
            this.Load += new System.EventHandler(this.FrmLoaiCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsLoaiChungTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAICHUNGTUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDSLCT;
        private System.Windows.Forms.DataGridView dgvLoaiCT;
        private System.Windows.Forms.TextBox txtTenLoaiCT;
        private System.Windows.Forms.TextBox txtMaLoaiCT;
        private System.Windows.Forms.Label lbTenloaiCT;
        private System.Windows.Forms.Label lbMaLoaiCT;
        private QLRBWDsLoaiChungTu qLRBWDsLoaiChungTu;
        private System.Windows.Forms.BindingSource lOAICHUNGTUBindingSource;
        private QLRBWDsLoaiChungTuTableAdapters.LOAICHUNGTUTableAdapter lOAICHUNGTUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCT;
    }
}