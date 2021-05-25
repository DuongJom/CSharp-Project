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
    public partial class frmTimKiem : Form
    {
        static string connection = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connection);
        SqlDataAdapter da;
        DataTable dt;
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
            sqlConnection.Open();
           try
            {
                if (rdbTenSach.Checked && txtSearchTenSach.Text!="")
                {
                    da = new SqlDataAdapter("SELECT * FROM Sach WHERE tenSach=N'" + txtSearchTenSach.Text.ToString() + "'", sqlConnection);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dgvTimSach.DataSource = dt;
                    dgvTimSach.AutoResizeColumns();
                    if (dgvTimSach.RowCount > 0)
                        MessageBox.Show("Đã tìm thấy " + (dgvTimSach.RowCount - 1) + " kết quả");
                    else MessageBox.Show("Không tìm thấy kết quả nào");
                }
                else if (rdbTacGia.Checked && txtSearchTacGia.Text!="")
                {
                    da = new SqlDataAdapter("SELECT * FROM Sach WHERE tacGia=N'" + txtSearchTacGia.Text.ToString() + "'", sqlConnection);
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dgvTimSach.DataSource = dt;
                    dgvTimSach.AutoResizeColumns();
                    if (dgvTimSach.RowCount > 0)
                        MessageBox.Show("Đã tìm thấy " + (dgvTimSach.RowCount - 1) + " kết quả");
                    else MessageBox.Show("Không tìm thấy kết quả nào");
                }
                else MessageBox.Show("Vui lòng chọn nội dung tìm kiếm!");
                
                this.txtSearchTacGia.ResetText();
                this.txtSearchTenSach.ResetText();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            if (rdbTenSach.Checked)
            {
                txtSearchTenSach.Enabled = true;
            }
            else if(rdbTacGia.Checked)
                txtSearchTacGia.Enabled = true;
            else
            {
                txtSearchTenSach.Enabled = true;
                txtSearchTacGia.Enabled=true;
            }
        }

        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
