namespace CoffeeAndCompany
{
    partial class CC_changepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CC_changepassword));
            iTalk.ControlRenderer controlRenderer4 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable4 = new iTalk.MSColorTable();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTalk_MenuStrip1 = new iTalk.iTalk_MenuStrip();
            this.btnresetpass = new MonoFlat.MonoFlat_Button();
            this.txtconpass = new MonoFlat.MonoFlat_TextBox();
            this.txtpassword = new MonoFlat.MonoFlat_TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.iTalk_MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.quitToolStripMenuItem.Text = "Back";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // iTalk_MenuStrip1
            // 
            this.iTalk_MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.iTalk_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_MenuStrip1.Name = "iTalk_MenuStrip1";
            controlRenderer4.ColorTable = msColorTable4;
            controlRenderer4.RoundedEdges = true;
            this.iTalk_MenuStrip1.Renderer = controlRenderer4;
            this.iTalk_MenuStrip1.Size = new System.Drawing.Size(416, 29);
            this.iTalk_MenuStrip1.TabIndex = 14;
            this.iTalk_MenuStrip1.Text = "iTalk_MenuStrip1";
            // 
            // btnresetpass
            // 
            this.btnresetpass.BackColor = System.Drawing.Color.Transparent;
            this.btnresetpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnresetpass.Image = null;
            this.btnresetpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresetpass.Location = new System.Drawing.Point(135, 134);
            this.btnresetpass.Name = "btnresetpass";
            this.btnresetpass.Size = new System.Drawing.Size(146, 41);
            this.btnresetpass.TabIndex = 13;
            this.btnresetpass.Text = "Reset Password";
            this.btnresetpass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnresetpass.Click += new System.EventHandler(this.btnresetpass_Click);
            // 
            // txtconpass
            // 
            this.txtconpass.BackColor = System.Drawing.Color.Transparent;
            this.txtconpass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtconpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtconpass.Image = ((System.Drawing.Image)(resources.GetObject("txtconpass.Image")));
            this.txtconpass.Location = new System.Drawing.Point(211, 78);
            this.txtconpass.MaxLength = 32767;
            this.txtconpass.Multiline = false;
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.ReadOnly = false;
            this.txtconpass.Size = new System.Drawing.Size(187, 41);
            this.txtconpass.TabIndex = 12;
            this.txtconpass.Text = "Confirm Password";
            this.txtconpass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtconpass.UseSystemPasswordChar = true;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtpassword.Image = ((System.Drawing.Image)(resources.GetObject("txtpassword.Image")));
            this.txtpassword.Location = new System.Drawing.Point(18, 78);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = false;
            this.txtpassword.Size = new System.Drawing.Size(187, 41);
            this.txtpassword.TabIndex = 11;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(12, 42);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(392, 24);
            this.lblusername.TabIndex = 10;
            this.lblusername.Text = "Username";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CC_changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 181);
            this.Controls.Add(this.iTalk_MenuStrip1);
            this.Controls.Add(this.btnresetpass);
            this.Controls.Add(this.txtconpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblusername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CC_changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC - Change Password";
            this.Load += new System.EventHandler(this.CC_changepassword_Load);
            this.iTalk_MenuStrip1.ResumeLayout(false);
            this.iTalk_MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private iTalk.iTalk_MenuStrip iTalk_MenuStrip1;
        private MonoFlat.MonoFlat_Button btnresetpass;
        private MonoFlat.MonoFlat_TextBox txtconpass;
        private MonoFlat.MonoFlat_TextBox txtpassword;
        private System.Windows.Forms.Label lblusername;
    }
}