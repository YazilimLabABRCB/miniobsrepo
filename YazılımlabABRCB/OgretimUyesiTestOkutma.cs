using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.IO;
using MySql.Data.MySqlClient;

namespace YazılımlabABRCB
{
    public partial class OgretimUyesiTestOkutma : Form
    {
        public OgretimUyesiTestOkutma()
        {
            InitializeComponent();
        }

		//Genel tanımlamalar
		string DosyaAdi;

		public void DonemSec()
		{
			MySqlConnection baglanti = new MySqlConnection();
			baglanti.ConnectionString = "Server = localhost; Database = TestOtomasyon; user = root; pwd = 'R.cnkb0z'; ";
			MySqlCommand donemad = new MySqlCommand();
			donemad.CommandText = "SELECT donem_ad FROM Donem";
			donemad.Connection = baglanti;
			donemad.CommandType = CommandType.Text;

			MySqlDataReader dr;
			baglanti.Open();
			dr = donemad.ExecuteReader();

			while (dr.Read())
			{
				donemsecCmb.Items.Add(dr["donem_ad"]);
			}

			baglanti.Close();
		}
		public void SinavTuruSec()
		{
			MySqlConnection bgl = new MySqlConnection();
			bgl.ConnectionString = "Server = localhost; Database = TestOtomasyon; user = root; pwd = 'R.cnkb0z'; ";
			MySqlCommand sinavturad = new MySqlCommand();
			sinavturad.CommandText = "SELECT sinavtur_ad FROM Sinavturu";
			sinavturad.Connection = bgl;
			sinavturad.CommandType = CommandType.Text;

			MySqlDataReader dr1;
			bgl.Open();
			dr1 = sinavturad.ExecuteReader();

			while (dr1.Read())
			{
				sinavturusecCmb.Items.Add(dr1["sinavtur_ad"]);
			}

			bgl.Close();
		}
		public void DersSec()
		{
			MySqlConnection derssec = new MySqlConnection();
			derssec.ConnectionString = "Server = localhost; Database = TestOtomasyon; user = root; pwd = 'R.cnkb0z'; ";
			MySqlCommand donemad = new MySqlCommand();
			donemad.CommandText = "SELECT ders_ad FROM Ders";
			donemad.Connection = derssec;
			donemad.CommandType = CommandType.Text;

			MySqlDataReader dr;
			derssec.Open();
			dr = donemad.ExecuteReader();

			while (dr.Read())
			{
				derssecCmb.Items.Add(dr["ders_ad"]);
			}

			derssec.Close();
		}
		public void BolumSec()
		{
			MySqlConnection derssec = new MySqlConnection();
			derssec.ConnectionString = "Server = localhost; Database = TestOtomasyon; user = root; pwd = 'R.cnkb0z'; ";
			MySqlCommand donemad = new MySqlCommand();
			donemad.CommandText = "SELECT bolum_ad FROM Bolum";
			donemad.Connection = derssec;
			donemad.CommandType = CommandType.Text;

			MySqlDataReader dr;
			derssec.Open();
			dr = donemad.ExecuteReader();

			while (dr.Read())
			{
				bolumsecCmb.Items.Add(dr["bolum_ad"]);
			}

			derssec.Close();
		}
		public void DisableBtn()
		{
			ogrcevapsecBtn.Enabled = false;
			cvpanahtarisecBtn.Enabled = false;
			sonucgosterBtn.Enabled = false;
		}
		public void EnableBtn()
		{
			ogrcevapsecBtn.Enabled = true;
			cvpanahtarisecBtn.Enabled = true;
			sonucgosterBtn.Enabled = true;
		}
		public void DosyaSec1()
		{
			openFileDialog1.Filter = "Metin Belgesi(*.txt) | *.txt";
			openFileDialog1.FileName = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) //OK, YES ise load yap.
			{
				// MessageBox.Show(openFileDialog1.FileName);
				ogrencicvptxt.Text = openFileDialog1.FileName;
				DosyaAdi = Path.GetFileName(openFileDialog1.FileName);
				//progressBar1.Value = 100;
			}
		}
		public void DosyaSec2()
		{
			openFileDialog1.Filter = "Metin Belgesi(*.txt) | *.txt";
			openFileDialog1.FileName = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) //OK, YES ise load yap.
			{
				// MessageBox.Show(openFileDialog1.FileName);
				cvpanahtariTxt.Text = openFileDialog1.FileName;
				DosyaAdi = Path.GetFileName(openFileDialog1.FileName);
				//progressBar1.Value = 100;
			}
		}
		public void DuzenlemeSayfasiAc2()
		{
			if (cvpanahtariTxt.Text != "")
			{
				CevapAnahtariDuzenle cevapduzenle = new CevapAnahtariDuzenle();
				cevapduzenle.cvpduzenle = cvpanahtariTxt.Text;
				cevapduzenle.ShowDialog();
			}
			else
			{
				MessageBox.Show("Seçim boş!");
			}

		}

		public void SonucIsle()
		{
			TextReader treader = new StreamReader(cvpanahtariTxt.Text);
			string okunan = treader.ReadToEnd();
			string[] satirlar = okunan.Split(';');
		}
		private void OgretimUyesiTestOkutma_Load(object sender, EventArgs e)
		{
			SinavTuruSec();
			DonemSec();
			DersSec();
			BolumSec();
			DisableBtn();
		}
		public void DuzenlemeSayfasiAc()
		{
			if (ogrencicvptxt.Text != "")
			{
				OgrenciCevapDuzenle duzenle = new OgrenciCevapDuzenle();
				duzenle.degergonder = ogrencicvptxt.Text;
				duzenle.ShowDialog();
			}
			else
			{
				MessageBox.Show("Seçim boş!");
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ogrencicvptxt.Text!="" && cvpanahtariTxt.Text!="")
			{
				var ogrencisonuc = File.ReadLines(ogrencicvptxt.Text, Encoding.UTF8);
				var cevapanahtari = File.ReadLines(cvpanahtariTxt.Text, Encoding.UTF8);
				
				MessageBox.Show("Okuma işlemi tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Eksik bilgi girişi yapıldı. Lütfen eksik bıraktığınız kısım için dosya seçme işlemini tamamlayınız.", "Hata: Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void yeniToolStripButton_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			DosyaSec1();
			DuzenlemeSayfasiAc();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			DosyaSec2();
			DuzenlemeSayfasiAc2();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//int secim = listBox1.SelectedIndex;
			//if (secim != -1)
			{
				//listBox1.Items.RemoveAt(secim);
			}
			//else
			{
				//MessageBox.Show("Silinecek item belirtilmedi veya boş!", "Hata: Boş seçim", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//listBox1.Items.Clear();
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			//if (e.Button == MouseButtons.Right)
			{
				//contextMenuStrip1.Show(listBox1, e.X, e.Y);
				//contextMenuStrip1.Show(listBox1, new Point(e.X, e.Y)); pointler arası çakışma var!!!
			}
		}

		private void listBox2_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void silToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			
		}

		private void tümünüTemizleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void testokutmaonaylaBtn_Click(object sender, EventArgs e)
		{
			if (bolumsecCmb.SelectedItem!=null && derssecCmb.SelectedItem != null && donemsecCmb.SelectedItem != null && sinavturusecCmb.SelectedItem != null)
			{
				EnableBtn();
			}
		}
	}
}
