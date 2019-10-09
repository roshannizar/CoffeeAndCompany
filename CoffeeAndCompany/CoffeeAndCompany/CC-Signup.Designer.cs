namespace CoffeeAndCompany
{
    partial class frmsignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsignup));
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            this.btnsignup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconpass = new MonoFlat.MonoFlat_TextBox();
            this.txtfullname = new MonoFlat.MonoFlat_TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbstan = new MonoFlat.MonoFlat_RadioButton();
            this.rbadmin = new MonoFlat.MonoFlat_RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontactno = new MonoFlat.MonoFlat_TextBox();
            this.txtpass = new MonoFlat.MonoFlat_TextBox();
            this.txtemail = new MonoFlat.MonoFlat_TextBox();
            this.txtusername = new MonoFlat.MonoFlat_TextBox();
            this.iTalk_MenuStrip1 = new iTalk.iTalk_MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.iTalk_MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsignup
            // 
            this.btnsignup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Location = new System.Drawing.Point(46, 431);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(229, 45);
            this.btnsignup.TabIndex = 5;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            this.btnsignup.MouseLeave += new System.EventHandler(this.btnsignup_MouseLeave);
            this.btnsignup.MouseHover += new System.EventHandler(this.btnsignup_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 494);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 110);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coffee and Company\r\nSignup\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtconpass
            // 
            this.txtconpass.BackColor = System.Drawing.Color.Transparent;
            this.txtconpass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtconpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtconpass.Image = ((System.Drawing.Image)(resources.GetObject("txtconpass.Image")));
            this.txtconpass.Location = new System.Drawing.Point(46, 297);
            this.txtconpass.MaxLength = 32767;
            this.txtconpass.Multiline = false;
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.ReadOnly = false;
            this.txtconpass.Size = new System.Drawing.Size(229, 41);
            this.txtconpass.TabIndex = 3;
            this.txtconpass.Text = "Password";
            this.txtconpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtconpass.UseSystemPasswordChar = true;
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.Color.Transparent;
            this.txtfullname.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtfullname.Image = ((System.Drawing.Image)(resources.GetObject("txtfullname.Image")));
            this.txtfullname.Location = new System.Drawing.Point(44, 19);
            this.txtfullname.MaxLength = 32767;
            this.txtfullname.Multiline = false;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.ReadOnly = false;
            this.txtfullname.Size = new System.Drawing.Size(229, 41);
            this.txtfullname.TabIndex = 2;
            this.txtfullname.Text = "Full Name";
            this.txtfullname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfullname.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbstan);
            this.panel1.Controls.Add(this.rbadmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcontactno);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.btnsignup);
            this.panel1.Controls.Add(this.txtconpass);
            this.panel1.Controls.Add(this.txtfullname);
            this.panel1.Location = new System.Drawing.Point(763, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 494);
            this.panel1.TabIndex = 2;
            // 
            // rbstan
            // 
            this.rbstan.Checked = false;
            this.rbstan.Location = new System.Drawing.Point(142, 394);
            this.rbstan.Name = "rbstan";
            this.rbstan.Size = new System.Drawing.Size(77, 17);
            this.rbstan.TabIndex = 15;
            this.rbstan.Text = "Standard";
            // 
            // rbadmin
            // 
            this.rbadmin.Checked = false;
            this.rbadmin.Location = new System.Drawing.Point(142, 371);
            this.rbadmin.Name = "rbadmin";
            this.rbadmin.Size = new System.Drawing.Size(98, 17);
            this.rbadmin.TabIndex = 14;
            this.rbadmin.Text = "Administrator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account Type";
            // 
            // txtcontactno
            // 
            this.txtcontactno.BackColor = System.Drawing.Color.Transparent;
            this.txtcontactno.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtcontactno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtcontactno.Image = ((System.Drawing.Image)(resources.GetObject("txtcontactno.Image")));
            this.txtcontactno.Location = new System.Drawing.Point(47, 184);
            this.txtcontactno.MaxLength = 32767;
            this.txtcontactno.Multiline = false;
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.ReadOnly = false;
            this.txtcontactno.Size = new System.Drawing.Size(229, 41);
            this.txtcontactno.TabIndex = 12;
            this.txtcontactno.Text = "Contact No";
            this.txtcontactno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontactno.UseSystemPasswordChar = false;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Transparent;
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtpass.Image = ((System.Drawing.Image)(resources.GetObject("txtpass.Image")));
            this.txtpass.Location = new System.Drawing.Point(47, 239);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = false;
            this.txtpass.Size = new System.Drawing.Size(229, 41);
            this.txtpass.TabIndex = 11;
            this.txtpass.Text = "Password";
            this.txtpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtemail.Image = ((System.Drawing.Image)(resources.GetObject("txtemail.Image")));
            this.txtemail.Location = new System.Drawing.Point(44, 129);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = false;
            this.txtemail.Size = new System.Drawing.Size(229, 41);
            this.txtemail.TabIndex = 9;
            this.txtemail.Text = "Email";
            this.txtemail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtusername.Image = ((System.Drawing.Image)(resources.GetObject("txtusername.Image")));
            this.txtusername.Location = new System.Drawing.Point(44, 74);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = false;
            this.txtusername.Size = new System.Drawing.Size(229, 41);
            this.txtusername.TabIndex = 8;
            this.txtusername.Text = "Username";
            this.txtusername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // iTalk_MenuStrip1
            // 
            this.iTalk_MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.iTalk_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_MenuStrip1.Name = "iTalk_MenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_MenuStrip1.Renderer = controlRenderer1;
            this.iTalk_MenuStrip1.Size = new System.Drawing.Size(1096, 29);
            this.iTalk_MenuStrip1.TabIndex = 4;
            this.iTalk_MenuStrip1.Text = "iTalk_MenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.homeToolStripMenuItem.Text = "New";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.quitToolStripMenuItem.Text = "Home";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem1.Image")));
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // frmsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iTalk_MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.iTalk_MenuStrip1;
            this.Name = "frmsignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC - Signup";
            this.Load += new System.EventHandler(this.frmsignup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.iTalk_MenuStrip1.ResumeLayout(false);
            this.iTalk_MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private MonoFlat.MonoFlat_TextBox txtconpass;
        private MonoFlat.MonoFlat_TextBox txtfullname;
        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_TextBox txtpass;
        private MonoFlat.MonoFlat_TextBox txtemail;
        private MonoFlat.MonoFlat_TextBox txtusername;
        private iTalk.iTalk_MenuStrip iTalk_MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private MonoFlat.MonoFlat_RadioButton rbstan;
        private MonoFlat.MonoFlat_RadioButton rbadmin;
        private System.Windows.Forms.Label label1;
        private MonoFlat.MonoFlat_TextBox txtcontactno;
    }
}