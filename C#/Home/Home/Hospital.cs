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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void btnApplyJobH1_Click(object sender, EventArgs e)
        {
            ApplicationForm A = new ApplicationForm();
            A.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ApplicationForm A = new ApplicationForm();
            A.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ApplicationForm A = new ApplicationForm();
            A.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ApplicationForm A = new ApplicationForm();
            A.Show();
            this.Hide();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            MyProfile M = new MyProfile();
            M.Show();
            this.Hide();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

            Check_Vacancy V = new Check_Vacancy();
            V.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Show();
        }
    }
}
