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
    public partial class Delete : Form
    {
        public Delete()
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
            this.Hide();
        }

        private void btnSignupU_Click(object sender, EventArgs e)
        {
            string username = txtUserNameD.Text;
            string password = txtPasswordD.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM  SignUp WHERE UserName = '" + username + "' and Password = '"+password+"' ";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfuly");
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
                
            }
            catch (Exception ed)
            {
                MessageBox.Show("done" + ed);
            }
        }
    }
}
