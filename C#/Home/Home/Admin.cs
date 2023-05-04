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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM SignUp";

            SqlDataAdapter da = new SqlDataAdapter(qry,conString);
            DataSet ds = new DataSet();

            da.Fill(ds, "SignUp");
            dgViewUserInfo.DataSource = ds.Tables["SignUp"];
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            string uname = txtUserNameD.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM SignUp WHERE UserName = '"+uname+"'";
            SqlCommand cmd = new SqlCommand(qry, con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User details deleted successfuly ! ");

            txtUserNameD.Text = null;
        }

        private void btnApplicantInfo_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT FullName , Age FROM Applications";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, conString);
            DataSet DS = new DataSet();

            adapter.Fill(DS, "Applications");
            dgViewApplicantInfo.DataSource = DS.Tables["Applications"];
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string uname = txtUserNameD.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM Applications WHERE UserName = '" + uname + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Applicant data deleted successfuly ! ");

            txtUserNameD.Text = null;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            mail.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DisplayApplicationDetails dis = new DisplayApplicationDetails();
            dis.Show();
            this.Hide();
        }
    }
}
