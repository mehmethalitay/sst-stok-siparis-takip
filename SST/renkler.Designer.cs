namespace SST
{
    partial class renkler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(renkler));
            this.renklerlb = new System.Windows.Forms.ListBox();
            this.renkt = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.renkl = new System.Windows.Forms.Label();
            this.deleteb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renklerlb
            // 
            this.renklerlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renklerlb.FormattingEnabled = true;
            this.renklerlb.ItemHeight = 16;
            this.renklerlb.Location = new System.Drawing.Point(12, 109);
            this.renklerlb.Margin = new System.Windows.Forms.Padding(4);
            this.renklerlb.Name = "renklerlb";
            this.renklerlb.Size = new System.Drawing.Size(209, 308);
            this.renklerlb.TabIndex = 0;
            // 
            // renkt
            // 
            this.renkt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.renkt.Location = new System.Drawing.Point(12, 28);
            this.renkt.Name = "renkt";
            this.renkt.ShortcutsEnabled = false;
            this.renkt.Size = new System.Drawing.Size(209, 26);
            this.renkt.TabIndex = 1;
            this.renkt.TextChanged += new System.EventHandler(this.renkt_TextChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "eraser.png");
            this.ımageList1.Images.SetKeyName(2, "refresh.png");
            this.ımageList1.Images.SetKeyName(3, "trash.png");
            // 
            // renkl
            // 
            this.renkl.AutoSize = true;
            this.renkl.ForeColor = System.Drawing.SystemColors.Control;
            this.renkl.Location = new System.Drawing.Point(11, 9);
            this.renkl.Name = "renkl";
            this.renkl.Size = new System.Drawing.Size(45, 16);
            this.renkl.TabIndex = 18;
            this.renkl.Text = "Renk";
            // 
            // deleteb
            // 
            this.deleteb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteb.ImageIndex = 3;
            this.deleteb.ImageList = this.ımageList1;
            this.deleteb.Location = new System.Drawing.Point(12, 60);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(101, 42);
            this.deleteb.TabIndex = 17;
            this.deleteb.Text = "Sil";
            this.deleteb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteb.UseVisualStyleBackColor = true;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // saveb
            // 
            this.saveb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveb.ImageKey = "check.png";
            this.saveb.ImageList = this.ımageList1;
            this.saveb.Location = new System.Drawing.Point(119, 60);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(101, 42);
            this.saveb.TabIndex = 6;
            this.saveb.Text = "Ekle";
            this.saveb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // renkler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(234, 433);
            this.Controls.Add(this.renkl);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.renkt);
            this.Controls.Add(this.renklerlb);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(250, 472);
            this.MinimumSize = new System.Drawing.Size(250, 472);
            this.Name = "renkler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SST Renkler";
            this.Load += new System.EventHandler(this.renkler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox renklerlb;
        private System.Windows.Forms.TextBox renkt;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label renkl;
    }
}