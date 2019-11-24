using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YazılımlabABRCB
{
    public partial class AdminBolum : Form
    {
        public AdminBolum()
        {
            InitializeComponent();
        }

        private void bolumgeributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void bolumgeributton1_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void bolumgeributton2_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void bolumgeributton3_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void bolumeklebutton_Click(object sender, EventArgs e)
        {
            
            if ( bolumeklebolumnotxt.Text != "" && bolumeklefakulteidtxt.Text != "" && bolumeklebolumadtxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Bölümü Eklemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Bolum` (`bolum_no`,`fakulte_no`, `bolum_ad`) values('" + bolumeklebolumnotxt.Text + "','" + bolumeklefakulteidtxt.Text + "','" + bolumeklebolumadtxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Bölüm Başarıyla Eklendi");
                    else
                        MessageBox.Show("Bölüm Eklenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (bolumeklefakulteidtxt.Text == "") MessageBox.Show("Fakülte Numarası Boş Bırakılamaz");
            else if (bolumeklebolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası  Boş Bırakılamaz");
            else if (bolumeklebolumadtxt.Text == "") MessageBox.Show("Bölüm Adı Boş Bırakılamaz");
            
        }
    }
}
