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
    }
}
