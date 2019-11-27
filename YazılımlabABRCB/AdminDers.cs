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

        private void AdminDers_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            dersguncellefakultenotxt.Visible = false;
            dersguncellebolumnotxt.Visible = false;
            dersguncellederskodutxt.Visible = false;
            dersguncelledersadtxt.Visible = false;
            dersguncellebutton.Visible = false;
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

        private void derssilmebutton_Click(object sender, EventArgs e)
        {
            if (derssilderskodutxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dersi Silmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand sil = new MySqlCommand("delete from `Ders` where ders_kodu =('" + derssilderskodutxt.Text + "')", Globals.con);


                    sonuc = sil.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Başarıyla Silindi");
                    else
                        MessageBox.Show("Ders Silinirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (derssilderskodutxt.Text == "") MessageBox.Show("Ders Kodu Girilmeden Silme İşlemi Gerçekleştirilemez");

        }

        private void dersarabutton_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand ara = new MySqlCommand("Select * from `Ders` where ders_kodu=('" + dersaraderskodutxt.Text + "')", Globals.con);

            var rd = ara.ExecuteReader();
            if (rd.Read())
            {



                rd.Close();
                ara.CommandText = "select fakulte_no,bolum_no,ders_kodu,ders_ad from `Ders` where ders_kodu='" + dersaraderskodutxt.Text + "' ";
                var dr = ara.ExecuteReader();
                dr.Read();
                dersguncellefakultenotxt.Text = dr.GetString(0);
                dersguncellebolumnotxt.Text = dr.GetString(1);
                dersguncellederskodutxt.Text = dr.GetString(2);
                dersguncelledersadtxt.Text = dr.GetString(3);

            }
            else MessageBox.Show("Bölüm Bulunamadı");
            Globals.con.Close();
            rd.Close();

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            dersguncellefakultenotxt.Visible = true;
            dersguncellebolumnotxt.Visible = true;
            dersguncellederskodutxt.Visible = true;
            dersguncelledersadtxt.Visible = true;
            dersguncellebutton.Visible = true;

        }

        private void dersguncellebutton_Click(object sender, EventArgs e)
        {
            if (dersguncellefakultenotxt.Text != "" && dersguncellebolumnotxt.Text != "" && dersguncellederskodutxt.Text != "" && dersguncelledersadtxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dersi Güncellemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand guncelle = new MySqlCommand("update `Ders` set  fakulte_no =" + dersguncellefakultenotxt.Text + ", bolum_no=" + dersguncellebolumnotxt.Text + ",ders_kodu='" + dersguncellederskodutxt.Text + "',ders_ad='" + dersguncelledersadtxt.Text + "' where ders_kodu=(" + dersaraderskodutxt.Text + ")", Globals.con);


                    sonuc = guncelle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Başarıyla Güncellendi");
                    else
                        MessageBox.Show("Ders Güncellenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
        }

        private void derseklekazanimeklebutton_Click(object sender, EventArgs e)
        {
            if (derseklekazanimrtxt.Text != "")
            {
                object sonuc = null;

                Globals.con.Open();
                MySqlCommand kazanimekle = new MySqlCommand("insert into `KazanimDers` (`kazanimders_adi`, `ders_kodu`) values('" + derseklekazanimrtxt.Text + "','" + derseklederskodutxt.Text + "')", Globals.con);

                sonuc = kazanimekle.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Kazanim Başarıyla Eklendi");
                    derseklekazanimrtxt.Text = "";
                }
                else
                    MessageBox.Show("Kazanim Eklenirken bir hata oluştu");
                Globals.con.Close();



            }
            else if (derseklekazanimrtxt.Text == "") MessageBox.Show("Kazanim Alanı Boş Bırakılamaz");

        }

        private void derslisteletab_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand listele = new MySqlCommand("select * from `dersliste` ", Globals.con);

            var rd = listele.ExecuteReader();
            while (rd.Read())
            {
                
                derslisteledgw.Rows.Add(rd.GetString(0), rd.GetString(4), rd.GetString(1), rd.GetString(5),rd.GetString(2), rd.GetString(3));

            }

            Globals.con.Close();
            rd.Close();
        }
    }
}

           