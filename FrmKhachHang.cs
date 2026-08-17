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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsKhachHang.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qLRBWDsKhachHang.KhachHang);
            string query = "SELECT * FROM KHACHHANG"; // Corrected the query to select from SANPHAM table
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

            dgvKH.DataSource = dataTable;

            //Set column widths and header texts
            dgvKH.Columns["MaKH"].Width = 70;
            dgvKH.Columns["HoTenKH"].Width = 120;
            dgvKH.Columns["DiaChiKH"].Width = 90;
            dgvKH.Columns["SDTKH"].Width = 80;
            dgvKH.Columns["EmailKH"].Width = 90;
            dgvKH.Columns["MaTKCT"].Width = 90;

            dgvKH.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKH.Columns["HoTenKH"].HeaderText = "Tên khách hàng";
            dgvKH.Columns["DiaChiKH"].HeaderText = "Địa chỉ";
            dgvKH.Columns["SDTKH"].HeaderText = "Số điện thoại";
            dgvKH.Columns["EmailKH"].HeaderText = "Email";
            dgvKH.Columns["MaTKCT"].HeaderText = "Mã TKCT";

            dgvKH.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTenKH"].Value?.ToString();
                txtDiachi.Text = row.Cells["DiaChiKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDTKH"].Value.ToString();
                txtEmail.Text = row.Cells["EmailKH"].Value?.ToString();

                // Khóa lại các TextBox
                txtMaKH.ReadOnly = true;
            }
        }

        private string LayMaKHCuoiCung()
        {
            string maKHCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MAKH FROM KhachHang ORDER BY MAKH DESC"; // Lấy MANV cuối cùng từ bảng KhachHang

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maKHCuoiCung = reader["MAKH"].ToString();
                    }

                    reader.Close();
                }
            }

            return maKHCuoiCung;
        }

        private string TaoMaKHMoi()
        {
            string maKHCuoiCung = LayMaKHCuoiCung();
            if (string.IsNullOrEmpty(maKHCuoiCung))
            {
                // Nếu không có khách hàng nào trong bảng, bắt đầu với mã NV001
                return "KH001";
            }

            // Lấy phần số từ mã khách hàng cuối cùng
            string phanSo = maKHCuoiCung.Substring(2);

            // Tăng phần số lên 1
            int soMoi = int.Parse(phanSo) + 1;

            // Tạo mã khách hàng mới với định dạng NVxxx
            string maKHMoi = "KH" + soMoi.ToString("D2");

            return maKHMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKHMoi = TaoMaKHMoi();
            txtMaKH.Text = maKHMoi;
            btnLuu.Visible = true;
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiachi.Text = "";

            // Khóa TextBox mã khách hàng để người dùng không thể chỉnh sửa
            txtMaKH.ReadOnly = true;

        }

        private void ClearInputFields()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            //cboCV.SelectedIndex = -1;
            // Xóa nội dung của DateTimePicker dtNgaySinh

            txtMaKH.ReadOnly = false; // Assuming you want to allow editing of MASP after update
        }
        private void LoadKhachHang()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKH.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            // Retrieve the MASP (product ID) of the selected product
            DataGridViewRow selectedRow = dgvKH.SelectedRows[0];
            string maSP = selectedRow.Cells["MAKH"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the product from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM KhachHang WHERE MAKH = @MAKH";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MAKH", maSP);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa khách hàng thành công.");

                            // Refresh the DataGridView
                            LoadKhachHang();

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
            string maKH = txtMaKH.Text;
            string tenKH = txtHoTen.Text;
            string dienThoai = txtSDT.Text;
            string diaChi = txtDiachi.Text;
            string email = txtEmail.Text;

            // Insert the new product into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 🔹 Đếm số lượng sản phẩm hiện có trong bảng SanPham
                string countQuery = "SELECT COUNT(*) FROM KhachHang";
                int soLuongKhachHang = 0;

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    soLuongKhachHang = (int)countCommand.ExecuteScalar();
                }

                // 🔹 Tạo MaTKCT theo công thức 1561 + (số lượng sản phẩm + 1)
                string maTKCT = "1311" + (soLuongKhachHang + 1).ToString();

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

                string query = "INSERT INTO KhachHang (MaKH, HoTenKH, DiaChiKH, SDTKH, EmailKH, MaTKCT) " +
                               "VALUES (@MaKH, @HoTenKH, @DiaChiKH, @SDTKH, @EmailKH, @MaTKCT)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@HoTenKH", tenKH);
                    command.Parameters.AddWithValue("@DiaChiKH", diaChi);
                    command.Parameters.AddWithValue("@SDTKH", dienThoai);
                    command.Parameters.AddWithValue("@EmailKH", email);
                    command.Parameters.AddWithValue("@MaTKCT", maTKCT);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm khách hàng thành công.");
                        ClearInputFields();
                        //// Refresh the DataGridView
                        LoadKhachHang();
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
            string maKH = txtMaKH.Text;
            string tenKH = txtHoTen.Text;
            string dienThoai = txtSDT.Text;
            string diaChi = txtDiachi.Text;
            string email = txtEmail.Text;

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin khách hàng
            string query = "UPDATE KhachHang SET HoTenKH = @HoTenKH, DiaChiKH = @DiaChiKH, SDTKH = @SDTKH, EmailKH = @EmailKH " +
                           "WHERE MAKH = @MAKH";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = maKH;
                    command.Parameters.Add("@HoTenKH", SqlDbType.NVarChar).Value = tenKH;
                    command.Parameters.Add("@DiaChiKH", SqlDbType.NVarChar).Value = dienThoai;
                    command.Parameters.Add("@SDTKH", SqlDbType.NVarChar).Value = diaChi;
                    command.Parameters.Add("@EmailKH", SqlDbType.NVarChar).Value = email;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật khách hàng thành công.");
                            // Refresh DataGridView
                            LoadKhachHang();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có khách hàng nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT * FROM KHACHHANG WHERE MaKH LIKE @MaKH";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaKH", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    // Hiển thị kết quả lên DataGridView
                    dgvKH.DataSource = dt;

                    // Đặt tiêu đề cho các cột của DataGridView
                    dgvKH.Columns["MaKH"].HeaderText = "Mã KH";
                    dgvKH.Columns["HoTenKH"].HeaderText = "Tên khách hàng";
                    dgvKH.Columns["DiaChiKH"].HeaderText = "Địa chỉ";
                    dgvKH.Columns["SDTKH"].HeaderText = "Số điện thoại";
                    dgvKH.Columns["EmailKH"].HeaderText = "EmailKH";
                    dgvKH.Columns["MaTKCT"].HeaderText = "Mã TKCT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
