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
    public partial class FormHDGTGT : Form
    {
        private string chucVu;
        public FormHDGTGT(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
        }
        KetNoi data = new KetNoi();

        private void FormHDGTGT_Load(object sender, EventArgs e)
        {
            this.cHUNGTUTableAdapter.Fill(this.qLRBWDsHDGTGT.CHUNGTU);
            LoadChungTu();
            LoadLoaiCT();
            SetColumnHeaders();
            ConfigureRoleBasedVisibility();
            InitCart();
            LoadKhachHang();
            LoadNhanVien();
            LoadSanPham();
            cboKH.SelectedIndexChanged += cboKH_SelectedIndexChanged;
            cbNV.SelectedIndexChanged += cbNV_SelectedIndexChanged;
            cbPTTT.SelectedIndexChanged -= cbPTTT_SelectedIndexChanged;
            LoadPhuongThucThanhToanCoDinh();
            cbPTTT.SelectedIndexChanged += cbPTTT_SelectedIndexChanged;
            txttkco.Text = "511";
            txttkco.Enabled = false;
            if (this.chucVu == "Nhân viên bán hàng")
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
            }
            else
            {
                btnThem.Visible = true;
                btnXoa.Visible = true;
                btnSua.Visible = true;
                btnLuu.Visible = true;
            }
        }
        private void LoadPhuongThucThanhToanCoDinh()
        {
            DataTable dtPTTT = new DataTable();
            dtPTTT.Columns.Add("MaPTTT", typeof(string));
            dtPTTT.Columns.Add("TenPTTT", typeof(string));
            DataRow rowTienMat = dtPTTT.NewRow();
            rowTienMat["MaPTTT"] = "111";
            rowTienMat["TenPTTT"] = "Trả bằng tiền mặt";
            dtPTTT.Rows.Add(rowTienMat);
            DataRow rowChuyenKhoan = dtPTTT.NewRow();
            rowChuyenKhoan["MaPTTT"] = "112";
            rowChuyenKhoan["TenPTTT"] = "Chuyển khoản ngân hàng";
            dtPTTT.Rows.Add(rowChuyenKhoan);
            cbPTTT.DataSource = dtPTTT;
            cbPTTT.DisplayMember = "TenPTTT";
            cbPTTT.ValueMember = "MaPTTT";
            cbPTTT.SelectedIndex = 0;
        }
        private DataTable dtCart;
        private void InitCart()
        {
            dtCart = new DataTable();
            dtCart.Columns.Add("MaSP", typeof(string));
            dtCart.Columns.Add("TenSP", typeof(string));
            dtCart.Columns.Add("SoLuong", typeof(int));
            dtCart.Columns.Add("DonGia", typeof(decimal));
            dtCart.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia"); // computed column

            dgvCart.DataSource = dtCart;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.MultiSelect = false;
            dgvCart.AllowUserToAddRows = false;
        }
        private void SetColumnHeaders()
        {
            dgvPhieuThu.Columns["MaCT"].HeaderText = "Mã CT";
            dgvPhieuThu.Columns["NgayLap"].HeaderText = "Ngày lập";
            dgvPhieuThu.Columns["SoCT"].HeaderText = "Số CT";
            dgvPhieuThu.Columns["Mota"].HeaderText = "Mô tả";
            dgvPhieuThu.Columns["PTTT"].HeaderText = "Phương thức thanh toán";
            dgvPhieuThu.Columns["MaKH"].HeaderText = "Mã KH";
            dgvPhieuThu.Columns["MaNV"].HeaderText = "Mã NV";
            dgvPhieuThu.Columns["MaLCT"].HeaderText = "Mã loại CT";
            dgvPhieuThu.Columns["MaBT"].HeaderText = "Mã bút toán";
        }

        private void ConfigureRoleBasedVisibility()
        {
            if (this.chucVu == "Quản lý")
            {
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnThem.Visible = false;
            }
            else
            {
                btnXoa.Visible = true;
                btnSua.Visible = true;
                btnThem.Visible = true;
            }
        }

        private void LoadChungTu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CHUNGTU WHERE MACT LIKE 'HD%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPhieuThu.DataSource = dt;
            }
        }

        private void LoadLoaiCT()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryTT = "SELECT * FROM LOAICHUNGTU WHERE TENCT = N'Hóa đơn GTGT'";
                SqlDataAdapter adapter = new SqlDataAdapter(queryTT, connection);
                DataTable dtTT = new DataTable();
                adapter.Fill(dtTT);

                if (dtTT.Rows.Count > 0)
                {
                    txtLCT.Text = dtTT.Rows[0]["TenCT"].ToString();
                }
            }
        }

        private string LayTenKH(string customerId)
        {
            string customerName = "";
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTenKH FROM KhachHang WHERE MaKH = @MaKH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKH", customerId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        customerName = result.ToString();
                    }
                }
            }
            return customerName;
        }

        private string LayTenNV(string employeeId)
        {
            string employeeName = "";
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTen as HoTenNV FROM NHANVIEN WHERE MANV = @MANV";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MANV", employeeId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeName = result.ToString();
                    }
                }
            }
            return employeeName;
        }
        private void dgvPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuThu.Rows[e.RowIndex];

                txtMaCT.Text = row.Cells["MaCT"].Value?.ToString();
                txtSoCT.Text = row.Cells["SoCT"].Value?.ToString();
                string customerId = row.Cells["MAKH"].Value?.ToString();
                string employeeId = row.Cells["MANV"].Value?.ToString();
                txtKH.Text = LayTenKH(customerId);
                cbNV.Text = LayTenNV(employeeId);
                txtMoTa.Text = row.Cells["Mota"].Value?.ToString();
                dtpNgayLap.Text = row.Cells["NgayLap"].Value?.ToString();
                cbPTTT.Text = row.Cells["PTTT"].Value?.ToString();
                cboKH.Text = row.Cells["MAKH"].Value?.ToString();
                txttkco.Text = "511";
                txttkco.Enabled = false;
                txtMaNV.Text = row.Cells["MANV"].Value?.ToString();
            }
        }
        private void LoadKhachHang()
        {
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT MaKH, HoTenKH, DiaChiKH, SDTKH, EmailKH, MaTKCT FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cboKH.DisplayMember = "MaKH";
                cboKH.ValueMember = "MaKH";
                cboKH.DataSource = dt;
                cboKH.Tag = dt;
            }
        }
        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKH.Tag == null)
            {
                return;
            }

            DataTable dt = (DataTable)cboKH.Tag;

            if (cboKH.SelectedValue != null)
            {
                string selectedMaKH = cboKH.SelectedValue.ToString();
                if (dt.Rows.Count > 0)
                {
                    DataRow[] selectedRows = dt.Select($"MaKH = '{selectedMaKH}'");

                    if (selectedRows.Length > 0)
                    {
                        txtKH.Text = selectedRows[0]["HoTenKH"].ToString();
                    }
                }
            }
        }
        private void LoadNhanVien()
        {
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT MaNV, HoTen FROM NhanVien WHERE HoTen <> 'admin'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbNV.DisplayMember = "HoTen";
                cbNV.ValueMember = "MaKH";
                cbNV.DataSource = dt;
                cbNV.Tag = dt;
            }
        }
        private void cbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNV.SelectedItem == null || cbNV.Tag == null)
            {
                return;
            }

            DataTable dt = (DataTable)cbNV.Tag;
            string selectedHoTen = cbNV.Text;

            if (dt.Rows.Count > 0)
            {
                DataRow[] selectedRows = dt.Select($"HoTen = '{selectedHoTen}'");

                if (selectedRows.Length > 0)
                {
                    txtMaNV.Text = selectedRows[0]["MaNV"].ToString();
                }
            }
        }
        private void LoadSanPham()
        {
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT MaSP, TenSP FROM SanPham";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbSP.DisplayMember = "TenSP";
                cbSP.ValueMember = "MaSP";
                cbSP.DataSource = dt;
                cbSP.Tag = dt;
            }
        }
        private void UpdateSummary()
        {
            decimal total = 0;
            foreach (DataRow r in dtCart.Rows) total += r.Field<decimal>("ThanhTien");
            lblTotal.Text = total.ToString("N0");
        }

        private void bnthemsp_Click(object sender, EventArgs e)
        {
            if (cbSP.SelectedValue == null)
            {
                MessageBox.Show("Chọn sản phẩm.");
                return;
            }

            string maSP = cbSP.SelectedValue.ToString();
            string tenSP = cbSP.Text;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int qty) || qty <= 0) { MessageBox.Show("Số lượng không hợp lệ"); return; }
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal price) || price <= 0) { MessageBox.Show("Đơn giá không hợp lệ"); return; }
            DataRow existing = dtCart.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSP") == maSP);
            if (existing != null)
            {
                existing.SetField("SoLuong", existing.Field<int>("SoLuong") + qty);
                existing.SetField("DonGia", price);
            }
            else
            {
                dtCart.Rows.Add(maSP, tenSP, qty, price);
            }

            UpdateSummary();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chứng từ cần xóa.");
                return;
            }

            DataGridViewRow selectedRow = dgvPhieuThu.SelectedRows[0];
            string maCT = selectedRow.Cells["MaCT"].Value?.ToString();

            if (string.IsNullOrEmpty(maCT))
            {
                MessageBox.Show("Không thể xác định mã chứng từ.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chứng từ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                string deleteChungTuQuery = "DELETE FROM CHUNGTU WHERE MaCT = @MaCT";
                                using (SqlCommand deleteChungTuCommand = new SqlCommand(deleteChungTuQuery, connection, transaction))
                                {
                                    deleteChungTuCommand.Parameters.AddWithValue("@MaCT", maCT);
                                    deleteChungTuCommand.ExecuteNonQuery();
                                }
                                transaction.Commit();
                                MessageBox.Show("Xóa chứng từ thành công!");
                                LoadChungTu();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Lỗi khi xóa chứng từ: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chứng từ cần sửa.");
                return;
            }

            string maCT = txtMaCT.Text.Trim();
            string soCT = txtSoCT.Text;
            string maKH = txtKH.Text;
            string maNV = txtMaNV.Text;
            string moTa = txtMoTa.Text;
            DateTime ngayLapValue = dtpNgayLap.Value;
            string maLoaiCT = "3";
            string pttt = cbPTTT.Text;

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE CHUNGTU SET NgayLap = @NgayLap, SoCT = @SoCT, Mota = @Mota, PTTT = @PTTT, MaLCT = @MaLCT WHERE MaCT = @MaCT";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NgayLap", ngayLapValue);
                    command.Parameters.AddWithValue("@SoCT", soCT);
                    command.Parameters.AddWithValue("@Mota", moTa);
                    command.Parameters.AddWithValue("@PTTT", pttt);
                    command.Parameters.AddWithValue("@MaLCT", maLoaiCT);
                    command.Parameters.AddWithValue("@MaCT", maCT);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa chứng từ thành công!");
                        LoadChungTu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa chứng từ: " + ex.Message);
                    }
                }
            }
        }
        private string LayMaCTCuoiCung()
        {
            string maCTCuoiCung = "";

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaCT FROM CHUNGTU WHERE MaCT LIKE 'HD%' ORDER BY MaCT DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maCTCuoiCung = reader["MaCT"].ToString();
                    }

                    reader.Close();
                }
            }

            return maCTCuoiCung;
        }

        private string TaoMaCTMoi()
        {
            string maCTCuoiCung = LayMaCTCuoiCung();
            if (string.IsNullOrEmpty(maCTCuoiCung))
            {
                return "HD001";
            }

            string phanSo = maCTCuoiCung.Substring(2);
            int soMoi = int.Parse(phanSo) + 1;
            string maCTMoi = "HD" + soMoi.ToString("D3");

            return maCTMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTMoi = TaoMaCTMoi();
            txtMaCT.Text = maCTMoi;
            btnLuu.Visible = true;
            txtSoCT.Text = "";
            txtLCT.Text = "Hóa đơn GTGT";
            dtpNgayLap.Value = DateTime.Now;
            txtMoTa.Text = "";
            txtMaCT.ReadOnly = true;
            txtLCT.Enabled = false;
        }
        private void ClearInputFields()
        {
            txtMaCT.Clear();
            txtSoCT.Clear();
            txtLCT.Clear();
            dtpNgayLap.Value = DateTime.Now;
            txtMoTa.Clear();

            txtMaCT.ReadOnly = false;
        }
        private void LuuChiTietChungTu()
        {
            string maChungTu = txtMaCT.Text;
            DateTime ngayLap = dtpNgayLap.Value;
            if (string.IsNullOrEmpty(maChungTu) || dtCart.Rows.Count == 0)
            {
                MessageBox.Show("Mã Chứng từ không hợp lệ hoặc danh sách sản phẩm rỗng.", "Lỗi Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "INSERT INTO CHITIETCHUNGTU (MaCT, MaSP, NgayLap, SlSP, DGSP) " +
                           "VALUES (@MaCT, @MaSP, @NgayLap, @SlSP, @DGSP)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DataRow row in dtCart.Rows)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            string maSP = row["MaSP"].ToString();
                            int soLuong = (int)row["SoLuong"];
                            decimal donGia = (decimal)row["DonGia"];
                            command.Parameters.AddWithValue("@MaCT", maChungTu);
                            command.Parameters.AddWithValue("@MaSP", maSP);
                            command.Parameters.AddWithValue("@NgayLap", ngayLap);
                            command.Parameters.AddWithValue("@SlSP", soLuong);
                            command.Parameters.AddWithValue("@DGSP", donGia);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();

                    MessageBox.Show($"Đã lưu thành công {dtCart.Rows.Count} chi tiết sản phẩm vào chứng từ {maChungTu}.", "Thành công");
                    dtCart.Clear();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maCT = txtMaCT.Text;
            DateTime NgayLap;
            if (!DateTime.TryParse(dtpNgayLap.Text, out NgayLap))
            {
                MessageBox.Show("Ngày lập không hợp lệ.");
                return;
            }
            NgayLap = NgayLap.Date;
            string soCT = txtSoCT.Text;
            string moTa = txtMoTa.Text;
            string pTTT = cbPTTT.Text;
            string maKH = cboKH.SelectedValue?.ToString();
            string maNV = txtMaNV.Text;
            string maLCT = "4";
            string maBT = txtMaBT.Text;

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO CHUNGTU (MaCT, NgayLap, SoCT, Mota, PTTT, MaKH, MaNV, MaLCT, MaBT) " +
                               "VALUES (@MaCT, @NgayLap, @SoCT, @Mota, @PTTT, @MaKH, @MaNV, @MaLCT, @MaBT)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaCT", maCT);
                    command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = NgayLap;
                    command.Parameters.AddWithValue("@SoCT", soCT);
                    command.Parameters.AddWithValue("@Mota", moTa);
                    command.Parameters.AddWithValue("@PTTT", pTTT);
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    command.Parameters.AddWithValue("@MaLCT", maLCT);
                    command.Parameters.AddWithValue("@MaBT", maBT);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm chứng từ thành công.");
                        LoadSanPham();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            LuuChiTietChungTu();
            ClearInputFields();
            LoadChungTu();
        }

        private void btnMaBT_Click(object sender, EventArgs e)
        {
            string noiDung = txtMoTa.Text.Trim();
            string tkno = txttkno.Text;
            string tkco = txttkco.Text;
            int soLuongBt = 1;
            decimal donGiaBt = decimal.Parse(lblTotal.Text);
            string maBTCuoiCung = "";

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = "SELECT TOP 1 MaBT FROM Buttoan ORDER BY MaBT DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        maBTCuoiCung = reader["MaBT"].ToString();
                    }

                    reader.Close();
                }
            }

            string phanSo = maBTCuoiCung.Substring(2);
            int soMoi = int.Parse(phanSo) + 1;
            string maBTMoi = "BT" + soMoi.ToString("D2");

            txtMaBT.Text = maBTMoi;
            using (FrmButToan frm = new FrmButToan(noiDung, tkno, tkco, soLuongBt, donGiaBt))
            {
                var dr = frm.ShowDialog();
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvCart.SelectedRows[0];

            try
            {
                decimal thanhTien = 0;
                decimal soLuong = 0;
                decimal donGia = 0;
                if (selectedRow.Cells["SoLuong"] != null && selectedRow.Cells["SoLuong"].Value != null)
                {
                    decimal.TryParse(selectedRow.Cells["SoLuong"].Value.ToString(), out soLuong);
                }
                if (selectedRow.Cells["DonGia"] != null && selectedRow.Cells["DonGia"].Value != null)
                {
                    decimal.TryParse(selectedRow.Cells["DonGia"].Value.ToString(), out donGia);
                }
                thanhTien = soLuong * donGia;

                decimal tongTienHienTai = 0;
                string totalText = lblTotal.Text.Replace(".", "").Replace(",", "").Trim();

                if (decimal.TryParse(totalText, out tongTienHienTai))
                {
                    tongTienHienTai -= thanhTien;
                    lblTotal.Text = tongTienHienTai.ToString("N0");
                }
                dgvCart.Rows.Remove(selectedRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dòng hoặc cập nhật tổng tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapNhatTongTien(decimal giaTriThayDoi, bool reset = false)
        {
            decimal tongTienHienTai = 0;
            string totalText = lblTotal.Text.Replace(".", "").Replace(",", "").Trim();
            decimal.TryParse(totalText, out tongTienHienTai);
            if (reset)
            {
                tongTienHienTai = 0;
            }
            else
            {
                tongTienHienTai += giaTriThayDoi;
            }
            lblTotal.Text = tongTienHienTai.ToString("N0");
        }
        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn XÓA TOÀN BỘ danh sách tạm thời không?",
                "Xác nhận xóa TẤT CẢ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dtCart.Clear();
                    CapNhatTongTien(0, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tất cả: " + ex.Message, "Lỗi");
                }
            }
        }
        private void cbPTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPTTT.SelectedIndex == -1 || cbPTTT.SelectedValue == null)
            {
                txttkno.Text = "";
                return;
            }
            string maTKNo = cbPTTT.SelectedValue.ToString();
            txttkno.Text = maTKNo;
        }

        public DataTable GetThongTinChungTu(string maChungTu)
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = @"
                            SELECT CHUNGTU.MaCT, day(CHUNGTU.NgayLap) AS Ngay, month(CHUNGTU.NgayLap) AS Thang, year(CHUNGTU.NgayLap) AS Nam,
		                           Buttoan.MaBT, FORMAT(Buttoan.SoLuong*Buttoan.DonGia, '#,##0', 'vi-VN') AS TongTien, SoCT, Mota, HoTen, HoTenKH, DiaChiKH, PTTT,
		                           FORMAT((Buttoan.SoLuong*Buttoan.DonGia)*0.1, '#,##0', 'vi-VN') AS VAT, FORMAT((Buttoan.SoLuong*Buttoan.DonGia)*1.1, '#,##0', 'vi-VN') AS TongTienThanhToan
	                        FROM CHUNGTU
	                        JOIN KhachHang ON KhachHang.MaKH = CHUNGTU.MaKH
	                        JOIN CHITIETCHUNGTU ON CHUNGTU.MaCT = CHITIETCHUNGTU.MaCT
	                        JOIN Buttoan ON CHUNGTU.MaBT = Buttoan.MaBT
	                        JOIN NhanVien ON NhanVien.MaNV = CHUNGTU.MaNV
                            WHERE CHUNGTU.MaCT = @MaCT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@MaCT", maChungTu);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        private DataTable LayDuLieuPhieuXuatKhoDetail(string maCT)
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = @"
                            SELECT ROW_NUMBER() OVER (ORDER BY CHUNGTU.MaCT) AS STT, SanPham.MaSP, TenSP, DonViTinh, SlSP, Soluongton, FORMAT(DGSP, '#,##0', 'vi-VN') AS DonGia, FORMAT(SlSP*DGSP, '#,##0', 'vi-VN') AS SoTien
	                        FROM CHUNGTU
	                        JOIN CHITIETCHUNGTU ON CHUNGTU.MaCT = CHITIETCHUNGTU.MaCT
	                        JOIN SanPham ON SanPham.MaSP = CHITIETCHUNGTU.MaSP
                            WHERE CHUNGTU.MaCT = @MaCT";

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaCT", maCT);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string maCT = txtMaCT.Text;

            if (string.IsNullOrEmpty(maCT))
            {
                MessageBox.Show("Vui lòng chọn một Hóa Đơn GTGT để in.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dtHeader = GetThongTinChungTu(maCT);
                DataTable dtDetail = LayDuLieuPhieuXuatKhoDetail(maCT);
                FrmBaoCaoHoaDonGTGT frmBaoCao = new FrmBaoCaoHoaDonGTGT();
                frmBaoCao.HienThiBaoCaoHoaDonGTGT(dtHeader, dtDetail);

                frmBaoCao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuẩn bị dữ liệu báo cáo: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
