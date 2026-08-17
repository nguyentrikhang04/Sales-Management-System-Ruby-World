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
    public partial class FrmBaoCaoPhieuThu : Form
    {
        public FrmBaoCaoPhieuThu()
        {
            InitializeComponent();
        }
        public void HienThiBaoCao(DataTable dsPhieuThuHeader)
        {
            rptViewer.LocalReport.DataSources.Clear();

            rptViewer.LocalReport.ReportEmbeddedResource = "_4196_NguyenTriKhang_KLTN_.rptPhieuThu.rdlc";

            ReportDataSource rdsHeader = new ReportDataSource();
            rdsHeader.Name = "PhieuThuIn";
            rdsHeader.Value = dsPhieuThuHeader;
            rptViewer.LocalReport.DataSources.Add(rdsHeader);
            rptViewer.RefreshReport();
        }

        private void FrmBaoCaoPhieuThu_Load(object sender, EventArgs e)
        {
            this.rptViewer.RefreshReport();
        }
    }
}
