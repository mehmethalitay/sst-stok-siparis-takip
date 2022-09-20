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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da,da2;
        DataSet ds,ds2;
        string idgetir,time;

        private void listele()
        {
            baglan = new SQLiteConnection("Data Source=sst;Version=3;");
            da = new SQLiteDataAdapter("Select *From musteriler", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da.Fill(ds, 0, 100, "musteriler");
            musterid.DataSource = ds.Tables["musteriler"];

            ilc.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select * from il", baglan);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilc.Items.Add(dr["il"].ToString());
            }

            bedenc.Items.Clear();
            SQLiteCommand komut2 = new SQLiteCommand("select * from bedenler", baglan);
            SQLiteDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                bedenc.Items.Add(dr2["beden"].ToString());
            }

            musterid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            musterid.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            musterid.Columns[0].Visible = false;
            musterid.Columns[1].HeaderText = "Ad";
            musterid.Columns[2].HeaderText = "Soyad";
            musterid.Columns[3].HeaderText = "Cinsiyet";
            musterid.Columns[4].HeaderText = "Doğum T.";
            musterid.Columns[5].HeaderText = "Beden";
            musterid.Columns[6].HeaderText = "Telefon";
            musterid.Columns[7].HeaderText = "İl";
            musterid.Columns[8].HeaderText = "İlçe";
            musterid.Columns[9].HeaderText = "Mahalle";
            musterid.Columns[10].HeaderText = "Adres";

        }

        private void temizle()
        {
            foreach (Control item in customeraddg.Controls)
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

                else if (item is MaskedTextBox)
                {
                    MaskedTextBox masked = (MaskedTextBox)item;
                    masked.Clear();
                }
            }
        }

        private void ac()
        {

            foreach (var item in customeraddg.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Enabled = true;
                }

                else if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Enabled = true;
                }                
            }

            dogumtarihidt.Enabled = true;
        }

        private void kapat()
        {
            foreach (var item in customeraddg.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Enabled = false;
                }

                else if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Enabled = false;
                }
            }

            dogumtarihidt.Enabled = false;
        }

        private void ilc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ilc.Text == "")
            {

            }
            else
            {
                ilcec.Items.Clear();
                SQLiteCommand komut1 = new SQLiteCommand("select * from ilce where il like '" + ilc.Text + "'", baglan);
                SQLiteDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    ilcec.Items.Add(dr1["ilce"].ToString());
                }
                ilcec.Enabled = true;
            }            
        }


        private void ilcec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ilc.Text == "")
            {

            }
            else
            {
                mahallec.Items.Clear();
                SQLiteCommand komut1 = new SQLiteCommand("select * from mahalle where ilce like '" + ilcec.Text + "' and il like '" + ilc.Text + "' ", baglan);
                SQLiteDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    mahallec.Items.Add(dr1["mahalle"].ToString());
                }
                mahallec.Enabled = true;
            }
        }       

        private void saveb_Click(object sender, EventArgs e)
        {
            DateTime dgt = Convert.ToDateTime(dogumtarihidt.Value);
            try
            {
                if (isimt.Text == "" || soyisimt.Text == "" || cinsiyetc.Text == "" || bedenc.Text == "" || telefont.Text == "" || 
                    ilc.Text == "" || ilcec.Text == "" || mahallec.Text == "" || adrest.Text == "")

                {
                    MessageBox.Show("Boş alan bırakmayın");
                }

                else
                {
                    idgetir = musterid.CurrentRow.Cells[0].Value.ToString();
                    if (ConnectionState.Closed == baglan.State) baglan.Open();
                    SQLiteCommand con = new SQLiteCommand("update musteriler set ad = @ad, soyad = @soyad, cinsiyet = @cinsiyet, dt = @dt, beden = @beden, telefon = @telefon, il = @il, ilce = @ilce, mahalle = @mahalle, adres = @adres where id = " + idgetir , baglan);
                    con.Parameters.AddWithValue("@ad", isimt.Text);
                    con.Parameters.AddWithValue("@soyad", soyisimt.Text);
                    con.Parameters.AddWithValue("@cinsiyet", cinsiyetc.Text);
                    con.Parameters.AddWithValue("@dt", dgt);
                    con.Parameters.AddWithValue("@beden", bedenc.Text);
                    con.Parameters.AddWithValue("@telefon", telefont.Text);
                    con.Parameters.AddWithValue("@il", ilc.Text);
                    con.Parameters.AddWithValue("@ilce", ilcec.Text);
                    con.Parameters.AddWithValue("@mahalle", mahallec.Text);
                    con.Parameters.AddWithValue("@adres", adrest.Text);
                    con.ExecuteNonQuery();
                    MessageBox.Show("Kişi Başarı İle Güncellendi");
                    listele();
                    temizle();
                    updateb.Enabled = true;
                    saveb.Visible = false;
                    clearb.Visible = false;
                    kapat();
                }
            }
            
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void clearb_Click(object sender, EventArgs e)
        {
            temizle();
            updateb.Enabled = true;
            saveb.Visible = false;
            clearb.Visible = false;
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            ac();
            DateTime dt2 = Convert.ToDateTime(dogumtarihidt.Value.ToShortDateString());
            isimt.Text = musterid.CurrentRow.Cells[1].Value.ToString();
            soyisimt.Text = musterid.CurrentRow.Cells[2].Value.ToString();
            cinsiyetc.Text = musterid.CurrentRow.Cells[3].Value.ToString();
            dogumtarihidt.Value = Convert.ToDateTime(dt2);
            bedenc.Text = musterid.CurrentRow.Cells[5].Value.ToString();
            telefont.Text = musterid.CurrentRow.Cells[6].Value.ToString();
            ilc.Text = musterid.CurrentRow.Cells[7].Value.ToString();
            ilcec.Text = musterid.CurrentRow.Cells[8].Value.ToString();
            mahallec.Text = musterid.CurrentRow.Cells[9].Value.ToString();
            adrest.Text = musterid.CurrentRow.Cells[10].Value.ToString();

            updateb.Enabled = false;
            saveb.Visible = true;
            clearb.Visible = true;

            ilcec.Enabled = false;
            mahallec.Enabled = false;
            ilc.Enabled = true;

            ilc.DropDownStyle = ComboBoxStyle.DropDownList;
            ilcec.DropDownStyle = ComboBoxStyle.DropDownList;
            mahallec.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void yenileb_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void mahallec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void telefont_TextChanged(object sender, EventArgs e)
        {
            
        }

        musteriekle musteriekle = new musteriekle();
        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle.ShowDialog();
        }

        private void searcht_TextChanged(object sender, EventArgs e)
        {
            da = new SQLiteDataAdapter("select * from musteriler where ad like '" + searcht.Text + "%'", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();
            da.Fill(ds, "musteriler");
            musterid.DataSource = ds.Tables["musteriler"];
            baglan.Close();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
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
                        cmd = new SQLiteCommand("Delete From musteriler where id='" + musterid.CurrentRow.Cells[0].Value + "'", baglan);
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
        }

        private void musterid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idgetir = musterid.CurrentRow.Cells[0].Value.ToString();
            //da2 = new SQLiteDataAdapter("Select *From musteriler where id = '" + idgetir + "'", baglan);
            //ds2 = new DataSet();
            //if (ConnectionState.Closed == baglan.State) baglan.Open();
            //da2.Fill(ds2, 0, 100, "musteriler");
            //musterid.DataSource = ds2.Tables["musteriler"];
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            listele();
            kapat();
            temizle();
            updateb.Enabled = true;
            saveb.Visible = false;
            clearb.Visible = false;
        }
    }
}
