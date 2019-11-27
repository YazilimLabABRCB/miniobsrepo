using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
//using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace YazılımlabABRCB
{
	public partial class OgretimUyesiSoruBazlıDuzenleme : Form
	{
		public OgretimUyesiSoruBazlıDuzenleme()
		{
			InitializeComponent();
		}

		public string degergonder;
		public string DosyaAdi;

		MySqlCommand komut;
		MySqlDataAdapter da;
		DataSet ds;
		bool degisim = false;
		MySqlConnection baglanti = new MySqlConnection();

		private void OgretimUyesiSoruBazlıDuzenleme_Load(object sender, EventArgs e)
		{
			
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void kaydetToolStripButton_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
