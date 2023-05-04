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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MyProfile mp = new MyProfile();
            mp.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Show();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnSignupU_Click(object sender, EventArgs e)
        {
            string Uname = txtUserNameU.Text;
            string Pass = txtPasswordU.Text;
          
            string NewPass = txtNewPasswordU.Text;
            string Cpass = txtNewPasswordU.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE SignUp SET Password = '"+NewPass+"' , ConfirmPassword = '"+Cpass+"'  WHERE UserName = '"+Uname+"' and Password = '"+Pass+"' ";
            SqlCommand cmd = new SqlCommand(qry,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfuly");
                MyProfile mp = new MyProfile();
                mp.Show();
                this.Hide();
            }
            catch(Exception ec)
            {
                MessageBox.Show("Error" + ec);
            }
            txtUserNameU.Text = null;
            txtPasswordU.Text = null;
            txtNewPasswordU.Text = null;
            txtconfirmPassU.Text = null;
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked)
            {
                txtNewPasswordU.UseSystemPasswordChar = true;

            }
            else
            {
                txtNewPasswordU.UseSystemPasswordChar = false;

            }
            if(checkShowConPassword.Checked)
            {
                txtconfirmPassU.UseSystemPasswordChar = true;
            }
            else
            {
                txtconfirmPassU.UseSystemPasswordChar = false;
            }
        }
    }
}
