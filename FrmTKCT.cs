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
    public partial class FrmTKCT : Form
    {
        private string chucVu;
        public FrmTKCT(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
            LoadTieuKhoan();
        }
        KetNoi data = new KetNoi();
        private void FrmTKCT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsTKCT.TaiKhoanCT' table. You can move, or remove it, as needed.
            this.taiKhoanCTTableAdapter.Fill(this.qLRBWDsTKCT.TaiKhoanCT);
            LoadTietKhoan();

            // Set column widths and header texts
            dgvTietKhoan.Columns["MaTKCT"].Width = 80;
            dgvTietKhoan.Columns["MaTK1"].Width = 80;
            dgvTietKhoan.Columns["TenTKCT"].Width = 150;

            dgvTietKhoan.Columns["MaTKCT"].HeaderText = "Mã tài khoản chi tiết";
            dgvTietKhoan.Columns["MaTK1"].HeaderText = "Mã tài khoản cấp 1";
            dgvTietKhoan.Columns["TenTKCT"].HeaderText = "Tên tài khoản chi tiết";

            dgvTietKhoan.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvTietKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            LoadTieuKhoan();

            if (this.chucVu == "Quản lý")
            {
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
            }
            else
            {
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
                btnLuu.Visible = true;
            }
        }
        private void LoadTietKhoan()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoanCT";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTietKhoan.DataSource = dt;
            }
        }
        private void LoadTieuKhoan()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoanC1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboMaC2.DisplayMember = "TenTKC1";
                cboMaC2.ValueMember = "MaTK1";
                cboMaC2.DataSource = dt;
            }
        }

        private void dgvTietKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.chucVu == "Quản lý")
                {
                    btnThem.Visible = false;
                    btnXoa.Visible = false;
                    btnSua.Visible = false;
                    btnLuu.Visible = false;
                }
                else
                {
                    btnXoa.Visible = true;
                    btnSua.Visible = true;
                }
                // Lấy dữ liệu từ ô được click
                DataGridViewRow row = dgvTietKhoan.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaTKCT.Text = row.Cells["MaTKCT"].Value?.ToString();
                txtTenTKCT.Text = row.Cells["TenTKCT"].Value?.ToString();

                // Set ComboBox selections if they exist
                if (row.Cells["MaTK1"].Value != null)
                {
                    cboMaC2.SelectedValue = row.Cells["MaTK1"].Value.ToString();
                }
                else
                {
                    cboMaC2.SelectedIndex = -1; // No selection
                }

                // Lấy đường dẫn hình ảnh từ DataGridView


                // Khóa lại các TextBox
                txtMaTKCT.ReadOnly = true;
                // ...
                //LoadComboBoxData();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTKCT.ReadOnly = false;
            btnLuu.Visible = true;
            txtTenTKCT.Text = "";
            cboMaC2.SelectedIndex = -1;
        }
        private void ClearInputFields()
        {
            txtMaTKCT.Clear();
            txtTenTKCT.Clear();
            cboMaC2.SelectedIndex = -1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaTietK = txtMaTKCT.Text;
            string TenTK = txtTenTKCT.Text;
            string TieuK = cboMaC2.SelectedValue.ToString();

            // Insert the new product into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoanCT (MaTKCT, MaTK1, TenTKCT) " +
                               "VALUES (@MaTKCT, @MaTK1, @TenTKCT)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaTKCT", MaTietK);
                    command.Parameters.AddWithValue("@MaTK1", TieuK);
                    command.Parameters.AddWithValue("@TenTKCT", TenTK);


                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoản chi tiết thành công.");
                        ClearInputFields();
                        //// Refresh the DataGridView
                        LoadTietKhoan();
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
            if (dgvTietKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản chi tiết cần xóa.");
                return;
            }

            // Retrieve the MASP (product ID) of the selected product
            DataGridViewRow selectedRow = dgvTietKhoan.SelectedRows[0];
            string TietKhoan = selectedRow.Cells["MaTKCT"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản chi tiết này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the product from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM TaiKhoanCT WHERE MaTKCT = @MaTKCT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaTKCT", TietKhoan);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa tài khoản chi tiết thành công.");

                            // Refresh the DataGridView
                            LoadTietKhoan();

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
            string MaTietK = txtMaTKCT.Text;
            string TenTK = txtTenTKCT.Text;
            string TieuK = cboMaC2.SelectedValue != null ? cboMaC2.SelectedValue.ToString() : "";

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhân viên
            string query = "UPDATE TaiKhoanCT SET MaTK1 = @MaTK1, TenTKCT = @TenTKCT " +
                           "WHERE MaTKCT = @MaTKCT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaTKCT", SqlDbType.NVarChar).Value = MaTietK;
                    command.Parameters.Add("@MaTK1", SqlDbType.NVarChar).Value = TieuK;
                    command.Parameters.Add("@TenTKCT", SqlDbType.NVarChar).Value = TenTK;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản chi tiết thành công.");
                            // Refresh DataGridView
                            LoadTietKhoan();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản chi tiết nào được cập nhật.");
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
