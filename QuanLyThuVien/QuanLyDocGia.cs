using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmQuanLyDocGia : Form
    {
        static string connection = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connection);
        SqlDataAdapter da;
        DataTable dt;
        bool them;
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
                sqlConnection.Open();
                da = new SqlDataAdapter("SELECT * FROM DocGia", sqlConnection);
                dt = new DataTable();
                da.Fill(dt);
                dgvDocGia.AutoResizeColumns();
                dgvDocGia.DataSource = dt;
                this.txtTenDG.ResetText();
                this.txtMaDG.ResetText();
                this.txtSoDK.ResetText();
                this.txtCMND.ResetText();
                this.txtNgaySinh.ResetText();
                this.txtMaDG.Enabled = false;
                this.txtTenDG.Enabled = false;
                this.txtSoDK.Enabled = false;
                this.txtCMND.Enabled = false;
                this.txtNgaySinh.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnCancel.Enabled = false;
                this.btnAdd.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu! Kiểm tra lại kết nối!");
            }

        }
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtTenDG.ResetText();
            this.txtMaDG.ResetText();
            this.txtSoDK.ResetText();
            this.txtCMND.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtMaDG.Enabled = true;
            this.txtTenDG.Enabled = true;
            this.txtSoDK.Enabled = true;
            this.txtCMND.Enabled = true;
            this.txtNgaySinh.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnCancel.Enabled = true;
            this.txtMaDG.Focus();
            them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            int r = dgvDocGia.CurrentCell.RowIndex;
            this.txtMaDG.Text = dgvDocGia.Rows[r].Cells[0].Value.ToString();
            this.txtTenDG.Text = dgvDocGia.Rows[r].Cells[1].Value.ToString();
            this.txtSoDK.Text = dgvDocGia.Rows[r].Cells[3].Value.ToString();
            this.txtCMND.Text = dgvDocGia.Rows[r].Cells[4].Value.ToString();
            this.txtNgaySinh.Text = dgvDocGia.Rows[r].Cells[2].Value.ToString();
            this.txtMaDG.Enabled = false;
            this.txtTenDG.Enabled = true;
            this.txtSoDK.Enabled = true;
            this.txtCMND.Enabled = true;
            this.txtNgaySinh.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnCancel.Enabled = true;
            this.txtTenDG.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("INSERT INTO DocGia VALUES('" + txtMaDG.Text.ToString() + "',N'" + txtTenDG.Text.ToString() + "','" + txtNgaySinh.Text.ToString() + "',N'" + txtSoDK.Text.ToString() +
                        "'," + txtCMND.Text.ToString() + ")");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                int r = dgvDocGia.CurrentCell.RowIndex;
                string maDG = dgvDocGia.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("UPDATE DocGia SET tenDG=N'" + txtTenDG.Text.ToString() + "',ngaySinh='" + txtNgaySinh.Text.ToString() + "',soDangKy = '" + txtSoDK.Text.ToString()
                    + "',soCMND=" + txtCMND.Text.ToString() + "WHERE maDG = '" + maDG + "'");
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa độc giả có mã là " + maDG);
            }
            sqlConnection.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                int r = dgvDocGia.CurrentCell.RowIndex;
                string maDG = dgvDocGia.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("DELETE FROM DocGia WHERE maDG ='" + maDG + "'");
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã xóa độc giả có mã là " + maDG);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtMaDG.ResetText();
            this.txtTenDG.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtSoDK.ResetText();
            this.txtCMND.ResetText();

            this.btnAdd.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void frmQuanLyDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
