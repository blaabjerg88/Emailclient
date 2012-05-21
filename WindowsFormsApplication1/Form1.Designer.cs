namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.buttonsend = new System.Windows.Forms.Button();
            this.textto = new System.Windows.Forms.Label();
            this.textfrom = new System.Windows.Forms.Label();
            this.textsub = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(611, 16);
            this.buttonsend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(100, 47);
            this.buttonsend.TabIndex = 0;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // textto
            // 
            this.textto.AutoSize = true;
            this.textto.Location = new System.Drawing.Point(10, 16);
            this.textto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textto.Name = "textto";
            this.textto.Size = new System.Drawing.Size(29, 17);
            this.textto.TabIndex = 1;
            this.textto.Text = "To:";
            // 
            // textfrom
            // 
            this.textfrom.AutoSize = true;
            this.textfrom.Location = new System.Drawing.Point(10, 46);
            this.textfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textfrom.Name = "textfrom";
            this.textfrom.Size = new System.Drawing.Size(44, 17);
            this.textfrom.TabIndex = 2;
            this.textfrom.Text = "From:";
            // 
            // textsub
            // 
            this.textsub.AutoSize = true;
            this.textsub.Location = new System.Drawing.Point(10, 76);
            this.textsub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textsub.Name = "textsub";
            this.textsub.Size = new System.Drawing.Size(59, 17);
            this.textsub.TabIndex = 3;
            this.textsub.Text = "Subject:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(117, 13);
            this.textBoxTo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(434, 22);
            this.textBoxTo.TabIndex = 5;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(117, 43);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(486, 22);
            this.textBoxFrom.TabIndex = 6;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(117, 73);
            this.textBoxSub.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(486, 22);
            this.textBoxSub.TabIndex = 7;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(13, 103);
            this.textBoxBody.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(698, 421);
            this.textBoxBody.TabIndex = 8;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(559, 13);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(44, 22);
            this.buttonTest.TabIndex = 9;
            this.buttonTest.Text = "auto";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(611, 70);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Cancel";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 537);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSub);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textsub);
            this.Controls.Add(this.textfrom);
            this.Controls.Add(this.textto);
            this.Controls.Add(this.buttonsend);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.Label textto;
        private System.Windows.Forms.Label textfrom;
        private System.Windows.Forms.Label textsub;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonBack;
    }
}

