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
    public partial class FrmChiTietChungTu : Form
    {
        private string chucVu;
        public FrmChiTietChungTu(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
        }
        private void ConfigureRoleBasedVisibility()
        {
            if (this.chucVu == "Quản lý")
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnThem.Visible = false;
            }
            else
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                btnThem.Visible = true;
            }
        }

        private void FrmChiTietChungTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsCTTT.CHITIETCHUNGTU' table. You can move, or remove it, as needed.
            this.cHITIETCHUNGTUTableAdapter.Fill(this.qLRBWDsCTTT.CHITIETCHUNGTU);

        }
        private void LoadChiTietChungTu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CHITIETCHUNGTU ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSanPham.DataSource = dt;
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaCT.Text = row.Cells["MaCT"].Value?.ToString();
                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                dtpNgayLap.Text = row.Cells["NgayLap"].Value?.ToString();
                txtSlgSP.Text = row.Cells["SlSP"].Value?.ToString();
                txtDgSP.Text = row.Cells["DGSP"].Value?.ToString();


                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCT.Text = "";
            btnLuu.Visible = true;
            txtMaSP.Text = "";
            txtSlgSP.Text = "";
            txtDgSP.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết chứng từ cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dgvSanPham.SelectedRows[0];
            string maCT = selectedRow.Cells["MaCT"].Value.ToString();
            string maSP = selectedRow.Cells["MaSP"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết chứng từ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM CHITIETCHUNGTU WHERE MaCT = @MaCT AND MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaCT", maCT);
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa chi tiết chứng từ thành công.");
                            LoadChiTietChungTu();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            LoadChiTietChungTu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra hàng được chọn
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết chứng từ cần sửa.");
                return;
            }

            DataGridViewRow selectedRow = dgvSanPham.SelectedRows[0];

            // 💡 LẤY KHÓA CHÍNH CŨ TỪ HÀNG ĐƯỢC CHỌN (Dùng để tìm bản ghi)
            string maCT_Cu = selectedRow.Cells["MaCT"].Value.ToString();
            string maSP_Cu = selectedRow.Cells["MaSP"].Value.ToString();

            // 2. Lấy giá trị mới từ các Control
            string maCT_Moi = txtMaCT.Text; // Dù bạn không dùng nó trong UPDATE, nên lấy nếu cần logic phức tạp hơn
            string maSP_Moi = txtMaSP.Text;
            string slgSP_Moi = txtSlgSP.Text;
            string dgSP_Moi = txtDgSP.Text;

            DateTime NgayLap;
            if (!DateTime.TryParse(dtpNgayLap.Text, out NgayLap))
            {
                MessageBox.Show("Ngày lập không hợp lệ.");
                return;
            }
            NgayLap = NgayLap.Date;

            // 3. Chuỗi SQL: SET dùng tham số MỚI, WHERE dùng tham số CŨ
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            string query = "UPDATE CHITIETCHUNGTU SET MaCT = @MaCT_Moi, MaSP = @MaSP_Moi, NgayLap = @NgayLap, SlSP = @SlSP_Moi, DGSP = @DGSP_Moi " +
                           "WHERE MaCT = @MaCT_Cu AND MaSP = @MaSP_Cu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 4. Gán Tham Số

                    // GIÁ TRỊ MỚI (SET)
                    command.Parameters.AddWithValue("@MaCT_Moi", maCT_Moi);
                    command.Parameters.AddWithValue("@MaSP_Moi", maSP_Moi);
                    command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = NgayLap;

                    // 💡 Cần chuyển đổi sang kiểu số (int/decimal) nếu cột trong DB là kiểu số
                    command.Parameters.AddWithValue("@SlSP_Moi", slgSP_Moi);
                    command.Parameters.AddWithValue("@DGSP_Moi", dgSP_Moi);

                    // GIÁ TRỊ CŨ (WHERE)
                    command.Parameters.AddWithValue("@MaCT_Cu", maCT_Cu);
                    command.Parameters.AddWithValue("@MaSP_Cu", maSP_Cu);

                    connection.Open();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật chi tiết chứng từ thành công.");
                            LoadChiTietChungTu();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy chi tiết chứng từ nào để cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadChiTietChungTu();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maCT = txtMaCT.Text;
            DateTime NgayLap;
            if (!DateTime.TryParse(dtpNgayLap.Text, out NgayLap))
            {
                MessageBox.Show("Ngày lập không hợp lệ.");
                return;
            }
            NgayLap = NgayLap.Date;
            string maSP = txtMaSP.Text;
            string slgSP = txtSlgSP.Text;
            string dgSP = txtDgSP.Text;

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // 🔹 Thực hiện INSERT chi tiết chứng từ mới
                string query = "INSERT INTO CHITIETCHUNGTU (MaCT, MaSP, NgayLap, SlSP, DGSP)" +
                               "VALUES (@MaCT, @MaSP, @NgayLap, @SlSP, @DGSP)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaCT", maCT);
                    command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = NgayLap;
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@SlSP", slgSP);
                    command.Parameters.AddWithValue("@DGSP", dgSP);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm chi tiết chứng từ thành công.");
                        LoadChiTietChungTu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadChiTietChungTu();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã chứng từ để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT * FROM CHITIETCHUNGTU WHERE MaCT LIKE @MaCT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaCT", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    // Hiển thị kết quả lên DataGridView
                    dgvSanPham.DataSource = dt;

                    // Đặt tiêu đề cho các cột của DataGridView
                    dgvSanPham.Columns["MaCT"].HeaderText = "MaCT";
                    dgvSanPham.Columns["MaSP"].HeaderText = "MaSP";
                    dgvSanPham.Columns["NgayLap"].HeaderText = "NgayLap";
                    dgvSanPham.Columns["SlSP"].HeaderText = "SlSP";
                    dgvSanPham.Columns["DGSP"].HeaderText = "DGSP";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra chi tiết chứng từ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
