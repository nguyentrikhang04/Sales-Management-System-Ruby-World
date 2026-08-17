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
    public partial class FrmDoiMK : Form
    {
        public FrmDoiMK()
        {
            InitializeComponent();
            txtMKC.PasswordChar = '*';
            txtMKM.PasswordChar = '*';
            txtNLMK.PasswordChar = '*';
            cbMKC.CheckedChanged += cbMKC_CheckedChanged;
        }
        private void btnCN_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text; // Assuming you have a TextBox to input the username
            string oldPassword = txtMKC.Text;
            string newPassword = txtMKM.Text;
            string confirmPassword = txtNLMK.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp.");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string queryCheckOldPassword = "SELECT COUNT(*) FROM TaiKhoanDN WHERE Taikhoan = @Taikhoan AND MatKhau = @MatKhau";
            string queryUpdatePassword = "UPDATE TaiKhoanDN SET MatKhau = @MatKhauMoi WHERE Taikhoan = @Taikhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryCheckOldPassword, connection))
                {
                    command.Parameters.AddWithValue("@Taikhoan", username);
                    command.Parameters.AddWithValue("@MatKhau", oldPassword);

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.");
                        return;
                    }
                }

                using (SqlCommand command = new SqlCommand(queryUpdatePassword, connection))
                {
                    command.Parameters.AddWithValue("@Taikhoan", username);
                    command.Parameters.AddWithValue("@MatKhauMoi", newPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công.");
                        //ClearInputFields();
                        // Tìm và đóng FrmTrangChu nếu đang mở
                        foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                        {
                            if (f is FrmTrangChu)
                                f.Close();
                        }
                        // Đóng form đổi mật khẩu
                        this.Close();
                        FrmDangNhap frmDangNhap = new FrmDangNhap();
                        frmDangNhap.Show(); // Mở form đăng nhập
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại.");
                    }
                }
            }
        }

        private void ClearInputFields()
        {
            txtMKC.Clear();
            txtMKM.Clear();
            txtNLMK.Clear();
            txtTenDN.Clear(); // Clear username field as well if needed
        }

        private void cbMKC_CheckedChanged(object sender, EventArgs e)
        {
            txtMKC.PasswordChar = cbMKC.Checked ? '\0' : '*';
            txtMKM.PasswordChar = cbMKC.Checked ? '\0' : '*';
            txtNLMK.PasswordChar = cbMKC.Checked ? '\0' : '*';
        }
    }
}
