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
    public partial class FrmBaoCaoTGNH : Form
    {
        public FrmBaoCaoTGNH()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoTGNH_Load(object sender, EventArgs e)
        {

            //this.rptViewer.RefreshReport();
        }

        public void LoadReport(DataTable dtReportData, DataTable dtHeaderData, DateTime ngayBD, DateTime ngayKT)
        {
            ReportDataSource rds = new ReportDataSource("dsSoTienGuiNganHang", dtReportData);

            // Thiết lập ReportPath (Đảm bảo đường dẫn file .rdlc là chính xác)
            rptViewer.LocalReport.ReportPath = "rptSoTienGuiNganHang.rdlc";
            ReportDataSource rdsHeader = new ReportDataSource("dsHeaderTGNH", dtHeaderData);

            // Thêm Data Source và Tham số ngày
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(rds);
            rptViewer.LocalReport.DataSources.Add(rdsHeader);

            // Chuẩn bị tham số cho Header báo cáo
            ReportParameter rpNgayBD = new ReportParameter("NgayBatDau", ngayBD.ToString("dd/MM/yyyy"));
            ReportParameter rpNgayKT = new ReportParameter("NgayKetThuc", ngayKT.ToString("dd/MM/yyyy"));
            rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpNgayBD, rpNgayKT });

            // Tải báo cáo
            rptViewer.RefreshReport();
        }
    }
}
