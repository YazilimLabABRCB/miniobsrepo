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
using MySql.Data;

namespace YazılımlabABRCB
{
    public partial class AdminBolum : Form
    {
        public AdminBolum()
        {
            InitializeComponent();
        }

        private void AdminBolum_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            bolumguncellebolumaditxt.Visible = false;
            bolumguncellebolumnotxt.Visible = false;
            bolumguncellefakultenotxt.Visible = false;
            bolumguncellebutton.Visible = false;
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
            
            if ( bolumeklebolumnotxt.Text != "" && bolumeklefakultenotxt.Text != "" && bolumeklebolumadtxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Bölümü Eklemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Bolum` (`bolum_no`,`fakulte_no`, `bolum_ad`) values('" + bolumeklebolumnotxt.Text + "','" + bolumeklefakultenotxt.Text + "','" + bolumeklebolumadtxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Bölüm Başarıyla Eklendi");
                    else
                        MessageBox.Show("Bölüm Eklenirken bir hata oluştu");
                    Globals.con.Close();
                    

                }
            }
            else if (bolumeklefakultenotxt.Text == "") MessageBox.Show("Fakülte Numarası Boş Bırakılamaz");
            else if (bolumeklebolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası  Boş Bırakılamaz");
            else if (bolumeklebolumadtxt.Text == "") MessageBox.Show("Bölüm Adı Boş Bırakılamaz");
            
        }

        private void bolumsilmebutton_Click(object sender, EventArgs e)
        {
            if (bolumsilbolumnotxt.Text != "" )
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Bölümü Silmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand sil = new MySqlCommand("delete from `Bolum` where bolum_no=('" + bolumsilbolumnotxt.Text + "')", Globals.con);


                    sonuc = sil.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Bölüm Başarıyla Silindi");
                    else
                        MessageBox.Show("Bölüm Silinirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (bolumsilbolumnotxt.Text == "") MessageBox.Show("Bölüm Numarası Girilmeden Silme İşlemi Gerçekleştirilemez");

        }

        private void bolumarabutton_Click(object sender, EventArgs e)
        {
            
            Globals.con.Open();
            MySqlCommand ara = new MySqlCommand("Select * from `Bolum` where bolum_no=('" + bolumarabolumnotxt.Text + "')", Globals.con);
           
            var rd = ara.ExecuteReader();
            if (rd.Read())
            {
                
                
                    
                    rd.Close();
                    ara.CommandText = "select bolum_no,fakulte_no,bolum_ad from `Bolum` where bolum_no='" + bolumarabolumnotxt.Text + "' ";
                    var dr = ara.ExecuteReader();
                    dr.Read();
                   bolumguncellebolumnotxt.Text = dr.GetString(0);
                   bolumguncellefakultenotxt.Text = dr.GetString(1);
                   bolumguncellebolumaditxt.Text = dr.GetString(2);
                
            }
            else MessageBox.Show("Bölüm Bulunamadı");
            Globals.con.Close();
            rd.Close();

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            bolumguncellebolumaditxt.Visible = true;
            bolumguncellebolumnotxt.Visible = true;
            bolumguncellefakultenotxt.Visible = true;
            bolumguncellebutton.Visible = true;
        }

        private void bolumguncellebutton_Click(object sender, EventArgs e)
        {
            if (bolumguncellebolumnotxt.Text != "" && bolumguncellefakultenotxt.Text != "" && bolumguncellebolumaditxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Bölümü Güncellemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand guncelle = new MySqlCommand("update `Bolum` set  bolum_no =" + bolumguncellebolumnotxt.Text + ",fakulte_no =" + bolumguncellefakultenotxt.Text +",bolum_ad='" + bolumguncellebolumaditxt.Text + "' where bolum_no=(" + bolumarabolumnotxt.Text + ")", Globals.con);

                    
                    sonuc = guncelle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Bölüm Başarıyla Güncellendi");
                    else
                        MessageBox.Show("Bölüm Güncellenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }

        }


        private void bolumeklekazanimbutton_Click(object sender, EventArgs e)
        {
            if (bolumeklekazanimrtxt.Text != "" )
            {
                 object sonuc = null;
   
                    Globals.con.Open();
                    MySqlCommand kazanimekle = new MySqlCommand("insert into `KazanimBolum` (`kazanimbolum_adi`, `bolum_no`) values('" + bolumeklekazanimrtxt.Text + "','" + bolumeklebolumnotxt.Text + "')", Globals.con);

                    sonuc = kazanimekle.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Kazanim Başarıyla Eklendi");
                    bolumeklekazanimrtxt.Text = "";
                }
                else
                    MessageBox.Show("Kazanim Eklenirken bir hata oluştu");
                    Globals.con.Close();
                    

                
            }
            else if (bolumeklekazanimrtxt.Text == "") MessageBox.Show("Kazanim Alanı Boş Bırakılamaz");
           
        }

        private void bolumlisteletab_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand listele = new MySqlCommand("select * from `bolumliste` ", Globals.con);

            var rd = listele.ExecuteReader();
            while (rd.Read())
            {
                
                bolumlisteledgw.Rows.Add(rd.GetString(1), rd.GetString(3), rd.GetString(0), rd.GetString(2));
             
            }
            
            Globals.con.Close();
            rd.Close();
        }
    }
}
