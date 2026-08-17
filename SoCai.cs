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
    public partial class SoCai : Form
    {
        public SoCai()
        {
            InitializeComponent();
        }

        private void SoCai_Load(object sender, EventArgs e)
        {

            cboMaTKC.Items.Add("111");
            cboMaTKC.Items.Add("112");
            cboMaTKC.Items.Add("131");
            cboMaTKC.SelectedIndex = 0;
            cboMaTKC.SelectedIndexChanged += new EventHandler(cboMaTKC_SelectedIndexChanged);
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpNgayBD.Value = firstDayOfMonth;
            dtpNgayKT.Value = today;
            LoadDuLieuSoCai();
        }
        private void LoadDuLieuSoCai()
        {
            if (cboMaTKC.SelectedItem == null)
            {
                return;
            }

            try
            {
                string maTKChinh = cboMaTKC.SelectedItem.ToString();
                DateTime ngayBD = dtpNgayBD.Value;
                DateTime ngayKTFilter = dtpNgayKT.Value.AddDays(1);
                DataTable dtDetail = LayDuLieuSoCai_Detail(ngayBD, ngayKTFilter, maTKChinh);
                dgv.DataSource = dtDetail;

            }
            catch (Exception ex)
            {
                // Nếu có lỗi SQL hoặc lỗi kết nối, nó sẽ hiển thị ở đây
                MessageBox.Show("Lỗi tải dữ liệu Sổ Cái: " + ex.Message);
            }
        }
        private void cboMaTKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuLieuSoCai();
            string selectedItem = cboMaTKC.SelectedItem.ToString();

            if (selectedItem == "111")
            {
                txtTenTKC.Text = "Tiền mặt";
            }
            else if (selectedItem == "112")
            {
                txtTenTKC.Text = "Tiền gửi ngân hàng";
            }
            else if (selectedItem == "131")
            {
                txtTenTKC.Text = "Phải thu khách hàng";
            }
        }
        public DataTable LayDuLieuSoCai_Detail(DateTime ngayBD, DateTime ngayKT, string maTKChinh)
        {
            string query = @"
                            SELECT
                                FORMAT(CHUNGTU.NgayLap, 'dd/MM/yyyy') AS NgayLap,
                                CHUNGTU.SoCT,
                                CHUNGTU.Mota AS DienGiai,
                                MAX(CASE
                                    WHEN Buttoan.TKNO LIKE @MaTKChinh + '%' THEN Buttoan.TKCO
                                    WHEN Buttoan.TKCO LIKE @MaTKChinh + '%' THEN Buttoan.TKNO
                                    ELSE ''
                                END) AS TaiKhoanDoiUng,
                                FORMAT(SUM(CASE 
                                    WHEN Buttoan.TKNO LIKE @MaTKChinh + '%' THEN Buttoan.SoLuong * Buttoan.DonGia 
                                    ELSE 0 
                                END), '#,##0', 'vi-VN') AS PS_No,
                                FORMAT(SUM(CASE 
                                    WHEN Buttoan.TKCO LIKE @MaTKChinh + '%' THEN Buttoan.SoLuong * Buttoan.DonGia 
                                    ELSE 0 
                                END), '#,##0', 'vi-VN') AS PS_Co
                            FROM 
                                CHUNGTU
                                JOIN Buttoan ON CHUNGTU.MaBT = Buttoan.MaBT
                            WHERE
                                (Buttoan.TKNO LIKE @MaTKChinh + '%' OR Buttoan.TKCO LIKE @MaTKChinh + '%')
                                AND CHUNGTU.NgayLap >= @NgayBD 
                                AND CHUNGTU.NgayLap < @NgayKT  
                            GROUP BY
                                CHUNGTU.NgayLap, CHUNGTU.SoCT, CHUNGTU.Mota
                            ORDER BY
                                CHUNGTU.NgayLap, CHUNGTU.SoCT;";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số ngày vào truy vấn
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
                DateTime ngayKetThuc = dtpNgayKT.Value;
                string maTKChinh = cboMaTKC.SelectedItem.ToString();
                if (ngayBatDau > ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataTable dtBaoCao = LayDuLieuSoCai_Detail(ngayBatDau, ngayKetThuc, maTKChinh);
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
                using (SqlCommand cmd = new SqlCommand("pr_SoCai_Header", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKetThuc_Filter);
                    cmd.Parameters.AddWithValue("@MaTKChinh", maTKChinh);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string maTKChinh = cboMaTKC.SelectedItem.ToString();
            DateTime ngayBatDau = dtpNgayBD.Value;
            DateTime ngayKetThuc = dtpNgayKT.Value.AddDays(1);
            DataTable dtBaoCao = LayDuLieuSoCai_Detail(ngayBatDau, ngayKetThuc, maTKChinh);
            DataTable dtBaoCaoHeader = LayDuLieuSoCai_Header(ngayBatDau, ngayKetThuc, maTKChinh);
            if (dtBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sổ cái trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmSoCai frmReport = new FrmSoCai();
            frmReport.LoadReport(dtBaoCao, dtBaoCaoHeader, dtpNgayBD.Value, dtpNgayKT.Value, cboMaTKC.Text, txtTenTKC.Text);
            frmReport.ShowDialog();
        }
    }
}
