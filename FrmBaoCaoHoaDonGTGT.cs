using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class FrmBaoCaoHoaDonGTGT : Form
    {
        public FrmBaoCaoHoaDonGTGT()
        {
            InitializeComponent();
        }
        public void HienThiBaoCaoHoaDonGTGT(DataTable dtHeader, DataTable dtDetail)
        {
            // 1. Thiết lập file RDLC
            rptViewer.LocalReport.ReportPath = "rptHDGTGT.rdlc";

            // Xóa các nguồn dữ liệu cũ
            rptViewer.LocalReport.DataSources.Clear();

            // 2. Gán dữ liệu Header
            ReportDataSource rdsHeader = new ReportDataSource();
            // TÊN NÀY PHẢI KHỚP VỚI TÊN DATASET HEADER TRONG FILE RDLC!
            rdsHeader.Name = "HDGTGTIn";
            rdsHeader.Value = dtHeader;
            rptViewer.LocalReport.DataSources.Add(rdsHeader);

            // 3. Gán dữ liệu Detail
            ReportDataSource rdsDetail = new ReportDataSource();
            // TÊN NÀY PHẢI KHỚP VỚI TÊN DATASET DETAIL TRONG FILE RDLC!
            rdsDetail.Name = "HDGTGTDetail";
            rdsDetail.Value = dtDetail;
            rptViewer.LocalReport.DataSources.Add(rdsDetail);

            // 4. Hiển thị báo cáo
            rptViewer.RefreshReport();
        }

        private void FrmBaoCaoHoaDonGTGT_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }
    }
}
