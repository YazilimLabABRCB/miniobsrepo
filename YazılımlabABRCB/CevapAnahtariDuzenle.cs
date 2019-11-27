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

namespace YazılımlabABRCB
{
	public partial class CevapAnahtariDuzenle : Form
	{
		public CevapAnahtariDuzenle()
		{
			InitializeComponent();
		}

		public void DataGridGuncelle()
		{
			try
			{
				TextWriter writer = new StreamWriter(cvpanahtariduzenleTxt.Text);
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					for (int j = 0; j < dataGridView1.Columns.Count; j++)
					{
						if (j == dataGridView1.Columns.Count - 1)
						{
							writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\n");
						}
						else
						writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString()+";");
						
					}
					

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
		}
		public void DataGridAtama()
		{
			var lines = File.ReadAllLines(cvpanahtariduzenleTxt.Text, Encoding.GetEncoding("iso-8859-9"));
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
		public string cvpduzenle { get; set; }

		private void CevapAnahtariDuzenle_Load(object sender, EventArgs e)
		{
			cvpanahtariduzenleTxt.Text = cvpduzenle;
			DataGridAtama();
		}

		private void cvpanahtarionayBtn_Click(object sender, EventArgs e)
		{
			DataGridGuncelle();
		}
	}
}
