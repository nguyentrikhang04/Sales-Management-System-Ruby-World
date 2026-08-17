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
    public partial class SoNhatKyChung : Form
    {
        public SoNhatKyChung()
        {
            InitializeComponent();
        }

        private void SoNhatKyChung_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpNgayBD.Value = firstDayOfMonth;
            dtpNgayKT.Value = today;
        }

        public DataTable LayDuLieuSoNhatKyThuTien(DateTime ngayBD, DateTime ngayKT)
        {
            string query = @"
                            SET NOCOUNT ON;
                            ;WITH ButToanGroup AS (
                                SELECT
                                    CT.NgayLap,
                                    CT.SoCT,
                                    CT.MoTa AS DienGiai,
                                    MAX(CASE WHEN BT.TKNO IS NOT NULL THEN BT.TKNO END) AS TK_No,
                                    MAX(CASE WHEN BT.TKNO IS NOT NULL THEN ISNULL(BT.DonGia * CTD.SlSP, BT.DonGia) END) AS Tien_No,
                                    MAX(CASE WHEN BT.TKCO IS NOT NULL THEN BT.TKCO END) AS TK_Co,
                                    MAX(CASE WHEN BT.TKCO IS NOT NULL THEN ISNULL(BT.DonGia * CTD.SlSP, BT.DonGia) END) AS Tien_Co,
                                    ROW_NUMBER() OVER (ORDER BY CT.NgayLap, CT.SoCT) AS SortKey
                                FROM CHUNGTU CT
                                JOIN Buttoan BT ON CT.MaBT = BT.MaBT
                                LEFT JOIN CHITIETCHUNGTU CTD ON CT.MaCT = CTD.MaCT
                                WHERE CT.NgayLap >= @TuNgay AND CT.NgayLap <= @DenNgay
                                GROUP BY CT.NgayLap, CT.SoCT, CT.MoTa
                            )

                            SELECT
                                CONVERT(varchar, NgayLap, 103) AS NgayCT,
                                SoCT,
                                DienGiai,
                                TK_No AS TaiKhoan,
                                FORMAT(Tien_No, '#,##0', 'vi-VN') AS PhatSinhNo,
                                '' AS PhatSinhCo,
                                SortKey * 2 - 1 AS OrderCol
                            FROM ButToanGroup
                            WHERE TK_No IS NOT NULL

                            UNION ALL

                            SELECT
                                '' AS NgayCT,
                                '' AS SoCT,
                                '' AS DienGiai,
                                TK_Co AS TaiKhoan,
                                '' AS PhatSinhNo,
                                FORMAT(Tien_Co, '#,##0', 'vi-VN') AS PhatSinhCo,
                                SortKey * 2 AS OrderCol
                            FROM ButToanGroup
                            WHERE TK_Co IS NOT NULL

                            ORDER BY OrderCol;";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số ngày vào truy vấn
                    cmd.Parameters.AddWithValue("@TuNgay", ngayBD);
                    cmd.Parameters.AddWithValue("@DenNgay", ngayKT);

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
                using (SqlCommand cmd = new SqlCommand("pr_NhatKyChung_Header", conn))
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
                DateTime denngay = dtpNgayKT.Value;
                DateTime ngayKetThuc = dtpNgayKT.Value.AddDays(1);
                DataTable dtBaoCao = LayDuLieuSoNhatKyThuTien(ngayBatDau, denngay);
                DataTable dtBaoCaoHeader = LayDuLieuSoNhatKyThuTien_Header(ngayBatDau, ngayKetThuc);
                FrmBaoCaoSoNhatKyChung frmReport = new FrmBaoCaoSoNhatKyChung();
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
