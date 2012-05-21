namespace WindowsFormsApplication1
{
    partial class FormInbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.listViewInbox = new System.Windows.Forms.ListView();
            this.inboxID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListMails = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(445, 157);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(704, 413);
            this.textBoxBody.TabIndex = 0;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(155, 12);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(68, 27);
            this.buttonReceive.TabIndex = 1;
            this.buttonReceive.Text = "Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(155, 40);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(68, 28);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // listViewInbox
            // 
            this.listViewInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inboxID,
            this.inboxSubject});
            this.listViewInbox.Location = new System.Drawing.Point(9, 72);
            this.listViewInbox.Margin = new System.Windows.Forms.Padding(2);
            this.listViewInbox.MultiSelect = false;
            this.listViewInbox.Name = "listViewInbox";
            this.listViewInbox.Size = new System.Drawing.Size(431, 499);
            this.listViewInbox.TabIndex = 4;
            this.listViewInbox.UseCompatibleStateImageBehavior = false;
            this.listViewInbox.View = System.Windows.Forms.View.Details;
            this.listViewInbox.SelectedIndexChanged += new System.EventHandler(this.listViewInbox_SelectedIndexChanged);
            // 
            // inboxID
            // 
            this.inboxID.Text = "ID";
            this.inboxID.Width = 0;
            // 
            // inboxSubject
            // 
            this.inboxSubject.Text = "Subject";
            this.inboxSubject.Width = 90;
            // 
            // buttonListMails
            // 
            this.buttonListMails.Location = new System.Drawing.Point(80, 11);
            this.buttonListMails.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListMails.Name = "buttonListMails";
            this.buttonListMails.Size = new System.Drawing.Size(70, 57);
            this.buttonListMails.TabIndex = 5;
            this.buttonListMails.Text = "List mails";
            this.buttonListMails.UseVisualStyleBackColor = true;
            this.buttonListMails.Click += new System.EventHandler(this.buttonListMails_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(9, 11);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(67, 57);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "New";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(955, 49);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 19);
            this.progressBar1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 80);
            this.textBox1.TabIndex = 8;
            // 
            // FormInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 582);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonListMails);
            this.Controls.Add(this.listViewInbox);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.textBoxBody);
            this.Name = "FormInbox";
            this.Text = "FormInbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ListView listViewInbox;
        private System.Windows.Forms.Button buttonListMails;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader inboxID;
        private System.Windows.Forms.ColumnHeader inboxSubject;
    }
}