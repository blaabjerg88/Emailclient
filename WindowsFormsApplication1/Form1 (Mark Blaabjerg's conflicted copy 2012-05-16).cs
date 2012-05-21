using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Form1 staticVar = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("mandkage92@gmail.com", "N53SN53S");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(textBoxFrom.Text);
            msg.To.Add(new MailAddress(textBoxTo.Text));
            msg.Subject = textBoxSub.Text;
            msg.Body = textBoxBody.Text;
            try
            {
                client.Send(msg);
            }
            catch(Exception ex)
            {
                MessageBox.Show("blabla: " + ex.Message);
            }

            staticVar = this;
            this.Hide();
            FormInbox formInbox = new FormInbox();
            formInbox.Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            textBoxTo.Text = "blaabjerg88@gmail.com";
            textBoxFrom.Text = "mandkage92@gmail.com";
            textBoxSub.Text = "test1";
            textBoxBody.Text = "dette er en test";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            staticVar = this;
            this.Hide();
            FormInbox formInbox = new FormInbox();
            formInbox.Show();
        }

    }
}
