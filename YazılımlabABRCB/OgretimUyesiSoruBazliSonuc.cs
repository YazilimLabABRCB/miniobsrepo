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

namespace YazılımlabABRCB
{
    public partial class OgretimUyesiSoruBazliSonuc : Form
    {
        public OgretimUyesiSoruBazliSonuc()
        {
            InitializeComponent();
        }

		string DosyaAdi;

		private void OgretimUyesiSoruBazliSonuc_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var lines = File.ReadAllLines(textBox1.Text, Encoding.GetEncoding("iso-8859-9"));
			if (lines.Count() > 0)
			{
				foreach (var columnName in lines.FirstOrDefault()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
				{
					dataGridView1.Columns.Add(columnName, columnName);
				}
				foreach (var cellValues in lines.Skip(1))
				{
					var cellArray = cellValues
						.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					if (cellArray.Length == dataGridView1.Columns.Count)
						dataGridView1.Rows.Add(cellArray);
				}
			}

			
			/*
			string rLine;
			string[] satirDizi;
			int i = 0;
			DataRow dRow;
			DataTable dt = new DataTable();
			try
			{

				if (File.Exists(textBox1.Text))
				{
					StreamReader reader = File.OpenText(textBox1.Text);
					rLine = reader.ReadLine();
					satirDizi = rLine.Split('t');

					for (int m = 0; m < satirDizi.Length; m++)
					{
						dt.Columns.Add(satirDizi[m]);
					}

					while (rLine != null)
					{
						dRow = dt.NewRow();
						dt.Rows.Add(dRow);
						rLine = reader.ReadLine();

						if (rLine != null)
						{
							satirDizi = rLine.Split('t');
						}

						for (int j = 0; j < satirDizi.Length; j++)
						{
							dt.Rows[j]=;
						}
						i++;
					}

					dataGridView1.DataSource = dt;
					reader.Close();
				}
				else
					MessageBox.Show("Dosya Bulunamadı...", "Error");
			}

			catch (Exception ex)

			{
				MessageBox.Show("Hata :" + ex.ToString(), "Error");
			}
			*/
		}

		private void button2_Click(object sender, EventArgs e)
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
