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
    public partial class FrmLoaiCT : Form
    {
        private string chucVu;
        public FrmLoaiCT(string chucVuFromLogin)
        {
            InitializeComponent();
            this.chucVu = chucVuFromLogin;
        }

        private void FrmLoaiCT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsLoaiChungTu.LOAICHUNGTU' table. You can move, or remove it, as needed.
            this.lOAICHUNGTUTableAdapter.Fill(this.qLRBWDsLoaiChungTu.LOAICHUNGTU);
            LoadLoaiCT();
            dgvLoaiCT.Columns["MaLCT"].Width = 120;
            dgvLoaiCT.Columns["TenCT"].Width = 220;

            dgvLoaiCT.Columns["MaLCT"].HeaderText = "Mã loại chứng từ";
            dgvLoaiCT.Columns["TenCT"].HeaderText = "Tên loại chứng từ";

            dgvLoaiCT.DefaultCellStyle.Font = new Font("Consolas", 9);
            dgvLoaiCT.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);

            // Kiểm tra và cập nhật trạng thái của các nút dựa trên chức vụ
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
        private void LoadLoaiCT()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LOAICHUNGTU";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvLoaiCT.DataSource = dt;
            }
        }
        private void dgvLoaiCT_CellClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow row = dgvLoaiCT.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtMaLoaiCT.Text = row.Cells["MaLCT"].Value?.ToString();
                txtTenLoaiCT.Text = row.Cells["TenCT"].Value?.ToString();
                // Khóa lại các TextBox
                txtMaLoaiCT.ReadOnly = true;

            }
        }

        private int LayMaLoaiCuoiCung()
        {
            string maLoaiCuoiCung = "";

            // Kết nối tới CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaLCT FROM LOAICHUNGTU ORDER BY MaLCT DESC"; // Lấy MaNCC cuối cùng từ bảng NhaCungCap

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maLoaiCuoiCung = reader["MaLCT"].ToString();
                    }

                    reader.Close();
                }
            }

            return int.Parse(maLoaiCuoiCung);
        }

        private int TaoMaLoaiMoi()
        {
            int maLoaiCuoiCung = LayMaLoaiCuoiCung();
            if (maLoaiCuoiCung == null)
            {
                // Nếu không có nhà cung cấp nào trong bảng, bắt đầu với mã NCC001
                return 1;
            }

            // Tăng phần số lên 1
            int soMoi = maLoaiCuoiCung + 1;


            return soMoi;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLoaiCT.ReadOnly = true;
            int soMoi = TaoMaLoaiMoi();
            txtMaLoaiCT.Text = soMoi.ToString();
            btnLuu.Visible = true;
            txtTenLoaiCT.Text = "";
        }

        private void ClearInputFields()
        {
            txtMaLoaiCT.Clear();
            txtTenLoaiCT.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaLoai = txtMaLoaiCT.Text;
            string TenLoaiCT = txtTenLoaiCT.Text;

            // Insert the new product into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LOAICHUNGTU (TenCT) " +
                               "VALUES (@TenCT)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@MaLCT", MaLoai);
                    command.Parameters.AddWithValue("@TenCT", TenLoaiCT);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm loại chứng từ thành công.");
                        ClearInputFields();
                        //// Refresh the DataGridView
                        LoadLoaiCT();
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
            if (dgvLoaiCT.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại chứng từ cần xóa.");
                return;
            }

            // Retrieve the MASP (product ID) of the selected product
            DataGridViewRow selectedRow = dgvLoaiCT.SelectedRows[0];
            string TietKhoan = selectedRow.Cells["MaLCT"].Value.ToString();

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại chứng từ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete the product from the database
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM LOAICHUNGTU WHERE MaLCT = @MaLCT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLCT", TietKhoan);

                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa loại chứng từ thành công.");

                            // Refresh the DataGridView
                            LoadLoaiCT();

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
            string MaLoai = txtMaLoaiCT.Text;
            string TenLoaiCT = txtTenLoaiCT.Text;

            // Chuỗi kết nối CSDL
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            // Câu truy vấn SQL để cập nhật thông tin nhân viên
            string query = "UPDATE LOAICHUNGTU SET TenCT = @TenCT " +
                           "WHERE MaLCT = @MaLCT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                    command.Parameters.Add("@MaLCT", SqlDbType.NVarChar).Value = MaLoai;
                    command.Parameters.Add("@TenCT", SqlDbType.NVarChar).Value = TenLoaiCT;
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật loại chứng từ thành công.");
                            // Refresh DataGridView
                            LoadLoaiCT();
                            // Clear input fields
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Không có loại chứng từ nào được cập nhật.");
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
