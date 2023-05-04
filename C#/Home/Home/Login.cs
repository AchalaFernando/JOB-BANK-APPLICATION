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
    public partial class Login : Form
    {
        
        public Login()
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
        public static string username;
        
        public static string ToMyProfile
        {
            get { return username; }
            set { username = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ToMyProfile = txtUserNameL.Text;
            string username = txtUserNameL.Text;
            try
            {
                string password = txtPasswordL.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT * FROM Signup WHERE UserName='" + username + "' and Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            
            
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    MessageBox.Show("You have successfuly logged in");
                    MyProfile mp = new MyProfile();
                    mp.Show();
                    this.Hide();
                    
                    
                }
                else
                {
                    MessageBox.Show("Username & Password are incorrect");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            txtUserNameL.Text = "";
            txtPasswordL.Text = "";
        }

        private void txtUserNameL_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserNameL.Text))
            {
                e.Cancel = true;
                txtUserNameL.Focus();
                errorProvider1.SetError(txtUserNameL, "Please enter your name ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserNameL, null);
            }
        }

        private void txtPasswordL_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordL.Text))
            {
                e.Cancel = true;
                txtPasswordL.Focus();
                errorProvider1.SetError(txtPasswordL, "Please enter your password ! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPasswordL, null);
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
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
