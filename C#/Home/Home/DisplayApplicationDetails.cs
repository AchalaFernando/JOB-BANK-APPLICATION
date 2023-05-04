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
    public partial class DisplayApplicationDetails : Form
    {
        public DisplayApplicationDetails()
        {
            InitializeComponent();
        }

        private void btnDisplayApplication_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECTfinalDB\PROdb.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM Applications";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, conString);
            DataSet DS = new DataSet();

            adapter.Fill(DS, "Applications");
            dgViewApplicationDisplay.DataSource = DS.Tables["Applications"];
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
