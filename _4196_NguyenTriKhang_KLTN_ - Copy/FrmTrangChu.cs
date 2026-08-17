using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class FrmTrangChu : Form
    {
        private string chucVu;
        public FrmTrangChu(string chucVuFromLogin)
        {
            InitializeComponent();
            this.chucVu = chucVuFromLogin;
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
            //ChangeFocus(pnNV);

        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.chucVu == "Quản lý")
            {
                FrmTrangChu frmTrangChu = new FrmTrangChu(this.chucVu);
                frmTrangChu.Show();
                this.Hide();
            }
            else
            {
                FrmKeToan frmBT = new FrmKeToan(this.chucVu);
                frmBT.ShowDialog();
                this.Hide();
            }
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmTaiKhoan frm = new FrmTaiKhoan();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmChucVu frm = new FrmChucVu();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmKhachHang frm = new FrmKhachHang();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmNhaCC frm = new FrmNhaCC();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmDoiMK frm = new FrmDoiMK();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Kiểm tra phản hồi từ người dùng
            if (result == DialogResult.OK)
            {
                // Thực hiện đăng xuất (thường là đóng form hiện tại và mở lại form đăng nhập)
                // Ví dụ: Đóng form hiện tại (FrmMain) và mở form đăng nhập (FrmDangNhap)
                this.Close(); // Đóng form hiện tại

                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Show(); // Mở form đăng nhập
            }
            else
            {
                // Người dùng chọn Cancel hoặc đóng hộp thoại cảnh báo
                // Không làm gì cả, quay trở lại trạng thái hiện tại của ứng dụng

            }
        }

        private void loạiChứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmLoaiCT frm = new FrmLoaiCT(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sốDưĐầuKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmSoDuDK frm = new FrmSoDuDK(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void bútToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmButToan frm = new FrmButToan(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            //this.Close();   
            FrmSanPham frm = new FrmSanPham();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void quảnLýNhómSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmNhomSP frm = new FrmNhomSP();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void tàiKhoảnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmTKCT frm = new FrmTKCT(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void tàiKhoảnCấp1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmTKC1 frm = new FrmTKC1(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void saoLưuVàPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmPhucHoiDL frm = new FrmPhucHoiDL();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();   
            FrmPhieuthu frm = new FrmPhieuthu(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }
    }
}
