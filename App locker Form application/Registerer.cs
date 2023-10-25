using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Net;

namespace App_locker_Form_application
{
    public partial class Registerer : Form
    {
        public Registerer()
        {
            InitializeComponent();
            DisplayLocalIPaddrerss();
        }

        private void DisplayLocalIPaddrerss()
        {
            try
            {
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
                IPS.Text = localIP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registerer_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void button_contact_Click(object sender, EventArgs e)
        {
            contact C2 = new contact();
            C2.Show();
            Visible = false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if(txt_user.Text=="")
            {
                MessageBox.Show("Enter the username");
            }
            else if(txt_password.Text=="")
            {
                MessageBox.Show("Enter the password");
            }
            else if (txt_phone.Text == "")
            {
                MessageBox.Show("Enter the Phone number");
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Enter the Email");
            }
            else if (txt_full.Text == "")
            {
                MessageBox.Show("Enter the Full name");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-FEMUI2B;Initial Catalog=Registerer;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from tbl_registerer where username = @username and password = @password and email = @email and fullname = @fullname and phone = @phone", con);
                    cmd.Parameters.AddWithValue("@username", txt_user.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@fullname", txt_full.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("registerer successfull");
                        Choose_App C3 = new Choose_App();
                        C3.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Username and Password is invalid");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
           
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_full.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_user.Clear();
            txt_password.Clear();

            txt_full.Focus();
        }

        

        private void IPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void IPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
