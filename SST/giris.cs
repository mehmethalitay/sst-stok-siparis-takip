using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SST
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        menu menu = new menu();

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void loginb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu.ShowDialog();
            this.Visible = true;
        }
    }
}
