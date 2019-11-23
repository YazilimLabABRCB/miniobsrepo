using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YazılımlabABRCB
{
    public partial class Login : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void admingirisbutton_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from Admin where admin_id='" + adminnotextbox.Text + "'and admin_pw='" + adminsifretextbox.Text + "'";
            dr = cmd.ExecuteReader();
            if (adminnotextbox.Text == "" || adminsifretextbox.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Doldurun");
            }
            else if (dr.Read())
            {
                AdminHomePage AdminHomePage = new AdminHomePage();
                this.Hide();
                AdminHomePage.Show();
            }
            else MessageBox.Show("Hatalı Giriş Yaptınız! Tekrar Deneyiniz");

            Globals.con.Close();

        }

        private void ogretimuyesigirisbutton_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            Globals.con.Open();
            cmd.Connection = Globals.con;
            cmd.CommandText = "Select * from Kullanici where sicil_no='" + ogretimuyesinotextbox.Text + "'and kullanici_pw='" + ogretimuyesisifretextbox.Text + "'";
            dr = cmd.ExecuteReader();
            if (ogretimuyesinotextbox.Text == "" || ogretimuyesisifretextbox.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Doldurun");
            }
            else if (dr.Read())
            {
                OgretimUyesiHomePage OgretimUyesiHomePage = new OgretimUyesiHomePage();
                this.Hide();
                OgretimUyesiHomePage.Show();
            }
            else MessageBox.Show("Hatalı Giriş Yaptınız! Tekrar Deneyiniz");
            Globals.con.Close();
        }
    }
}
