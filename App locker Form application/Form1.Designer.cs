
namespace App_locker_Form_application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.button_contact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(57, 36);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(385, 42);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome use App Locker";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(357, 355);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(85, 35);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_contact
            // 
            this.button_contact.Location = new System.Drawing.Point(602, 12);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(80, 35);
            this.button_contact.TabIndex = 11;
            this.button_contact.Text = "Contact";
            this.button_contact.UseVisualStyleBackColor = true;
            this.button_contact.Click += new System.EventHandler(this.button_contact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(57, 180);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(223, 23);
            this.location.TabIndex = 13;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(57, 355);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(85, 35);
            this.browse.TabIndex = 14;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.location);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "App Locker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_contact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

