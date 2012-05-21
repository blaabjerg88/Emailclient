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
            this.listViewInbox = new System.Windows.Forms.ListView();
            this.inboxID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarMail = new System.Windows.Forms.ProgressBar();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReply = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBody
            // 
            this.textBoxBody.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBody.Location = new System.Drawing.Point(593, 97);
            this.textBoxBody.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ReadOnly = true;
            this.textBoxBody.Size = new System.Drawing.Size(937, 603);
            this.textBoxBody.TabIndex = 0;
            // 
            // listViewInbox
            // 
            this.listViewInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inboxID,
            this.inboxSubject,
            this.inboxSender,
            this.inboxTime});
            this.listViewInbox.FullRowSelect = true;
            this.listViewInbox.Location = new System.Drawing.Point(12, 41);
            this.listViewInbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewInbox.MultiSelect = false;
            this.listViewInbox.Name = "listViewInbox";
            this.listViewInbox.Size = new System.Drawing.Size(573, 661);
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
            this.inboxSubject.Width = 250;
            // 
            // inboxSender
            // 
            this.inboxSender.Text = "Sender";
            this.inboxSender.Width = 180;
            // 
            // inboxTime
            // 
            this.inboxTime.Text = "Received";
            this.inboxTime.Width = 138;
            // 
            // progressBarMail
            // 
            this.progressBarMail.Location = new System.Drawing.Point(1272, 5);
            this.progressBarMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarMail.Name = "progressBarMail";
            this.progressBarMail.Size = new System.Drawing.Size(259, 23);
            this.progressBarMail.TabIndex = 7;
            this.progressBarMail.Visible = false;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFrom.Location = new System.Drawing.Point(664, 41);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(639, 22);
            this.textBoxFrom.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(982, 11);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(77, 17);
            this.labelProgress.TabIndex = 9;
            this.labelProgress.Text = "Updating...";
            this.labelProgress.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSubject.Location = new System.Drawing.Point(664, 67);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ReadOnly = true;
            this.textBoxSubject.Size = new System.Drawing.Size(639, 22);
            this.textBoxSubject.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subject:";
            // 
            // buttonReply
            // 
            this.buttonReply.Location = new System.Drawing.Point(1310, 41);
            this.buttonReply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(68, 48);
            this.buttonReply.TabIndex = 13;
            this.buttonReply.Text = "Reply";
            this.buttonReply.UseVisualStyleBackColor = true;
            this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(1386, 41);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(4);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(68, 48);
            this.buttonForward.TabIndex = 14;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1462, 41);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 48);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1548, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.settingsToolStripMenuItem.Text = "Refresh";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // FormInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1548, 716);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonReply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.progressBarMail);
            this.Controls.Add(this.listViewInbox);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInbox";
            this.Text = "FormInbox";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.ListView listViewInbox;
        private System.Windows.Forms.ProgressBar progressBarMail;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.ColumnHeader inboxID;
        private System.Windows.Forms.ColumnHeader inboxSubject;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ColumnHeader inboxSender;
        private System.Windows.Forms.ColumnHeader inboxTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReply;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}