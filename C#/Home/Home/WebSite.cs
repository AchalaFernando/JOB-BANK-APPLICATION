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
    public partial class WebSite : Form
    {
        public WebSite()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://albhadreen.com/ ");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 Fm = new Form1();
            Fm.Show();
            this.Hide();
        }
    }
}
