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
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
            LoadNhaCungCap();
            LoadNhomSP();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsSanPham.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.qLRBWDsSanPham.SanPham);
            string query = "SELECT * FROM SanPham";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True")
)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            dgvSanPham.DataSource = dataTable;

            dgvSanPham.Columns["MaSP"].Width = 70;
            dgvSanPham.Columns["TenSP"].Width = 150;
            dgvSanPham.Columns["DonViTinh"].Width = 50;
            dgvSanPham.Columns["Soluongton"].Width = 80;
            dgvSanPham.Columns["MaNhomSP"].Width = 70;
            dgvSanPham.Columns["MaNCC"].Width = 70;
            dgvSanPham.Columns["MaTKCT"].Width = 70;

            dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
            dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["DonViTinh"].HeaderText = "ĐVT";
            dgvSanPham.Columns["Soluongton"].HeaderText = "Số lượng";
            dgvSanPham.Columns["MaNhomSP"].HeaderText = "Mã NSP";
            dgvSanPham.Columns["MaNCC"].HeaderText = "Mã NCC";
            dgvSanPham.Columns["MaTKCT"].HeaderText = "Mã TKCT";

            dgvSanPham.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            LoadNhaCungCap();
            LoadNhomSP();
        }
        KetNoi data = new KetNoi();
        private void LoadNhomSP()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNhomSP, TenNhom FROM NhomSP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboNhomSP.DisplayMember = "TenNhom";
                cboNhomSP.ValueMember = "MaNhomSP";
                cboNhomSP.DataSource = dt;
            }
        }

        private void LoadNhaCungCap()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNCC, TenNCC FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
                cboNCC.DataSource = dt;
            }
        }

        private void LoadSanPham()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSP, TenSP, DonViTinh, Soluongton, MaNhomSP, MaNCC, MaTKCT FROM SanPham";
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

                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txtDVT.Text = row.Cells["DonViTinh"].Value?.ToString();
                txtSoluong.Text = row.Cells["Soluongton"].Value?.ToString();

                cboNhomSP.SelectedValue = row.Cells["MaNhomSP"].Value?.ToString();
                cboNCC.SelectedValue = row.Cells["MaNCC"].Value?.ToString();

                txtMaSP.ReadOnly = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
            }
        }

        private string LayMaSPCuoiCung()
        {
            string maSPCuoiCung = "";

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaSP FROM SanPham ORDER BY MaSP DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maSPCuoiCung = reader["MaSP"].ToString();
                    }

                    reader.Close();
                }
            }

            return maSPCuoiCung;
        }

        private string TaoMaSPMoi()
        {
            string maSPCuoiCung = LayMaSPCuoiCung();
            if (string.IsNullOrEmpty(maSPCuoiCung))
            {
                return "SP01";
            }

            string phanSo = maSPCuoiCung.Substring(2);
            int soMoi = int.Parse(phanSo) + 1;
            string maSPMoi = "SP" + soMoi.ToString("D2");

            return maSPMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSPMoi = TaoMaSPMoi();
            txtMaSP.Text = maSPMoi;
            btnLuu.Visible = true;
            txtTenSP.Text = "";
            txtDVT.Text = "";
            txtSoluong.Text = "";
            cboNhomSP.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;

            txtMaSP.ReadOnly = true;
        }

        private void ClearInputFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDVT.Clear();
            txtSoluong.Clear();
            cboNhomSP.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;

            txtMaSP.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string DVT = txtDVT.Text;
            string Soluong = txtSoluong.Text;
            string NhomSP = cboNhomSP.SelectedValue?.ToString();
            string NCC = cboNCC.SelectedValue?.ToString();

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 🔹 Đếm số lượng sản phẩm hiện có trong bảng SanPham
                string countQuery = "SELECT COUNT(*) FROM SanPham";
                int soLuongSanPham = 0;

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    soLuongSanPham = (int)countCommand.ExecuteScalar();
                }

                // 🔹 Tạo MaTKCT theo công thức 1561 + (số lượng sản phẩm + 1)
                string maTKCT = "1561" + (soLuongSanPham + 1).ToString();

                // 🔹 Kiểm tra nếu MaTKCT đã tồn tại trong bảng TaiKhoanCT chưa
                string checkQuery = "SELECT COUNT(*) FROM TaiKhoanCT WHERE MaTKCT = @MaTKCT";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@MaTKCT", maTKCT);
                    int exists = (int)checkCommand.ExecuteScalar();

                    if (exists == 0)
                    {
                        // Nếu MaTKCT chưa tồn tại, thêm vào bảng TaiKhoanCT
                        string insertTaiKhoanCT = "INSERT INTO TaiKhoanCT (MaTKCT) VALUES (@MaTKCT)";
                        using (SqlCommand insertCommand = new SqlCommand(insertTaiKhoanCT, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@MaTKCT", maTKCT);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                // 🔹 Thực hiện INSERT sản phẩm mới
                string query = "INSERT INTO SanPham (MaSP, TenSP, MaNhomSP, DonViTinh, Soluongton, MaNCC, MaTKCT) " +
                               "VALUES (@MaSP, @TenSP, @MaNhomSP, @DonViTinh, @Soluongton, @MaNCC, @MaTKCT)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@TenSP", tenSP);
                    command.Parameters.AddWithValue("@DonViTinh", DVT);
                    command.Parameters.AddWithValue("@Soluongton", Soluong);
                    command.Parameters.AddWithValue("@MaNhomSP", NhomSP);
                    command.Parameters.AddWithValue("@MaNCC", NCC);
                    command.Parameters.AddWithValue("@MaTKCT", maTKCT);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm sản phẩm thành công.");
                        ClearInputFields();
                        LoadSanPham();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadSanPham();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dgvSanPham.SelectedRows[0];
            string maSP = selectedRow.Cells["MaSP"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa sản phẩm thành công.");
                            LoadSanPham();
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
            LoadSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string DVT = txtDVT.Text;
            string Soluong = txtSoluong.Text;
            string NhomSP = cboNhomSP.SelectedValue?.ToString();
            string NCC = cboNCC.SelectedValue?.ToString();

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "UPDATE SanPham SET MaNhomSP = @MaNhomSP, MaNCC = @MaNCC, TenSP = @TenSP, " +
                           "DonViTinh = @DonViTinh, Soluongton = @Soluongton " +
                           "WHERE MaSP = @MaSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSP", maSP);
                    command.Parameters.AddWithValue("@MaNhomSP", NhomSP);
                    command.Parameters.AddWithValue("@MaNCC", NCC);
                    command.Parameters.AddWithValue("@TenSP", tenSP);
                    command.Parameters.AddWithValue("@DonViTinh", DVT);
                    command.Parameters.AddWithValue("@Soluongton", int.Parse(Soluong));

                    connection.Open();
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công.");
                            LoadSanPham();
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
            LoadSanPham();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT * FROM SANPHAM WHERE MaSP LIKE @MaSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    // Hiển thị kết quả lên DataGridView
                    dgvSanPham.DataSource = dt;

                    // Đặt tiêu đề cho các cột của DataGridView
                    dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";
                    dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
                    dgvSanPham.Columns["DonViTinh"].HeaderText = "ĐVT";
                    dgvSanPham.Columns["Soluongton"].HeaderText = "Số lượng";
                    dgvSanPham.Columns["MaNhomSP"].HeaderText = "Mã NSP";
                    dgvSanPham.Columns["MaNCC"].HeaderText = "Mã NCC";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
