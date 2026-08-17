namespace _4196_NguyenTriKhang_KLTN_
{
    partial class SoNhatKyThuTien
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
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lbngaybd = new System.Windows.Forms.Label();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgvSoNhatKyThuTien = new System.Windows.Forms.DataGridView();
            this.prSoNhatKyThuTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLRBWDsNKTT = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNKTT();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbngaykt = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.pr_SoNhatKyThuTienTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsNKTTTableAdapters.pr_SoNhatKyThuTienTableAdapter();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiNo_TK111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiCo_TK112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiCo_TK131 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiCo_TK141 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiCo_TK511 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanKhac_SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanKhac_SoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoNhatKyThuTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNKTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(380, 80);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 117;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(217, 83);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 116;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(556, 19);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(300, 33);
            this.lbDSSD.TabIndex = 112;
            this.lbDSSD.Text = "SỔ NHẬT KÝ THU TIỀN";
            // 
            // dgvSoNhatKyThuTien
            // 
            this.dgvSoNhatKyThuTien.AutoGenerateColumns = false;
            this.dgvSoNhatKyThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoNhatKyThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.SoCT,
            this.DienGiai,
            this.GhiNo_TK111,
            this.GhiCo_TK112,
            this.GhiCo_TK131,
            this.GhiCo_TK141,
            this.GhiCo_TK511,
            this.TaiKhoanKhac_SoTien,
            this.TaiKhoanKhac_SoHieu});
            this.dgvSoNhatKyThuTien.DataSource = this.prSoNhatKyThuTienBindingSource;
            this.dgvSoNhatKyThuTien.Location = new System.Drawing.Point(9, 120);
            this.dgvSoNhatKyThuTien.Name = "dgvSoNhatKyThuTien";
            this.dgvSoNhatKyThuTien.RowHeadersWidth = 51;
            this.dgvSoNhatKyThuTien.RowTemplate.Height = 24;
            this.dgvSoNhatKyThuTien.Size = new System.Drawing.Size(1241, 486);
            this.dgvSoNhatKyThuTien.TabIndex = 111;
            // 
            // prSoNhatKyThuTienBindingSource
            // 
            this.prSoNhatKyThuTienBindingSource.DataMember = "pr_SoNhatKyThuTien";
            this.prSoNhatKyThuTienBindingSource.DataSource = this.qLRBWDsNKTT;
            // 
            // qLRBWDsNKTT
            // 
            this.qLRBWDsNKTT.DataSetName = "QLRBWDsNKTT";
            this.qLRBWDsNKTT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(886, 80);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayKT.TabIndex = 119;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(715, 83);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 118;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1043, 19);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 142;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // pr_SoNhatKyThuTienTableAdapter
            // 
            this.pr_SoNhatKyThuTienTableAdapter.ClearBeforeFill = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 125;
            // 
            // SoCT
            // 
            this.SoCT.DataPropertyName = "SoCT";
            this.SoCT.HeaderText = "SoCT";
            this.SoCT.MinimumWidth = 6;
            this.SoCT.Name = "SoCT";
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "DienGiai";
            this.DienGiai.MinimumWidth = 6;
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.Width = 458;
            // 
            // GhiNo_TK111
            // 
            this.GhiNo_TK111.DataPropertyName = "GhiNo_TK111";
            this.GhiNo_TK111.HeaderText = "GhiNo_TK111";
            this.GhiNo_TK111.MinimumWidth = 6;
            this.GhiNo_TK111.Name = "GhiNo_TK111";
            this.GhiNo_TK111.ReadOnly = true;
            this.GhiNo_TK111.Width = 80;
            // 
            // GhiCo_TK112
            // 
            this.GhiCo_TK112.DataPropertyName = "GhiCo_TK112";
            this.GhiCo_TK112.HeaderText = "GhiCo_TK112";
            this.GhiCo_TK112.MinimumWidth = 6;
            this.GhiCo_TK112.Name = "GhiCo_TK112";
            this.GhiCo_TK112.ReadOnly = true;
            this.GhiCo_TK112.Width = 30;
            // 
            // GhiCo_TK131
            // 
            this.GhiCo_TK131.DataPropertyName = "GhiCo_TK131";
            this.GhiCo_TK131.HeaderText = "GhiCo_TK131";
            this.GhiCo_TK131.MinimumWidth = 6;
            this.GhiCo_TK131.Name = "GhiCo_TK131";
            this.GhiCo_TK131.ReadOnly = true;
            this.GhiCo_TK131.Width = 80;
            // 
            // GhiCo_TK141
            // 
            this.GhiCo_TK141.DataPropertyName = "GhiCo_TK141";
            this.GhiCo_TK141.HeaderText = "GhiCo_TK141";
            this.GhiCo_TK141.MinimumWidth = 6;
            this.GhiCo_TK141.Name = "GhiCo_TK141";
            this.GhiCo_TK141.ReadOnly = true;
            this.GhiCo_TK141.Width = 80;
            // 
            // GhiCo_TK511
            // 
            this.GhiCo_TK511.DataPropertyName = "GhiCo_TK511";
            this.GhiCo_TK511.HeaderText = "GhiCo_TK511";
            this.GhiCo_TK511.MinimumWidth = 6;
            this.GhiCo_TK511.Name = "GhiCo_TK511";
            this.GhiCo_TK511.ReadOnly = true;
            this.GhiCo_TK511.Width = 80;
            // 
            // TaiKhoanKhac_SoTien
            // 
            this.TaiKhoanKhac_SoTien.DataPropertyName = "TaiKhoanKhac_SoTien";
            this.TaiKhoanKhac_SoTien.HeaderText = "TaiKhoanKhac_SoTien";
            this.TaiKhoanKhac_SoTien.MinimumWidth = 6;
            this.TaiKhoanKhac_SoTien.Name = "TaiKhoanKhac_SoTien";
            this.TaiKhoanKhac_SoTien.ReadOnly = true;
            this.TaiKhoanKhac_SoTien.Width = 20;
            // 
            // TaiKhoanKhac_SoHieu
            // 
            this.TaiKhoanKhac_SoHieu.DataPropertyName = "TaiKhoanKhac_SoHieu";
            this.TaiKhoanKhac_SoHieu.HeaderText = "TaiKhoanKhac_SoHieu";
            this.TaiKhoanKhac_SoHieu.MinimumWidth = 6;
            this.TaiKhoanKhac_SoHieu.Name = "TaiKhoanKhac_SoHieu";
            this.TaiKhoanKhac_SoHieu.ReadOnly = true;
            this.TaiKhoanKhac_SoHieu.Width = 135;
            // 
            // SoNhatKyThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 612);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgvSoNhatKyThuTien);
            this.Name = "SoNhatKyThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoNhatKyThuTien";
            this.Load += new System.EventHandler(this.SoNhatKyThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoNhatKyThuTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsNKTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lbngaybd;
        private System.Windows.Forms.Label lbDSSD;
        private System.Windows.Forms.DataGridView dgvSoNhatKyThuTien;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lbngaykt;
        private System.Windows.Forms.Button btnXuatFile;
        private QLRBWDsNKTT qLRBWDsNKTT;
        private System.Windows.Forms.BindingSource prSoNhatKyThuTienBindingSource;
        private QLRBWDsNKTTTableAdapters.pr_SoNhatKyThuTienTableAdapter pr_SoNhatKyThuTienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiNo_TK111;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiCo_TK112;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiCo_TK131;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiCo_TK141;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiCo_TK511;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanKhac_SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanKhac_SoHieu;
    }
}