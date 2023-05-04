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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/maps/place/AL+BHADREEN+(PVT)+LTD/@6.9200038,79.8624133,15z/data=!4m19!1m13!4m12!1m4!2m2!1d79.861243!2d6.9270786!4e1!1m6!1m2!1s0x3ae2599ba2da1c11:0xb371b07a5db00a36!2sALBHADREEN+(PVT)+LTD!2m2!1d79.881635!2d6.9127697!3m4!1s0x3ae2599ba2da1c11:0xb371b07a5db00a36!8m2!3d6.9127697!4d79.881635");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
