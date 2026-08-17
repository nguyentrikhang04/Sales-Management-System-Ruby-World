using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class FrmButToan : Form
    {
        private string chucVu;
        KetNoi data = new KetNoi();
        public FrmButToan(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
        }
        public FrmButToan(string noiDung, string tkno, string tkco, int soLuong, decimal donGia)
        {
            
            InitializeComponent();
            LoadTaiKhoan();
            txtNoiDung.Text = noiDung;
            cbxTKNo.Text = tkno.Trim();
            cbxTKCo.Text = tkco.Trim();
            txtSoLuong.Text = soLuong.ToString();
            txtDonGia.Text = donGia.ToString("F2");
        }

        private void FrmButToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsButtoan.Buttoan' table. You can move, or remove it, as needed.
            this.buttoanTableAdapter.Fill(this.qLRBWDsButtoan.Buttoan);
        }
        private void LoadTaiKhoan()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // --- KHAI BÁO CÁC QUERY CẦN THIẾT ---
            string queryTK1 = "SELECT MaTK1 FROM TaiKhoanC1";
            string queryTKCT = "SELECT MaTKCT FROM TaiKhoanCT"; // Chỉ cần MaTKCT, vì MaTK1 được lấy ở query trên

            List<string> combinedAccounts = new List<string>();

            // VÙNG 1: TẢI TẤT CẢ TÀI KHOẢN CẤP 1 (MaTK1)
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(queryTK1, connection1);
                DataTable dtTK1 = new DataTable();
                adapter1.Fill(dtTK1);

                foreach (DataRow row in dtTK1.Rows)
                {
                    // Thêm tất cả MaTK1 vào danh sách (Ví dụ: 632, 511,...)
                    string maTK1 = row["MaTK1"].ToString().Trim();
                    if (!combinedAccounts.Contains(maTK1))
                    {
                        combinedAccounts.Add(maTK1);
                    }
                }
            }

            // VÙNG 2: TẢI TẤT CẢ TÀI KHOẢN CHI TIẾT (MaTKCT)
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter2 = new SqlDataAdapter(queryTKCT, connection2);
                DataTable dtTKCT = new DataTable();
                adapter2.Fill(dtTKCT);

                foreach (DataRow row in dtTKCT.Rows)
                {
                    // Thêm MaTKCT vào danh sách
                    string maTKCT = row["MaTKCT"].ToString().Trim();
                    if (!combinedAccounts.Contains(maTKCT))
                    {
                        combinedAccounts.Add(maTKCT);
                    }
                }
            }

            // SẮP XẾP VÀ GÁN DỮ LIỆU CHỈ MỘT LẦN
            combinedAccounts.Sort();

            // Gán cho TK Nợ
            cbxTKNo.DataSource = combinedAccounts;

            // Tạo bản sao và gán cho TK Có
            // Dùng ToList() để tạo bản sao độc lập, tránh việc thay đổi trên 1 combobox ảnh hưởng cái kia
            cbxTKCo.DataSource = combinedAccounts.ToList();
        }
        private void dgvButToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvButToan.Rows[e.RowIndex];

                txtMaBT.Text = row.Cells["MaBT"].Value?.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();

                // 1. Gán giá trị TK Nợ vào thuộc tính Text
                if (row.Cells["TKNO"].Value != null)
                {
                    cbxTKNo.Text = row.Cells["TKNO"].Value.ToString(); // Dùng .Text thay vì .SelectedValue
                }
                else
                {
                    cbxTKNo.SelectedIndex = -1;
                }

                // 2. Gán giá trị TK Có vào thuộc tính Text
                if (row.Cells["TKCO"].Value != null)
                {
                    cbxTKCo.Text = row.Cells["TKCO"].Value.ToString(); // Dùng .Text thay vì .SelectedValue
                }
                else
                {
                    cbxTKCo.SelectedIndex = -1;
                }

                // --- Phần còn lại giữ nguyên ---
                txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                txtMaBT.ReadOnly = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
        }
        private string LayMaBTCuoiCung()
        {
            string maBTCuoiCung = "";

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaBT FROM Buttoan ORDER BY MaBT DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maBTCuoiCung = reader["MaBT"].ToString();
                    }

                    reader.Close();
                }
            }

            return maBTCuoiCung;
        }

        private string TaoMaBTMoi()
        {
            string maBTCuoiCung = LayMaBTCuoiCung();
            if (string.IsNullOrEmpty(maBTCuoiCung))
            {
                return "BT01";
            }

            string phanSo = maBTCuoiCung.Substring(2);
            int soMoi = int.Parse(phanSo) + 1;
            string maBTMoi = "BT" + soMoi.ToString("D2");

            return maBTMoi;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMoi = TaoMaBTMoi();
            txtMaBT.Text = maMoi;
            btnLuu.Visible = true;
            txtMaBT.ReadOnly = true;
        }
        private void ClearInputFields()
        {
            txtMaBT.Clear();
            txtNoiDung.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            cbxTKNo.SelectedIndex = -1;
            cbxTKCo.SelectedIndex = -1;

            txtMaBT.ReadOnly = false;
        }
        private void LoadButtoan()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Buttoan";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvButToan.DataSource = dt;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maBT = txtMaBT.Text;
            string noiDung = txtNoiDung.Text;
            string soLuong = txtSoLuong.Text;
            string donGia = txtDonGia.Text;
            string tkno = cbxTKNo.SelectedValue?.ToString();
            string tkco = cbxTKCo.SelectedValue?.ToString();

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Buttoan (MaBT, NoiDung, TKNO, TKCO, SoLuong, DonGia)"+
                                "VALUES (@MaBT, @NoiDung, @TKNO, @TKCO, @SoLuong, @DonGia)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBT", maBT);
                    command.Parameters.AddWithValue("@NoiDung", noiDung);
                    command.Parameters.AddWithValue("@TKNO", tkno);
                    command.Parameters.AddWithValue("@TKCO", tkco);
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@DonGia", donGia);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm bút toán thành công.");
                        ClearInputFields();
                        LoadButtoan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadButtoan();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvButToan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bút tóan cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dgvButToan.SelectedRows[0];
            string maBT = selectedRow.Cells["MaBT"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bút toán này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Buttoan WHERE MaBT = @MaBT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBT", maBT);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa bút toán thành công.");
                            LoadButtoan();
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            LoadButtoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maBT = txtMaBT.Text;
            string noiDung = txtNoiDung.Text;
            string soLuong = txtSoLuong.Text;
            string donGia = txtDonGia.Text;
            string tkno = cbxTKNo.SelectedValue?.ToString();
            string tkco = cbxTKCo.SelectedValue?.ToString();

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "UPDATE Buttoan SET MaBT = @MaBT, NoiDung = @NoiDung, TKNO = @TKNO, " +
                           "TKCO = @TKCO, SoLuong = @SoLuong, DonGia = @DonGia " +
                           "WHERE MaBT = @MaBT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBT", maBT);
                    command.Parameters.AddWithValue("@NoiDung", noiDung);
                    command.Parameters.AddWithValue("@TKNO", tkno);
                    command.Parameters.AddWithValue("@TKCO", tkco);
                    command.Parameters.AddWithValue("@SoLuong", int.Parse(soLuong));
                    command.Parameters.AddWithValue("@DonGia", donGia);

                    connection.Open();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công.");
                            LoadButtoan();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có sản phẩm nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadButtoan();
        }
    }
}
