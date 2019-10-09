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
    public partial class frmsales : Form
    {
        public frmsales()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;password=tanki_online123;database=cc");
        connection conn = new connection();

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdashboard obj = new frmdashboard();
            obj.Show();
            this.Hide();
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

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Erase all?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("DELETE FROM delivery");
                    MessageBox.Show("All data erased successfully...", "Erased", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text = "Erased...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while deleting!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblstatus.Text = "Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM delivery", con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
        }



        private void frmsales_Load(object sender, EventArgs e)
        {
            txtsalesperson.Text = frmdashboard.sendUsername;
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM customer");

                while (sdr.Read())
                {
                    cbcustomerid.Items.Add(sdr["customerid"].ToString());
                }
            }
            catch (Exception ex)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr1 = conn.viewData("SELECT * FROM stock");

                while (sdr1.Read())
                {
                    cbstockid.Items.Add(sdr1["stockid"].ToString());
                }
            }
            catch (Exception ex)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr2 = conn.viewData("SELECT * FROM delivery");

                while (sdr2.Read())
                {
                    cbdeliverid.Items.Add(sdr2["deliveryid"].ToString());
                }
            }
            catch (Exception ex)
            {
                e.ToString();
            }
        }

        private void cbcustomerid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM customer WHERE customerid=" + cbcustomerid.SelectedItem.ToString());

                while (sdr.Read())
                {
                    txtcustomername.Text = sdr["customername"].ToString();
                }
            }
            catch (Exception ex)
            {
                e.ToString();
            }
        }

        private void cbstockid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM stock WHERE stockid=" + cbstockid.SelectedItem.ToString());

                while (sdr.Read())
                {
                    txtstockname.Text = sdr["stockname"].ToString();
                    txtstockprice.Text = sdr["price"].ToString();
                    txtstockquan.Text = sdr["quantity"].ToString();
                }
            }
            catch(Exception ex)
            {
                e.ToString();
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quan = int.Parse(txtquantity.Text);
                int stockquan = int.Parse(txtstockquan.Text);
                int total = stockquan - quan;
                txtavaiquan.Text = total.ToString();
            }
            catch (Exception ex)
            {
                e.ToString();
            }
        }

        private void txtsellprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quan = int.Parse(txtquantity.Text);
                float price = float.Parse(txtsellprice.Text);
                float total = quan * price;
                txttotalaomount.Text = total.ToString();
            }
            catch (Exception ex)
            {
                e.ToString();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (frmdashboard.sendPosition == "Administrator")
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

        private void btnnewcus_Click(object sender, EventArgs e)
        {
             frmcustomer obj = new frmcustomer();
             obj.Show();
             this.Hide();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            if (frmdashboard.sendPosition == "Administrator")
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

        private void btndeliver_Click(object sender, EventArgs e)
        {
            frmdelivery obj = new frmdelivery();
            obj.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.queryExecute("INSERT INTO sales VALUES('" + txtsalesid.Text + "','" + txtsalesperson.Text + "','" + cbcustomerid.Text + "','" + cbstockid.Text + "','" + cbdeliverid.Text + "','" + lbldate.Text + "','" + txtquantity.Text + "','" + txtsellprice.Text + "','" + txttotalaomount.Text + "')");
                conn.queryExecute("UPDATE stock SET quantity='" + txtavaiquan.Text + "' WHERE stockid='" + cbstockid.Text + "'");
                MessageBox.Show("Query Added Successfully...", "Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblstatus.Text = "Added...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured while adding the query!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblstatus.Text = "Error occured...";
            }
            finally
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void cbbasedon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbasedon.SelectedItem.ToString() == "Date")
            {
                txtsearch.Visible = false;
                dtpdatesearch.Visible = true;
            }
            else
            {
                txtsearch.Visible = true;
                dtpdatesearch.Visible = false;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbbasedon.SelectedItem.ToString() == "Sales ID" || cbbasedon.SelectedItem.ToString()=="")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE salesid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..."+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Sales Person")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE userid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Customer ID")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE customerid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Stock ID")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE stockid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Delivery ID")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE deliveryid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Date")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM sales WHERE date like '%" + dtpdatesearch.Value + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtavaiquan_TextChanged(object sender, EventArgs e)
        {
            int quan = int.Parse(txtavaiquan.Text);
            if (quan <= 10)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"F:\CC\beep.WAV");
                player.Play();
                txtavaiquan.BackColor = Color.OrangeRed;
            }
            else
            {
                txtavaiquan.BackColor = Color.WhiteSmoke;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {
            string month = dtpdate.Value.Month.ToString();
            string day = dtpdate.Value.Day.ToString();
            string year = dtpdate.Value.Year.ToString();
            lbldate.Text = year + "-" + month + "-" + day;
        }
    }
}
