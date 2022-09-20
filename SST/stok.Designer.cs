namespace SST
{
    partial class stok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.namet = new System.Windows.Forms.TextBox();
            this.codet = new System.Windows.Forms.TextBox();
            this.sizec = new System.Windows.Forms.ComboBox();
            this.colorc = new System.Windows.Forms.ComboBox();
            this.namel = new System.Windows.Forms.Label();
            this.codel = new System.Windows.Forms.Label();
            this.sizel = new System.Windows.Forms.Label();
            this.colorl = new System.Windows.Forms.Label();
            this.stockd = new System.Windows.Forms.DataGridView();
            this.stockaddg = new System.Windows.Forms.GroupBox();
            this.raft = new System.Windows.Forms.TextBox();
            this.rafl = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.stockg = new System.Windows.Forms.GroupBox();
            this.stokadetlbl = new System.Windows.Forms.Label();
            this.islemtxtlbl = new System.Windows.Forms.Label();
            this.islemcb = new System.Windows.Forms.ComboBox();
            this.tedarikt = new System.Windows.Forms.TextBox();
            this.tedarikl = new System.Windows.Forms.Label();
            this.stokadt = new System.Windows.Forms.TextBox();
            this.stocknlb = new System.Windows.Forms.Label();
            this.stocknl = new System.Windows.Forms.Label();
            this.stocknc = new System.Windows.Forms.ComboBox();
            this.stockhd = new System.Windows.Forms.DataGridView();
            this.stockhl = new System.Windows.Forms.Label();
            this.stoklarl = new System.Windows.Forms.Label();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.searcht = new System.Windows.Forms.TextBox();
            this.searchl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yenileb = new System.Windows.Forms.Button();
            this.updateb = new System.Windows.Forms.Button();
            this.deleteb = new System.Windows.Forms.Button();
            this.clearb1 = new System.Windows.Forms.Button();
            this.saveb1 = new System.Windows.Forms.Button();
            this.clearb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.imageb = new System.Windows.Forms.Button();
            this.imagepb = new System.Windows.Forms.PictureBox();
            this.fiyatt = new System.Windows.Forms.TextBox();
            this.fiyatl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockd)).BeginInit();
            this.stockaddg.SuspendLayout();
            this.stockg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagepb)).BeginInit();
            this.SuspendLayout();
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(9, 355);
            this.namet.Margin = new System.Windows.Forms.Padding(4);
            this.namet.Name = "namet";
            this.namet.ShortcutsEnabled = false;
            this.namet.Size = new System.Drawing.Size(211, 26);
            this.namet.TabIndex = 1;
            // 
            // codet
            // 
            this.codet.Location = new System.Drawing.Point(9, 302);
            this.codet.Margin = new System.Windows.Forms.Padding(4);
            this.codet.Name = "codet";
            this.codet.ShortcutsEnabled = false;
            this.codet.Size = new System.Drawing.Size(211, 26);
            this.codet.TabIndex = 0;
            // 
            // sizec
            // 
            this.sizec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizec.FormattingEnabled = true;
            this.sizec.Location = new System.Drawing.Point(9, 407);
            this.sizec.Margin = new System.Windows.Forms.Padding(4);
            this.sizec.Name = "sizec";
            this.sizec.Size = new System.Drawing.Size(211, 24);
            this.sizec.TabIndex = 2;
            // 
            // colorc
            // 
            this.colorc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorc.FormattingEnabled = true;
            this.colorc.Location = new System.Drawing.Point(9, 457);
            this.colorc.Margin = new System.Windows.Forms.Padding(4);
            this.colorc.Name = "colorc";
            this.colorc.Size = new System.Drawing.Size(211, 24);
            this.colorc.TabIndex = 3;
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.ForeColor = System.Drawing.SystemColors.Window;
            this.namel.Location = new System.Drawing.Point(6, 335);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(70, 16);
            this.namel.TabIndex = 4;
            this.namel.Text = "Ürün Adı";
            // 
            // codel
            // 
            this.codel.AutoSize = true;
            this.codel.ForeColor = System.Drawing.SystemColors.Window;
            this.codel.Location = new System.Drawing.Point(6, 282);
            this.codel.Name = "codel";
            this.codel.Size = new System.Drawing.Size(85, 16);
            this.codel.TabIndex = 5;
            this.codel.Text = "Ürün Kodu";
            // 
            // sizel
            // 
            this.sizel.AutoSize = true;
            this.sizel.ForeColor = System.Drawing.SystemColors.Window;
            this.sizel.Location = new System.Drawing.Point(6, 387);
            this.sizel.Name = "sizel";
            this.sizel.Size = new System.Drawing.Size(54, 16);
            this.sizel.TabIndex = 6;
            this.sizel.Text = "Beden";
            // 
            // colorl
            // 
            this.colorl.AutoSize = true;
            this.colorl.ForeColor = System.Drawing.SystemColors.Window;
            this.colorl.Location = new System.Drawing.Point(6, 437);
            this.colorl.Name = "colorl";
            this.colorl.Size = new System.Drawing.Size(45, 16);
            this.colorl.TabIndex = 7;
            this.colorl.Text = "Renk";
            // 
            // stockd
            // 
            this.stockd.AllowUserToAddRows = false;
            this.stockd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.stockd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockd.DefaultCellStyle = dataGridViewCellStyle38;
            this.stockd.Location = new System.Drawing.Point(424, 61);
            this.stockd.Name = "stockd";
            this.stockd.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockd.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.stockd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockd.Size = new System.Drawing.Size(528, 254);
            this.stockd.TabIndex = 8;
            this.stockd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockd_CellClick);
            // 
            // stockaddg
            // 
            this.stockaddg.Controls.Add(this.fiyatt);
            this.stockaddg.Controls.Add(this.fiyatl);
            this.stockaddg.Controls.Add(this.raft);
            this.stockaddg.Controls.Add(this.rafl);
            this.stockaddg.Controls.Add(this.clearb);
            this.stockaddg.Controls.Add(this.saveb);
            this.stockaddg.Controls.Add(this.colorc);
            this.stockaddg.Controls.Add(this.namet);
            this.stockaddg.Controls.Add(this.colorl);
            this.stockaddg.Controls.Add(this.codet);
            this.stockaddg.Controls.Add(this.sizel);
            this.stockaddg.Controls.Add(this.sizec);
            this.stockaddg.Controls.Add(this.imageb);
            this.stockaddg.Controls.Add(this.codel);
            this.stockaddg.Controls.Add(this.imagepb);
            this.stockaddg.Controls.Add(this.namel);
            this.stockaddg.ForeColor = System.Drawing.SystemColors.Window;
            this.stockaddg.Location = new System.Drawing.Point(12, 12);
            this.stockaddg.Name = "stockaddg";
            this.stockaddg.Size = new System.Drawing.Size(236, 642);
            this.stockaddg.TabIndex = 9;
            this.stockaddg.TabStop = false;
            this.stockaddg.Text = "Ürün Bilgileri";
            // 
            // raft
            // 
            this.raft.Location = new System.Drawing.Point(9, 506);
            this.raft.Margin = new System.Windows.Forms.Padding(4);
            this.raft.Name = "raft";
            this.raft.ShortcutsEnabled = false;
            this.raft.Size = new System.Drawing.Size(211, 26);
            this.raft.TabIndex = 4;
            // 
            // rafl
            // 
            this.rafl.AutoSize = true;
            this.rafl.ForeColor = System.Drawing.SystemColors.Window;
            this.rafl.Location = new System.Drawing.Point(6, 485);
            this.rafl.Name = "rafl";
            this.rafl.Size = new System.Drawing.Size(32, 16);
            this.rafl.TabIndex = 11;
            this.rafl.Text = "Raf";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "eraser.png");
            this.ımageList1.Images.SetKeyName(2, "picture.png");
            this.ımageList1.Images.SetKeyName(3, "trash.png");
            this.ımageList1.Images.SetKeyName(4, "refresh.png");
            this.ımageList1.Images.SetKeyName(5, "packages.png");
            this.ımageList1.Images.SetKeyName(6, "product.png");
            this.ımageList1.Images.SetKeyName(7, "loading.png");
            // 
            // stockg
            // 
            this.stockg.Controls.Add(this.stokadetlbl);
            this.stockg.Controls.Add(this.islemtxtlbl);
            this.stockg.Controls.Add(this.islemcb);
            this.stockg.Controls.Add(this.tedarikt);
            this.stockg.Controls.Add(this.tedarikl);
            this.stockg.Controls.Add(this.clearb1);
            this.stockg.Controls.Add(this.stokadt);
            this.stockg.Controls.Add(this.saveb1);
            this.stockg.Controls.Add(this.stocknlb);
            this.stockg.Controls.Add(this.stocknl);
            this.stockg.Controls.Add(this.stocknc);
            this.stockg.ForeColor = System.Drawing.SystemColors.Window;
            this.stockg.Location = new System.Drawing.Point(251, 347);
            this.stockg.Name = "stockg";
            this.stockg.Size = new System.Drawing.Size(236, 307);
            this.stockg.TabIndex = 10;
            this.stockg.TabStop = false;
            this.stockg.Text = "Stok Ekle";
            // 
            // stokadetlbl
            // 
            this.stokadetlbl.AutoSize = true;
            this.stokadetlbl.Font = new System.Drawing.Font("Arial MT Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokadetlbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.stokadetlbl.Location = new System.Drawing.Point(11, 22);
            this.stokadetlbl.Name = "stokadetlbl";
            this.stokadetlbl.Size = new System.Drawing.Size(174, 14);
            this.stokadetlbl.TabIndex = 18;
            this.stokadetlbl.Text = "Seçilen Stok Güncel Adet: 0";
            this.stokadetlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // islemtxtlbl
            // 
            this.islemtxtlbl.AutoSize = true;
            this.islemtxtlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.islemtxtlbl.Location = new System.Drawing.Point(9, 96);
            this.islemtxtlbl.Name = "islemtxtlbl";
            this.islemtxtlbl.Size = new System.Drawing.Size(47, 16);
            this.islemtxtlbl.TabIndex = 17;
            this.islemtxtlbl.Text = "İşlem";
            // 
            // islemcb
            // 
            this.islemcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemcb.FormattingEnabled = true;
            this.islemcb.ItemHeight = 16;
            this.islemcb.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.islemcb.Location = new System.Drawing.Point(12, 116);
            this.islemcb.Margin = new System.Windows.Forms.Padding(4);
            this.islemcb.Name = "islemcb";
            this.islemcb.Size = new System.Drawing.Size(211, 24);
            this.islemcb.TabIndex = 16;
            // 
            // tedarikt
            // 
            this.tedarikt.Location = new System.Drawing.Point(12, 218);
            this.tedarikt.Margin = new System.Windows.Forms.Padding(4);
            this.tedarikt.Name = "tedarikt";
            this.tedarikt.ShortcutsEnabled = false;
            this.tedarikt.Size = new System.Drawing.Size(211, 26);
            this.tedarikt.TabIndex = 9;
            // 
            // tedarikl
            // 
            this.tedarikl.AutoSize = true;
            this.tedarikl.ForeColor = System.Drawing.SystemColors.Window;
            this.tedarikl.Location = new System.Drawing.Point(11, 198);
            this.tedarikl.Name = "tedarikl";
            this.tedarikl.Size = new System.Drawing.Size(76, 16);
            this.tedarikl.TabIndex = 15;
            this.tedarikl.Text = "Tedarikçi";
            // 
            // stokadt
            // 
            this.stokadt.Location = new System.Drawing.Point(12, 164);
            this.stokadt.Margin = new System.Windows.Forms.Padding(4);
            this.stokadt.Name = "stokadt";
            this.stokadt.ShortcutsEnabled = false;
            this.stokadt.Size = new System.Drawing.Size(211, 26);
            this.stokadt.TabIndex = 8;
            this.stokadt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stokadt_KeyPress);
            // 
            // stocknlb
            // 
            this.stocknlb.AutoSize = true;
            this.stocknlb.ForeColor = System.Drawing.SystemColors.Window;
            this.stocknlb.Location = new System.Drawing.Point(9, 144);
            this.stocknlb.Name = "stocknlb";
            this.stocknlb.Size = new System.Drawing.Size(83, 16);
            this.stocknlb.TabIndex = 13;
            this.stocknlb.Text = "Stok Adeti";
            // 
            // stocknl
            // 
            this.stocknl.AutoSize = true;
            this.stocknl.ForeColor = System.Drawing.SystemColors.Window;
            this.stocknl.Location = new System.Drawing.Point(9, 44);
            this.stocknl.Name = "stocknl";
            this.stocknl.Size = new System.Drawing.Size(68, 16);
            this.stocknl.TabIndex = 13;
            this.stocknl.Text = "Stok Adı";
            // 
            // stocknc
            // 
            this.stocknc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stocknc.FormattingEnabled = true;
            this.stocknc.ItemHeight = 16;
            this.stocknc.Location = new System.Drawing.Point(12, 64);
            this.stocknc.Margin = new System.Windows.Forms.Padding(4);
            this.stocknc.Name = "stocknc";
            this.stocknc.Size = new System.Drawing.Size(211, 24);
            this.stocknc.TabIndex = 12;
            this.stocknc.SelectedIndexChanged += new System.EventHandler(this.stocknc_SelectedIndexChanged);
            // 
            // stockhd
            // 
            this.stockhd.AllowUserToAddRows = false;
            this.stockhd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockhd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.stockhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockhd.DefaultCellStyle = dataGridViewCellStyle41;
            this.stockhd.Location = new System.Drawing.Point(492, 358);
            this.stockhd.Name = "stockhd";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockhd.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.stockhd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockhd.Size = new System.Drawing.Size(460, 296);
            this.stockhd.TabIndex = 13;
            // 
            // stockhl
            // 
            this.stockhl.AutoSize = true;
            this.stockhl.ForeColor = System.Drawing.SystemColors.Window;
            this.stockhl.Location = new System.Drawing.Point(821, 338);
            this.stockhl.Name = "stockhl";
            this.stockhl.Size = new System.Drawing.Size(131, 16);
            this.stockhl.TabIndex = 15;
            this.stockhl.Text = " Stok Hareketleri";
            // 
            // stoklarl
            // 
            this.stoklarl.AutoSize = true;
            this.stoklarl.ForeColor = System.Drawing.SystemColors.Window;
            this.stoklarl.Location = new System.Drawing.Point(888, 42);
            this.stoklarl.Name = "stoklarl";
            this.stoklarl.Size = new System.Drawing.Size(64, 16);
            this.stoklarl.TabIndex = 17;
            this.stoklarl.Text = " Stoklar";
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // searcht
            // 
            this.searcht.Location = new System.Drawing.Point(257, 28);
            this.searcht.Name = "searcht";
            this.searcht.ShortcutsEnabled = false;
            this.searcht.Size = new System.Drawing.Size(625, 26);
            this.searcht.TabIndex = 20;
            this.searcht.TextChanged += new System.EventHandler(this.searcht_TextChanged);
            // 
            // searchl
            // 
            this.searchl.AutoSize = true;
            this.searchl.ForeColor = System.Drawing.SystemColors.Window;
            this.searchl.Location = new System.Drawing.Point(254, 12);
            this.searchl.Name = "searchl";
            this.searchl.Size = new System.Drawing.Size(85, 16);
            this.searchl.TabIndex = 21;
            this.searchl.Text = "Ürün Kodu";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(257, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "Yeni Ürün Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yenileb
            // 
            this.yenileb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yenileb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yenileb.ImageIndex = 7;
            this.yenileb.ImageList = this.ımageList1;
            this.yenileb.Location = new System.Drawing.Point(257, 256);
            this.yenileb.Name = "yenileb";
            this.yenileb.Size = new System.Drawing.Size(161, 59);
            this.yenileb.TabIndex = 19;
            this.yenileb.Text = "Yenile";
            this.yenileb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yenileb.UseVisualStyleBackColor = true;
            this.yenileb.Click += new System.EventHandler(this.yenileb_Click);
            // 
            // updateb
            // 
            this.updateb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateb.ImageIndex = 4;
            this.updateb.ImageList = this.ımageList1;
            this.updateb.Location = new System.Drawing.Point(257, 126);
            this.updateb.Name = "updateb";
            this.updateb.Size = new System.Drawing.Size(161, 59);
            this.updateb.TabIndex = 18;
            this.updateb.Text = "Güncelle";
            this.updateb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateb.UseVisualStyleBackColor = true;
            this.updateb.Click += new System.EventHandler(this.updateb_Click);
            // 
            // deleteb
            // 
            this.deleteb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteb.ImageIndex = 3;
            this.deleteb.ImageList = this.ımageList1;
            this.deleteb.Location = new System.Drawing.Point(257, 191);
            this.deleteb.Name = "deleteb";
            this.deleteb.Size = new System.Drawing.Size(161, 59);
            this.deleteb.TabIndex = 16;
            this.deleteb.Text = "Ürün Sil";
            this.deleteb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteb.UseVisualStyleBackColor = true;
            this.deleteb.Click += new System.EventHandler(this.deleteb_Click);
            // 
            // clearb1
            // 
            this.clearb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearb1.ImageIndex = 1;
            this.clearb1.ImageList = this.ımageList1;
            this.clearb1.Location = new System.Drawing.Point(12, 260);
            this.clearb1.Name = "clearb1";
            this.clearb1.Size = new System.Drawing.Size(94, 42);
            this.clearb1.TabIndex = 11;
            this.clearb1.Text = "Sıfırla";
            this.clearb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearb1.UseVisualStyleBackColor = true;
            this.clearb1.Click += new System.EventHandler(this.clearb1_Click);
            // 
            // saveb1
            // 
            this.saveb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveb1.ImageIndex = 0;
            this.saveb1.ImageList = this.ımageList1;
            this.saveb1.Location = new System.Drawing.Point(110, 260);
            this.saveb1.Name = "saveb1";
            this.saveb1.Size = new System.Drawing.Size(113, 42);
            this.saveb1.TabIndex = 10;
            this.saveb1.Text = "Kaydet";
            this.saveb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveb1.UseVisualStyleBackColor = true;
            this.saveb1.Click += new System.EventHandler(this.saveb1_Click);
            // 
            // clearb
            // 
            this.clearb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearb.ImageIndex = 1;
            this.clearb.ImageList = this.ımageList1;
            this.clearb.Location = new System.Drawing.Point(9, 595);
            this.clearb.Name = "clearb";
            this.clearb.Size = new System.Drawing.Size(94, 42);
            this.clearb.TabIndex = 6;
            this.clearb.Text = "Sıfırla";
            this.clearb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearb.UseVisualStyleBackColor = true;
            this.clearb.Visible = false;
            this.clearb.Click += new System.EventHandler(this.clearb_Click);
            // 
            // saveb
            // 
            this.saveb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveb.ImageIndex = 0;
            this.saveb.ImageList = this.ımageList1;
            this.saveb.Location = new System.Drawing.Point(107, 595);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(113, 42);
            this.saveb.TabIndex = 5;
            this.saveb.Text = "Kaydet";
            this.saveb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Visible = false;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // imageb
            // 
            this.imageb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imageb.ImageIndex = 2;
            this.imageb.ImageList = this.ımageList1;
            this.imageb.Location = new System.Drawing.Point(9, 235);
            this.imageb.Name = "imageb";
            this.imageb.Size = new System.Drawing.Size(211, 42);
            this.imageb.TabIndex = 12;
            this.imageb.Text = "Resim Seç";
            this.imageb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imageb.UseVisualStyleBackColor = true;
            this.imageb.Click += new System.EventHandler(this.imageb_Click);
            // 
            // imagepb
            // 
            this.imagepb.BackColor = System.Drawing.SystemColors.Window;
            this.imagepb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagepb.Image = global::SST.Properties.Resources.image;
            this.imagepb.Location = new System.Drawing.Point(9, 20);
            this.imagepb.Name = "imagepb";
            this.imagepb.Size = new System.Drawing.Size(211, 209);
            this.imagepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagepb.TabIndex = 11;
            this.imagepb.TabStop = false;
            // 
            // fiyatt
            // 
            this.fiyatt.Location = new System.Drawing.Point(9, 558);
            this.fiyatt.Margin = new System.Windows.Forms.Padding(4);
            this.fiyatt.Name = "fiyatt";
            this.fiyatt.ShortcutsEnabled = false;
            this.fiyatt.Size = new System.Drawing.Size(211, 26);
            this.fiyatt.TabIndex = 13;
            // 
            // fiyatl
            // 
            this.fiyatl.AutoSize = true;
            this.fiyatl.ForeColor = System.Drawing.SystemColors.Window;
            this.fiyatl.Location = new System.Drawing.Point(6, 538);
            this.fiyatl.Name = "fiyatl";
            this.fiyatl.Size = new System.Drawing.Size(44, 16);
            this.fiyatl.TabIndex = 14;
            this.fiyatl.Text = "Fiyat";
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(964, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchl);
            this.Controls.Add(this.searcht);
            this.Controls.Add(this.yenileb);
            this.Controls.Add(this.updateb);
            this.Controls.Add(this.stoklarl);
            this.Controls.Add(this.deleteb);
            this.Controls.Add(this.stockhl);
            this.Controls.Add(this.stockhd);
            this.Controls.Add(this.stockg);
            this.Controls.Add(this.stockaddg);
            this.Controls.Add(this.stockd);
            this.Font = new System.Drawing.Font("Arial MT Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(980, 705);
            this.MinimumSize = new System.Drawing.Size(980, 705);
            this.Name = "stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SST Stok Takip";
            this.Load += new System.EventHandler(this.stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockd)).EndInit();
            this.stockaddg.ResumeLayout(false);
            this.stockaddg.PerformLayout();
            this.stockg.ResumeLayout(false);
            this.stockg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagepb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.TextBox codet;
        private System.Windows.Forms.ComboBox sizec;
        private System.Windows.Forms.ComboBox colorc;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label codel;
        private System.Windows.Forms.Label sizel;
        private System.Windows.Forms.Label colorl;
        private System.Windows.Forms.DataGridView stockd;
        private System.Windows.Forms.GroupBox stockaddg;
        private System.Windows.Forms.Button clearb;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.TextBox raft;
        private System.Windows.Forms.Label rafl;
        private System.Windows.Forms.GroupBox stockg;
        private System.Windows.Forms.TextBox tedarikt;
        private System.Windows.Forms.Label tedarikl;
        private System.Windows.Forms.Button clearb1;
        private System.Windows.Forms.TextBox stokadt;
        private System.Windows.Forms.Button saveb1;
        private System.Windows.Forms.Label stocknlb;
        private System.Windows.Forms.Label stocknl;
        private System.Windows.Forms.ComboBox stocknc;
        private System.Windows.Forms.PictureBox imagepb;
        private System.Windows.Forms.Button imageb;
        private System.Windows.Forms.DataGridView stockhd;
        private System.Windows.Forms.Label stockhl;
        private System.Windows.Forms.Button deleteb;
        private System.Windows.Forms.Label stoklarl;
        private System.Windows.Forms.Button updateb;
        private System.Windows.Forms.Label islemtxtlbl;
        private System.Windows.Forms.ComboBox islemcb;
        private System.Windows.Forms.Label stokadetlbl;
        private System.Windows.Forms.Button yenileb;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.TextBox searcht;
        private System.Windows.Forms.Label searchl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fiyatt;
        private System.Windows.Forms.Label fiyatl;
    }
}