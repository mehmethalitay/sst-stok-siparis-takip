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
    public partial class bedenler : Form
    {
        public bedenler()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan;
        SQLiteDataAdapter da;
        DataSet ds;

        private void listele()
        {
            baglan = new SQLiteConnection("Data Source=sst;Version=3;");
            da = new SQLiteDataAdapter("Select *From bedenler", baglan);
            ds = new DataSet();
            if (ConnectionState.Closed == baglan.State) baglan.Open();

            bedenlerlb.DataSource = ds.Tables["bedenler"];

            bedenlerlb.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select * from bedenler", baglan);
            SQLiteDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                bedenlerlb.Items.Add(dr["beden"].ToString());
            }
        }

        private void bedent_TextChanged(object sender, EventArgs e)
        {
            bedent.Text = bedent.Text.ToUpper();
            bedent.SelectionStart = bedent.Text.Length;
        }

        private void bedenler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void saveb_Click(object sender, EventArgs e)
        {
            try
            {
                if (bedent.Text == "")
                {
                    MessageBox.Show("Beden Alanını Boş Bırakmayın");
                }
                else
                {
                    if (ConnectionState.Closed == baglan.State) baglan.Open();
                    SQLiteCommand con = new SQLiteCommand("Insert Into bedenler (beden) values (@beden)", baglan);
                    con.Parameters.AddWithValue("@beden", bedent.Text);
                    con.ExecuteNonQuery();
                    listele();
                    bedent.Text = "";
                    MessageBox.Show("Beden Eklendi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beden Ekleme İşlemi Başarısız");
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
                    cmd = new SQLiteCommand("Delete From bedenler where beden='" + bedenlerlb.SelectedItem + "'", baglan);
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
    }
}
