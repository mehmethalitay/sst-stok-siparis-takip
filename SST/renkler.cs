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
    public partial class renkler : Form
    {
        public renkler()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da;
        DataSet ds;

        private void renkt_TextChanged(object sender, EventArgs e)
        {
            renkt.Text = renkt.Text.ToUpper();
            renkt.SelectionStart = renkt.Text.Length;
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
                    cmd = new SQLiteCommand("Delete From renkler where renk='" + renklerlb.SelectedItem + "'", baglan);
                    cmd.ExecuteNonQuery();
                    listele();
                    MessageBox.Show("Silme İşlemi Tamamlandı");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Başarısız");
            }
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            try
            {
                if (renkt.Text == "")
                {
                    MessageBox.Show("Renk Alanını Boş Bırakmayın");
                }
                else
                {
                    if (ConnectionState.Closed == baglan.State) baglan.Open();
                    SQLiteCommand con = new SQLiteCommand("Insert Into renkler (renk) values (@renk)", baglan);
                    con.Parameters.AddWithValue("@renk", renkt.Text);
                    con.ExecuteNonQuery();
                    listele();
                    renkt.Text = "";
                    MessageBox.Show("Renk Eklendi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Renk Ekleme İşlemi Başarısız");
            }

        }

        private void listele()
        {
            baglan = new SQLiteConnection("Data Source=sst;Version=3;");
            da = new SQLiteDataAdapter("Select *From renkler", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();

            renklerlb.DataSource = ds.Tables["renkler"];

            renklerlb.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select * from renkler", baglan);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                renklerlb.Items.Add(dr["renk"].ToString());
            }
        }

        private void renkler_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
