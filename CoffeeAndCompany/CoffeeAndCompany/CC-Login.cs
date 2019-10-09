using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeAndCompany
{
    public partial class frmlogin : Form
    {
        public static string callusername="";
        public static string callposition = "";
        public frmlogin()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=tanki_online123;database=cc");
        connection conn = new connection();

        private void btnsignin_MouseHover_1(object sender, EventArgs e)
        {
            btnsignin.ForeColor = Color.White;
            btnsignin.FlatAppearance.BorderColor = Color.Teal;
        }

        private void btnsignin_MouseLeave(object sender, EventArgs e)
        {
            btnsignin.ForeColor = Color.Black;
            btnsignin.FlatAppearance.BorderColor = Color.Black;
        }

        private void cbshowpassword_CheckedChanged(object sender)
        {
            if (cbshowpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void lblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = txtusername.Text;

            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM user WHERE email='" + txtusername.Text + "'");

                while (sdr.Read())
                {
                    if (user == sdr["email"].ToString())
                    {
                        string position = sdr["position"].ToString();
                        frmresetpass obj = new frmresetpass();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials... Please try Again with valid credentials", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;

            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM user WHERE email='"+txtusername.Text+"' AND password='"+txtpassword.Text+"'");

                while(sdr.Read())
                {
                    if (user == sdr["email"].ToString() && pass == sdr["password"].ToString())
                    {
                        string position = sdr["position"].ToString();
                        callposition = position;
                        callusername = user;
                        frmdashboard obj = new frmdashboard();
                        obj.Show();
                        this.Hide();
                    }
                    MessageBox.Show("Invalid credentials... Please try Again with valid credentials", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            callusername = txtusername.Text;
        }
    }
}
