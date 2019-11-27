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
    public partial class AdminDonem : Form
    {
        public AdminDonem()
        {
            InitializeComponent();
        }

        private void donemgeributton_Click(object sender, EventArgs e)
        {
            AdminHomePage AdminHomePage = new AdminHomePage();
            this.Hide();
            AdminHomePage.Show();
        }
        private void AdminDonem_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            donemguncelledonemidtxt.Visible = false;
            donemguncelledonemadtxt.Visible = false;
            donemguncellebutton.Visible = false;

        }

        private void donemeklebutton_Click(object sender, EventArgs e)
        {
            if (donemekledonemidtxt.Text != "" && donemekledonemadtxt.Text != "" )
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dönemi Eklemek istediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand ekle = new MySqlCommand("insert into `Donem` (`donem_id`, `donem_ad`) values('" + donemekledonemidtxt.Text + "','" + donemekledonemadtxt.Text + "')", Globals.con);


                    sonuc = ekle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Dönem Başarıyla Eklendi");
                    else
                        MessageBox.Show("Dönem Eklenirden bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (donemekledonemidtxt.Text == "") MessageBox.Show("Dönem id Boş Bırakılmamalıdır");
            else if (donemekledonemadtxt.Text == "") MessageBox.Show("Dönem Ad Boş Bırakılmamalıdır");
            
        }

        private void donemsilmebutton_Click(object sender, EventArgs e)
        {
            if (donemsildonemidtxt.Text != "")
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dönemi Silmek İstediğinize Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand sil = new MySqlCommand("delete from `Donem` where donem_id=('" + donemsildonemidtxt.Text + "')", Globals.con);


                    sonuc = sil.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Dönem Başarıyla Silindi");
                    else
                        MessageBox.Show("Dönem Silinirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
            else if (donemsildonemidtxt.Text == "") MessageBox.Show("Dönem id Girilmeden Silme İşlemi Gerçekleştirilemez");

        }

        

        private void donemarabutton_Click(object sender, EventArgs e)
        {
            Globals.con.Open();
            MySqlCommand ara = new MySqlCommand("Select * from `Donem` where donem_id=('" + donemaradonemidtxt.Text + "')", Globals.con);

            var rd = ara.ExecuteReader();
            if (rd.Read())
            {



                rd.Close();
                ara.CommandText = "select donem_id,donem_ad from `Donem` where donem_id='" + donemaradonemidtxt.Text + "' ";
                var dr = ara.ExecuteReader();
                dr.Read();
                donemguncelledonemidtxt.Text = dr.GetString(0);
                donemguncelledonemadtxt.Text = dr.GetString(1);
                

            }
            else MessageBox.Show("Dönem Bulunamadı");
            Globals.con.Close();
            rd.Close();

            label5.Visible = true;
            label6.Visible = true;
            donemguncelledonemidtxt.Visible = true;
            donemguncelledonemadtxt.Visible = true;
            donemguncellebutton.Visible = true;
        }

        private void donemguncellebutton_Click(object sender, EventArgs e)
        {

            if (donemguncelledonemidtxt.Text != "" && donemguncelledonemadtxt.Text != "" )
            {
                DialogResult cikis = new DialogResult();
                object sonuc = null;
                cikis = MessageBox.Show("Dönemi Güncellemek İstediğinizie Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    Globals.con.Open();
                    MySqlCommand guncelle = new MySqlCommand("update `Donem` set  donem_id=" + donemguncelledonemidtxt.Text + ",donem_ad ='" + donemguncelledonemadtxt.Text + "' where donem_id=(" + donemaradonemidtxt.Text + ")", Globals.con);


                    sonuc = guncelle.ExecuteNonQuery();
                    if (sonuc != null)
                        MessageBox.Show("Dönem Başarıyla Güncellendi");
                    else
                        MessageBox.Show("Dönem Güncellenirken bir hata oluştu");
                    Globals.con.Close();
                    this.Hide();

                }
            }
        }
    }
}
