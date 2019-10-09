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
    public partial class frmstock : Form
    {
        public frmstock()
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to UPDATE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("UPDATE stock SET stockname='" + txtstockname.Text + "',categoryname='" + cbcategoryname.Text + "',description='" + txtdescription.Text + "',quantity='" + txtquantity.Text + "',price='" + txtprice.Text + "' WHERE stockid='" + txtstockid.Text + "'");
                    MessageBox.Show("Query successfully updated...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblstatus.Text = "Updated...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while updating!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text = "Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM stock", con);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to DELETE the query?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("DELETE FROM stock WHERE stockid='" + txtstockid.Text + "'");
                    MessageBox.Show("Query successfully deleted...", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblstatus.Text = "Deleted...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while deleting!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text="Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM stock",con);
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.queryExecute("INSERT INTO stock VALUES('" + txtstockid.Text + "','" + txtstockname.Text + "','" + cbcategoryname.Text + "','" + txtdescription.Text + "','" + txtquantity.Text + "','" + txtprice.Text + "')");
                MessageBox.Show("Query Added Successfully...", "Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblstatus.Text="Added...";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured while adding the query!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblstatus.Text="Error occured...";
            }
            finally
            {
                con.Open();
                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM stock",con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                stockDataGrid.DataSource = dt;
                con.Close();
            }
        }

        private void frmstock_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM stock", con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                stockDataGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Lost... Restart your computer or contact Administrator"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Erase all?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    conn.queryExecute("DELETE FROM stock");
                    MessageBox.Show("All data erased successfully...", "Erased", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblstatus.Text = "Erased...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while deleting!"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblstatus.Text = "Error occured...";
                }
                finally
                {
                    con.Close();

                    con.Open();
                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM stock", con);
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbbasedon.SelectedItem.ToString() == "Stock ID" || cbbasedon.SelectedItem.ToString() == "")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM stock WHERE stockid like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..."+ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Stock Name")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM stock WHERE stockname like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (cbbasedon.SelectedItem.ToString() == "Category Name")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM stock WHERE categoryname like '%" + txtsearch.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    stockDataGrid.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query not found..." + ex, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
