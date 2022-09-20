using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST
{
    public partial class ayarlar : Form
    {
        public ayarlar()
        {
            InitializeComponent();
        }

        renkler renkler = new renkler();

        private void renkayarb_Click(object sender, EventArgs e)
        {
            renkler.ShowDialog();
        }

        bedenler bedenler = new bedenler();

        private void bedenayarb_Click(object sender, EventArgs e)
        {
            bedenler.ShowDialog();
        }
    }
}
