using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımlabABRCB
{
    public partial class AdminSınavSonuc : Form
    {
        public AdminSınavSonuc()
        {
            InitializeComponent();
        }

        private void bolumgeributton_Click(object sender, EventArgs e)
        {

        }

        private void sinavsonucgeributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }
    }
}
