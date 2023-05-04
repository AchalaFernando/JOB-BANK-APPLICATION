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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Check_Vacancy CV = new Check_Vacancy();
            CV.Show();
            this.Show();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MyProfile M = new MyProfile();
            M.Show();
            this.Hide();
        }
    }
}
