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
    public partial class AdminDers : Form
    {
        public AdminDers()
        {
            InitializeComponent();
        }

        private void dersgeributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void derseklebutton_Click(object sender, EventArgs e)
        {
            if (derseklefakultenotxt.Text != "" && derseklebolumnotxt.Text != "" && derseklederskodutxt.Text != "" && dersekledersadıtxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dersi Eklemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Ders` (`fakulte_no`,`bolum_no`, `ders_kodu`,`ders_ad`) values('" + derseklefakultenotxt.Text + "','" + derseklebolumnotxt.Text + "','" + derseklederskodutxt.Text + "','" + dersekledersadıtxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Başarıyla Eklendi");
                    else
                        MessageBox.Show("Ders Eklenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (derseklefakultenotxt.Text == "") MessageBox.Show("Fakülte Numarası Boş Bırakılamaz");
            else if (derseklebolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası  Boş Bırakılamaz");
            else if (derseklederskodutxt.Text == "") MessageBox.Show("Ders Kodu Boş Bırakılamaz");
            else if (dersekledersadıtxt.Text == "") MessageBox.Show("Ders Adı Boş Bırakılamaz");

        }
    }
}
