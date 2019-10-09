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
    public partial class frmdelivery : Form
    {
        public frmdelivery()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=tanki_online123;database=cc");
        connection conn = new connection();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to UPDATE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("UPDATE delivery SET driverid='" + cbdriverid.Text + "',date='" + dtpdate.Value + "' WHERE deliveryid='" + txtdeliverid.Text + "'");
                    MessageBox.Show("Query successfully updated...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblstatus.Text = "Updated...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while updating!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblstatus.Text = "Error...";
                }
                finally
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM delivery", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                e.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to DELETE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("DELETE FROM delivery WHERE deliveryid='" + txtdeliverid.Text + "'");
                    MessageBox.Show("Query successfully deleted...", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblstatus.Text = "Deleted...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while deleting!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text = "Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM delivery", con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                e.ToString();
            }
        }

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

        private void btnadd_MouseHover(object sender, EventArgs e)
        {
            btnadd.ForeColor = Color.Teal;
            btnadd.FlatAppearance.BorderColor = Color.Teal;
        }

        private void btnadd_MouseLeave(object sender, EventArgs e)
        {
            btnadd.ForeColor = Color.Black;
            btnadd.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnupdate_MouseHover(object sender, EventArgs e)
        {
            btnupdate.ForeColor = Color.Teal;
            btnupdate.FlatAppearance.BorderColor = Color.Teal;
        }

        private void btnupdate_MouseLeave(object sender, EventArgs e)
        {
            btnupdate.ForeColor = Color.Black;
            btnupdate.FlatAppearance.BorderColor = Color.Black;
        }

        private void btndelete_MouseHover(object sender, EventArgs e)
        {
            btndelete.ForeColor = Color.Teal;
            btndelete.FlatAppearance.BorderColor = Color.Teal;
        }

        private void btndelete_MouseLeave(object sender, EventArgs e)
        {
            btndelete.ForeColor = Color.Black;
            btndelete.FlatAppearance.BorderColor = Color.Black;
        }

        private void frmdelivery_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM delivery", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                deliveryDataGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                e.ToString();
            }

            try
            {
                MySqlDataReader sdr = conn.viewData("SELECT * FROM driver");

                while (sdr.Read())
                {
                    cbdriverid.Items.Add(sdr["driverid"].ToString());
                }
            }
            catch (Exception ex)
            {
                e.ToString();
            }
        }

        private void cbdriverid_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader sdr = conn.viewData("SELECT * FROM driver WHERE driverid=" + cbdriverid.SelectedItem.ToString());

            while (sdr.Read())
            {
                txtdrivername.Text = sdr["drivername"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.queryExecute("INSERT INTO delivery VALUES('" + txtdeliverid.Text + "','" + cbdriverid.Text + "','" + lbldate.Text + "')");
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
                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM delivery", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                deliveryDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (frmdashboard.sendPosition == "Administrator")
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
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbbasedon.SelectedItem.ToString() == "Delivery ID" || cbbasedon.SelectedItem.ToString()=="")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM delivery WHERE deliveryid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not  found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Driver ID")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM delivery WHERE driverid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not  found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Date")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM delivery WHERE date like '%" + dtpdatesearch + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    deliveryDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not  found..." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {
            string month = dtpdate.Value.Month.ToString();
            string day = dtpdate.Value.Day.ToString();
            string year = dtpdate.Value.Year.ToString();
            lbldate.Text = year+"-"+month + "-" + day;
        }
    }
}
