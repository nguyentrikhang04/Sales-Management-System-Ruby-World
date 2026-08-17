using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class BaoCaoCongNoPhaiThuKhachHang : Form
    {
        public BaoCaoCongNoPhaiThuKhachHang()
        {
            InitializeComponent();
        }

        private void BaoCaoCongNoPhaiThuKhachHang_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpNgayBD.Value = firstDayOfMonth;
            dtpNgayKT.Value = today;
        }

        public DataTable LayDuLieuSoNhatKyThuTien(DateTime ngayBD, DateTime ngayKT)
        {
            string query = @"
                            SELECT 
                                KH.MaKH,
                                KH.HoTenKH AS TenKhachHang,
                                KH.MaTKCT AS TaiKhoanCongNo,
                                ISNULL(FORMAT(CASE WHEN ISNULL(SD.DuNo, 0) > 0 THEN SD.DuNo ELSE NULL END, '#,##0', 'vi-VN'), 0) AS NoDauKy,
                                ISNULL(FORMAT(CASE WHEN ISNULL(SD.DuCo, 0) > 0 THEN SD.DuCo ELSE NULL END, '#,##0', 'vi-VN'), 0) AS CoDauKy,
                                ISNULL(FORMAT(CASE WHEN ISNULL(PS_No.SoTien, 0) > 0 THEN PS_No.SoTien ELSE NULL END, '#,##0', 'vi-VN'), 0) AS PhatSinhNo,
                                ISNULL(FORMAT(CASE WHEN ISNULL(PS_Co.SoTien, 0) > 0 THEN PS_Co.SoTien ELSE NULL END, '#,##0', 'vi-VN'), 0) AS PhatSinhCo,
                                ISNULL(FORMAT(CASE 
                                    WHEN (ISNULL(SD.DuNo, 0) + ISNULL(PS_No.SoTien, 0) - ISNULL(PS_Co.SoTien, 0)) > 0 
                                    THEN (ISNULL(SD.DuNo, 0) + ISNULL(PS_No.SoTien, 0) - ISNULL(PS_Co.SoTien, 0))
                                    ELSE NULL 
                                END, '#,##0', 'vi-VN'), 0) AS NoCuoiKy,
                                ISNULL(FORMAT(CASE 
                                    WHEN (ISNULL(SD.DuCo, 0) + ISNULL(PS_Co.SoTien, 0) - ISNULL(PS_No.SoTien, 0)) > 0 
                                    THEN (ISNULL(SD.DuCo, 0) + ISNULL(PS_Co.SoTien, 0) - ISNULL(PS_No.SoTien, 0))
                                    ELSE NULL 
                                END, '#,##0', 'vi-VN'), 0) AS CoCuoiKy
                            FROM KhachHang KH
                            LEFT JOIN SoDuDauKy SD ON KH.MaTKCT = SD.MaTKCT AND SD.NgayDK = '2025-01-01'
                            LEFT JOIN (
                                SELECT CT.MaKH, SUM(BT.DonGia * ISNULL(CTD.SlSP, 1)) AS SoTien
                                FROM CHUNGTU CT
                                JOIN Buttoan BT ON CT.MaBT = BT.MaBT
                                LEFT JOIN CHITIETCHUNGTU CTD ON CT.MaCT = CTD.MaCT
                                WHERE BT.TKNO LIKE '131%' 
                                  AND CT.NgayLap >= @TuNgay AND CT.NgayLap < @NgayKT
                                GROUP BY CT.MaKH
                            ) PS_No ON KH.MaKH = PS_No.MaKH
                            LEFT JOIN (
                                SELECT CT.MaKH, SUM(BT.DonGia * ISNULL(CTD.SlSP, 1)) AS SoTien
                                FROM CHUNGTU CT
                                JOIN Buttoan BT ON CT.MaBT = BT.MaBT
                                LEFT JOIN CHITIETCHUNGTU CTD ON CT.MaCT = CTD.MaCT
                                WHERE BT.TKCO LIKE '131%' 
                                  AND CT.NgayLap >= @TuNgay AND CT.NgayLap < @NgayKT
                                GROUP BY CT.MaKH
                            ) PS_Co ON KH.MaKH = PS_Co.MaKH
                            WHERE KH.MaTKCT LIKE '131%'
                              AND (
                                  ISNULL(SD.DuNo,0) > 0 OR ISNULL(SD.DuCo,0) > 0 
                                  OR ISNULL(PS_No.SoTien,0) > 0 OR ISNULL(PS_Co.SoTien,0) > 0
                              )
                            ORDER BY KH.MaKH";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuNgay", ngayBD);
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
                using (SqlCommand cmd = new SqlCommand("pr_CongNoPhaiThu_Header", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuNgay", ngayBD);
                    cmd.Parameters.AddWithValue("@DenNgay", ngayKetThuc_Filter);

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
                FrmBaoCaoCongNoPhaiThuKhachHang frmReport = new FrmBaoCaoCongNoPhaiThuKhachHang();
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
