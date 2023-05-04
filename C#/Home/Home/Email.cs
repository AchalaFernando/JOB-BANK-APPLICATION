using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;

namespace Home
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTOemail.Text = null;
            txtSubjectEmail.Text = null;
            txtEmailBody.Text = null;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignupU_Click(object sender, EventArgs e)
        {
            string to = txtTOemail.Text; ;
            string subject = txtSubjectEmail.Text; ;
            string body = txtEmailBody.Text; ;
            string Email = "181plymouthsoc@gmail.com";
            string Password = "123456789soc";
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential(Email, Password);
            MailMessage mail = new MailMessage(Email, to, subject, body);
            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Send(mail);
            MessageBox.Show("Email Sent Successfully");
        }

        private void btnBackToAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
