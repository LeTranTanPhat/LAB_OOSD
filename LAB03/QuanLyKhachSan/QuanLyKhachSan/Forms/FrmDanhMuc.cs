using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService danhMucService = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        /// <summary>
        /// Tải lại toàn bộ DataGridView và ComboBox từ Database
        /// </summary>
        /// 
        private void tpKhuVuc_Click(object sender, EventArgs e)
        {
        }
        private void TaiDuLieu()
        {
            try
            {
                dgvKhu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLoaiTN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvQD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvKhu.DataSource = danhMucService.LayKhuVuc();
                dgvNV.DataSource = danhMucService.LayNhanVien();
                dgvLoaiTN.DataSource = danhMucService.LayLoaiTienNghi();
                dgvDV.DataSource = danhMucService.LayDichVu();
                dgvQD.DataSource = danhMucService.LayQuyDinhDenBu();

                cboQDLoai.DataSource = danhMucService.LayLoaiTienNghi();
                cboQDLoai.DisplayMember = "TenLoaiTN";
                cboQDLoai.ValueMember = "MaLoaiTN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể kết nối cơ sở dữ liệu:\n" + ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Xử lý hiển thị thông báo và tải lại dữ liệu nếu thành công
        /// </summary>
        private void XuLyKetQua(KetQuaXuLy result, Action xoaTrangForm = null)
        {
            if (result.ThanhCong)
            {
                MessageBox.Show(result.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaTrangForm?.Invoke(); // Xóa trắng ô nhập liệu nếu thành công
                TaiDuLieu(); // Load lại lưới dữ liệu
            }
            else
            {
                MessageBox.Show(result.ThongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Xử lý Thêm Danh Mục

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            var res = danhMucService.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim());
            XuLyKetQua(res, () => {
                txtKhuMa.Clear();
                txtKhuTen.Clear();
            });
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            var res = danhMucService.ThemNhanVien(
                txtNVMa.Text.Trim(),
                txtNVTen.Text.Trim(),
                txtNVVaiTro.Text.Trim(),
                txtNVSDT.Text.Trim()
            );
            XuLyKetQua(res, () => {
                txtNVMa.Clear();
                txtNVTen.Clear();
                txtNVVaiTro.Clear();
                txtNVSDT.Clear();
            });
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            var res = danhMucService.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim());
            XuLyKetQua(res, () => {
                txtLoaiMa.Clear();
                txtLoaiTen.Clear();
            });
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            var res = danhMucService.ThemDichVu(
                txtDVMa.Text.Trim(),
                txtDVTen.Text.Trim(),
                txtDVDVT.Text.Trim(),
                numDVGia.Value
            );
            XuLyKetQua(res, () => {
                txtDVMa.Clear();
                txtDVTen.Clear();
                txtDVDVT.Clear();
                numDVGia.Value = 0;
            });
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string maLoaiTN = cboQDLoai.SelectedValue?.ToString() ?? "";

            var res = danhMucService.ThemQuyDinh(
                txtQDMa.Text.Trim(),
                maLoaiTN,
                txtQDMucDo.Text.Trim(),
                numQDTien.Value
            );
            XuLyKetQua(res, () => {
                txtQDMa.Clear();
                txtQDMucDo.Clear();
                numQDTien.Value = 0;
            });
        }

        #endregion

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNVMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}