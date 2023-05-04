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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
           
            
            string uname = txtUserNameS.Text;
            string email = txtEmailS.Text;
            string pass = txtPasswordS.Text;
            string cpass = txtConfirmPasswordS.Text;

           
           

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");
            
            

            try
            {
               
                if (txtPasswordS.Text == txtConfirmPasswordS.Text)
                {
                    string qry = "INSERT INTO SignUp VALUES('" + uname + "' , '" + email + "' , '" + pass + "' , '" + cpass + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfuly");

                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords are not matching!");
                }
                if(uname == "" || email == "" || pass == "" || cpass == "" )
                {

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ ex);
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                txtPasswordS.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordS.UseSystemPasswordChar = false;
            }
        }

        private void checkShowConPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowConPassword.Checked)
            {
                txtConfirmPasswordS.UseSystemPasswordChar = true;
            }
            else
            {
                txtConfirmPasswordS.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPasswordS_TextChanged(object sender, EventArgs e)
        {
            if(txtPasswordS.Text == txtConfirmPasswordS.Text)
            {
                lblShowPassWrongOrCorrect.ForeColor = Color.Green;
                lblShowPassWrongOrCorrect.Text = "Correct";
            }
            else
            {
                lblShowPassWrongOrCorrect.ForeColor = Color.Red;
                lblShowPassWrongOrCorrect.Text = "Wrong ! ";
            }
        }
    }
}
