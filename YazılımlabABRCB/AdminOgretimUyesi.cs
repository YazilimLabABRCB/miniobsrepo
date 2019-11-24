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
    public partial class AdminOgretimUyesi : Form
    {
        public AdminOgretimUyesi()
        {
            InitializeComponent();
        }

        public static implicit operator AdminOgretimUyesi(AdminBolum v)
        {
            throw new NotImplementedException();
        }

        private void bolumgeributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }

        private void kullanicieklemebutton_Click(object sender, EventArgs e)
        {
            if (ogretimuyesieklesicilnotxt.Text != "" && ogretimuyesiekleadtxt.Text != "" && ogretimuyesieklesoyadtxt.Text != "" && ogretimuyesieklesifretxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Öğretim Üyesini Eklemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Kullanici` (`sicil_no`,`kullanici_ad`, `kullanici_soyad`,`kullanici_pw`) values('" + ogretimuyesieklesicilnotxt.Text + "','" + ogretimuyesiekleadtxt.Text + "','" + ogretimuyesieklesoyadtxt.Text + "','" + ogretimuyesieklesifretxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Öğretim Üyesi Başarıyla Eklendi");
                    else
                        MessageBox.Show("Öğretim Üyesi Eklenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (ogretimuyesieklesicilnotxt.Text == "") MessageBox.Show("Sicil Numarası Boş Bırakılamaz");
            else if (ogretimuyesiekleadtxt.Text == "") MessageBox.Show("Ad  Boş Bırakılamaz");
            else if (ogretimuyesieklesoyadtxt.Text == "") MessageBox.Show("Soyad Boş Bırakılamaz");
            else if (ogretimuyesieklesifretxt.Text == "") MessageBox.Show("Şifre Boş Bırakılamaz");

        }
    }
}
