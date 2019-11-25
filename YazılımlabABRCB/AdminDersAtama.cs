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
    public partial class AdminDersAtama : Form
    {
        public AdminDersAtama()
        {
            InitializeComponent();
        }

        private void AdminDersAtama_Load(object sender, EventArgs e)
        {

        }

        private void dersatamageributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void dersatamabutton_Click(object sender, EventArgs e)
        {
            if (dersatamasicilnotxt.Text != "" && dersatamabolumnotxt.Text != "" && dersatamadonemidtxt.Text != "" && dersatamaderskodutxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dersi Atamak İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Atama` (`sicil_no`,`bolum_no`, `donem_id`,`ders_kodu`) values('" + dersatamasicilnotxt.Text + "','" + dersatamabolumnotxt.Text + "','" + dersatamadonemidtxt.Text + "','" + dersatamaderskodutxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Atama Başarıyla Gerçekleşti");
                    else
                        MessageBox.Show("Ders Atanırken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (dersatamasicilnotxt.Text == "") MessageBox.Show("Sicil Numarası Boş Bırakılamaz");
            else if (dersatamabolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası  Boş Bırakılamaz");
            else if (dersatamadonemidtxt.Text == "") MessageBox.Show("Dönem id Boş Bırakılamaz");
            else if (dersatamaderskodutxt.Text == "") MessageBox.Show("Ders Kodu Boş Bırakılamaz");
        }
    }
}
