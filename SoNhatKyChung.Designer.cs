namespace _4196_NguyenTriKhang_KLTN_
{
    partial class SoNhatKyChung
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
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbngaykt = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lbngaybd = new System.Windows.Forms.Label();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgvSoNhatKyThuTien = new System.Windows.Forms.DataGridView();
            this.qLRBWDsNKC = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNKC();
            this.prNhatKyChungDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_NhatKyChung_DetailTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNKCTableAdapters.pr_NhatKyChung_DetailTableAdapter();
            this.NgayCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinhCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prNhatKyChungDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1046, 25);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 156;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(889, 86);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayKT.TabIndex = 155;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(718, 89);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 154;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(383, 86);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 153;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(220, 89);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 152;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(513, 25);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(255, 33);
            this.lbDSSD.TabIndex = 151;
            this.lbDSSD.Text = "SỔ NHẬT KÝ CHUNG";
            // 
            // dgvSoNhatKyThuTien
            // 
            this.dgvSoNhatKyThuTien.AutoGenerateColumns = false;
            this.dgvSoNhatKyThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoNhatKyThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayCT,
            this.SoCT,
            this.DienGiai,
            this.TaiKhoan,
            this.PhatSinhNo,
            this.PhatSinhCo});
            this.dgvSoNhatKyThuTien.DataSource = this.prNhatKyChungDetailBindingSource;
            this.dgvSoNhatKyThuTien.Location = new System.Drawing.Point(12, 126);
            this.dgvSoNhatKyThuTien.Name = "dgvSoNhatKyThuTien";
            this.dgvSoNhatKyThuTien.RowHeadersWidth = 51;
            this.dgvSoNhatKyThuTien.RowTemplate.Height = 24;
            this.dgvSoNhatKyThuTien.Size = new System.Drawing.Size(1241, 486);
            this.dgvSoNhatKyThuTien.TabIndex = 150;
            // 
            // qLRBWDsNKC
            // 
            this.qLRBWDsNKC.DataSetName = "QLRBWDsNKC";
            this.qLRBWDsNKC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prNhatKyChungDetailBindingSource
            // 
            this.prNhatKyChungDetailBindingSource.DataMember = "pr_NhatKyChung_Detail";
            this.prNhatKyChungDetailBindingSource.DataSource = this.qLRBWDsNKC;
            // 
            // pr_NhatKyChung_DetailTableAdapter
            // 
            this.pr_NhatKyChung_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // NgayCT
            // 
            this.NgayCT.DataPropertyName = "NgayCT";
            this.NgayCT.HeaderText = "NgayCT";
            this.NgayCT.MinimumWidth = 6;
            this.NgayCT.Name = "NgayCT";
            this.NgayCT.ReadOnly = true;
            this.NgayCT.Width = 125;
            // 
            // SoCT
            // 
            this.SoCT.DataPropertyName = "SoCT";
            this.SoCT.HeaderText = "SoCT";
            this.SoCT.MinimumWidth = 6;
            this.SoCT.Name = "SoCT";
            this.SoCT.ReadOnly = true;
            this.SoCT.Width = 125;
            // 
            // DienGiai
            // 
            this.DienGiai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "DienGiai";
            this.DienGiai.MinimumWidth = 6;
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "TaiKhoan";
            this.TaiKhoan.MinimumWidth = 6;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            this.TaiKhoan.Width = 125;
            // 
            // PhatSinhNo
            // 
            this.PhatSinhNo.DataPropertyName = "PhatSinhNo";
            this.PhatSinhNo.HeaderText = "PhatSinhNo";
            this.PhatSinhNo.MinimumWidth = 6;
            this.PhatSinhNo.Name = "PhatSinhNo";
            this.PhatSinhNo.ReadOnly = true;
            this.PhatSinhNo.Width = 125;
            // 
            // PhatSinhCo
            // 
            this.PhatSinhCo.DataPropertyName = "PhatSinhCo";
            this.PhatSinhCo.HeaderText = "PhatSinhCo";
            this.PhatSinhCo.MinimumWidth = 6;
            this.PhatSinhCo.Name = "PhatSinhCo";
            this.PhatSinhCo.ReadOnly = true;
            this.PhatSinhCo.Width = 125;
            // 
            // SoNhatKyChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 658);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgvSoNhatKyThuTien);
            this.Name = "SoNhatKyChung";
            this.Text = "SoNhatKyChung";
            this.Load += new System.EventHandler(this.SoNhatKyChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prNhatKyChungDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lbngaykt;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lbngaybd;
        private System.Windows.Forms.Label lbDSSD;
        private System.Windows.Forms.DataGridView dgvSoNhatKyThuTien;
        private System.Windows.Forms.BindingSource prNhatKyChungDetailBindingSource;
        private QLRBWDsNKC qLRBWDsNKC;
        private QLRBWDsNKCTableAdapters.pr_NhatKyChung_DetailTableAdapter pr_NhatKyChung_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinhCo;
    }
}