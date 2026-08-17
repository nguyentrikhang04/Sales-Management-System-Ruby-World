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
    public partial class FrmNhaCC : Form
    {
        public FrmNhaCC()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsNhaCungCap.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.qLRBWDsNhaCungCap.NhaCungCap);
            LoadNhaCungCap();

            // Set column widths and header texts
            dgvNhaCC.Columns["MaNCC"].Width = 80;
            dgvNhaCC.Columns["TenNCC"].Width = 150;
            dgvNhaCC.Columns["DiachiNCC"].Width = 80;
            dgvNhaCC.Columns["SdtNCC"].Width = 90;
            dgvNhaCC.Columns["MaTKCT"].Width = 90;

            dgvNhaCC.Columns["MaNCC"].HeaderText = "Mã NCC";
            dgvNhaCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvNhaCC.Columns["DiachiNCC"].HeaderText = "Địa chỉ";
            dgvNhaCC.Columns["SdtNCC"].HeaderText = "Số điện thoại";
            dgvNhaCC.Columns["MaTKCT"].HeaderText = "Mã TKCT";
        }
        private string LayMaNCCCuoiCung()
        {
            string maNCCCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaNCC FROM NhaCungCap ORDER BY MaNCC DESC"; // Lấy MaNCC cuối cùng từ bảng NhaCungCap

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maNCCCuoiCung = reader["MaNCC"].ToString();
                    }

                    reader.Close();
                }
            }

            return maNCCCuoiCung;
        }

        private string TaoMaNCCMoi()
        {
            string maNCCCuoiCung = LayMaNCCCuoiCung();
            if (string.IsNullOrEmpty(maNCCCuoiCung))
            {
                // Nếu không có nhà cung cấp nào trong bảng, bắt đầu với mã NCC001
                return "NCC01";
            }

            // Lấy phần số từ mã nhà cung cấp cuối cùng
            string phanSo = maNCCCuoiCung.Substring(3);

            // Tăng phần số lên 1
            int soMoi = int.Parse(phanSo) + 1;

            // Tạo mã nhà cung cấp mới với định dạng NCCxxx
            string maNCCMoi = "NCC" + soMoi.ToString("D2");

            return maNCCMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNCCMoi = TaoMaNCCMoi();
            txtMaNCC.Text = MaNCCMoi;
            btnLuu.Visible = true;
            txtTenNCC.Text = "";
            txtSDTNCC.Text = "";
            txtDiaChiNCC.Text = "";

            // Khóa TextBox mã nhà cung cấp để người dùng không thể chỉnh sửa
            txtMaNCC.ReadOnly = true;
        }

        private void ClearInputFields()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDTNCC.Clear();
            txtDiaChiNCC.Clear();

            txtMaNCC.ReadOnly = false; // Assuming you want to allow editing of MaNCC after update
        }

        private void LoadNhaCungCap()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhaCC.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.");
                return;
            }

            // Retrieve the MaNCC of the selected supplier
            DataGridViewRow selectedRow = dgvNhaCC.SelectedRows[0];
            string maNCC = selectedRow.Cells["MaNCC"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the supplier from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNCC", maNCC);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa nhà cung cấp thành công.");

                            // Refresh the DataGridView
                            LoadNhaCungCap();

                            // Optionally clear the input fields and reset the form
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string dienThoai = txtSDTNCC.Text;
            string diaChi = txtDiaChiNCC.Text;

            // Insert the new supplier into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 🔹 Đếm số lượng sản phẩm hiện có trong bảng SanPham
                string countQuery = "SELECT COUNT(*) FROM NhaCungCap";
                int soLuongNhaCungCap = 0;

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    soLuongNhaCungCap = (int)countCommand.ExecuteScalar();
                }

                // 🔹 Tạo MaTKCT theo công thức 1561 + (số lượng sản phẩm + 1)
                string maTKCT = "33110" + (soLuongNhaCungCap + 1).ToString();

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

                string query = "INSERT INTO NhaCungCap (MaNCC, TenNCC, DiachiNCC, SdtNCC, MaTKCT) " +
                               "VALUES (@MaNCC, @TenNCC, @DiachiNCC, @SdtNCC, @MaTKCT)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNCC", MaNCC);
                    command.Parameters.AddWithValue("@TenNCC", tenNCC);
                    command.Parameters.AddWithValue("@DiachiNCC", diaChi);
                    command.Parameters.AddWithValue("@SdtNCC", dienThoai);
                    command.Parameters.AddWithValue("@MaTKCT", maTKCT);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhà cung cấp thành công.");
                        ClearInputFields();
                        // Refresh the DataGridView
                        LoadNhaCungCap();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string dienThoai = txtSDTNCC.Text;
            string diaChi = txtDiaChiNCC.Text;

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhà cung cấp
            string query = "UPDATE NhaCungCap SET TenNCC = @TenNCC, DiachiNCC = @DiachiNCC, SdtNCC = @SdtNCC " +
                           "WHERE MaNCC = @MaNCC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = MaNCC;
                    command.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tenNCC;
                    command.Parameters.Add("@DiachiNCC", SqlDbType.NVarChar).Value = diaChi;
                    command.Parameters.Add("@SdtNCC", SqlDbType.NVarChar).Value = dienThoai;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nhà cung cấp thành công.");
                            // Refresh DataGridView
                            LoadNhaCungCap();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có nhà cung cấp nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvNhaCC.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaNCC.Text = row.Cells["MaNCC"].Value?.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value?.ToString();
                txtDiaChiNCC.Text = row.Cells["DiachiNCC"].Value?.ToString();
                txtSDTNCC.Text = row.Cells["SdtNCC"].Value?.ToString();

                // Khóa lại các TextBox
                txtMaNCC.ReadOnly = true;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT MaNCC, TenNCC, DiachiNCC, SdtNCC FROM NhaCungCap WHERE MaNCC LIKE @MaNCC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNCC", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvNhaCC.DataSource = dt;
                    if (dt.Columns.Contains("MaNCC"))
                        dgvNhaCC.Columns["MaNCC"].HeaderText = "Mã NCC";
                    if (dt.Columns.Contains("TenNCC"))
                        dgvNhaCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                    if (dt.Columns.Contains("DiachiNCC"))
                        dgvNhaCC.Columns["DiachiNCC"].HeaderText = "Địa chỉ";
                    if (dt.Columns.Contains("SdtNCC"))
                        dgvNhaCC.Columns["SdtNCC"].HeaderText = "Số điện thoại";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
