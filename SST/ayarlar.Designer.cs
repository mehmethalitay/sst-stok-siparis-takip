namespace SST
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.renkayarb = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bedenayarb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renkayarb
            // 
            this.renkayarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renkayarb.ImageKey = "color-circle.png";
            this.renkayarb.ImageList = this.ımageList1;
            this.renkayarb.Location = new System.Drawing.Point(13, 13);
            this.renkayarb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renkayarb.Name = "renkayarb";
            this.renkayarb.Size = new System.Drawing.Size(165, 73);
            this.renkayarb.TabIndex = 0;
            this.renkayarb.Text = "Renkler";
            this.renkayarb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.renkayarb.UseVisualStyleBackColor = true;
            this.renkayarb.Click += new System.EventHandler(this.renkayarb_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "meter.png");
            this.ımageList1.Images.SetKeyName(1, "color-circle.png");
            this.ımageList1.Images.SetKeyName(2, "settings.png");
            this.ımageList1.Images.SetKeyName(3, "trash.png");
            this.ımageList1.Images.SetKeyName(4, "safe.png");
            this.ımageList1.Images.SetKeyName(5, "picture.png");
            this.ımageList1.Images.SetKeyName(6, "eraser.png");
            this.ımageList1.Images.SetKeyName(7, "check.png");
            this.ımageList1.Images.SetKeyName(8, "order.png");
            this.ımageList1.Images.SetKeyName(9, "packages.png");
            this.ımageList1.Images.SetKeyName(10, "customer.png");
            this.ımageList1.Images.SetKeyName(11, "inventory.png");
            // 
            // bedenayarb
            // 
            this.bedenayarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bedenayarb.ImageKey = "meter.png";
            this.bedenayarb.ImageList = this.ımageList1;
            this.bedenayarb.Location = new System.Drawing.Point(13, 94);
            this.bedenayarb.Margin = new System.Windows.Forms.Padding(4);
            this.bedenayarb.Name = "bedenayarb";
            this.bedenayarb.Size = new System.Drawing.Size(165, 73);
            this.bedenayarb.TabIndex = 1;
            this.bedenayarb.Text = "Bedenler";
            this.bedenayarb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bedenayarb.UseVisualStyleBackColor = true;
            this.bedenayarb.Click += new System.EventHandler(this.bedenayarb_Click);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.bedenayarb);
            this.Controls.Add(this.renkayarb);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ayarlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button renkayarb;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button bedenayarb;
    }
}