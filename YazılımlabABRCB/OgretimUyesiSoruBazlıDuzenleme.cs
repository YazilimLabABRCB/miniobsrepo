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

		public void Yukle()
		{
			toolStripTextBox1.Text = degergonder;
			var lines = File.ReadAllLines(toolStripTextBox1.Text, Encoding.GetEncoding("iso-8859-9"));
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

		public void DataGridGuncelle()
		{
			try
			{
				TextWriter writer = new StreamWriter(toolStripTextBox1.Text);
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + ";");
					}
					Console.WriteLine("");
				}
				writer.Close();
				MessageBox.Show("Güncelleme başarılı");

			}
			catch (ArgumentNullException)
			{
				MessageBox.Show("Değer girilmedi!");
			}
			catch (FormatException)
			{
				MessageBox.Show("Hatalı türde veri girildi!");
			}
			catch (OverflowException)
			{
				MessageBox.Show("Girilen değer çok büyük!");
			}
			finally
			{
				TextWriter writerfinal = new StreamWriter(toolStripTextBox1.Text);
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						writerfinal.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + ";");
					}
					Console.WriteLine("");
				}
			}
		}

		private void OgretimUyesiSoruBazlıDuzenleme_Load(object sender, EventArgs e)
		{
			Yukle();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void kaydetToolStripButton_Click(object sender, EventArgs e)
		{
			DataGridGuncelle();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
