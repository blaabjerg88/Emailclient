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
        public static FormInbox staticVar = null;
        private Pop3Client pop3client;
        private Dictionary<int, Message> messages;
        public FormInbox()
        {
            InitializeComponent();
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
                        
                        if (plainTextPart != null)
                        {
                            body = plainTextPart.GetBodyAsText();
                            //textBoxBody.Text = "From: " + from + "\n";
                            //textBoxBody.Text += "Subject: " + subject + "\n"; 
                            //textBoxBody.Text += body;
                            //InsertMails(from.ToString(), subject.ToString(), body.ToString());

                            //string testString = "#etst#<FindThis>12345";
                            //Regex objFindEmailPattern = new Regex("(?<=<)(.*?)(?=>)");
                            //return !objFindEmailPattern.IsMatch(testString);
                            //MessageBox.Show();
                            
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
                    }
                    catch (Exception e)
                    {
                        fail++;
                    }
                }
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
                textBoxBody.Text = "test";
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", TimeReceived \"TimeReceived\"";
                query += "from Mails;";
                Mails = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //recipeDataGrid.DataSource = recipe;
                //textBoxBody.Text = recipe.ToString();
                
                // Or looped through for some other reason
                foreach (DataRow r in Mails.Rows)
                {
                    MessageBox.Show(r["Sender"].ToString());
                    MessageBox.Show(r["Subject"].ToString());
                    MessageBox.Show(r["Body"].ToString());
                    MessageBox.Show(r["TimeReceived"].ToString());
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

        private void InsertMails(string newSender, string newSubject, string newBody)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Sender", newSender);
            data.Add("Subject", newSubject);
            data.Add("Body", newBody);
            //data.Add("Timestamp", cookingTimeTextBox.Text);
            //data.Add("COOKING_DIRECTIONS", "Placeholder");
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
            // Function to list all mails from our database...

            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                
                String query = "select ID \"ID\", Subject \"Subject\"";
                query += "from Mails;";
                
                //String query = "select Sender \"Sender\", Subject \"Subject\",";
                //query += "Body \"Body\", TimeReceived \"TimeReceived\"";
                //query += "from Mails;";

                Mails = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //recipeDataGrid.DataSource = recipe;
                //textBoxBody.Text = recipe.ToString();

                // Or looped through for some other reason
 
                //listViewInbox.Width = 270;
                //listViewInbox.Location = new System.Drawing.Point(10, 10);

                // Declare and construct the ColumnHeader objects.
                ColumnHeader header1, header2;
                header1 = new ColumnHeader();
                header2 = new ColumnHeader();

                // Set the text, alignment and width for each column header.
                header1.Text = "File name";
                header1.TextAlign = HorizontalAlignment.Left;
                header1.Width = 10;

                header2.TextAlign = HorizontalAlignment.Left;
                header2.Text = "Location";
                header2.Width = 20;

                // Add the headers to the ListView control.
                listViewInbox.Columns.Add(header1);
                listViewInbox.Columns.Add(header2);

                listViewInbox.View = View.Details;

                int test = (3 + 0) / 6 * 100;
                MessageBox.Show(test.ToString());

                
        foreach (DataRow r in Mails.Rows)
                {
                    /** /
                    ListViewItem newItem = new ListViewItem();
                    newItem.SubItems.Add(r["ID"].ToString());
                    newItem.SubItems.Add(r["Subject"].ToString());
                    listViewInbox.Items.Add(newItem);
                    /**/
                    //////////

                    ListViewItem newItem = new ListViewItem(r["Subject"].ToString());
                    newItem.SubItems.Add(r["ID"].ToString());
                    
                    listViewInbox.Items.Add(newItem);
                    
                    /**/
                    //MessageBox.Show(r["ID"].ToString());

                    //listViewInbox.Items.Add(r["Subject"].ToString() + " - " + r["Sender"].ToString());
                    //listViewInbox.Items.Add(r["ID"].ToString());
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
        {
            listMails();
        }

        private void listViewInbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //getEmailFromID();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            staticVar = this;
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void getEmailFromID(int mailID)
        {
            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable Mails;
                String query = "select Sender \"Sender\", Subject \"Subject\",";
                query += "Body \"Body\", TimeReceived \"TimeReceived\"";
                query += "from Mails;";
                query += "where ID = " + mailID;
                Mails = db.GetDataTable(query);

                foreach (DataRow r in Mails.Rows)
                {
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
    }
}
