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
    public partial class FrmNhomSP : Form
    {
        public FrmNhomSP()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private void FrmNhomSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsNhomSP.NhomSP' table. You can move, or remove it, as needed.
            this.nhomSPTableAdapter.Fill(this.qLRBWDsNhomSP.NhomSP);

            LoadNhomSP();
            dgvNhomSP.Columns["MaNhomSP"].HeaderText = "Mã nhóm";
            dgvNhomSP.Columns["TenNhom"].HeaderText = "Tên nhóm sản phẩm";

            dgvNhomSP.Columns["MaNhomSP"].Width = 100;
            dgvNhomSP.Columns["TenNhom"].Width = 120;

            dgvNhomSP.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvNhomSP.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
        }
        private void LoadNhomSP()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM NhomSP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhomSP.DataSource = dt;
            }
        }

        private string LayMaNhomSPCuoiCung()
        {
            string MaNhomSPCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaNhomSP FROM NhomSP ORDER BY MaNhomSP DESC"; // Lấy MaNCC cuối cùng từ bảng NhaCungCap

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MaNhomSPCuoiCung = reader["MaNhomSP"].ToString();
                    }

                    reader.Close();
                }
            }

            return MaNhomSPCuoiCung;
        }

        private string TaoMaNhomSPMoi()
        {
            string MaNhomSPCuoiCung = LayMaNhomSPCuoiCung();
            if (string.IsNullOrEmpty(MaNhomSPCuoiCung))
            {
                // Nếu không có nhóm sản phẩm nào trong bảng, bắt đầu với mã NCC001
                return "NSP01";
            }

            // Lấy phần số từ mã nhóm sản phẩm cuối cùng
            string phanSo = MaNhomSPCuoiCung.Substring(3);

            // Tăng phần số lên 1
            int soMoi = int.Parse(phanSo) + 1;

            // Tạo mã nhóm sản phẩm mới với định dạng CVxx
            string MaNhomSPMoi = "NSP" + soMoi.ToString("D2");

            return MaNhomSPMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNhomSPMoi = TaoMaNhomSPMoi();
            txtMaNhom.Text = MaNhomSPMoi;
            btnLuu.Visible = true;
            txtTenNhom.Text = "";

            txtMaNhom.ReadOnly = true;
        }
        private void ClearInputFields()
        {
            txtMaNhom.Clear();
            txtTenNhom.Clear();

            txtMaNhom.ReadOnly = false; // Assuming you want to allow editing of MaNCC after update
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaNhomSP = txtMaNhom.Text;
            string TenNhom = txtTenNhom.Text;

            // Insert the new supplier into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO NhomSP (MaNhomSP, TenNhom) " +
                               "VALUES (@MaNhomSP, @TenNhom)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNhomSP", MaNhomSP);
                    command.Parameters.AddWithValue("@TenNhom", TenNhom);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhóm sản phẩm thành công.");
                        ClearInputFields();
                        // Refresh the DataGridView
                        LoadNhomSP();
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
            if (dgvNhomSP.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm sản phẩm cần xóa.");
                return;
            }

            // Retrieve the MaNCC of the selected supplier
            DataGridViewRow selectedRow = dgvNhomSP.SelectedRows[0];
            string maNhom = selectedRow.Cells["MaNhomSP"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the supplier from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM NhomSP WHERE MaNhomSP = @MaNhomSP";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNhomSP", maNhom);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa nhóm sản phẩm thành công.");

                            // Refresh the DataGridView
                            LoadNhomSP();

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
            string MaNhomSP = txtMaNhom.Text;
            string TenNhom = txtTenNhom.Text;


            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhóm sản phẩm
            string query = "UPDATE NhomSP SET TenNhom = @TenNhom WHERE MaNhomSP = @MaNhomSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaNhomSP", SqlDbType.NVarChar).Value = MaNhomSP;
                    command.Parameters.Add("@TenNhom", SqlDbType.NVarChar).Value = TenNhom;

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật nhóm sản phẩm thành công.");
                            // Refresh DataGridView
                            LoadNhomSP();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có nhóm sản phẩm nào được cập nhật.");
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
                DataGridViewRow row = dgvNhomSP.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaNhom.Text = row.Cells["MaNhomSP"].Value?.ToString();
                txtTenNhom.Text = row.Cells["TenNhom"].Value?.ToString();

                // Khóa lại các TextBox
                txtMaNhom.ReadOnly = true;
            }
        }
    }
}
