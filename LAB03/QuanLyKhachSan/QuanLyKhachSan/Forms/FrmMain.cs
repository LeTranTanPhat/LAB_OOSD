using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc f = new FrmDanhMuc();
            f.ShowDialog(this);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ////FrmPhongTienNghi f = new FrmPhongTienNghi();
            //f.ShowDialog(this);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            //FrmDatPhong f = new FrmDatPhong();
            //f.ShowDialog(this);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //FrmDichVu f = new FrmDichVu();
            //f.ShowDialog(this);
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            //FrmTraPhong f = new FrmTraPhong();
            //f.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //FrmThongKe f = new FrmThongKe();
            //f.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}