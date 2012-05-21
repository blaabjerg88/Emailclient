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
        public Form1(int selectedMail, int action)
        {
            InitializeComponent();


            // Actions:
            // 0 = new mail
            // 1 = reply
            // 2 = forward

            string selectedSender = "unknown";
            string selectedSubject = "unknown";
            string selectedBody = "unknown";
            if (action == 1 || action == 2)
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mail;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", Timestamp \"Timestamp\"";
                query += "from Mails ";
                query += "where ID = " + selectedMail + ";";
                Mail = db.GetDataTable(query);
                foreach (DataRow r in Mail.Rows)
                {
                    selectedSender = r["Sender"].ToString();
                    selectedSubject = r["Subject"].ToString();
                    selectedBody = r["Body"].ToString();
                }
            }

            switch (action)
            {
                case 1: // Reply
                    textBoxTo.Text = selectedSender;
                    textBoxSub.Text = "RE: " + selectedSubject;
                    break;
                case 2: // Forward
                    textBoxTo.Text = "";
                    textBoxSub.Text = "FW: " + selectedSubject;
                    break;
                default:
                    textBoxTo.Text = "";
                    textBoxFrom.Text = "";
                    textBoxSub.Text = "";
                    break;
            }

            //MessageBox.Show(selectedMail.ToString() + " - " + action.ToString());
        }

        /*
        public DataTable getSelectedItem(int thisID)
        {
            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable thisItem;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", Timestamp \"Timestamp\"";
                query += "from Mails ";
                query += "where ID = " + thisID + ";";
                thisItem = db.GetDataTable(query);
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }

            return thisItem;
        }
        */

        private void buttonsend_Click(object sender, EventArgs e)
        {   // send button
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("mandkage92gmail.com", "N53SN53S");
            //client.UseDefaultCredentials = true;
            client.EnableSsl = true;
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
        {   // auto fill button
            textBoxTo.Text = "blaabjerg88@gmail.com";
            textBoxFrom.Text = "mandkage92@gmail.com";
            textBoxSub.Text = "test1999";
            textBoxBody.Text = "dette er en test";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {   // cancel button
            /*
            staticVar = this;
            this.Hide();
            FormInbox formInbox = new FormInbox();
            formInbox.Show();
             */
            this.Close();
        }

    }
}
