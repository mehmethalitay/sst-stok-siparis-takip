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
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da;
        DataSet ds;

        private void urunekle_Load(object sender, EventArgs e)
        {
            baglan = new SQLiteConnection("Data Source=sst;Version=3;");
            da = new SQLiteDataAdapter("Select *From stok", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();

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
                imagepb.Image = Image.FromFile(@"resim\image.jpg");
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
                    SQLiteCommand con = new SQLiteCommand("Insert Into stok (urunkod,urunad,beden,renk,fiyat,raf,stok,image) values (@urunkod,@urunad,@beden,@renk,@fiyat,@raf,@stok,@image)", baglan);
                    con.Parameters.AddWithValue("@urunkod", codet.Text);
                    con.Parameters.AddWithValue("@urunad", namet.Text);
                    con.Parameters.AddWithValue("@beden", sizec.Text);
                    con.Parameters.AddWithValue("@renk", colorc.Text);
                    con.Parameters.AddWithValue("@fiyat", fiyatt.Text);
                    con.Parameters.AddWithValue("@raf", raft.Text);
                    con.Parameters.AddWithValue("@stok", 0);
                    con.Parameters.AddWithValue("@image", yeniad);
                    con.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarı İle Eklendi");
                    this.Close();

                }
            }

            catch (SQLiteException hata)
            {
                if (hata.ErrorCode == 19)
                {
                    MessageBox.Show("Aynı Üründen Var");
                }
                else
                    MessageBox.Show(hata.ToString());
            }
        }

        string resimyolu;
        private void imageb_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            resimsec.Filter = "Tüm Resimler (bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                resimyolu = resimsec.FileName;
                secilenresiml.Text = "Seçilen Resim";
                imagepb.Image = new Bitmap(resimyolu);
            }

        }

        private void fiyatt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
