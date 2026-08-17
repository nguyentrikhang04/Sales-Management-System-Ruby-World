namespace _4196_NguyenTriKhang_KLTN_
{
    partial class SoTienGuiNganHang
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
            this.qLRBWDsTGNH = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTGNH();
            this.prSoTienGuiNganHangDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_SoTienGuiNganHang_DetailTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsTGNHTableAdapters.pr_SoTienGuiNganHang_DetailTableAdapter();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienGiaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiNoTK112DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCoTK111DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCoTK131DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCoTK141DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCoTK511DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTGNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoTienGuiNganHangDetailBindingSource)).BeginInit();
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
            this.btnXuatFile.TabIndex = 149;
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
            this.dtpNgayKT.TabIndex = 148;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(718, 89);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 147;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(383, 86);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 146;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(220, 89);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 145;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(559, 25);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(330, 33);
            this.lbDSSD.TabIndex = 144;
            this.lbDSSD.Text = "SỔ TIỀN GỬI NGÂN HÀNG";
            // 
            // dgvSoNhatKyThuTien
            // 
            this.dgvSoNhatKyThuTien.AutoGenerateColumns = false;
            this.dgvSoNhatKyThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoNhatKyThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayLapDataGridViewTextBoxColumn,
            this.soCTDataGridViewTextBoxColumn,
            this.dienGiaiDataGridViewTextBoxColumn,
            this.ghiNoTK112DataGridViewTextBoxColumn,
            this.ghiCoTK111DataGridViewTextBoxColumn,
            this.ghiCoTK131DataGridViewTextBoxColumn,
            this.ghiCoTK141DataGridViewTextBoxColumn,
            this.ghiCoTK511DataGridViewTextBoxColumn,
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn,
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn});
            this.dgvSoNhatKyThuTien.DataSource = this.prSoTienGuiNganHangDetailBindingSource;
            this.dgvSoNhatKyThuTien.Location = new System.Drawing.Point(12, 126);
            this.dgvSoNhatKyThuTien.Name = "dgvSoNhatKyThuTien";
            this.dgvSoNhatKyThuTien.RowHeadersWidth = 51;
            this.dgvSoNhatKyThuTien.RowTemplate.Height = 24;
            this.dgvSoNhatKyThuTien.Size = new System.Drawing.Size(1241, 486);
            this.dgvSoNhatKyThuTien.TabIndex = 143;
            // 
            // qLRBWDsTGNH
            // 
            this.qLRBWDsTGNH.DataSetName = "QLRBWDsTGNH";
            this.qLRBWDsTGNH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prSoTienGuiNganHangDetailBindingSource
            // 
            this.prSoTienGuiNganHangDetailBindingSource.DataMember = "pr_SoTienGuiNganHang_Detail";
            this.prSoTienGuiNganHangDetailBindingSource.DataSource = this.qLRBWDsTGNH;
            // 
            // pr_SoTienGuiNganHang_DetailTableAdapter
            // 
            this.pr_SoTienGuiNganHang_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            this.ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapDataGridViewTextBoxColumn.Width = 125;
            // 
            // soCTDataGridViewTextBoxColumn
            // 
            this.soCTDataGridViewTextBoxColumn.DataPropertyName = "SoCT";
            this.soCTDataGridViewTextBoxColumn.HeaderText = "SoCT";
            this.soCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soCTDataGridViewTextBoxColumn.Name = "soCTDataGridViewTextBoxColumn";
            this.soCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // dienGiaiDataGridViewTextBoxColumn
            // 
            this.dienGiaiDataGridViewTextBoxColumn.DataPropertyName = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.HeaderText = "DienGiai";
            this.dienGiaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dienGiaiDataGridViewTextBoxColumn.Name = "dienGiaiDataGridViewTextBoxColumn";
            this.dienGiaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiNoTK112DataGridViewTextBoxColumn
            // 
            this.ghiNoTK112DataGridViewTextBoxColumn.DataPropertyName = "GhiNo_TK112";
            this.ghiNoTK112DataGridViewTextBoxColumn.HeaderText = "GhiNo_TK112";
            this.ghiNoTK112DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiNoTK112DataGridViewTextBoxColumn.Name = "ghiNoTK112DataGridViewTextBoxColumn";
            this.ghiNoTK112DataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiNoTK112DataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiCoTK111DataGridViewTextBoxColumn
            // 
            this.ghiCoTK111DataGridViewTextBoxColumn.DataPropertyName = "GhiCo_TK111";
            this.ghiCoTK111DataGridViewTextBoxColumn.HeaderText = "GhiCo_TK111";
            this.ghiCoTK111DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiCoTK111DataGridViewTextBoxColumn.Name = "ghiCoTK111DataGridViewTextBoxColumn";
            this.ghiCoTK111DataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiCoTK111DataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiCoTK131DataGridViewTextBoxColumn
            // 
            this.ghiCoTK131DataGridViewTextBoxColumn.DataPropertyName = "GhiCo_TK131";
            this.ghiCoTK131DataGridViewTextBoxColumn.HeaderText = "GhiCo_TK131";
            this.ghiCoTK131DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiCoTK131DataGridViewTextBoxColumn.Name = "ghiCoTK131DataGridViewTextBoxColumn";
            this.ghiCoTK131DataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiCoTK131DataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiCoTK141DataGridViewTextBoxColumn
            // 
            this.ghiCoTK141DataGridViewTextBoxColumn.DataPropertyName = "GhiCo_TK141";
            this.ghiCoTK141DataGridViewTextBoxColumn.HeaderText = "GhiCo_TK141";
            this.ghiCoTK141DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiCoTK141DataGridViewTextBoxColumn.Name = "ghiCoTK141DataGridViewTextBoxColumn";
            this.ghiCoTK141DataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiCoTK141DataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiCoTK511DataGridViewTextBoxColumn
            // 
            this.ghiCoTK511DataGridViewTextBoxColumn.DataPropertyName = "GhiCo_TK511";
            this.ghiCoTK511DataGridViewTextBoxColumn.HeaderText = "GhiCo_TK511";
            this.ghiCoTK511DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiCoTK511DataGridViewTextBoxColumn.Name = "ghiCoTK511DataGridViewTextBoxColumn";
            this.ghiCoTK511DataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiCoTK511DataGridViewTextBoxColumn.Width = 125;
            // 
            // taiKhoanKhacSoTienDataGridViewTextBoxColumn
            // 
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoanKhac_SoTien";
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.HeaderText = "TaiKhoanKhac_SoTien";
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.Name = "taiKhoanKhacSoTienDataGridViewTextBoxColumn";
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.taiKhoanKhacSoTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // taiKhoanKhacSoHieuDataGridViewTextBoxColumn
            // 
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoanKhac_SoHieu";
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.HeaderText = "TaiKhoanKhac_SoHieu";
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.Name = "taiKhoanKhacSoHieuDataGridViewTextBoxColumn";
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.taiKhoanKhacSoHieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // SoTienGuiNganHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 642);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgvSoNhatKyThuTien);
            this.Name = "SoTienGuiNganHang";
            this.Text = "SoTienGuiNganHang";
            this.Load += new System.EventHandler(this.SoTienGuiNganHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoNhatKyThuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsTGNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoTienGuiNganHangDetailBindingSource)).EndInit();
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
        private QLRBWDsTGNH qLRBWDsTGNH;
        private System.Windows.Forms.BindingSource prSoTienGuiNganHangDetailBindingSource;
        private QLRBWDsTGNHTableAdapters.pr_SoTienGuiNganHang_DetailTableAdapter pr_SoTienGuiNganHang_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienGiaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiNoTK112DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCoTK111DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCoTK131DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCoTK141DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCoTK511DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanKhacSoTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanKhacSoHieuDataGridViewTextBoxColumn;
    }
}