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
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            dersatamaguncellesicilnotxt.Visible = false;
            dersatamaguncellebolumnotxt.Visible = false;
            dersatamaguncelledonemidtxt.Visible = false;
            dersatamaguncellederskodutxt.Visible = false;
            dersatamaguncellebutton.Visible = false;

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

        private void dersatamasilmebutton_Click(object sender, EventArgs e)
        {
            if (dersatamasilsicilnotxt.Text != "" && dersatamasilbolumnotxt.Text != "" && dersatamasildonemidtxt.Text != "" && dersatamasilderskodutxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dersi Atamayı Silmek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand sil = new MySqlCommand("delete from `Atama` where sicil_no=('" + dersatamasilsicilnotxt.Text + "') and bolum_no=('" + dersatamasilbolumnotxt.Text + "') and donem_id=('" + dersatamasildonemidtxt.Text + "') and ders_kodu=('" + dersatamasilderskodutxt.Text + "')", Globals.con);


                    sonuc = sil.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Atama Silme Başarıyla Gerçekleşti");
                    else
                        MessageBox.Show("Ders Atama Silinirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (dersatamasicilnotxt.Text == "") MessageBox.Show("Sicil Numarası Boş Bırakılamaz");
            else if (dersatamabolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası  Boş Bırakılamaz");
            else if (dersatamadonemidtxt.Text == "") MessageBox.Show("Dönem id Boş Bırakılamaz");
            else if (dersatamaderskodutxt.Text == "") MessageBox.Show("Ders Kodu Boş Bırakılamaz");
        }

        private void dersatamaarabutton_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand ara = new MySqlCommand("Select * from `Atama` where sicil_no=('" + dersatamaarasicilnotxt.Text + "')", Globals.con);

            var rd = ara.ExecuteReader();
            if (rd.Read())
            {



                rd.Close();
                ara.CommandText = "select sicil_no,bolum_no,donem_id,ders_kodu from `Atama` where sicil_no='" + dersatamaarasicilnotxt.Text + "' ";
                var dr = ara.ExecuteReader();
                dr.Read();
                dersatamaguncellesicilnotxt.Text = dr.GetString(0);
                dersatamaguncellebolumnotxt.Text = dr.GetString(1);
                dersatamaguncelledonemidtxt.Text = dr.GetString(2);
                dersatamaguncellederskodutxt.Text = dr.GetString(3);

            }
            else MessageBox.Show("Öğretim Üyesi Bulunamadı");
            Globals.con.Close();
            rd.Close();

            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            dersatamaguncellesicilnotxt.Visible = true;
            dersatamaguncellebolumnotxt.Visible = true;
            dersatamaguncelledonemidtxt.Visible = true;
            dersatamaguncellederskodutxt.Visible = true;
            dersatamaguncellebutton.Visible = true;

        }

        private void dersatamaguncellebutton_Click(object sender, EventArgs e)
        {

            if (dersatamaguncellesicilnotxt.Text != "" && dersatamaguncellebolumnotxt.Text != "" && dersatamaguncelledonemidtxt.Text != "" && dersatamaguncellederskodutxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Ders Atamayı Güncellemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand guncelle = new MySqlCommand("update `Atama` set  sicil_no =" + dersatamaguncellesicilnotxt.Text + ",bolum_no =" + dersatamaguncellebolumnotxt.Text + ",donem_id='" + dersatamaguncelledonemidtxt.Text + "',ders_kodu='" + dersatamaguncellederskodutxt.Text + "' where sicil_no=(" + dersatamaarasicilnotxt.Text + ")", Globals.con);


                    sonuc = guncelle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Ders Atama Başarıyla Güncellendi");
                    else
                        MessageBox.Show("Ders Atama Güncellenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
        }
    }
    }

