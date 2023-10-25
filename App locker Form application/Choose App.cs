using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;

namespace App_locker_Form_application
{
    public partial class Choose_App : Form
    {
        

        public Choose_App()
        {
            InitializeComponent();
            DisplayLocalIPaddrerss();
        }

        int Disunit = 1;
        int Top = 32;
        int Left = 164;
        int count = 0;

        private void DisplayLocalIPaddrerss()
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileStream fsOut = File.Open(path.Text, FileMode.Open);
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            CryptoStream cs = new CryptoStream(fsOut, tdes.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.WriteLine("Encrypted");
            sw.Flush();
            sw.Close();

            FileStream fsKeyOut = File.Create("Encrypt");

            BinaryWriter bw = new BinaryWriter(fsKeyOut);

            bw.Write(tdes.Key);
            bw.Write(tdes.IV);

            bw.Flush();
            bw.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Registerer r2 = new Registerer();
            r2.Show();
            Visible = false;
        }

        private void Choose_App_Load(object sender, EventArgs e)
        {
           
        }

        private void button_contact_Click(object sender, EventArgs e)
        {
            contact C2 = new contact();
            C2.Show();
            Visible = false;
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            count++;
            for (int i = 0; i < count; i++)
            {
                if (MessageBox.Show("Are you sure add one more App?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    TextBox path = new TextBox();
                    this.Controls.Add(path);
                    path.Location = new System.Drawing.Point(32, 194);
                    path.Name = "path";
                    path.Size = new System.Drawing.Size(195, 23);
                    path.TabIndex = 14;
                    path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                    Top += +30;
                    count--;
                }
            }

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                path.Text = od.FileName;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
