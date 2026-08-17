namespace _4196_NguyenTriKhang_KLTN_
{
    partial class SoCai
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
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lbngaykt = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lbngaybd = new System.Windows.Forms.Label();
            this.lbDSSD = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cboMaTKC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTKC = new System.Windows.Forms.TextBox();
            this.qLRBWDsSoCai = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSoCai();
            this.prSoCaiDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pr_SoCai_DetailTableAdapter = new _4196_NguyenTriKhang_KLTN_.QLRBWDsSoCaiTableAdapters.pr_SoCai_DetailTableAdapter();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanDoiUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PS_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PS_Co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSoCai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoCaiDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(911, 118);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayKT.TabIndex = 148;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // lbngaykt
            // 
            this.lbngaykt.AutoSize = true;
            this.lbngaykt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaykt.Location = new System.Drawing.Point(740, 121);
            this.lbngaykt.Name = "lbngaykt";
            this.lbngaykt.Size = new System.Drawing.Size(126, 20);
            this.lbngaykt.TabIndex = 147;
            this.lbngaykt.Text = "Ngày kết thúc";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(405, 118);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayBD.TabIndex = 146;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lbngaybd
            // 
            this.lbngaybd.AutoSize = true;
            this.lbngaybd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaybd.Location = new System.Drawing.Point(242, 121);
            this.lbngaybd.Name = "lbngaybd";
            this.lbngaybd.Size = new System.Drawing.Size(117, 20);
            this.lbngaybd.TabIndex = 145;
            this.lbngaybd.Text = "Ngày bắt đầu";
            // 
            // lbDSSD
            // 
            this.lbDSSD.AutoSize = true;
            this.lbDSSD.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSSD.Location = new System.Drawing.Point(430, 20);
            this.lbDSSD.Name = "lbDSSD";
            this.lbDSSD.Size = new System.Drawing.Size(255, 33);
            this.lbDSSD.TabIndex = 144;
            this.lbDSSD.Text = "SỔ CÁI TÀI KHOẢN";
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.SoCT,
            this.DienGiai,
            this.TaiKhoanDoiUng,
            this.PS_No,
            this.PS_Co});
            this.dgv.DataSource = this.prSoCaiDetailBindingSource;
            this.dgv.Location = new System.Drawing.Point(34, 158);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1241, 486);
            this.dgv.TabIndex = 143;
            // 
            // cboMaTKC
            // 
            this.cboMaTKC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTKC.FormattingEnabled = true;
            this.cboMaTKC.Location = new System.Drawing.Point(221, 68);
            this.cboMaTKC.Name = "cboMaTKC";
            this.cboMaTKC.Size = new System.Drawing.Size(170, 26);
            this.cboMaTKC.TabIndex = 150;
            this.cboMaTKC.SelectedIndexChanged += new System.EventHandler(this.cboMaTKC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 151;
            this.label1.Text = "Tên tài khoản";
            // 
            // txtTenTKC
            // 
            this.txtTenTKC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTKC.Location = new System.Drawing.Point(562, 68);
            this.txtTenTKC.Name = "txtTenTKC";
            this.txtTenTKC.Size = new System.Drawing.Size(304, 25);
            this.txtTenTKC.TabIndex = 152;
            // 
            // qLRBWDsSoCai
            // 
            this.qLRBWDsSoCai.DataSetName = "QLRBWDsSoCai";
            this.qLRBWDsSoCai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prSoCaiDetailBindingSource
            // 
            this.prSoCaiDetailBindingSource.DataMember = "pr_SoCai_Detail";
            this.prSoCaiDetailBindingSource.DataSource = this.qLRBWDsSoCai;
            // 
            // pr_SoCai_DetailTableAdapter
            // 
            this.pr_SoCai_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = global::_4196_NguyenTriKhang_KLTN_.Properties.Resources._in;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(1056, 20);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(149, 30);
            this.btnXuatFile.TabIndex = 149;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "NgayLap";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // SoCT
            // 
            this.SoCT.DataPropertyName = "SoCT";
            this.SoCT.HeaderText = "SoCT";
            this.SoCT.MinimumWidth = 6;
            this.SoCT.Name = "SoCT";
            this.SoCT.Width = 125;
            // 
            // DienGiai
            // 
            this.DienGiai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "DienGiai";
            this.DienGiai.MinimumWidth = 6;
            this.DienGiai.Name = "DienGiai";
            // 
            // TaiKhoanDoiUng
            // 
            this.TaiKhoanDoiUng.DataPropertyName = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.HeaderText = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.MinimumWidth = 6;
            this.TaiKhoanDoiUng.Name = "TaiKhoanDoiUng";
            this.TaiKhoanDoiUng.ReadOnly = true;
            this.TaiKhoanDoiUng.Width = 125;
            // 
            // PS_No
            // 
            this.PS_No.DataPropertyName = "PS_No";
            this.PS_No.HeaderText = "PS_No";
            this.PS_No.MinimumWidth = 6;
            this.PS_No.Name = "PS_No";
            this.PS_No.ReadOnly = true;
            this.PS_No.Width = 125;
            // 
            // PS_Co
            // 
            this.PS_Co.DataPropertyName = "PS_Co";
            this.PS_Co.HeaderText = "PS_Co";
            this.PS_Co.MinimumWidth = 6;
            this.PS_Co.Name = "PS_Co";
            this.PS_Co.ReadOnly = true;
            this.PS_Co.Width = 125;
            // 
            // SoCai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 655);
            this.Controls.Add(this.txtTenTKC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaTKC);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.lbngaykt);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lbngaybd);
            this.Controls.Add(this.lbDSSD);
            this.Controls.Add(this.dgv);
            this.Name = "SoCai";
            this.Text = "SoCai";
            this.Load += new System.EventHandler(this.SoCai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLRBWDsSoCai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prSoCaiDetailBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cboMaTKC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTKC;
        private System.Windows.Forms.BindingSource prSoCaiDetailBindingSource;
        private QLRBWDsSoCai qLRBWDsSoCai;
        private QLRBWDsSoCaiTableAdapters.pr_SoCai_DetailTableAdapter pr_SoCai_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanDoiUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn PS_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PS_Co;
    }
}