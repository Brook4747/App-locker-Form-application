
namespace App_locker_Form_application
{
    partial class contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contact));
            this.label1 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get In touch with us";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(12, 95);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(43, 17);
            this.name1.TabIndex = 1;
            this.name1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // txt_name1
            // 
            this.txt_name1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_name1.Location = new System.Drawing.Point(12, 124);
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(278, 23);
            this.txt_name1.TabIndex = 3;
            // 
            // txt_company
            // 
            this.txt_company.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_company.Location = new System.Drawing.Point(374, 124);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(278, 23);
            this.txt_company.TabIndex = 4;
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Location = new System.Drawing.Point(12, 170);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(39, 17);
            this.email1.TabIndex = 5;
            this.email1.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_email.Location = new System.Drawing.Point(12, 199);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(278, 23);
            this.txt_email.TabIndex = 6;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 248);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(61, 17);
            this.message.TabIndex = 7;
            this.message.Text = "Message";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(640, 115);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(12, 413);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(197, 38);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "Send Message";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(597, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(84, 34);
            this.button_home.TabIndex = 10;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 581);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.txt_name1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "contact";
            this.Text = "contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_home;
    }
}