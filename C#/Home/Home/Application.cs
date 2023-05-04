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
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox13_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox15_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Check_Vacancy V = new Check_Vacancy();
            V.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MyProfile M = new MyProfile();
            M.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            string fname = txtFname.Text;
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            string dob = txtDOB.Text;
            string email = txtEmail.Text;
            string religion = txtReligion.Text;
            string gender;

            if(rbMale.Checked)
            {
                 gender = "Male";
            }
            else
            {
                 gender = "Female";
            }
                
           
            int passportNo = int.Parse(txtPassportNo.Text);
            int nicNo = int.Parse(txtNicNo.Text);
            string eduQ = txtEduQuali.Text;
            string proQ = txtProfQuali.Text;
            string proExp = txtProfExp.Text;
            string medStatus = txtMedStatus.Text;
            string date = txtDate.Text;
            string selectedVacancy = txtSelectedVacancy.Text;





            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30");



            try
            {

                
                    string qry = "INSERT INTO Applications VALUES('" + fname + "' , '" + age + "' , '" + address + "' , '" + dob + "' , '" + email + "' , '" + religion + "' , '" + gender + "' , '" + passportNo + "' , '" + nicNo + "' , '" + eduQ + "' , '" + proQ + "' , '" + proExp + "' , '" + medStatus + "' , '" + date + "' , '" + selectedVacancy + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfuly");

                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
    
}
