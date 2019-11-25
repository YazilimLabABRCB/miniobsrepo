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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void bolumbutton_Click(object sender, EventArgs e)
        {
            AdminBolum AdminBolum = new AdminBolum();
            this.Hide();
            AdminBolum.Show();

        }

        private void dersbutton_Click(object sender, EventArgs e)
        {
            AdminDers AdminDers = new AdminDers();
            this.Hide();
            AdminDers.Show();

        }

        private void dersatamabutton_Click(object sender, EventArgs e)
        {
            AdminDersAtama AdminDersAtama = new AdminDersAtama();
            this.Hide();
            AdminDersAtama.Show();

        }

        private void donembutton_Click(object sender, EventArgs e)
        {
            AdminDonem AdminDonem = new AdminDonem();
            this.Hide();
            AdminDonem.Show();

        }

        private void kullanicibutton_Click(object sender, EventArgs e)
        {
            AdminOgretimUyesi AdminKullanıcı = new AdminOgretimUyesi();
            this.Hide();
            AdminKullanıcı.Show();

        }

        private void sınavsonucbutton_Click(object sender, EventArgs e)
        {
            AdminSınavSonuc AdminSınavSonuc = new AdminSınavSonuc();
            this.Hide();
            AdminSınavSonuc.Show();

        }
    }
}
