using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SQLite;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using OpenPop.Pop3.Exceptions;
using OpenPop.Common.Logging;
using Message = OpenPop.Mime.Message;


namespace WindowsFormsApplication1
{
    public partial class FormInbox : Form
    {
        int selectedMail = 0;

        public static FormInbox staticVar = null;
        private Pop3Client pop3client;
        private Dictionary<int, Message> messages;
        public FormInbox()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            listMails();
            pop3client = new Pop3Client();
            messages = new Dictionary<int,Message>();
        }

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            ReceiveMails();
        }

        private void ReceiveMails()
        {
            try
            {
                if (pop3client.Connected)
                    pop3client.Disconnect();
                pop3client.Connect("pop.gmail.com", 995, true);
                pop3client.Authenticate("mandkage92@gmail.com", "N53SN53S");
                int count = pop3client.GetMessageCount();
                messages.Clear();
                int success = 0;
                int fail = 0;
                //progressBarMail.Visible = true;
                //labelProgress.Visible = true;
                for (int i = count; i >= 1; i -= 1)
                {
                    try
                    {
                        Application.DoEvents();
                        string body;
                        Message message = pop3client.GetMessage(i);
                        MessagePart plainTextPart = message.FindFirstPlainTextVersion();

                        MessageHeader headers = pop3client.GetMessageHeaders(i);
                        RfcMailAddress from = headers.From;
                        string subject = headers.Subject;
                        DateTime Time = headers.DateSent.AddHours(2);
                        string messageID = headers.MessageId;

                        //MessageBox.Show(messageID);
                        if (plainTextPart != null)
                        {
                            body = plainTextPart.GetBodyAsText();
                            
                            //string testString = "#etst#<FindThis>12345";
                            //Regex objFindEmailPattern = new Regex("(?<=<)(.*?)(?=>)");
                            //return !objFindEmailPattern.IsMatch(testString);
                            //MessageBox.Show();
                            MessageBox.Show(messageID);
                            InsertMails(from.ToString(), subject.ToString(), body.ToString(), Time.ToString(), messageID);
                        }
                        else
                        {
                            List<MessagePart> textVersions = message.FindAllTextVersions();
                            if (textVersions.Count >= 1)
                                body = textVersions[0].GetBodyAsText();
                            else
                                body = "<<OpenPop>> error <<OpenPop>>";
                        }
                        List<MessagePart> attachments = message.FindAllAttachments();
                        foreach (MessagePart attachment in attachments)
                        { }
                        messages.Add(i, message);
                        success++;

                        // Print progres, and update progressbar
                        int progressPercentage = Convert.ToInt32(((success+fail)*100)/count);
                        //progressBarMail.Value = progressPercentage;
                        //labelProgress.Text = "Downloaded: " + success.ToString() + " of " + count.ToString() + " (" + progressPercentage.ToString() + "%)";
                        //MessageBox.Show("456");
                        backgroundWorker1.ReportProgress(progressPercentage);
                    }
                    catch (Exception e)
                    {
                        fail++;
                    }
                }
                //progressBarMail.Visible = false;
                //labelProgress.Text = count.ToString() + " new messages ( " + fail.ToString() + " errors )";
                //listMails();
            }

            catch (InvalidLoginException)
            {
            }
            catch (PopServerNotFoundException)
            {
            }
            catch (PopServerLockedException)
            { }
            catch (LoginDelayException)
            { }
            catch (Exception e)
            { }
            finally
            { }
        }

        private void GetMails()
        {
            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", TimeReceived \"TimeReceived\"";
                query += "from Mails;";
                Mails = db.GetDataTable(query);

                foreach (DataRow r in Mails.Rows)
                {
                    //MessageBox.Show(r["Sender"].ToString());
                    //MessageBox.Show(r["Subject"].ToString());
                    //MessageBox.Show(r["Body"].ToString());
                    //MessageBox.Show(r["TimeReceived"].ToString());
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }
        }

        private void InsertMails(string newSender, string newSubject, string newBody, string newDatetime, string newMessageID)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Sender", newSender);
            data.Add("Subject", newSubject);
            data.Add("Body", newBody);
            data.Add("Timestamp", newDatetime);
            data.Add("gmailID", newMessageID);
            
            try
            {
                db.Insert("Mails", data);
            }
            catch (Exception e)
            {
                //MessageBox.Show(crap.Message);
                String error = "The following error has occurred:\n\n";
                error += e.Message.ToString() + "\n\n";
                MessageBox.Show(error);
            }
        }

        private void listMails()
        {
            try
            {
                listViewInbox.Items.Clear();
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                
                //String query = "select ID \"ID\", Subject \"Subject\"";
                //query += "from Mails;";

                String query = "select ID \"ID\", Sender \"Sender\", Subject \"Subject\", Timestamp \"Timestamp\"";
                query += "from Mails;";
                //query += "order by Timestamp asc;";

                Mails = db.GetDataTable(query);

                //listViewInbox.Clear();
                foreach (DataRow r in Mails.Rows)
                {
                    ListViewItem newItem = new ListViewItem(r["ID"].ToString());
                    newItem.SubItems.Add(r["Subject"].ToString());
                    newItem.SubItems.Add(r["Sender"].ToString());
                    newItem.SubItems.Add(r["Timestamp"].ToString());
                    listViewInbox.Items.Add(newItem);
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            GetMails();
        }

        private void buttonListMails_Click(object sender, EventArgs e)
        {   // Refresh button
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
            //ReceiveMails();
            listMails();
        }

        private void listViewInbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            string selected = lv.FocusedItem.SubItems[0].Text.ToString();
            listMails();

            getEmailFromID(Convert.ToInt32(selected));
            selectedMail = Convert.ToInt32(selected);
        }

        private void getEmailFromID(int mailID)
        {
            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", Timestamp \"Timestamp\"";
                query += "from Mails ";
                query += "where ID = " + mailID + ";";
                Mails = db.GetDataTable(query);
                
                foreach (DataRow r in Mails.Rows)
                {
                    textBoxFrom.Text = r["Sender"].ToString();
                    textBoxSubject.Text = r["Subject"].ToString();
                    textBoxBody.Text = r["Body"].ToString();
                }
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }
        }

        private void deleteFromDB(int mailID)
        {
            MessageBox.Show("message deleted. ID: " + mailID);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ReceiveMails();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarMail.Visible = true;
            progressBarMail.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listMails();
            progressBarMail.Visible = false;
        }

        private void buttonReply_Click(object sender, EventArgs e)
        {   // Mail - Reply
            staticVar = this;
            //this.Hide();
            Form1 form1 = new Form1(selectedMail, 1);
            form1.Show();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {   // Mail - Forward
            staticVar = this;
            //this.Hide();
            Form1 form1 = new Form1(selectedMail, 2);
            form1.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {   // Mail - Delete
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable Mails;
            String query = "delete from Mails where ID = " + selectedMail + ";";
            Mails = db.GetDataTable(query);
            
            // Delete from the listView...

            listMails();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {   // Menu - New mail
            staticVar = this;
            //this.Hide();
            Form1 form1 = new Form1(selectedMail, 0);
            form1.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {   // Menu - Refresh
            //ReceiveMails();
            if (backgroundWorker1.IsBusy != true)
                backgroundWorker1.RunWorkerAsync();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {   // Menu - Settings
            MessageBox.Show("Settings will be here soon...");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {   // Menu - Quit
            MessageBox.Show("Really want to quit this awesome program?? ok, we will make it soon...");
        }
    }
}
