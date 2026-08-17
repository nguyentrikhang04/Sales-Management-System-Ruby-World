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
    public partial class SoChiTietVatTuHangHoa : Form
    {
        public SoChiTietVatTuHangHoa()
        {
            InitializeComponent();
        }

        private void SoChiTietVatTuHangHoa_Load(object sender, EventArgs e)
        {
            LoadTKCT();
            cboMaTKC.SelectedIndexChanged += new EventHandler(cboMaTKC_SelectedIndexChanged);
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpNgayBD.Value = firstDayOfMonth;
            dtpNgayKT.Value = today;
            LoadDuLieuSoCai();
        }
        private void LoadTKCT()
        {
            
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = @"
                                    SELECT TRIM(MaTKCT) AS MATK, TenTKCT AS TENTK
                                    FROM TaiKhoanCT
                                    WHERE MaTKCT LIKE '15%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboMaTKC.DisplayMember = "MATK";
                cboMaTKC.ValueMember = "MATK";
                cboMaTKC.DataSource = dt;
                cboMaTKC.Tag = dt;
            }
        }
        private void LoadDuLieuSoCai()
        {
            if (cboMaTKC.SelectedItem == null)
            {
                return;
            }

            try
            {
                string maTKChinh = cboMaTKC.SelectedValue.ToString().Trim();
                DateTime ngayBD = dtpNgayBD.Value;
                DateTime ngayKTFilter = dtpNgayKT.Value.AddDays(1);
                DataTable dtDetail = LayDuLieuSoCai_Detail(ngayBD, ngayKTFilter, maTKChinh);
                dgv.DataSource = dtDetail;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Sổ Cái: " + ex.Message);
            }
        }
        private void cboMaTKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cboMaTKC.Tag as DataTable;
            if (dt == null || cboMaTKC.SelectedValue == null)
            {
                txtTenTKC.Text = string.Empty;
                return;
            }
            string maTaiKhoan = cboMaTKC.SelectedValue.ToString();
            DataRow[] selectedRows = dt.Select($"MATK = '{maTaiKhoan}'");

            if (selectedRows.Length > 0)
            {
                txtTenTKC.Text = selectedRows[0]["TENTK"].ToString();
            }
            else
            {
                txtTenTKC.Text = string.Empty;
            }
            LoadDuLieuSoCai();
        }
        public DataTable LayDuLieuSoCai_Detail(DateTime ngayBD, DateTime ngayKT, string maTKChinh)
        {
            string query = @"
                            SELECT
                                FORMAT(CHUNGTU.NgayLap, 'dd/MM/yyyy') AS NgayLap,
                                CHUNGTU.SoCT,
                                CHUNGTU.Mota AS DienGiai,
                                Buttoan.DonGia,
                                CASE
                                    WHEN Buttoan.TKNO LIKE @MaTKChinh + '%' THEN Buttoan.TKCO
                                    WHEN Buttoan.TKCO LIKE @MaTKChinh + '%' THEN Buttoan.TKNO
                                    ELSE ''
                                END AS TaiKhoanDoiUng,
                                CASE WHEN Buttoan.TKNO LIKE @MaTKChinh + '%'
                                     THEN CHITIETCHUNGTU.SlSP
                                     ELSE 0
                                END AS SoLuongNhap,
                                CASE WHEN Buttoan.TKNO LIKE @MaTKChinh + '%'
                                     THEN CHITIETCHUNGTU.SlSP * CHITIETCHUNGTU.DGSP
                                     ELSE 0
                                END AS ThanhTienNhap,
                                CASE WHEN Buttoan.TKCO LIKE @MaTKChinh + '%'
                                     THEN CHITIETCHUNGTU.SlSP
                                     ELSE 0
                                END AS SoLuongXuat,
                                CASE WHEN Buttoan.TKCO LIKE @MaTKChinh + '%'
                                     THEN CHITIETCHUNGTU.SlSP * CHITIETCHUNGTU.DGSP
                                     ELSE 0
                                END AS ThanhTienXuat
                            FROM
                                CHUNGTU
                                JOIN Buttoan ON CHUNGTU.MaBT = Buttoan.MaBT
		                        LEFT JOIN CHITIETCHUNGTU ON CHUNGTU.MaCT = CHITIETCHUNGTU.MaCT
                            WHERE
                                (TRIM(Buttoan.TKNO) LIKE @MaTKChinh + '%' OR TRIM(Buttoan.TKCO) LIKE @MaTKChinh + '%')
                                AND CHUNGTU.NgayLap >= @NgayBD
                                AND CHUNGTU.NgayLap < @NgayKT
                            ORDER BY
                                CHUNGTU.NgayLap, CHUNGTU.SoCT;";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKT);
                    cmd.Parameters.AddWithValue("@MaTKChinh", maTKChinh);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void LoadDataToGrid()
        {
            try
            {
                DateTime ngayBatDau = dtpNgayBD.Value;
                DateTime ngayKetThucFilter = dtpNgayKT.Value.AddDays(1);

                string maTKChinh = cboMaTKC.SelectedValue.ToString().Trim();
                if (ngayBatDau >= ngayKetThucFilter)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable dtBaoCao = LayDuLieuSoCai_Detail(ngayBatDau, ngayKetThucFilter, maTKChinh);
                dgv.DataSource = dtBaoCao;
                dgv.AutoResizeColumns();
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

        public DataTable LayDuLieuSoCai_Header(DateTime ngayBD, DateTime ngayKT, string maTKChinh)
        {
            DateTime ngayKetThuc_Filter = ngayKT.AddDays(1);
            DataTable dt = new DataTable();
            string connString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("pr_SCT_VTHH_Header", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKetThuc_Filter);
                    cmd.Parameters.AddWithValue("@MaTKCT", maTKChinh);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (cboMaTKC.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maTKChinh = cboMaTKC.SelectedValue.ToString().Trim();
            DateTime ngayBatDau = dtpNgayBD.Value;
            DateTime ngayKetThuc = dtpNgayKT.Value.AddDays(1);
            DataTable dtBaoCao = LayDuLieuSoCai_Detail(ngayBatDau, ngayKetThuc, maTKChinh);
            DataTable dtBaoCaoHeader = LayDuLieuSoCai_Header(ngayBatDau, ngayKetThuc, maTKChinh);
            FrmSoChiTietVatTuHangHoa frmReport = new FrmSoChiTietVatTuHangHoa();
            frmReport.LoadReport(
                dtBaoCao,
                dtBaoCaoHeader,
                dtpNgayBD.Value,
                dtpNgayKT.Value,
                cboMaTKC.Text,
                txtTenTKC.Text
            );
            frmReport.ShowDialog();
        }
    }
}
