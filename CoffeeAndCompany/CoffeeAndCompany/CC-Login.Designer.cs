namespace CoffeeAndCompany
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblforgotpassword = new System.Windows.Forms.LinkLabel();
            this.btnsignin = new System.Windows.Forms.Button();
            this.cbshowpassword = new MonoFlat.MonoFlat_CheckBox();
            this.txtpassword = new MonoFlat.MonoFlat_TextBox();
            this.txtusername = new MonoFlat.MonoFlat_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblforgotpassword);
            this.panel1.Controls.Add(this.btnsignin);
            this.panel1.Controls.Add(this.cbshowpassword);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(668, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 401);
            this.panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(139, 318);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(103, 45);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Forgot";
            // 
            // lblforgotpassword
            // 
            this.lblforgotpassword.AutoSize = true;
            this.lblforgotpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotpassword.Location = new System.Drawing.Point(167, 385);
            this.lblforgotpassword.Name = "lblforgotpassword";
            this.lblforgotpassword.Size = new System.Drawing.Size(75, 16);
            this.lblforgotpassword.TabIndex = 6;
            this.lblforgotpassword.TabStop = true;
            this.lblforgotpassword.Text = "Password?";
            this.lblforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblforgotpassword_LinkClicked);
            // 
            // btnsignin
            // 
            this.btnsignin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.Location = new System.Drawing.Point(30, 318);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(103, 45);
            this.btnsignin.TabIndex = 5;
            this.btnsignin.Text = "Sign In";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            this.btnsignin.MouseLeave += new System.EventHandler(this.btnsignin_MouseLeave);
            this.btnsignin.MouseHover += new System.EventHandler(this.btnsignin_MouseHover_1);
            // 
            // cbshowpassword
            // 
            this.cbshowpassword.Checked = false;
            this.cbshowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbshowpassword.Location = new System.Drawing.Point(30, 296);
            this.cbshowpassword.Name = "cbshowpassword";
            this.cbshowpassword.Size = new System.Drawing.Size(148, 16);
            this.cbshowpassword.TabIndex = 4;
            this.cbshowpassword.Text = "Show Password";
            this.cbshowpassword.CheckedChanged += new MonoFlat.MonoFlat_CheckBox.CheckedChangedEventHandler(this.cbshowpassword_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtpassword.Image = ((System.Drawing.Image)(resources.GetObject("txtpassword.Image")));
            this.txtpassword.Location = new System.Drawing.Point(30, 242);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = false;
            this.txtpassword.Size = new System.Drawing.Size(210, 41);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtusername.Image = ((System.Drawing.Image)(resources.GetObject("txtusername.Image")));
            this.txtusername.Location = new System.Drawing.Point(30, 192);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = false;
            this.txtusername.Size = new System.Drawing.Size(210, 41);
            this.txtusername.TabIndex = 2;
            this.txtusername.Text = "Username";
            this.txtusername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 401);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coffee and Company";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC - Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblforgotpassword;
        private System.Windows.Forms.Button btnsignin;
        private MonoFlat.MonoFlat_CheckBox cbshowpassword;
        private MonoFlat.MonoFlat_TextBox txtpassword;
        private MonoFlat.MonoFlat_TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexit;
    }
}