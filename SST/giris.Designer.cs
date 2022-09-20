namespace SST
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernamet = new System.Windows.Forms.TextBox();
            this.passwordt = new System.Windows.Forms.TextBox();
            this.usernamel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titlel = new System.Windows.Forms.Label();
            this.loginb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SST.Properties.Resources.inventory;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernamet
            // 
            this.usernamet.Font = new System.Drawing.Font("Arial MT Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernamet.Location = new System.Drawing.Point(520, 177);
            this.usernamet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernamet.Name = "usernamet";
            this.usernamet.Size = new System.Drawing.Size(242, 30);
            this.usernamet.TabIndex = 1;
            // 
            // passwordt
            // 
            this.passwordt.Font = new System.Drawing.Font("Arial MT Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordt.Location = new System.Drawing.Point(520, 237);
            this.passwordt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordt.Name = "passwordt";
            this.passwordt.PasswordChar = '*';
            this.passwordt.Size = new System.Drawing.Size(242, 30);
            this.passwordt.TabIndex = 2;
            // 
            // usernamel
            // 
            this.usernamel.AutoSize = true;
            this.usernamel.Location = new System.Drawing.Point(520, 157);
            this.usernamel.Name = "usernamel";
            this.usernamel.Size = new System.Drawing.Size(98, 16);
            this.usernamel.TabIndex = 3;
            this.usernamel.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre";
            // 
            // titlel
            // 
            this.titlel.AutoSize = true;
            this.titlel.Font = new System.Drawing.Font("Arial MT Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titlel.Location = new System.Drawing.Point(453, 29);
            this.titlel.Name = "titlel";
            this.titlel.Size = new System.Drawing.Size(355, 31);
            this.titlel.TabIndex = 5;
            this.titlel.Text = "SST Stok Sipariş Takip";
            // 
            // loginb
            // 
            this.loginb.Location = new System.Drawing.Point(520, 274);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(242, 43);
            this.loginb.TabIndex = 6;
            this.loginb.Text = "Giriş";
            this.loginb.UseVisualStyleBackColor = true;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.loginb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 397);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.titlel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernamel);
            this.Controls.Add(this.passwordt);
            this.Controls.Add(this.usernamet);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(900, 440);
            this.MinimumSize = new System.Drawing.Size(900, 440);
            this.Name = "giris";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SST Stok Sipariş Takip";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernamet;
        private System.Windows.Forms.TextBox passwordt;
        private System.Windows.Forms.Label usernamel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titlel;
        private System.Windows.Forms.Button loginb;
    }
}

