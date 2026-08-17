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
    public partial class FrmDangNhap : Form
    {
        private string chucVu;
        public FrmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
            ckbHienMatKhau.CheckedChanged += ckbHienMatKhau_CheckedChanged;
        }
        private KetNoi data = new KetNoi();
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //LoadChucVu();
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = ckbHienMatKhau.Checked ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string query = @"SELECT TaiKhoanDN.Taikhoan, TaiKhoanDN.MatKhau, ChucVu.TenCV, NhanVien.HoTen " +
                           "FROM TaiKhoanDN " +
                           "JOIN NhanVien ON TaiKhoanDN.Taikhoan = NhanVien.Taikhoan " +
                           "JOIN ChucVu ON NhanVien.MaCV = ChucVu.MaCV " +
                           "WHERE TaiKhoanDN.Taikhoan = @username AND TaiKhoanDN.MatKhau = @password";

            SqlParameter[] parameters =
            {
                new SqlParameter("@username", txtTenDangNhap.Text),
                new SqlParameter("@password", txtMatKhau.Text)
            };

            try
            {
                using (SqlDataReader dr = data.ExecuteReader(query, parameters))
                {
                    if (dr.Read())
                    {
                        string TK = dr["Taikhoan"].ToString().ToUpper().Trim();
                        string MK = dr["MatKhau"].ToString().Trim();
                        string ChucVu = dr["TenCV"].ToString().Trim();

                        if (txtTenDangNhap.Text.ToUpper() == TK && txtMatKhau.Text == MK)
                        {
                            //MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.chucVu = ChucVu;
                            if (ChucVu == "Nhân viên bán hàng")
                            {
                                FormHDGTGT frmBanHang = new FormHDGTGT(ChucVu);
                                frmBanHang.Show();
                                this.Hide();
                            }
                            else if (ChucVu == "Quản lý")
                            {
                                FrmTrangChu frmTrangChu = new FrmTrangChu(ChucVu);
                                frmTrangChu.Show();
                                this.Hide();
                            }
                            else if (ChucVu == "Kế toán")
                            {
                                FrmKeToan frmBT = new FrmKeToan(ChucVu);
                                frmBT.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Chức vụ không được hỗ trợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản, mật khẩu hoặc chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản, mật khẩu hoặc chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
