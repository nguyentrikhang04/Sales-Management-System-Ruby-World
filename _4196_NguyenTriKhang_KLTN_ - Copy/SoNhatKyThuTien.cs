using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class SoNhatKyThuTien : Form
    {
        public SoNhatKyThuTien()
        {
            InitializeComponent();
        }

        private void SoNhatKyThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsNKTT.pr_SoNhatKyThuTien' table. You can move, or remove it, as needed.
            this.pr_SoNhatKyThuTienTableAdapter.Fill(this.qLRBWDsNKTT.pr_SoNhatKyThuTien);
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpNgayBD.Value = firstDayOfMonth;
            dtpNgayKT.Value = today;
        }

        public DataTable LayDuLieuSoNhatKyThuTien(DateTime ngayBD, DateTime ngayKT)
        {
            string query = @"
                            SELECT
                                FORMAT(CHUNGTU.NgayLap, 'dd/MM/yyyy') AS NgayLap,
                                CHUNGTU.SoCT, 
                                CHUNGTU.Mota AS DienGiai,
                                FORMAT(SUM(CASE WHEN Buttoan.TKNO LIKE '111%' THEN Buttoan.SoLuong * Buttoan.DonGia ELSE 0 END), '#,##0', 'vi-VN') AS GhiNo_TK111,
                                FORMAT(SUM(CASE WHEN Buttoan.TKCO LIKE '112%' THEN Buttoan.SoLuong * Buttoan.DonGia ELSE 0 END), '#,##0', 'vi-VN') AS GhiCo_TK112,
                                FORMAT(SUM(CASE WHEN Buttoan.TKCO LIKE '131%' THEN Buttoan.SoLuong * Buttoan.DonGia ELSE 0 END), '#,##0', 'vi-VN') AS GhiCo_TK131,
                                FORMAT(SUM(CASE WHEN Buttoan.TKCO LIKE '141%' THEN Buttoan.SoLuong * Buttoan.DonGia ELSE 0 END), '#,##0', 'vi-VN') AS GhiCo_TK141,
                                FORMAT(SUM(CASE WHEN Buttoan.TKCO LIKE '511%' THEN Buttoan.SoLuong * Buttoan.DonGia ELSE 0 END), '#,##0', 'vi-VN') AS GhiCo_TK511,
                                FORMAT(SUM(CASE 
                                    WHEN Buttoan.TKCO NOT LIKE '112%' AND Buttoan.TKCO NOT LIKE '131%'
		                            AND Buttoan.TKCO NOT LIKE '141%' AND Buttoan.TKCO NOT LIKE '511%'
                                    THEN Buttoan.SoLuong * Buttoan.DonGia
                                    ELSE 0 
                                END), '#,##0', 'vi-VN') AS TaiKhoanKhac_SoTien,
                                MAX(CASE 
                                    WHEN Buttoan.TKCO NOT LIKE '112%' AND Buttoan.TKCO NOT LIKE '131%'
		                            AND Buttoan.TKCO NOT LIKE '141%' AND Buttoan.TKCO NOT LIKE '511%'
                                    THEN Buttoan.TKCO
                                    ELSE ''
                                END) AS TaiKhoanKhac_SoHieu   
                            FROM
                                CHUNGTU
	                            JOIN Buttoan ON CHUNGTU.MaBT = Buttoan.MaBT
	                            JOIN LOAICHUNGTU ON LOAICHUNGTU.MaLCT = CHUNGTU.MaLCT 
                            WHERE
                                Buttoan.TKNO LIKE '111%' AND
                                CHUNGTU.NgayLap >= @NgayBD - 1 AND CHUNGTU.NgayLap <= @NgayKT
                                
                            GROUP BY
                                CHUNGTU.NgayLap, CHUNGTU.SoCT, CHUNGTU.Mota 
                            ORDER BY
                                CHUNGTU.NgayLap";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số ngày vào truy vấn
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKT);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable LayDuLieuSoNhatKyThuTien_Header(DateTime ngayBD, DateTime ngayKT)
        {
            DateTime ngayKetThuc_Filter = ngayKT.AddDays(1);

            DataTable dt = new DataTable();
            string connString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_SoNhatKyThuTien_Header", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKetThuc_Filter); // Truyền ngày đã AddDays(1)

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBatDau = dtpNgayBD.Value;
                DateTime ngayKetThuc = dtpNgayKT.Value.AddDays(1);
                DataTable dtBaoCao = LayDuLieuSoNhatKyThuTien(ngayBatDau, ngayKetThuc);
                DataTable dtBaoCaoHeader = LayDuLieuSoNhatKyThuTien_Header(ngayBatDau, ngayKetThuc);
                if (dtBaoCao.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thu tiền mặt trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FrmBaoCaoNKTT frmReport = new FrmBaoCaoNKTT();
                frmReport.LoadReport(dtBaoCao, dtBaoCaoHeader, dtpNgayBD.Value, dtpNgayKT.Value);
                frmReport.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void LoadDataToGrid()
        {
            try
            {
                DateTime ngayBatDau = dtpNgayBD.Value;
                DateTime ngayKetThuc = dtpNgayKT.Value;
                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable dtBaoCao = LayDuLieuSoNhatKyThuTien(ngayBatDau, ngayKetThuc);
                dgvSoNhatKyThuTien.DataSource = dtBaoCao;
                dgvSoNhatKyThuTien.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}
