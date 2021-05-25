using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmNhapSach : Form
    {
        static string connection = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connection);
        SqlDataAdapter da;
        DataTable dt;
        bool them;
        //SqlDataAdapter da = new SqlDataAdapter("insert into Sach values(N'" + txtTenSach.Text + "',N'" + txtTacGia.Text + "',N'" + cbbTheLoai.SelectedItem.ToString() + "'", sqlConnection);
        public frmNhapSach()
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
                da = new SqlDataAdapter("SELECT * FROM Sach", sqlConnection);
                dt = new DataTable();
                da.Fill(dt);
                dgvSach.AutoResizeColumns();
                dgvSach.DataSource = dt;
                this.txtMasach.ResetText();
                this.txtTacGia.ResetText();
                this.txtTenSach.ResetText();
                this.txtTheLoai.ResetText();
                this.txbSoLuong.ResetText();
                this.txtMasach.Enabled = false;
                this.txtTacGia.Enabled = false;
                this.txtTenSach.Enabled = false;
                this.txtTheLoai.Enabled = false;
                this.txbSoLuong.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnCancel.Enabled = false;
                this.btnAdd.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnBackMain.Enabled = true;
                sqlConnection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu! Kiểm tra lại kết nối!");
            }
            
        }
        private void btnBackMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtTenSach.ResetText();
            this.txtTacGia.ResetText();
            this.txtTheLoai.ResetText();
            this.txbSoLuong.ResetText();
            this.txtMasach.Enabled = true;
            this.txtTacGia.Enabled = true;
            this.txtTenSach.Enabled = true;
            this.txtTheLoai.Enabled = true;
            this.txbSoLuong.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnBackMain.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnCancel.Enabled = true;
            this.txtMasach.Focus();
            them = true;
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
                    
                    cmd.CommandText = System.String.Concat("INSERT INTO Sach VALUES('"+txtMasach.Text.ToString()+"',N'"+txtTenSach.Text.ToString()+"',N'"+txtTacGia.Text.ToString()+"',N'" +txtTheLoai.Text.ToString()+
                        "',"+Convert.ToInt32(txbSoLuong.Text)+")");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = CommandType.Text;
                int r = dgvSach.CurrentCell.RowIndex;
                string maSach = dgvSach.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("UPDATE Sach SET tenSach=N'"+txtTenSach.Text.ToString()+"',tacGia=N'"+txtTacGia.Text.ToString()+"',theLoai = N'"+txtTheLoai.Text.ToString()
                    +"',soLuong="+Convert.ToInt32(txbSoLuong.Text)+"WHERE maSach = '"+maSach+"'");
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa sách có mã sách là " + maSach);
            }
            sqlConnection.Close();
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            LoadData();
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
                int r = dgvSach.CurrentCell.RowIndex;
                string maSach = dgvSach.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("DELETE FROM Sach WHERE maSach ='" + maSach + "'");
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã xóa sách có mã sách là "+maSach);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            int r = dgvSach.CurrentCell.RowIndex;
            this.txtMasach.Text = dgvSach.Rows[r].Cells[0].Value.ToString();
            this.txtTenSach.Text = dgvSach.Rows[r].Cells[1].Value.ToString();
            this.txtTacGia.Text = dgvSach.Rows[r].Cells[2].Value.ToString();
            this.txtTheLoai.Text = dgvSach.Rows[r].Cells[3].Value.ToString();
            this.txbSoLuong.Text = dgvSach.Rows[r].Cells[4].Value.ToString();
            this.txtMasach.Enabled = false;
            this.txtTacGia.Enabled = true;
            this.txtTenSach.Enabled = true;
            this.txtTheLoai.Enabled = true;
            this.txbSoLuong.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnBackMain.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnCancel.Enabled = true;
            this.txtTenSach.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtMasach.ResetText();
            this.txtTacGia.ResetText();
            this.txtTenSach.ResetText();
            this.txtTheLoai.ResetText();
            this.txbSoLuong.ResetText();

            this.btnAdd.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void frmNhapSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
