using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeAndCompany
{
    public partial class frmintro : Form
    {
        public frmintro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playUI_ProgressBar1.Increment(1);
            timer1.Start();

            if (playUI_ProgressBar1.Value == 20)
            {
                label2.Text = "Loading databases...";
            }
            if (playUI_ProgressBar1.Value == 40)
            {
                label2.Text = "Checking your server Connections...";
            }
            if (playUI_ProgressBar1.Value == 60)
            {
                label2.Text = "Ready";
            }

            if (playUI_ProgressBar1.Value == 80)
            {
                frmlogin log = new frmlogin();
                log.Show();
                this.Hide();
            }
            
        }

        private void playUI_ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
