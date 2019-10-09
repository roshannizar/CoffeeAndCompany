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
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=tanki_online123;database=cc");

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text == "" || txtusername.Text == "" || txtemail.Text == "" || txtcontactno.Text == "" || txtpass.Text == "" || txtconpass.Text == "")
            {
                MessageBox.Show("Please fill all the fields...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtfullname.Text == "First Name" || txtusername.Text == "Username" || txtemail.Text == "Email" || txtcontactno.Text == "Contact No" || txtpass.Text == "Password" || txtconpass.Text == "Password")
                {
                    MessageBox.Show("Invalid Information! Please give valid information to continue the process...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rbadmin.Checked == false && rbstan.Checked == false)
                    {
                        MessageBox.Show("Please choose account type...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtpass.Text == txtconpass.Text)
                        {
                            try
                            {
                                string position;

                                if(rbadmin.Checked==true)
                                {
                                    position="Administrator";
                                }
                                else
                                {
                                    position="Standard";
                                }

                                con.Open();
                                MySqlDataAdapter sda= new MySqlDataAdapter("INSERT INTO user VALUES('"+txtfullname.Text+"','"+txtemail.Text+"','"+txtcontactno.Text+"','"+position+"','"+txtpass.Text+"')",con);
                                sda.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Account created successfully...","Created",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error occured while creating account!"+ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords didn't match...", "Didn't Match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void btnsignup_MouseHover(object sender, EventArgs e)
        {
            btnsignup.ForeColor = Color.White;
            btnsignup.FlatAppearance.BorderColor = Color.White;
        }

        private void btnsignup_MouseLeave(object sender, EventArgs e)
        {
            btnsignup.ForeColor = Color.Black;
            btnsignup.FlatAppearance.BorderColor = Color.Black;
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to QUIT?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.ToString();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdashboard obj = new frmdashboard();
            obj.Show();
            this.Hide();
        }

        private void frmsignup_Load(object sender, EventArgs e)
        {

        }
    }
}
