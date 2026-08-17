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
    public partial class FrmTKC1 : Form
    {
        private string chucVu;
        public FrmTKC1(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
            LoadTongHop();
        }

        private void FrmTKC1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsTaiKhoanC1.TaiKhoanC1' table. You can move, or remove it, as needed.
            this.taiKhoanC1TableAdapter.Fill(this.qLRBWDsTaiKhoanC1.TaiKhoanC1);
            LoadTongHop();
            dgvTongHop.Columns["MaTK1"].Width = 100;
            dgvTongHop.Columns["TenTKC1"].Width = 200;

            dgvTongHop.Columns["MaTK1"].HeaderText = "Mã tài khoản cấp 1";
            dgvTongHop.Columns["TenTKC1"].HeaderText = "Tên tài khoản cấp 1";

            dgvTongHop.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvTongHop.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);

            if (this.chucVu == "Quản lý")
            {
                btnThem.Visible = false;

                btnSua.Visible = false;
                btnLuu.Visible = false;
                btnXoa.Visible = false;
            }
            else
            {
                btnThem.Visible = true;

                btnSua.Visible = true;
                btnLuu.Visible = true;
                btnXoa.Visible = true;
            }
        }
        private void LoadTongHop()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoanC1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTongHop.DataSource = dt;
            }
        }

        private void dgvTongHop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                btnSua.Visible = true;
                if (this.chucVu == "Quản lý")
                {
                    btnThem.Visible = false;

                    btnSua.Visible = false;
                    btnLuu.Visible = false;
                }
                else
                {

                    btnSua.Visible = true;
                }
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvTongHop.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaTH.Text = row.Cells["MaTK1"].Value?.ToString();
                txtTenTH.Text = row.Cells["TenTKC1"].Value?.ToString();
                // Khóa lại các TextBox
                txtMaTH.ReadOnly = true;

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTH.ReadOnly = false;
            btnLuu.Visible = true;
            txtTenTH.Text = "";
        }

        private void ClearInputFields()
        {
            txtMaTH.Clear();
            txtTenTH.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaTH = txtMaTH.Text;
            string TenTH = txtTenTH.Text;

            // Insert the new product into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoanC1 (MaTK1, TenTKC1) " +
                               "VALUES (@MaTK1, @TenTKC1)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaTK1", MaTH);
                    command.Parameters.AddWithValue("@TenTKC1", TenTH);


                    //command.Parameters.AddWithValue("@HINHANH", hinhAnh);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoản cấp 1 thành công.");
                        ClearInputFields();
                        //// Refresh the DataGridView
                        LoadTongHop();
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
            if (dgvTongHop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cấp 1 cần xóa.");
                return;
            }

            // Retrieve the MASP (product ID) of the selected product
            DataGridViewRow selectedRow = dgvTongHop.SelectedRows[0];
            string TietKhoan = selectedRow.Cells["MaTK1"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản cấp 1 này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the product from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM TaiKhoanC1 WHERE MaTK1 = @MaTK1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaTK1", TietKhoan);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa tài khoản cấp 1 thành công.");

                            // Refresh the DataGridView
                            LoadTongHop();

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
            string MaTH = txtMaTH.Text;
            string TenTH = txtTenTH.Text;

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhân viên
            string query = "UPDATE TaiKhoanC1 SET TenTKC1 = @TenTKC1 " +
                           "WHERE MaTK1 = @MaTK1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaTK1", SqlDbType.NVarChar).Value = MaTH;
                    command.Parameters.Add("@TenTKC1", SqlDbType.NVarChar).Value = TenTH;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản cấp 1 thành công.");
                            // Refresh DataGridView
                            LoadTongHop();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản cấp 1 nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

    }
}
