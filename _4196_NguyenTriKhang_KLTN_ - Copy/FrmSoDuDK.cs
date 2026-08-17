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
    public partial class FrmSoDuDK : Form
    {
        private string chucVu;
        public FrmSoDuDK(string chucVuFromLoginstring)
        {
            InitializeComponent();
            this.chucVu = chucVuFromLoginstring;
            LoadTietKhoan();
            LoadSoDu();
        }

        private void FrmSoDuDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsSDDK.SoDuDauKy' table. You can move, or remove it, as needed.
            this.soDuDauKyTableAdapter.Fill(this.qLRBWDsSDDK.SoDuDauKy);
            LoadSoDu();
            LoadTietKhoan();
            dgvSoDu.Columns["MaSDDKY"].Width = 70;
            dgvSoDu.Columns["NgayDK"].Width = 100;
            dgvSoDu.Columns["MaTKCT"].Width = 70;
            dgvSoDu.Columns["TenTaiKhoan"].Width = 100;
            dgvSoDu.Columns["DuCo"].Width = 70;
            dgvSoDu.Columns["DuNo"].Width = 70;
            dgvSoDu.Columns["SLTon"].Width = 70;


            dgvSoDu.Columns["MaSDDKY"].HeaderText = "Mã số dư đầu kỳ";
            dgvSoDu.Columns["NgayDK"].HeaderText = "Ngày dầu kỳ";
            dgvSoDu.Columns["MaTKCT"].HeaderText = "Mã tài khoản chi tiết";
            dgvSoDu.Columns["TenTaiKhoan"].HeaderText = "Tên tài khoản";
            dgvSoDu.Columns["DuCo"].HeaderText = "Dư Có";
            dgvSoDu.Columns["DuNo"].HeaderText = "Dư Nợ";
            dgvSoDu.Columns["SLTon"].HeaderText = "Số lượng tồn";

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
        private void LoadSoDu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SoDuDauKy";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSoDu.DataSource = dt;
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

                cboMaTK.DisplayMember = "MaTKCT";
                cboMaTK.ValueMember = "MaTKCT"; // Sửa lại để ValueMember là "MaTKCT"
                cboMaTK.DataSource = dt;
            }
        }

        private void dgvSoDu_CellClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow row = dgvSoDu.Rows[e.RowIndex];

                // Hiển thị thông tin lên các TextBox
                txtDuCo.Text = row.Cells["DuCo"].Value?.ToString();
                txtDuNo.Text = row.Cells["DuNo"].Value?.ToString();
                dtpNgayDK.Text = row.Cells["NgayDK"].Value?.ToString();
                txtLoaiTK.Text = row.Cells["TenTaiKhoan"].Value?.ToString();
                txtSLTon.Text = row.Cells["SLTon"].Value?.ToString();

                // Đặt giá trị cho ComboBox
                if (row.Cells["MaTKCT"].Value != null)
                {
                    cboMaTK.SelectedValue = row.Cells["MaTKCT"].Value.ToString();
                }
                else
                {
                    cboMaTK.SelectedIndex = -1; // No selection
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            txtDuCo.Text = "";
            txtDuNo.Text = "";
            dtpNgayDK.Value = DateTime.Now;
            txtLoaiTK.Text = "";
            cboMaTK.SelectedIndex = -1;
        }
        private void ClearInputFields()
        {
            txtDuCo.Clear();
            txtDuNo.Clear();
            txtLoaiTK.Clear();
            cboMaTK.SelectedIndex = -1;
            dtpNgayDK.Value = DateTime.Now;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSoDu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn số dư đầu kỳ cần xóa.");
                return;
            }

            // Lấy MaSDDKY từ dòng được chọn
            DataGridViewRow selectedRow = dgvSoDu.SelectedRows[0];

            // Kiểm tra nếu giá trị null
            if (selectedRow.Cells["MaSDDKY"].Value == null)
            {
                MessageBox.Show("Không thể xác định mã số dư đầu kỳ.");
                return;
            }

            if (!int.TryParse(selectedRow.Cells["MaSDDKY"].Value.ToString(), out int maSDDKY))
            {
                MessageBox.Show("Mã số dư đầu kỳ không hợp lệ.");
                return;
            }

            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa số dư đầu kỳ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM SoDuDauKy WHERE MaSDDKY = @MaSDDKY";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@MaSDDKY", SqlDbType.Int).Value = maSDDKY;

                        connection.Open();
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa số dư đầu kỳ thành công.");

                                // Làm mới DataGridView
                                LoadSoDu();

                                // Xóa các trường nhập liệu
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy số dư đầu kỳ cần xóa.");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaTK = cboMaTK.SelectedValue != null ? cboMaTK.SelectedValue.ToString() : "";
            if (string.IsNullOrEmpty(MaTK))
            {
                MessageBox.Show("Mã tài khoản không được để trống.");
                return;
            }

            if (float.TryParse(txtDuCo.Text, out float SoDu))
            {
                if (float.TryParse(txtDuNo.Text, out float SoAm))
                {
                    string LoaiTK = txtLoaiTK.Text;
                    DateTime ngayDK = dtpNgayDK.Value;
                    int slton = int.Parse(txtSLTon.Text);
                    // Chuỗi kết nối CSDL
                    string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

                    // Câu truy vấn SQL để cập nhật thông tin
                    string query = "UPDATE SoDuDauKy SET NgayDK = @NgayDK, MaTKCT = @MaTKCT, TenTaiKhoan = @TenTaiKhoan, DuCo = @DuCo, DuNo = @DuNo, SLTon = @SLTon " +
                                   "WHERE MaSDDKY = @MaSDDKY";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số vào câu truy vấn SQL để tránh lỗi SQL Injection và xử lý dữ liệu
                            command.Parameters.Add("@MaSDDKy", SqlDbType.Int).Value = int.Parse(dgvSoDu.SelectedRows[0].Cells["MaSDDKy"].Value.ToString());
                            command.Parameters.Add("@NgayDK", SqlDbType.DateTime).Value = ngayDK;
                            command.Parameters.Add("@MaTKCT", SqlDbType.NVarChar).Value = MaTK;
                            command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = LoaiTK;
                            command.Parameters.Add("@DuCo", SqlDbType.Float).Value = SoDu;
                            command.Parameters.Add("@DuNo", SqlDbType.Float).Value = SoAm;
                            command.Parameters.Add("@SLTon", SqlDbType.Float).Value = slton;


                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật số dư đầu kỳ thành công.");
                                    // Refresh DataGridView
                                    LoadSoDu();
                                    // Clear input fields
                                    ClearInputFields();
                                }
                                else
                                {
                                    MessageBox.Show("Không có số dư đầu kỳ nào được cập nhật hoặc mã tài khoản/ngày đăng ký không đúng.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số nợ phải là một số hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Số dư phải là một số hợp lệ.");
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string SoDu = txtDuCo.Text;
            string SoAm = txtDuNo.Text;
            string LoaiTK = txtLoaiTK.Text;
            string MaTK = cboMaTK.SelectedValue.ToString();
            int slton = int.Parse(txtSLTon.Text);
            DateTime NgayDK;
            if (!DateTime.TryParse(dtpNgayDK.Text, out NgayDK))
            {
                MessageBox.Show("Ngày đầu kỳ không hợp lệ.");
                return;
            }
            NgayDK = NgayDK.Date;


            // Insert the new product into the database
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SoDuDauKy (NgayDK, MaTKCT, TenTaiKhoan, DuNo, DuCo, SLTon) " +
                               "VALUES (@NgayDK, @MaTKCT, @TenTaiKhoan, @DuNo, @DuCo, @SLTon)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@NgayDK", SqlDbType.DateTime).Value = NgayDK;
                    command.Parameters.Add("@MaTKCT", SqlDbType.NVarChar).Value = MaTK;
                    command.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar).Value = LoaiTK;
                    command.Parameters.Add("@DuCo", SqlDbType.Float).Value = SoDu;
                    command.Parameters.Add("@DuNo", SqlDbType.Float).Value = SoAm;
                    command.Parameters.Add("@SLTon", SqlDbType.Float).Value = slton;



                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm số dư đầu kỳ thành công.");
                        LoadSoDu();
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
    }
}
