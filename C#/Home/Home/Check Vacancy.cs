using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Check_Vacancy : Form
    {
        public Check_Vacancy()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplyJobH1_Click(object sender, EventArgs e)
        {
            Hotel H = new Hotel();
            H.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Information_Technology IT = new Information_Technology();
            IT.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Hospital H = new Hospital();
            H.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Office_Staff O = new Office_Staff();
            O.Show();
            this.Hide();

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            MyProfile M = new MyProfile();
            M.Show();
            this.Hide();
        }

        private void btnBackToMyprofile_Click(object sender, EventArgs e)
        {
            MyProfile myP = new MyProfile();
            myP.Show();
            this.Hide();
        }
    }
}
