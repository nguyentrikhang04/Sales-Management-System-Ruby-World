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
    public partial class FrmChucVu : Form
    {
        public FrmChucVu()
        {
            InitializeComponent();
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsChucVu.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLRBWDsChucVu.ChucVu);
            LoadChucVu();
            dgvCV.Columns["MaCV"].HeaderText = "Mã CV";
            dgvCV.Columns["TenCV"].HeaderText = "Tên chức vụ";

            dgvCV.Columns["MaCV"].Width = 100;
            dgvCV.Columns["TenCV"].Width = 120;

            dgvCV.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvCV.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
        }
        KetNoi data = new KetNoi();
        private void LoadChucVu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChucVu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCV.DataSource = dt;
            }
        }
        private string LayMaCVCuoiCung()
        {
            string maCVCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaCV FROM ChucVu ORDER BY MaCV DESC"; // Lấy MaNCC cuối cùng từ bảng NhaCungCap

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maCVCuoiCung = reader["MaCV"].ToString();
                    }

                    reader.Close();
                }
            }

            return maCVCuoiCung;
        }

        private string TaoMaCVMoi()
        {
            string maCVCuoiCung = LayMaCVCuoiCung();
            if (string.IsNullOrEmpty(maCVCuoiCung))
            {
                // Nếu không có chức vụ nào trong bảng, bắt đầu với mã NCC001
                return "CV01";
            }

            // Lấy phần số từ mã chức vụ cuối cùng
            string phanSo = maCVCuoiCung.Substring(2);

            // Tăng phần số lên 1
            int soMoi = int.Parse(phanSo) + 1;

            // Tạo mã chức vụ mới với định dạng CVxx
            string maCVMoi = "CV" + soMoi.ToString("D2");

            return maCVMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaCVMoi = TaoMaCVMoi();
            txtMaCV.Text = MaCVMoi;
            btnLuu.Visible = true;
            txtTenCV.Text = "";

            txtMaCV.ReadOnly = true;
        }
        private void ClearInputFields()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();

            txtMaCV.ReadOnly = false; // Assuming you want to allow editing of MaNCC after update
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaCV = txtMaCV.Text;
            string tenCV = txtTenCV.Text;

            // Insert the new supplier into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ChucVu (MaCV, TenCV) " +
                               "VALUES (@MaCV, @TenCV)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaCV", MaCV);
                    command.Parameters.AddWithValue("@TenCV", tenCV);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm chức vụ thành công.");
                        ClearInputFields();
                        // Refresh the DataGridView
                        LoadChucVu();
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
            if (dgvCV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa.");
                return;
            }

            // Retrieve the MaNCC of the selected supplier
            DataGridViewRow selectedRow = dgvCV.SelectedRows[0];
            string maNCC = selectedRow.Cells["MaCV"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chức vụ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the supplier from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ChucVu WHERE MaCV = @MaCV";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaCV", maNCC);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa chức vụ thành công.");

                            // Refresh the DataGridView
                            LoadChucVu();

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
            string MaCV = txtMaCV.Text;
            string tenCV = txtTenCV.Text;


            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin chức vụ
            string query = "UPDATE ChucVu SET TenCV = @TenCV WHERE MaCV = @MaCV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaCV", SqlDbType.NVarChar).Value = MaCV;
                    command.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = tenCV;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật chức vụ thành công.");
                            // Refresh DataGridView
                            LoadChucVu();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có chức vụ nào được cập nhật.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvCV.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaCV.Text = row.Cells["MaCV"].Value?.ToString();
                txtTenCV.Text = row.Cells["TenCV"].Value?.ToString();

                // Khóa lại các TextBox
                txtMaCV.ReadOnly = true;
            }
        }

    }
}
