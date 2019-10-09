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
    public partial class frmresetpass : Form
    {
        public frmresetpass()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=tanki_online123;database=cc");

        private void btnback_Click(object sender, EventArgs e)
        {
            frmlogin obj = new frmlogin();
            obj.Show();
            this.Hide();
        }

        private void frmresetpass_Load(object sender, EventArgs e)
        {
            lblusername.Text = frmlogin.callusername;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin obj = new frmlogin();
            obj.Show();
            this.Hide();
        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("UPDATE user SET password='" + txtpassword.Text + "' WHERE email='" + lblusername.Text + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Your have successfully changed your password...", "Password UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmlogin obj = new frmlogin();
                obj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while Updating the password!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
