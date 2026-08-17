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
    public partial class FrmKeToan : Form
    {
        private string chucVu;
        public FrmKeToan(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
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

        private void chiTiếtChứngTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmChiTietChungTu frm = new FrmChiTietChungTu(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();

        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            PhieuXuatKho frm = new PhieuXuatKho(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void giấyBáoCóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FrmGiayBaoCo frm = new FrmGiayBaoCo(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void hóaĐơnGTGTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            FormHDGTGT frm = new FormHDGTGT(chucVu);
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sổNhậtKýThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            SoNhatKyThuTien frm = new SoNhatKyThuTien();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sổTiềnGửiNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            SoTienGuiNganHang frm = new SoTienGuiNganHang();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sổCáiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            SoCai frm = new SoCai();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sổChiTiếtVậtTưHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            SoChiTietVatTuHangHoa frm = new SoChiTietVatTuHangHoa();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void báoCáoCôngNợPhảiThuKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            BaoCaoCongNoPhaiThuKhachHang frm = new BaoCaoCongNoPhaiThuKhachHang();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }

        private void sổNhậtKýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            SoNhatKyChung frm = new SoNhatKyChung();
            frm.Show();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(frm);
            frm.Show();
        }
    }
}
