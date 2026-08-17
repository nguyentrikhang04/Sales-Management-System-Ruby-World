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
    public partial class FrmSoChiTietVatTuHangHoa : Form
    {
        public FrmSoChiTietVatTuHangHoa()
        {
            InitializeComponent();
        }

        private void FrmSoChiTietVatTuHangHoa_Load(object sender, EventArgs e)
        {

            //this.rptViewer.RefreshReport();
        }
        public void LoadReport(DataTable dtReportData, DataTable dtHeaderData, DateTime ngayBD, DateTime ngayKT, string maTKChinh, string tenTKChinh)
        {
            ReportDataSource rds = new ReportDataSource("dsSoCTVTHH", dtReportData);
            rptViewer.LocalReport.ReportPath = "rptSoCTVTHH.rdlc";
            ReportDataSource rdsHeader = new ReportDataSource("dsHeaderSCTVTHH", dtHeaderData);

            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(rds);
            rptViewer.LocalReport.DataSources.Add(rdsHeader);

            ReportParameter rpNgayBD = new ReportParameter("NgayBatDau", ngayBD.ToString("dd/MM/yyyy"));
            ReportParameter rpNgayKT = new ReportParameter("NgayKetThuc", ngayKT.ToString("dd/MM/yyyy"));
            ReportParameter rpMaTKC = new ReportParameter("MaTKC", maTKChinh);
            ReportParameter rpTenTKC = new ReportParameter("TenTKC", tenTKChinh);
            rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpNgayBD, rpNgayKT, rpMaTKC, rpTenTKC });

            rptViewer.RefreshReport();
        }
    }
}
