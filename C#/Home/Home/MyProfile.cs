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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnCheckVacancy_Click(object sender, EventArgs e)
        {
            Check_Vacancy cv = new Check_Vacancy();
            cv.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
            this.Hide();
        }

        private void btnApplicationDetails_Click(object sender, EventArgs e)
        {
            Application app = new Application();
            app.Show();
            this.Hide();
        }

        private void btnProfileInfo_Click(object sender, EventArgs e)
        {
            string Uname = Login.ToMyProfile;
           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");

            string qry = "SELECT UserName , Email FROM SignUp WHERE UserName = '"+Uname+"' ";
            SqlCommand cmd = new SqlCommand(qry,con);

           
            lblUserNameMP.Text = "Username : ";
            lblEmailMP.Text = "Email : ";


            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                lblMyPDisplayUsername.Text = sdr["UserName"].ToString();
                lblMyPDisplayEmail.Text = sdr["Email"].ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Done" + ex);
            }
            
            
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DisplayApplicationDetails dis = new DisplayApplicationDetails();
            dis.Show();
            this.Hide();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
