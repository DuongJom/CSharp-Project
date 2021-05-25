using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            //if (con.State == ConnectionState.Open)
            //    con.Close();
            //con.Open();
           if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                MessageBox.Show("Tài khoản không đúng!");
            }
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Account where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister re = new frmRegister();
            re.ShowDialog();
        }
    }
}
