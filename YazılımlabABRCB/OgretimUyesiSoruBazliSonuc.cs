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
	public partial class OgretimUyesiSoruBazliSonuc : Form
    {
        public OgretimUyesiSoruBazliSonuc()
        {
            InitializeComponent();
        }
		string DosyaAdi;

		public void DuzenlemeSayfasiAc()
		{
			if (textBox1.Text!="")
			{
				OgretimUyesiSoruBazlıDuzenleme duzenle = new OgretimUyesiSoruBazlıDuzenleme();
				duzenle.degergonder = textBox1.Text;
				duzenle.ShowDialog();
			}
			else
			{
				MessageBox.Show("Seçim boş!");
			}
			
		}
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
		public void DosyaSec()
		{
			openFileDialog1.Filter = "Metin Belgesi(*.txt) | *.txt";
			openFileDialog1.FileName = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) //OK, YES ise load yap.
			{
				// MessageBox.Show(openFileDialog1.FileName);
				textBox1.Text = openFileDialog1.FileName;
				DosyaAdi = Path.GetFileName(openFileDialog1.FileName);
				//progressBar1.Value = 100;
			}
		}
		public void DataGridAtama()
		{
			var lines = File.ReadAllLines(textBox1.Text, Encoding.GetEncoding("iso-8859-9"));
			if (lines.Count() > 0)
			{
				foreach (
					var columnName in lines.FirstOrDefault()
					.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
				)
				{
					dataGridView1.Columns.Add(columnName, columnName);
				}
				foreach (var cellValues in lines.Skip(1))
				{
					var cellArray = cellValues
						.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					if (cellArray.Length == dataGridView1.Columns.Count)
						dataGridView1.Rows.Add(cellArray);
				}
			}
		}

		private void OgretimUyesiSoruBazliSonuc_Load(object sender, EventArgs e)
		{
			DonemSec();
			SinavTuruSec();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//DataGridAtama();
			DuzenlemeSayfasiAc();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DosyaSec();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
