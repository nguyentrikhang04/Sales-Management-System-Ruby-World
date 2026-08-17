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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
            LoadChucVu();
        }
        KetNoi data = new KetNoi();

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsNhanVien.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLRBWDsNhanVien.NhanVien);
            string query = "SELECT * FROM NHANVIEN WHERE Taikhoan <> 'admin'";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            dgvNhanVien.DataSource = dataTable;

            dgvNhanVien.Columns["MaNV1"].Width = 70;
            dgvNhanVien.Columns["HoTen"].Width = 100;
            dgvNhanVien.Columns["GioiTinh"].Width = 50;
            dgvNhanVien.Columns["SDT"].Width = 80;
            dgvNhanVien.Columns["Email"].Width = 100;
            dgvNhanVien.Columns["MaCV"].Width = 70;
            dgvNhanVien.Columns["Taikhoan"].Width = 70;
            dgvNhanVien.Columns["MaTKCT"].Width = 70;

            dgvNhanVien.Columns["MaNV1"].HeaderText = "Mã NV";
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvNhanVien.Columns["Email"].HeaderText = "Email";
            dgvNhanVien.Columns["SDT"].HeaderText = "Điện thoại";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["MaCV"].HeaderText = "Mã CV";
            dgvNhanVien.Columns["Taikhoan"].HeaderText = "Tài khoản";
            dgvNhanVien.Columns["MaTKCT"].HeaderText = "Mã Tài khoản chi tiết";
            dgvNhanVien.Columns["Taikhoan"].Visible = false;
            dgvNhanVien.Columns["MaTKCT"].Visible = false;

            dgvNhanVien.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            LoadChucVu();
        }
        private void LoadChucVu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Load data into cbCV

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MACV, TENCV FROM CHUCVU";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboCV.DisplayMember = "TENCV";
                cboCV.ValueMember = "MACV";
                cboCV.DataSource = dt;
            }

        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaNV.Text = row.Cells["MANV1"].Value?.ToString();
                txtHoTenNV.Text = row.Cells["HOTEN"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();

                // Dựa vào giới tính, gán giá trị cho TextBox txtSL

                //dtNgaySinh.Text = row.Cells["NGAYSINH"].Value?.ToString();
                //txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
                //txtDC.Text = row.Cells["DIACHI"].Value?.ToString();

                // Set ComboBox selections if they exist
                if (row.Cells["MACV"].Value != null)
                {
                    cboCV.SelectedValue = row.Cells["MACV"].Value.ToString();
                }
                else
                {
                    cboCV.SelectedIndex = -1; // No selection
                }

                // Lấy đường dẫn hình ảnh từ DataGridView


                // Khóa lại các TextBox
                txtMaNV.ReadOnly = true;
                // ...
                //LoadComboBoxData();

            }
        }

        private string LayMaNhanVienCuoiCung()
        {
            string maNhanVienCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MANV FROM NHANVIEN ORDER BY MANV DESC"; // Lấy MANV cuối cùng từ bảng NHANVIEN

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maNhanVienCuoiCung = reader["MaNV"].ToString();
                    }

                    reader.Close();
                }
            }

            return maNhanVienCuoiCung;
        }

        private string TaoMaNhanVienMoi()
        {
            string maNhanVienCuoiCung = LayMaNhanVienCuoiCung();
            if (string.IsNullOrEmpty(maNhanVienCuoiCung))
            {
                // Nếu không có nhân viên nào trong bảng, bắt đầu với mã NV001
                return "NV01";
            }

            // Lấy phần số từ mã nhân viên cuối cùng
            string phanSo = maNhanVienCuoiCung.Substring(2);

            // Tăng phần số lên 1
            int soMoi = int.Parse(phanSo) + 1;

            // Tạo mã nhân viên mới với định dạng NVxxx
            string maNhanVienMoi = "NV" + soMoi.ToString("D2");

            return maNhanVienMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhanVienMoi = TaoMaNhanVienMoi();
            txtMaNV.Text = maNhanVienMoi;
            btnLuu.Visible = true;
            txtHoTenNV.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtGioiTinh.Text = "";
            cboCV.SelectedIndex = -1; // Reset ComboBox

            // Khóa TextBox mã nhân viên để người dùng không thể chỉnh sửa
            txtMaNV.ReadOnly = true;

        }
        private void ClearInputFields()
        {
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            txtSDT.Clear();
            txtGioiTinh.Clear();
            txtEmail.Clear();
            cboCV.SelectedIndex = -1;
            // Xóa nội dung của DateTimePicker dtNgaySinh

            txtMaNV.ReadOnly = false; // Assuming you want to allow editing of MASP after update
        }
        private void LoadNhanVien()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNV, HoTen, GioiTinh, SDT, Email, MaCV, Taikhoan, MaTKCT FROM NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhanVien.DataSource = dt;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtHoTenNV.Text;
            string dienThoai = txtSDT.Text;
            string gioiTinh = txtGioiTinh.Text;
            string email = txtEmail.Text;
            string maCV = cboCV.SelectedValue.ToString();

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 🔹 Đếm số lượng nhân viên hiện có trong bảng NhanVien
                string countQuery = "SELECT COUNT(*) FROM NhanVien";
                int soLuongNhanVien = 0;

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    soLuongNhanVien = (int)countCommand.ExecuteScalar();
                }

                // 🔹 Tạo MaTKCT theo công thức 6411 + (số lượng nhân viên + 1)
                string maTKCT = "6411" + (soLuongNhanVien + 1).ToString();

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

                // 🔹 Tạo Taikhoan theo công thức user + (số lượng nhân viên + 1)
                string taikhoan = "user" + (soLuongNhanVien + 1).ToString();

                // 🔹 Kiểm tra nếu Taikhoan đã tồn tại trong bảng TaiKhoanDN chưa
                string checkQuery1 = "SELECT COUNT(*) FROM TaiKhoanDN WHERE Taikhoan = @Taikhoan";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery1, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Taikhoan", taikhoan);
                    int exists = (int)checkCommand.ExecuteScalar();

                    if (exists == 0)
                    {
                        // Nếu Taikhoan chưa tồn tại, thêm vào bảng TaiKhoanDN
                        string insertTaiKhoanDN = "INSERT INTO TaiKhoanDN (Taikhoan) VALUES (@Taikhoan)";
                        using (SqlCommand insertCommand = new SqlCommand(insertTaiKhoanDN, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Taikhoan", taikhoan);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                // 🔹 Thực hiện INSERT nhân viên mới
                string query = "INSERT INTO NHANVIEN (MaNV, HoTen, GioiTinh, SDT, Email, MaCV, Taikhoan, MaTKCT) " +
                               "VALUES (@MaNV, @HoTen, @GioiTinh, @SDT, @Email, @MaCV, @Taikhoan, @MaTKCT)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    command.Parameters.AddWithValue("@HoTen", tenNV);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@SDT", dienThoai);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MaCV", maCV);
                    command.Parameters.AddWithValue("@Taikhoan", taikhoan); // Use taikhoan (e.g., user1) instead of maTKCT
                    command.Parameters.AddWithValue("@MaTKCT", maTKCT);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhân viên thành công.");
                        ClearInputFields();
                        // Refresh the DataGridView
                        LoadNhanVien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            // Retrieve the MASP (product ID) of the selected product
            DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
            string maNV = selectedRow.Cells["MANV1"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the product from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MANV", maNV);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa nhân viên thành công.");

                            // Refresh the DataGridView
                            LoadNhanVien();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtHoTenNV.Text;
            string dienThoai = txtSDT.Text;
            string gioiTinh = txtGioiTinh.Text;

            // Lấy ngày sinh từ DateTimePicker
            string email = txtEmail.Text;
            string maCV = cboCV.SelectedValue != null ? cboCV.SelectedValue.ToString() : "";

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhân viên
            string query = "UPDATE NHANVIEN SET MACV = @MACV, HoTen = @HoTen, SDT = @SDT, " +
                           "GioiTinh = @GioiTinh, EMAIL = @EMAIL " +
                           "WHERE MANV = @MANV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = maNV;
                    command.Parameters.Add("@MACV", SqlDbType.NVarChar).Value = maCV;
                    command.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = tenNV;
                    command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = dienThoai;
                    command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = gioiTinh;
                    command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = email;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nhân viên thành công.");
                            // Refresh DataGridView
                            LoadNhanVien();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có nhân viên nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT * FROM NhanVien WHERE MaNV LIKE @MaNV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNV", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    // Hiển thị kết quả lên DataGridView
                    dgvNhanVien.DataSource = dt;

                    // Đặt tiêu đề cho các cột của DataGridView

                    dgvNhanVien.Columns["MaNV1"].HeaderText = "Mã NV";
                    dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
                    dgvNhanVien.Columns["Email"].HeaderText = "Email";
                    dgvNhanVien.Columns["SDT"].HeaderText = "Điện thoại";
                    dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                    dgvNhanVien.Columns["MaCV"].HeaderText = "Mã CV";
                    dgvNhanVien.Columns["Taikhoan"].HeaderText = "Tài khoản";
                    dgvNhanVien.Columns["MaTKCT"].HeaderText = "Mã Tài khoản chi tiết";
                    dgvNhanVien.Columns["Taikhoan"].Visible = false;
                    dgvNhanVien.Columns["MaTKCT"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
