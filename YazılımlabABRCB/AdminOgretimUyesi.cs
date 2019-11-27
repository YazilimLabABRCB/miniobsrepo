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
        private void AdminOgretimUyesi_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            ogretimuyesiguncellesicilnotxt.Visible = false;
            ogretimuyesiguncelleadtxt.Visible = false;
            ogretimuyesiguncellesoyadtxt.Visible = false;
            ogretimuyesiguncellesifretxt.Visible = false;
            ogretimuyesiguncellebutton.Visible = false;
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

        private void ogretimuyesisilmebutton_Click(object sender, EventArgs e)
        {
            if (ogretimuyesisilsicilnotxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dönemi Silmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand sil = new MySqlCommand("delete from `Kullanici` where sicil_no=('" + ogretimuyesisilsicilnotxt.Text + "')", Globals.con);


                    sonuc = sil.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Öğretim Üyesi Başarıyla Silindi");
                    else
                        MessageBox.Show("Öğretim Üyesi Silinirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (ogretimuyesisilsicilnotxt.Text == "") MessageBox.Show("Sicil Numarası Girilmeden Silme İşlemi Gerçekleştirilemez");
        }

        private void kullanıcıarabutton_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand ara = new MySqlCommand("Select * from `Kullanici` where sicil_no=('" + ogretimuyesiarasicilnotxt.Text + "')", Globals.con);

            var rd = ara.ExecuteReader();
            if (rd.Read())
            {



                rd.Close();
                ara.CommandText = "select sicil_no,kullanici_ad,kullanici_soyad,kullanici_pw from `Kullanici` where sicil_no='" + ogretimuyesiarasicilnotxt.Text + "' ";
                var dr = ara.ExecuteReader();
                dr.Read();
                ogretimuyesiguncellesicilnotxt.Text = dr.GetString(0);
                ogretimuyesiguncelleadtxt.Text = dr.GetString(1);
                ogretimuyesiguncellesoyadtxt.Text = dr.GetString(2);
                ogretimuyesiguncellesifretxt.Text = dr.GetString(3);

            }
            else MessageBox.Show("Öğretim Üyesi Bulunamadı");
            Globals.con.Close();
            rd.Close();

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            ogretimuyesiguncellesicilnotxt.Visible = true;
            ogretimuyesiguncelleadtxt.Visible = true;
            ogretimuyesiguncellesoyadtxt.Visible = true;
            ogretimuyesiguncellesifretxt.Visible = true;
            ogretimuyesiguncellebutton.Visible = true;
        }

        private void ogretimuyesiguncellebutton_Click(object sender, EventArgs e)
        {
            if (ogretimuyesiguncellesicilnotxt.Text != "" && ogretimuyesiguncelleadtxt.Text != "" && ogretimuyesiguncellesoyadtxt.Text != "" && ogretimuyesiguncellesifretxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Öğretim Üyesini Güncellemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand guncelle = new MySqlCommand("update `Kullanici` set  sicil_no =" + ogretimuyesiguncellesicilnotxt.Text + ",kullanici_ad ='" + ogretimuyesiguncelleadtxt.Text + "',kullanici_soyad='" + ogretimuyesiguncellesoyadtxt.Text + "',kullanici_pw='" + ogretimuyesiguncellesifretxt.Text + "' where sicil_no=(" + ogretimuyesiarasicilnotxt.Text + ")", Globals.con);


                    sonuc = guncelle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Öğretim Üyesi Başarıyla Güncellendi");
                    else
                        MessageBox.Show("Öğretim  Üyesi Güncellenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }

        }

        private void ogretimuyesilisteletab_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand listele = new MySqlCommand("select * from Kullanici", Globals.con);
            var dr = listele.ExecuteReader();
            while (dr.Read())
            {
                ogretimuyesilisteledgw.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
            
            }
            dr.Close();
            Globals.con.Close();
        }   
    }
}
