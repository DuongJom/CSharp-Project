using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinh viên thực hiện: \n\t1. Nguyễn Thị Mỹ Duyên-1805HTTB009" +
                "\n\t2. Lê Thị Hương Giang-1805HTTB013" +
                "\n\t3. Vũ Đỗ Hương Giang-1805HTTB014" +
                "\n\t4. Đỗ Thị Thúy-1805HTTB038" +
                "\n\t5. Nguyễn Thị Trang-1805HTTB040" +
                "\n\t6. Khúc Bạch Tú Uyên-1805HTTB046","Thông tin thành viên",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhapSach frmNhapSach = new frmNhapSach();
            frmNhapSach.ShowDialog();
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyDocGia dg = new frmQuanLyDocGia();
            dg.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTimKiem timKiem = new frmTimKiem();
            timKiem.ShowDialog();
        }
    }
}
