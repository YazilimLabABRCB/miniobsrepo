using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using PowerPivotExcelClientAddInLib;

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
		public void ExcelAc()
		{
			
		}
		public void DosyaSec()
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			if (openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
			{
				this.textBox1.Text = openFileDialog1.FileName;
			}
		}
		public void TestKontrol()
		{
			
		}

		private void OgretimUyesiSoruBazliSonuc_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
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
