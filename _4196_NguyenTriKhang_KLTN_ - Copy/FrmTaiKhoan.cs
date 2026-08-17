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
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private void LoadTaiKhoan()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoanDN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTK.DataSource = dt;
            }
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsTaiKhoanDN.TaiKhoanDN' table. You can move, or remove it, as needed.
            this.taiKhoanDNTableAdapter.Fill(this.qLRBWDsTaiKhoanDN.TaiKhoanDN);
            LoadTaiKhoan();

            dgvTK.Columns["Taikhoan"].Width = 100;
            dgvTK.Columns["MatKhau"].Width = 100;

            dgvTK.Columns["Taikhoan"].HeaderText = "Mã TK";
            dgvTK.Columns["MatKhau"].HeaderText = "Mật khẩu";

            dgvTK.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvTK.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //string MaTKMoi = TaoMaTKMoi();
            //txtMaTK.Text = MaTKMoi;
            btnLuu.Visible = true;
            txtMK.Text = "";

            //txtMaTK.ReadOnly = true;
        }
        private void ClearInputFields()
        {
            txtMaTK.Clear();
            txtMK.Clear();
            txtMaTK.ReadOnly = false; // Assuming you want to allow editing of MaNCC after update
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaTK = txtMaTK.Text;
            string MK = txtMK.Text;

            // Insert the new supplier into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoanDN (Taikhoan, MatKhau) " +
                               "VALUES (@Taikhoan, @MatKhau)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Taikhoan", MaTK);
                    command.Parameters.AddWithValue("@MatKhau", MK);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoản thành công.");
                        ClearInputFields();
                        // Refresh the DataGridView
                        LoadTaiKhoan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTK.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
                return;
            }

            // Retrieve the MaNCC of the selected supplier
            DataGridViewRow selectedRow = dgvTK.SelectedRows[0];
            string maNCC = selectedRow.Cells["Taikhoan"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the supplier from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM TaiKhoanDN WHERE Taikhoan = @Taikhoan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Taikhoan", maNCC);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa tài khoản thành công.");

                            // Refresh the DataGridView
                            LoadTaiKhoan();

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
            string MaTK = txtMaTK.Text;
            string MK = txtMK.Text;

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin tài khoản
            string query = "UPDATE TaiKhoanDN SET MatKhau = @MK WHERE Taikhoan = @Taikhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@Taikhoan", SqlDbType.NVarChar).Value = MaTK;
                    command.Parameters.Add("@MK", SqlDbType.NVarChar).Value = MK;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công.");
                            // Refresh DataGridView
                            LoadTaiKhoan();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvTK.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaTK.Text = row.Cells["Taikhoan"].Value?.ToString();
                txtMK.Text = row.Cells["MatKhau"].Value?.ToString();
                // Khóa lại các TextBox
                txtMaTK.ReadOnly = true;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập mã tài khoản để tìm kiếm.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT * FROM TaiKhoanDN WHERE Taikhoan LIKE @Taikhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Taikhoan", "%" + tk + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);

                    // Hiển thị kết quả lên DataGridView
                    dgvTK.DataSource = dt;

                    // Đặt tiêu đề cho các cột của DataGridView
                    if (dt.Columns.Contains("Taikhoan"))
                        dgvTK.Columns["Taikhoan"].HeaderText = "Tài khoản";
                    if (dt.Columns.Contains("MatKhau"))
                        dgvTK.Columns["MatKhau"].HeaderText = "Mật khẩu";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
