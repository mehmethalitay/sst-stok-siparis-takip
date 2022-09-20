namespace SST
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderdetailsl = new System.Windows.Forms.Label();
            this.orderdetailsd = new System.Windows.Forms.DataGridView();
            this.activeorderd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stockg = new System.Windows.Forms.GroupBox();
            this.stockt = new System.Windows.Forms.TextBox();
            this.stockd = new System.Windows.Forms.DataGridView();
            this.customerg = new System.Windows.Forms.GroupBox();
            this.customert = new System.Windows.Forms.TextBox();
            this.customerd = new System.Windows.Forms.DataGridView();
            this.cartd = new System.Windows.Forms.DataGridView();
            this.cartl = new System.Windows.Forms.Label();
            this.settingb = new System.Windows.Forms.Button();
            this.caseb = new System.Windows.Forms.Button();
            this.orderb = new System.Windows.Forms.Button();
            this.stockb = new System.Windows.Forms.Button();
            this.customersb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeorderd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.stockg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockd)).BeginInit();
            this.customerg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartd)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "customer.png");
            this.ımageList1.Images.SetKeyName(1, "packages.png");
            this.ımageList1.Images.SetKeyName(2, "order.png");
            this.ımageList1.Images.SetKeyName(3, "safe.png");
            this.ımageList1.Images.SetKeyName(4, "settings.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderdetailsl);
            this.groupBox1.Controls.Add(this.orderdetailsd);
            this.groupBox1.Controls.Add(this.activeorderd);
            this.groupBox1.Location = new System.Drawing.Point(896, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 1017);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Siparişler";
            // 
            // orderdetailsl
            // 
            this.orderdetailsl.AutoSize = true;
            this.orderdetailsl.Location = new System.Drawing.Point(6, 528);
            this.orderdetailsl.Name = "orderdetailsl";
            this.orderdetailsl.Size = new System.Drawing.Size(126, 16);
            this.orderdetailsl.TabIndex = 2;
            this.orderdetailsl.Text = "Sipariş Detayları";
            // 
            // orderdetailsd
            // 
            this.orderdetailsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdetailsd.Location = new System.Drawing.Point(6, 547);
            this.orderdetailsd.Name = "orderdetailsd";
            this.orderdetailsd.Size = new System.Drawing.Size(984, 284);
            this.orderdetailsd.TabIndex = 1;
            // 
            // activeorderd
            // 
            this.activeorderd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeorderd.Location = new System.Drawing.Point(6, 25);
            this.activeorderd.Name = "activeorderd";
            this.activeorderd.Size = new System.Drawing.Size(984, 488);
            this.activeorderd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stockg);
            this.groupBox2.Controls.Add(this.customerg);
            this.groupBox2.Controls.Add(this.cartd);
            this.groupBox2.Controls.Add(this.cartl);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 1017);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş Ekle";
            // 
            // stockg
            // 
            this.stockg.Controls.Add(this.stockt);
            this.stockg.Controls.Add(this.stockd);
            this.stockg.Location = new System.Drawing.Point(6, 222);
            this.stockg.Name = "stockg";
            this.stockg.Size = new System.Drawing.Size(695, 194);
            this.stockg.TabIndex = 11;
            this.stockg.TabStop = false;
            this.stockg.Text = "Stoklar";
            // 
            // stockt
            // 
            this.stockt.Location = new System.Drawing.Point(6, 25);
            this.stockt.Name = "stockt";
            this.stockt.Size = new System.Drawing.Size(683, 26);
            this.stockt.TabIndex = 4;
            // 
            // stockd
            // 
            this.stockd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockd.Location = new System.Drawing.Point(6, 57);
            this.stockd.Name = "stockd";
            this.stockd.Size = new System.Drawing.Size(683, 128);
            this.stockd.TabIndex = 3;
            // 
            // customerg
            // 
            this.customerg.Controls.Add(this.customert);
            this.customerg.Controls.Add(this.customerd);
            this.customerg.Location = new System.Drawing.Point(6, 22);
            this.customerg.Name = "customerg";
            this.customerg.Size = new System.Drawing.Size(695, 194);
            this.customerg.TabIndex = 10;
            this.customerg.TabStop = false;
            this.customerg.Text = "Müşteriler";
            // 
            // customert
            // 
            this.customert.Location = new System.Drawing.Point(6, 25);
            this.customert.Name = "customert";
            this.customert.Size = new System.Drawing.Size(683, 26);
            this.customert.TabIndex = 4;
            // 
            // customerd
            // 
            this.customerd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerd.Location = new System.Drawing.Point(6, 57);
            this.customerd.Name = "customerd";
            this.customerd.Size = new System.Drawing.Size(683, 128);
            this.customerd.TabIndex = 3;
            // 
            // cartd
            // 
            this.cartd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartd.Location = new System.Drawing.Point(8, 624);
            this.cartd.Name = "cartd";
            this.cartd.Size = new System.Drawing.Size(695, 223);
            this.cartd.TabIndex = 9;
            // 
            // cartl
            // 
            this.cartl.AutoSize = true;
            this.cartl.Location = new System.Drawing.Point(8, 595);
            this.cartl.Name = "cartl";
            this.cartl.Size = new System.Drawing.Size(50, 16);
            this.cartl.TabIndex = 8;
            this.cartl.Text = "Sepet";
            // 
            // settingb
            // 
            this.settingb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingb.ImageIndex = 4;
            this.settingb.ImageList = this.ımageList1;
            this.settingb.Location = new System.Drawing.Point(12, 343);
            this.settingb.Name = "settingb";
            this.settingb.Size = new System.Drawing.Size(165, 76);
            this.settingb.TabIndex = 7;
            this.settingb.Text = "Ayarlar";
            this.settingb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingb.UseVisualStyleBackColor = true;
            this.settingb.Click += new System.EventHandler(this.settingb_Click);
            // 
            // caseb
            // 
            this.caseb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caseb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.caseb.ImageIndex = 3;
            this.caseb.ImageList = this.ımageList1;
            this.caseb.Location = new System.Drawing.Point(12, 258);
            this.caseb.Name = "caseb";
            this.caseb.Size = new System.Drawing.Size(165, 76);
            this.caseb.TabIndex = 6;
            this.caseb.Text = "Kasa";
            this.caseb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.caseb.UseVisualStyleBackColor = true;
            // 
            // orderb
            // 
            this.orderb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderb.ImageIndex = 2;
            this.orderb.ImageList = this.ımageList1;
            this.orderb.Location = new System.Drawing.Point(12, 176);
            this.orderb.Name = "orderb";
            this.orderb.Size = new System.Drawing.Size(165, 76);
            this.orderb.TabIndex = 2;
            this.orderb.Text = "Siparişler";
            this.orderb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.orderb.UseVisualStyleBackColor = true;
            // 
            // stockb
            // 
            this.stockb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stockb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockb.ImageIndex = 1;
            this.stockb.ImageList = this.ımageList1;
            this.stockb.Location = new System.Drawing.Point(12, 94);
            this.stockb.Name = "stockb";
            this.stockb.Size = new System.Drawing.Size(165, 76);
            this.stockb.TabIndex = 1;
            this.stockb.Text = "Stok";
            this.stockb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stockb.UseVisualStyleBackColor = true;
            this.stockb.Click += new System.EventHandler(this.stockb_Click);
            // 
            // customersb
            // 
            this.customersb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customersb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersb.ImageIndex = 0;
            this.customersb.ImageList = this.ımageList1;
            this.customersb.Location = new System.Drawing.Point(12, 12);
            this.customersb.Name = "customersb";
            this.customersb.Size = new System.Drawing.Size(165, 76);
            this.customersb.TabIndex = 0;
            this.customersb.Text = "Müşteriler";
            this.customersb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customersb.UseVisualStyleBackColor = true;
            this.customersb.Click += new System.EventHandler(this.customersb_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.settingb);
            this.Controls.Add(this.caseb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderb);
            this.Controls.Add(this.stockb);
            this.Controls.Add(this.customersb);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SST Stok Sipariş Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeorderd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stockg.ResumeLayout(false);
            this.stockg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockd)).EndInit();
            this.customerg.ResumeLayout(false);
            this.customerg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersb;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button stockb;
        private System.Windows.Forms.Button orderb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label orderdetailsl;
        private System.Windows.Forms.DataGridView orderdetailsd;
        private System.Windows.Forms.DataGridView activeorderd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView customerd;
        private System.Windows.Forms.GroupBox customerg;
        private System.Windows.Forms.DataGridView cartd;
        private System.Windows.Forms.Label cartl;
        private System.Windows.Forms.TextBox customert;
        private System.Windows.Forms.GroupBox stockg;
        private System.Windows.Forms.TextBox stockt;
        private System.Windows.Forms.DataGridView stockd;
        private System.Windows.Forms.Button caseb;
        private System.Windows.Forms.Button settingb;
    }
}