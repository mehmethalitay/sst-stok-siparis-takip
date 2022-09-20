using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.VisualBasic;

namespace SST
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da, da1, da2;
        DataSet ds, ds1, ds2;

        private void listele()
        {
            searcht.Text = "";

            baglan = new SQLiteConnection("Data Source=sst;Version=3;");
            da = new SQLiteDataAdapter("Select *From stok", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da.Fill(ds, 0, 100, "stok");

            stockd.DataSource = ds.Tables["stok"];

            da1 = new SQLiteDataAdapter("Select *From stokh", baglan);
            ds1 = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da1.Fill(ds1, 0, 100, "stokh");
            stockhd.DataSource = ds1.Tables["stokh"];

            stocknc.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select * from stok", baglan);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                stocknc.Items.Add(dr["urunkod"].ToString());
            }

            colorc.Items.Clear();
            SQLiteCommand komut1 = new SQLiteCommand("select * from renkler", baglan);
            SQLiteDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                colorc.Items.Add(dr1["renk"].ToString());
            }

            sizec.Items.Clear();
            SQLiteCommand komut2 = new SQLiteCommand("select * from bedenler", baglan);
            SQLiteDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                sizec.Items.Add(dr2["beden"].ToString());
            }

            stockd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockd.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            stockd.Columns[0].Visible = false;
            stockd.Columns[1].HeaderText = "Ürün Kod";
            stockd.Columns[2].HeaderText = "Ürün Adı";
            stockd.Columns[3].HeaderText = "Beden";
            stockd.Columns[4].HeaderText = "Renk";
            stockd.Columns[5].HeaderText = "Fiyat";
            stockd.Columns[6].HeaderText = "Raf";
            stockd.Columns[7].HeaderText = "Stok";
            stockd.Columns[8].Visible = false;

            stockhd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockhd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockhd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockhd.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockhd.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stockhd.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            stockhd.Columns[0].Visible = false;
            stockhd.Columns[1].HeaderText = "Tarih";
            stockhd.Columns[2].HeaderText = "İşlem";
            stockhd.Columns[3].HeaderText = "Stok Kod";
            stockhd.Columns[4].HeaderText = "Adet";
            stockhd.Columns[5].HeaderText = "Tedarik";

        }

        private void temizle()
        {
            foreach (Control item in stockaddg.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

                else if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = "";
                    cbox.SelectedIndex = -1;
                }
            }

            foreach (Control item in stockg.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

                else if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = "";
                    cbox.SelectedIndex = -1;
                }
                imagepb.Image = Image.FromFile(@"resim\image.jpg");
            }
        }

        private void stok_Load(object sender, EventArgs e)
        {
            listele();
        }

        string yeniad;
        private void saveb_Click(object sender, EventArgs e)
        {
            try
            {
                if (codet.Text == "" || namet.Text == "" || sizec.Text == "" || colorc.Text == "" || raft.Text == "")

                {
                    MessageBox.Show("Boş alan bırakmayın");
                }

                else
                {
                    if (resimyolu != null)
                    {
                        string hedef = Application.StartupPath + @"\resim\";
                        yeniad = Guid.NewGuid() + ".jpg";
                        File.Copy(resimyolu, hedef + yeniad);
                    }

                    else
                    {
                        yeniad = "image.jpg";
                    }

                    if (ConnectionState.Closed == baglan.State) baglan.Open();
                    SQLiteCommand con5 = new SQLiteCommand("update stok set urunkod = @urunkod, urunad = @urunad, beden = @beden, renk = @renk, fiyat= @fiyat, raf = @raf, image = @image where urunkod= @urunkod", baglan);
                    con5.Parameters.AddWithValue("@urunkod", codet.Text);
                    con5.Parameters.AddWithValue("@urunad", namet.Text);
                    con5.Parameters.AddWithValue("@beden", sizec.Text);
                    con5.Parameters.AddWithValue("@renk", colorc.Text);
                    con5.Parameters.AddWithValue("@fiyat", fiyatt.Text);
                    con5.Parameters.AddWithValue("@raf", raft.Text);
                    con5.Parameters.AddWithValue("@image", yeniad);
                    con5.ExecuteNonQuery();
                    listele();
                    temizle();
                    MessageBox.Show("Ürün Başarı İle Güncellendi");
                    updateb.Visible = true;
                    saveb.Visible = false;
                    clearb.Visible = false;
                    
                }
            }


            catch (SQLiteException hata)
            {
                if (hata.ErrorCode == 19)
                {
                    MessageBox.Show("Aynı Üründen Var");
                    updateb.Visible = true;
                    saveb.Visible = false;
                    clearb.Visible = false;
                }
                else { 
                MessageBox.Show(hata.ToString());
                updateb.Visible = true;
                saveb.Visible = false;
                clearb.Visible = false;
            }
            }
        }

        private void stokadt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void stokhareketekle()
        {
            SQLiteCommand con1 = new SQLiteCommand("Insert Into stokh (stokkod,tarih,islem,adet,tedarik) values (@stokkod,@tarih,@islem,@adet,@tedarik)", baglan);
            con1.Parameters.AddWithValue("@stokkod", stocknc.Text);
            con1.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            con1.Parameters.AddWithValue("@islem", islemcb.Text);
            con1.Parameters.AddWithValue("@adet", stokadt.Text);
            con1.Parameters.AddWithValue("@tedarik", tedarikt.Text);
            con1.ExecuteNonQuery();
            temizle();
            listele();
        }

        private void saveb1_Click(object sender, EventArgs e)
        {
            int eklenecekstokad, yenistok;
            try
            {
                if (stocknc.Text != "" && stokadt.Text != "" && tedarikt.Text != "" && islemcb.Text == "Giriş" || islemcb.Text == "Çıkış")
                {
                    if (islemcb.Text == "Giriş")
                    {
                        eklenecekstokad = Convert.ToInt32(stokadt.Text);
                        yenistok = eklenecekstokad + guncelstokad;
                        if (ConnectionState.Closed == baglan.State) baglan.Open();
                        SQLiteCommand con = new SQLiteCommand("update stok set stok = @stok where urunkod= @urunkod", baglan);
                        con.Parameters.AddWithValue("@urunkod", stocknc.Text);
                        con.Parameters.AddWithValue("@stok", yenistok);
                        con.ExecuteNonQuery();
                        stokhareketekle();
                        temizle();
                        MessageBox.Show("Giriş İşlemi Başarılı");
                    }

                    if (islemcb.Text == "Çıkış")
                    {
                        eklenecekstokad = Convert.ToInt32(stokadt.Text);
                        yenistok = guncelstokad - eklenecekstokad;
                        if (ConnectionState.Closed == baglan.State) baglan.Open();
                        SQLiteCommand con = new SQLiteCommand("update stok set stok = @stok where urunkod= @urunkod", baglan);
                        con.Parameters.AddWithValue("@urunkod", stocknc.Text);
                        con.Parameters.AddWithValue("@stok", yenistok);
                        con.ExecuteNonQuery();
                        stokhareketekle();
                        temizle();
                        MessageBox.Show("Çıkış İşlemi Başarılı");
                    }
                }
                else
                {
                    MessageBox.Show("(İşlem) Türünü Seçin. Stok Girişi İçin (Giriş)i Stok Çıkışı İçin (Çıkış)ı Seçin.");
                    temizle();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Alanları Boş Bırakmayın!");
            }
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int erisimkodu;
            SQLiteCommand cmd;
            try
            {
                Random r = new Random();
                int rastgele = r.Next(100, 999);
                erisimkodu = rastgele + 273 * 2 * rastgele + 528 - 13;
                int erisim = Convert.ToInt32(Interaction.InputBox("Erişim Kodu :" + rastgele, "Yetki Kodu", ""));
                if (erisimkodu == erisim)
                {
                    if (ConnectionState.Closed == baglan.State) baglan.Open();
                    cmd = new SQLiteCommand("Delete From stok where id='" + stockd.CurrentRow.Cells[0].Value + "'", baglan);
                    cmd.ExecuteNonQuery();
                    listele();
                    temizle();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Başarısız");
            }
        }

        private void clearb_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void clearb1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            namet.Text = stockd.CurrentRow.Cells[1].Value.ToString();
            codet.Text = stockd.CurrentRow.Cells[2].Value.ToString();
            sizec.Text = stockd.CurrentRow.Cells[3].Value.ToString();
            colorc.Text = stockd.CurrentRow.Cells[4].Value.ToString();
            fiyatt.Text = stockd.CurrentRow.Cells[5].Value.ToString();
            raft.Text = stockd.CurrentRow.Cells[6].Value.ToString();
            imagepb.Image = Image.FromFile(@"resim\" + stockd.CurrentRow.Cells[8].Value.ToString() + "");
            updateb.Visible = false;
            saveb.Visible = true;
            clearb.Visible = true;
        }

        int guncelstokad;
        private void stocknc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand("select * from stok where urunkod='" + stocknc.Text + "'", baglan);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                guncelstokad = Convert.ToInt32(dr["stok"]);
                stokadetlbl.Text = "Stok Adeti: " + guncelstokad.ToString();
            }

        }

        urunekle urunekle = new urunekle();

        private void searcht_TextChanged(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter("select * from stok where urunkod like '" + searcht.Text + "%'", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da.Fill(ds, "stok");
            stockd.DataSource = ds.Tables["stok"];
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunekle.ShowDialog();
            listele();
            temizle();
        }

        private void yenileb_Click(object sender, EventArgs e)
        {
            listele();
        }

        string secilistokkod;
        private void stockd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilistokkod = stockd.CurrentRow.Cells[1].Value.ToString();
            da2 = new SQLiteDataAdapter("Select *From stokh where stokkod = '" + secilistokkod + "'", baglan);
            ds2 = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da2.Fill(ds2, 0, 100, "stokh");
            stockhd.DataSource = ds2.Tables["stokh"];

            imagepb.Image = Image.FromFile(@"resim\" + stockd.CurrentRow.Cells[8].Value.ToString() + "");

        }

        string resimyolu;
        private void imageb_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            resimsec.Filter = "Tüm Resimler (bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                resimyolu = resimsec.FileName;
                imagepb.Image = new Bitmap(resimyolu);
            }

        }
    }
}
