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
    public partial class FrmGiayBaoCo : Form
    {
        private string chucVu;
        public FrmGiayBaoCo(string chucVu)
        {
            InitializeComponent();
            this.chucVu = chucVu;
        }

        private void FrmGiayBaoCo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLRBWDsGiayBaoCo.CHUNGTU' table. You can move, or remove it, as needed.
            this.cHUNGTUTableAdapter.Fill(this.qLRBWDsGiayBaoCo.CHUNGTU);
            LoadChungTu();
            LoadLoaiCT();
            SetColumnHeaders();
            ConfigureRoleBasedVisibility();
            LoadKhachHang();
            LoadNhanVien();
            LoadPTTT();
            cboKH.SelectedIndexChanged += cboKH_SelectedIndexChanged;
            cbNV.SelectedIndexChanged += cbNV_SelectedIndexChanged;
            
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
        private void LoadPTTT()
        {
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT MaTKCT, TenTKCT FROM TaiKhoanCT WHERE MaTKCT LIKE N'112%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Gán dữ liệu vào ComboBox
                cbPTTT.DisplayMember = "TenTKCT";
                cbPTTT.ValueMember = "MaTKCT";
                cbPTTT.DataSource = dt;

                // Gán DataTable vào Tag để sử dụng trong SelectedIndexChanged
                cbPTTT.Tag = dt;
            }
        }
        private void cbPTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPTTT.SelectedItem == null || cbPTTT.Tag == null)
            {
                return;
            }

            DataTable dt = (DataTable)cbPTTT.Tag;
            string selectedHoTen = cbPTTT.Text;

            if (dt.Rows.Count > 0)
            {
                DataRow[] selectedRows = dt.Select($"TenTKCT = '{selectedHoTen}'");

                if (selectedRows.Length > 0)
                {
                    txttkno.Text = selectedRows[0]["MaTKCT"].ToString();
                }
            }
        }
        private void LoadChungTu()
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CHUNGTU WHERE MACT LIKE 'GBC%'";
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
                string queryTT = "SELECT * FROM LOAICHUNGTU WHERE TENCT = N'Giấy báo có'";
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

        private string LayTKCO(string customerId)
        {
            string tkco = "";
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaTKCT FROM KhachHang WHERE MaKH = @MaKH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKH", customerId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        tkco = result.ToString();
                    }
                }
            }
            return tkco;
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
                cboKH.Text = row.Cells["MAKH"].Value?.ToString();
                txttkco.Text = LayTKCO(customerId);
                txtMaNV.Text = row.Cells["MANV"].Value?.ToString();
                string maTKCT = "";
                string tenCotPTTT = "PTTT";
                if (row.Cells[tenCotPTTT] != null && row.Cells[tenCotPTTT].Value != null)
                {
                    string tenPTTTDuocChon = row.Cells[tenCotPTTT].Value.ToString();
                    string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
                    string query = "SELECT MaTKCT FROM TaiKhoanCT WHERE TenTKCT = @TenTKCT";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTKCT", tenPTTTDuocChon);

                            try
                            {
                                connection.Open();
                                object result = command.ExecuteScalar();

                                if (result != null && result != DBNull.Value)
                                {
                                    maTKCT = result.ToString();
                                }
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi truy vấn Mã TKCT: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                maTKCT = "";
                            }
                        }
                    }
                    txttkno.Text = maTKCT;
                }
                else
                {
                    txttkno.Text = "";
                }
            }
        }
        private string LayTKNO(string employeeId)
        {
            string employeeName = "";
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenTKCT FROM TaiKhoanCT WHERE MaTKCT = @MaTKCT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaTKCT", employeeId);
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
        private void LoadKhachHang()
        {
            string connStr = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT MaKH, HoTenKH, DiaChiKH, SDTKH, EmailKH, MaTKCT FROM KhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Gán dữ liệu vào ComboBox
                cboKH.DisplayMember = "MaKH";
                cboKH.ValueMember = "MaKH";
                cboKH.DataSource = dt;

                // Gán DataTable vào Tag để sử dụng trong SelectedIndexChanged
                cboKH.Tag = dt;
            }
        }
        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu Tag chưa được gán dữ liệu
            if (cboKH.Tag == null)
            {
                return;
            }

            DataTable dt = (DataTable)cboKH.Tag;

            if (cboKH.SelectedValue != null)
            {
                string selectedMaKH = cboKH.SelectedValue.ToString();

                // Kiểm tra nếu DataTable không rỗng trước khi truy vấn
                if (dt.Rows.Count > 0)
                {
                    DataRow[] selectedRows = dt.Select($"MaKH = '{selectedMaKH}'");

                    if (selectedRows.Length > 0)
                    {
                        txtKH.Text = selectedRows[0]["HoTenKH"].ToString();
                        txttkco.Text = selectedRows[0]["MaTKCT"].ToString();
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

                // Gán dữ liệu vào ComboBox
                cbNV.DisplayMember = "HoTen";
                cbNV.ValueMember = "MaKH";
                cbNV.DataSource = dt;

                // Gán DataTable vào Tag để sử dụng trong SelectedIndexChanged
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

                        // Begin transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {

                                // Delete from CHUNGTU table
                                string deleteChungTuQuery = "DELETE FROM CHUNGTU WHERE MaCT = @MaCT";
                                using (SqlCommand deleteChungTuCommand = new SqlCommand(deleteChungTuQuery, connection, transaction))
                                {
                                    deleteChungTuCommand.Parameters.AddWithValue("@MaCT", maCT);
                                    deleteChungTuCommand.ExecuteNonQuery();
                                }

                                // Commit transaction
                                transaction.Commit();
                                MessageBox.Show("Xóa chứng từ thành công!");

                                // Reload data
                                LoadChungTu();
                            }
                            catch (Exception ex)
                            {
                                // Rollback transaction if error occurs
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
            string query = "SELECT TOP 1 MaCT FROM CHUNGTU WHERE MaCT LIKE 'GBC%' ORDER BY MaCT DESC";

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
                return "GBC001";
            }

            string phanSo = maCTCuoiCung.Substring(3);
            int soMoi = int.Parse(phanSo) + 1;
            string maCTMoi = "GBC" + soMoi.ToString("D3");

            return maCTMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTMoi = TaoMaCTMoi();
            txtMaCT.Text = maCTMoi;
            btnLuu.Visible = true;
            txtSoCT.Text = "";
            txtLCT.Text = "Giấy Báo Có";
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
            string maLCT = "1";
            string maBT = txtMaBT.Text;

            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // 🔹 Thực hiện INSERT sản phẩm mới
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            ClearInputFields();
            LoadChungTu();
        }

        private void btnMaBT_Click(object sender, EventArgs e)
        {
            // (tùy chọn) chuẩn bị giá trị ban đầu để truyền vào FrmButToan
            string noiDung = txtMoTa.Text.Trim();
            string tkno = txttkno.Text;
            string tkco = txttkco.Text;
            int soLuongBt = 1;
            decimal donGiaBt = decimal.Parse(txtTongTien.Text);
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

            // Mở FrmButToan với giá trị khởi tạo
            using (FrmButToan frm = new FrmButToan(noiDung, tkno, tkco, soLuongBt, donGiaBt))
            {
                // Bỏ dòng string maBT = FrmButToan.MaBT;

                var dr = frm.ShowDialog();
            }
        }
        public DataTable GetThongTinChungTu(string maChungTu)
        {
            string connectionString = @"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True";
            string query = @"
                            SELECT CHUNGTU.MaCT, FORMAT(NgayLap, 'dd/MM/yyyy') AS Ngay, Buttoan.MaBT, TKNO, TKCO, FORMAT(Buttoan.SoLuong*Buttoan.DonGia, '#,##0', 'vi-VN') AS SoTien, SoCT, HoTenKH, DiaChiKH, Mota, HoTen, TenTKCT
	                        FROM KhachHang
	                        JOIN CHUNGTU ON KhachHang.MaKH = CHUNGTU.MaKH
	                        JOIN Buttoan ON CHUNGTU.MaBT = Buttoan.MaBT
	                        JOIN NhanVien ON NhanVien.MaNV = CHUNGTU.MaNV
	                        JOIN TaiKhoanCT ON Buttoan.TKNO = TaiKhoanCT.MaTKCT
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
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một Giấy Báo Có cần xuất báo cáo.");
                return;
            }
            string maChungTuDuocChon = dgvPhieuThu.SelectedRows[0].Cells["MaCT"].Value.ToString();
            try
            {

                DataTable dtHeader = GetThongTinChungTu(maChungTuDuocChon);
                    FrmBaoCaoGiayBaoCo frmReport = new FrmBaoCaoGiayBaoCo();
                    frmReport.HienThiBaoCao(dtHeader);

                    frmReport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
