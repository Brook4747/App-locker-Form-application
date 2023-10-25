
namespace App_locker_Form_application
{
    partial class Registerer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerer));
            this.label1 = new System.Windows.Forms.Label();
            this.full = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_full = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.Label();
            this.button_contact = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IPS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registerer Information";
            // 
            // full
            // 
            this.full.AutoSize = true;
            this.full.Location = new System.Drawing.Point(91, 98);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(63, 17);
            this.full.TabIndex = 1;
            this.full.Text = "Full name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(91, 144);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(39, 17);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(91, 190);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(96, 17);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone Number";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(91, 236);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(67, 17);
            this.user.TabIndex = 4;
            this.user.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(91, 282);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(64, 17);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // txt_full
            // 
            this.txt_full.Location = new System.Drawing.Point(91, 118);
            this.txt_full.Name = "txt_full";
            this.txt_full.Size = new System.Drawing.Size(234, 23);
            this.txt_full.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(91, 164);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(234, 23);
            this.txt_email.TabIndex = 7;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(91, 210);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(234, 23);
            this.txt_phone.TabIndex = 8;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(91, 256);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(234, 23);
            this.txt_user.TabIndex = 9;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(91, 302);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(234, 23);
            this.txt_password.TabIndex = 10;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(357, 367);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(85, 35);
            this.button_next.TabIndex = 13;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(357, 401);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(85, 35);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(91, 328);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(70, 17);
            this.IP.TabIndex = 15;
            this.IP.Text = "IP address";
            this.IP.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_contact
            // 
            this.button_contact.Location = new System.Drawing.Point(602, 12);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(80, 35);
            this.button_contact.TabIndex = 17;
            this.button_contact.Text = "Contact";
            this.button_contact.UseVisualStyleBackColor = true;
            this.button_contact.Click += new System.EventHandler(this.button_contact_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(91, 387);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 30);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(515, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(80, 35);
            this.button_home.TabIndex = 19;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // IPS
            // 
            this.IPS.Location = new System.Drawing.Point(91, 348);
            this.IPS.Name = "IPS";
            this.IPS.Size = new System.Drawing.Size(234, 23);
            this.IPS.TabIndex = 22;
            this.IPS.TextChanged += new System.EventHandler(this.IPS_TextChanged);
            // 
            // Registerer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.IPS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_full);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.full);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registerer";
            this.Text = "Registerer";
            this.Load += new System.EventHandler(this.Registerer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label full;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_full;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Button button_contact;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox IPS;
    }
}