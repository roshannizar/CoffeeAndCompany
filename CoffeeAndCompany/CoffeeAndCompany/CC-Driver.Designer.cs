﻿namespace CoffeeAndCompany
{
    partial class frmdriver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdriver));
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdrivername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdriverid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stockDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbasedon = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.iTalk_MenuStrip1 = new iTalk.iTalk_MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGrid)).BeginInit();
            this.iTalk_MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(1191, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 168);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.ImageIndex = 2;
            this.btndelete.ImageList = this.imageList1;
            this.btndelete.Location = new System.Drawing.Point(16, 115);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(118, 42);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.MouseLeave += new System.EventHandler(this.btndelete_MouseLeave);
            this.btndelete.MouseHover += new System.EventHandler(this.btndelete_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Entypo_d83d(2)_1024.png");
            this.imageList1.Images.SetKeyName(1, "Entypo_e717(0)_1024.png");
            this.imageList1.Images.SetKeyName(2, "Entypo_e729(1)_1024.png");
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.ImageIndex = 1;
            this.btnupdate.ImageList = this.imageList1;
            this.btnupdate.Location = new System.Drawing.Point(16, 67);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 42);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            this.btnupdate.MouseLeave += new System.EventHandler(this.btnupdate_MouseLeave);
            this.btnupdate.MouseHover += new System.EventHandler(this.btnupdate_MouseHover);
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.ImageIndex = 0;
            this.btnadd.ImageList = this.imageList1;
            this.btnadd.Location = new System.Drawing.Point(16, 19);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(118, 42);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.MouseLeave += new System.EventHandler(this.btnadd_MouseLeave);
            this.btnadd.MouseHover += new System.EventHandler(this.btnadd_MouseHover);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno.Location = new System.Drawing.Point(121, 628);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(221, 22);
            this.txtcontactno.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Contact No";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(121, 556);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(221, 66);
            this.txtaddress.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address";
            // 
            // txtdrivername
            // 
            this.txtdrivername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdrivername.Location = new System.Drawing.Point(121, 528);
            this.txtdrivername.Name = "txtdrivername";
            this.txtdrivername.Size = new System.Drawing.Size(221, 22);
            this.txtdrivername.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Driver Name";
            // 
            // txtdriverid
            // 
            this.txtdriverid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdriverid.Location = new System.Drawing.Point(121, 500);
            this.txtdriverid.Name = "txtdriverid";
            this.txtdriverid.Size = new System.Drawing.Size(221, 22);
            this.txtdriverid.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Driver ID";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(39, 17);
            this.lblstatus.Text = "Status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stockDataGrid
            // 
            this.stockDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDataGrid.BackgroundColor = System.Drawing.Color.Teal;
            this.stockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGrid.Location = new System.Drawing.Point(12, 68);
            this.stockDataGrid.Name = "stockDataGrid";
            this.stockDataGrid.Size = new System.Drawing.Size(1330, 419);
            this.stockDataGrid.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Driver";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(772, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Based on";
            // 
            // cbbasedon
            // 
            this.cbbasedon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbasedon.FormattingEnabled = true;
            this.cbbasedon.Items.AddRange(new object[] {
            "Driver ID",
            "Driver Name"});
            this.cbbasedon.Location = new System.Drawing.Point(855, 39);
            this.cbbasedon.Name = "cbbasedon";
            this.cbbasedon.Size = new System.Drawing.Size(186, 23);
            this.cbbasedon.TabIndex = 54;
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1267, 36);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 26);
            this.btnsearch.TabIndex = 53;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(1069, 38);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(192, 24);
            this.txtsearch.TabIndex = 52;
            // 
            // iTalk_MenuStrip1
            // 
            this.iTalk_MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.iTalk_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_MenuStrip1.Name = "iTalk_MenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_MenuStrip1.Renderer = controlRenderer1;
            this.iTalk_MenuStrip1.Size = new System.Drawing.Size(1354, 29);
            this.iTalk_MenuStrip1.TabIndex = 15;
            this.iTalk_MenuStrip1.Text = "iTalk_MenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.backToDeliveryToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // backToDeliveryToolStripMenuItem
            // 
            this.backToDeliveryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.backToDeliveryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToDeliveryToolStripMenuItem.Image")));
            this.backToDeliveryToolStripMenuItem.Name = "backToDeliveryToolStripMenuItem";
            this.backToDeliveryToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.backToDeliveryToolStripMenuItem.Text = "Back to Delivery";
            this.backToDeliveryToolStripMenuItem.Click += new System.EventHandler(this.backToDeliveryToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem});
            this.moreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreToolStripMenuItem.Image")));
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resetAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetAllToolStripMenuItem.Image")));
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.resetAllToolStripMenuItem.Text = "Reset all";
            // 
            // frmdriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 696);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbasedon);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdrivername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iTalk_MenuStrip1);
            this.Controls.Add(this.txtdriverid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.stockDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC - Driver";
            this.Load += new System.EventHandler(this.frmdriver_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGrid)).EndInit();
            this.iTalk_MenuStrip1.ResumeLayout(false);
            this.iTalk_MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdrivername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private iTalk.iTalk_MenuStrip iTalk_MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.TextBox txtdriverid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView stockDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbasedon;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ToolStripMenuItem backToDeliveryToolStripMenuItem;
    }
}