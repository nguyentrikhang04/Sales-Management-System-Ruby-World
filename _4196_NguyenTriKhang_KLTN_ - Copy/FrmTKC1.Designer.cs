namespace _4196_NguyenTriKhang_KLTN_
{
    partial class FrmTKC1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTKC1));
            this.lbTenTKTH = new System.Windows.Forms.Label();
            this.lbTKTH = new System.Windows.Forms.Label();
            this.txtTenTH = new System.Windows.Forms.TextBox();
            this.txtMaTH = new System.Windows.Forms.TextBox();
            this.lbDSTKTH = new System.Windows.Forms.Label();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.qLRBWDsTaiKhoanC1 = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTaiKhoanC1();
            this.taiKhoanC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanC1TableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTaiKhoanC1TableAdapters.TaiKhoanC1TableAdapter();
            this.MaTK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTKC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTaiKhoanC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanC1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenTKTH
            // 
            this.lbTenTKTH.AutoSize = true;
            this.lbTenTKTH.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTKTH.Location = new System.Drawing.Point(513, 181);
            this.lbTenTKTH.Name = "lbTenTKTH";
            this.lbTenTKTH.Size = new System.Drawing.Size(180, 20);
            this.lbTenTKTH.TabIndex = 109;
            this.lbTenTKTH.Text = "Tên tài khoản cấp 1";
            // 
            // lbTKTH
            // 
            this.lbTKTH.AutoSize = true;
            this.lbTKTH.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKTH.Location = new System.Drawing.Point(513, 114);
            this.lbTKTH.Name = "lbTKTH";
            this.lbTKTH.Size = new System.Drawing.Size(171, 20);
            this.lbTKTH.TabIndex = 108;
            this.lbTKTH.Text = "Mã tài khoản cấp 1";
            // 
            // txtTenTH
            // 
            this.txtTenTH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTH.Location = new System.Drawing.Point(776, 176);
            this.txtTenTH.Name = "txtTenTH";
            this.txtTenTH.Size = new System.Drawing.Size(309, 25);
            this.txtTenTH.TabIndex = 107;
            // 
            // txtMaTH
            // 
            this.txtMaTH.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTH.Location = new System.Drawing.Point(776, 109);
            this.txtMaTH.Name = "txtMaTH";
            this.txtMaTH.Size = new System.Drawing.Size(309, 25);
            this.txtMaTH.TabIndex = 106;
            // 
            // lbDSTKTH
            // 
            this.lbDSTKTH.AutoSize = true;
            this.lbDSTKTH.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSTKTH.Location = new System.Drawing.Point(59, 27);
            this.lbDSTKTH.Name = "lbDSTKTH";
            this.lbDSTKTH.Size = new System.Drawing.Size(390, 33);
            this.lbDSTKTH.TabIndex = 105;
            this.lbDSTKTH.Text = "DANH SÁCH TÀI KHOẢN CẤP 1";
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTongHop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK1,
            this.TenTKC1});
            this.dgvTongHop.DataSource = this.taiKhoanC1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTongHop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTongHop.Location = new System.Drawing.Point(23, 72);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.RowTemplate.Height = 24;
            this.dgvTongHop.Size = new System.Drawing.Size(466, 290);
            this.dgvTongHop.TabIndex = 104;
            this.dgvTongHop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTongHop_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(853, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 113;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(958, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 29);
            this.btnLuu.TabIndex = 112;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(747, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 29);
            this.btnSua.TabIndex = 111;
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
            this.btnThem.Location = new System.Drawing.Point(639, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 29);
            this.btnThem.TabIndex = 110;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // qLRBWDsTaiKhoanC1
            // 
            this.qLRBWDsTaiKhoanC1.DataSetName = "QLRBWDsTaiKhoanC1";
            this.qLRBWDsTaiKhoanC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanC1BindingSource
            // 
            this.taiKhoanC1BindingSource.DataMember = "TaiKhoanC1";
            this.taiKhoanC1BindingSource.DataSource = this.qLRBWDsTaiKhoanC1;
            // 
            // taiKhoanC1TableAdapter
            // 
            this.taiKhoanC1TableAdapter.ClearBeforeFill = true;
            // 
            // MaTK1
            // 
            this.MaTK1.DataPropertyName = "MaTK1";
            this.MaTK1.HeaderText = "MaTK1";
            this.MaTK1.MinimumWidth = 6;
            this.MaTK1.Name = "MaTK1";
            this.MaTK1.Width = 125;
            // 
            // TenTKC1
            // 
            this.TenTKC1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTKC1.DataPropertyName = "TenTKC1";
            this.TenTKC1.HeaderText = "TenTKC1";
            this.TenTKC1.MinimumWidth = 6;
            this.TenTKC1.Name = "TenTKC1";
            // 
            // FrmTKC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 443);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbTenTKTH);
            this.Controls.Add(this.lbTKTH);
            this.Controls.Add(this.txtTenTH);
            this.Controls.Add(this.txtMaTH);
            this.Controls.Add(this.lbDSTKTH);
            this.Controls.Add(this.dgvTongHop);
            this.Name = "FrmTKC1";
            this.Text = "FrmTKC1";
            this.Load += new System.EventHandler(this.FrmTKC1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTaiKhoanC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanC1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTenTKTH;
        private System.Windows.Forms.Label lbTKTH;
        private System.Windows.Forms.TextBox txtTenTH;
        private System.Windows.Forms.TextBox txtMaTH;
        private System.Windows.Forms.Label lbDSTKTH;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private QLRBWDsTaiKhoanC1 qLRBWDsTaiKhoanC1;
        private System.Windows.Forms.BindingSource taiKhoanC1BindingSource;
        private QLRBWDsTaiKhoanC1TableAdapters.TaiKhoanC1TableAdapter taiKhoanC1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTKC1;
    }
}