namespace SST
{
    partial class bedenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bedenler));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bedenl = new System.Windows.Forms.Label();
            this.bedent = new System.Windows.Forms.TextBox();
            this.bedenlerlb = new System.Windows.Forms.ListBox();
            this.deleteb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // bedenl
            // 
            this.bedenl.AutoSize = true;
            this.bedenl.ForeColor = System.Drawing.SystemColors.Control;
            this.bedenl.Location = new System.Drawing.Point(11, 9);
            this.bedenl.Name = "bedenl";
            this.bedenl.Size = new System.Drawing.Size(54, 16);
            this.bedenl.TabIndex = 23;
            this.bedenl.Text = "Beden";
            // 
            // bedent
            // 
            this.bedent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bedent.Location = new System.Drawing.Point(12, 28);
            this.bedent.Name = "bedent";
            this.bedent.Size = new System.Drawing.Size(209, 26);
            this.bedent.TabIndex = 20;
            this.bedent.TextChanged += new System.EventHandler(this.bedent_TextChanged);
            // 
            // bedenlerlb
            // 
            this.bedenlerlb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bedenlerlb.FormattingEnabled = true;
            this.bedenlerlb.ItemHeight = 16;
            this.bedenlerlb.Location = new System.Drawing.Point(12, 109);
            this.bedenlerlb.Margin = new System.Windows.Forms.Padding(4);
            this.bedenlerlb.Name = "bedenlerlb";
            this.bedenlerlb.Size = new System.Drawing.Size(209, 308);
            this.bedenlerlb.TabIndex = 19;
            // 
            // deleteb
            // 
            this.deleteb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteb.ImageIndex = 3;
            this.deleteb.ImageList = this.ımageList1;
            this.deleteb.Location = new System.Drawing.Point(12, 60);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(101, 42);
            this.deleteb.TabIndex = 22;
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
            this.saveb.TabIndex = 21;
            this.saveb.Text = "Ekle";
            this.saveb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // bedenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(234, 433);
            this.Controls.Add(this.bedenl);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.bedent);
            this.Controls.Add(this.bedenlerlb);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(250, 472);
            this.MinimumSize = new System.Drawing.Size(250, 472);
            this.Name = "bedenler";
            this.Text = "SST Bedenler";
            this.Load += new System.EventHandler(this.bedenler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label bedenl;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.TextBox bedent;
        private System.Windows.Forms.ListBox bedenlerlb;
    }
}