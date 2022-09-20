using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SST
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        stok stok = new stok();

        private void stockb_Click(object sender, EventArgs e)
        {
            stok.ShowDialog();
        }

        ayarlar ayarlar = new ayarlar();

        private void settingb_Click(object sender, EventArgs e)
        {
            ayarlar.ShowDialog();
        }

        musteri musteri = new musteri();

        private void customersb_Click(object sender, EventArgs e)
        {
            musteri.ShowDialog();
        }
    }
}
