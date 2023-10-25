
namespace App_locker_Form_application
{
    partial class Choose_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_App));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_install = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_contact = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.path = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose An App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose app";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_install
            // 
            this.button_install.Location = new System.Drawing.Point(32, 337);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(75, 30);
            this.button_install.TabIndex = 5;
            this.button_install.Text = "Install";
            this.button_install.UseVisualStyleBackColor = true;
            this.button_install.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(310, 337);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 30);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button_contact
            // 
            this.button_contact.Location = new System.Drawing.Point(601, 12);
            this.button_contact.Name = "button_contact";
            this.button_contact.Size = new System.Drawing.Size(80, 35);
            this.button_contact.TabIndex = 7;
            this.button_contact.Text = "Contact";
            this.button_contact.UseVisualStyleBackColor = true;
            this.button_contact.Click += new System.EventHandler(this.button_contact_Click);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(511, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(80, 35);
            this.button_home.TabIndex = 8;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(135, 337);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 30);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(32, 164);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(195, 23);
            this.path.TabIndex = 14;
            this.path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Choose_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_contact);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choose_App";
            this.Text = "Choose_App";
            this.Load += new System.EventHandler(this.Choose_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_install;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_contact;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox path;
    }
}