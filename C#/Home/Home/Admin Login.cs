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

namespace Home
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUserNameL.Text;
            string password = txtPasswordL.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM AdminLogin WHERE UserName='" + uname + "' and Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);



            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                MessageBox.Show("You have successfuly logged in");
                Admin ad = new Admin();
                ad.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Wrong Username or Password !");
            }

            txtUserNameL.Text = null;
            txtPasswordL.Text = null;




        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked)
            {
                txtPasswordL.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordL.UseSystemPasswordChar = false;
            }
        }
    }
}
