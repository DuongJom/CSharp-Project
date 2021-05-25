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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            if (txtUserName.Text != "" && (txtPass.Text.CompareTo(txtRepeatPass.Text) == 0) && (ckbLinces.CheckState==CheckState.Checked))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("insert into Account values('" + txtUserName.Text.ToString() + "','" + txtPass.Text.ToString() + "')");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm user thành công!");
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Vui lòng cung cấp đủ thông tin yêu cầu!");
        }
    }
}
