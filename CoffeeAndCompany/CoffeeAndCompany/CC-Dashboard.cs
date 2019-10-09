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
    public partial class frmdashboard : Form
    {
        public static string sendUsername = "";
        public static string sendPosition = "";
        public frmdashboard()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=tanki_online123;database=cc");
        connection conn = new connection();

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlowstock obj = new frmlowstock();
            obj.Show();
            this.Hide();
        }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblposition.Text == "Administrator")
            {
                frmstock obj = new frmstock();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oops Access Denied... Your not an Adminsitrator or a Manager to Access!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblposition.Text == "Administrator")
            {
                frmsignup obj = new frmsignup();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oops Access Denied... Your not an Adminsitrator or a Manager to Access!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkViewDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdelivery obj = new frmdelivery();
            obj.Show();
            this.Hide();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            lblprofileactive.Text = "Active Profile: "+" "+frmlogin.callusername;
            lblposition.Text = frmlogin.callposition;
            sendUsername = frmlogin.callusername;
            sendPosition = lblposition.Text;
            int total = 0;
            float totalstock = 0;
            float totalsales = 0;
            int totaldeliver = 0;

            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM user");

                while (sdr.Read())
                {
                    total = total + 1;
                    lbltotaluser.Text =total.ToString();
                }
            }
            catch (Exception)
            {
                e.ToString();
            }
            try
            {

                MySqlDataReader sdr1 = conn.viewData("SELECT * FROM stock");

                while (sdr1.Read())
                {
                    float value = float.Parse(sdr1["price"].ToString());
                    totalstock = totalstock + value;
                    lblstock.Text = "Rs:" + " " + totalstock.ToString();
                }
            }
            catch(Exception ex)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr2 = conn.viewData("SELECT * FROM sales");

                while (sdr2.Read())
                {
                    float value1 = float.Parse(sdr2["amount"].ToString());
                    totalsales = totalsales + value1;
                    lblsales.Text = "Rs:" + " " + totalsales.ToString();
                }
            }
            catch(Exception)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr3 = conn.viewData("SELECT * FROM delivery");

                while (sdr3.Read())
                {
                    totaldeliver = totaldeliver + 1;
                    lbldeliver.Text = totaldeliver.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You lost your server connection!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin obj = new frmlogin();
            obj.Show();
            this.Hide();
        }

        private void addSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsales obj = new frmsales();
            obj.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcustomer obj = new frmcustomer();
            obj.Show();
            this.Hide();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblposition.Text == "Administrator")
            {
                frmdriver obj = new frmdriver();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oops Access Denied... Your not an Adminsitrator or a Manager to Access!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmresetpass obj = new frmresetpass();
             obj.Show();
             this.Hide();
        }
    }
}
