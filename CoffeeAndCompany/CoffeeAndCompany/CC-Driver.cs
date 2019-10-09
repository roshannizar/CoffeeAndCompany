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
    public partial class frmdriver : Form
    {
        public frmdriver()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=tanki_online123;database=cc");
        connection conn = new connection();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to UPDATE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("UPDATE driver SET drivername='" + txtdrivername.Text + "',address='" + txtaddress.Text + "',contactno='" + txtcontactno.Text + "' WHERE driverid='" + txtdriverid + "'");
                    MessageBox.Show("Query successfully updated...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblstatus.Text = "Updated...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while updating!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text = "Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM driver", con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                e.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.queryExecute("INSERT INTO driver VALUES('" + txtdriverid.Text + "','" + txtdrivername.Text + "','" + txtaddress.Text + "','" +txtcontactno.Text + "')");
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
                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM driver", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                stockDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to DELETE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("DELETE FROM driver WHERE driverid='" + txtdriverid.Text + "'");
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
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM driver", con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);
                    con.Close();
                }
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

        private void frmdriver_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM driver", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                stockDataGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Lost... Restart your computer or contact Administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void backToDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdelivery obj = new frmdelivery();
            obj.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbbasedon.SelectedItem.ToString() == "Driver ID")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM driver WHERE driverid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..."+ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Driver Name")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM driver WHERE drivername like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM driver WHERE driverid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
