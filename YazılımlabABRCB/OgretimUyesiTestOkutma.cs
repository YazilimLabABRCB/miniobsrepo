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
    public partial class OgretimUyesiTestOkutma : Form
    {
        public OgretimUyesiTestOkutma()
        {
            InitializeComponent();
        }

		//Genel tanımlamalar
		string DosyaAdi;

		private void OgretimUyesiTestOkutma_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text!="" && textBox2.Text!="")
			{
				var ogrencisonuc = File.ReadLines(textBox1.Text, Encoding.GetEncoding("iso-8859-9"));
				var cevapanahtari = File.ReadLines(textBox2.Text, Encoding.GetEncoding("iso-8859-9"));
				foreach (var ogrsonuc in ogrencisonuc)
				{
					listBox1.Items.Add(ogrsonuc);
				}

				foreach (var cvpanahtari in cevapanahtari)
				{
					listBox2.Items.Add(cvpanahtari);
				}
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

		private void button3_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Metin Belgesi(*.txt) | *.txt";
			openFileDialog1.FileName = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) //OK, YES ise load yap.
			{
				// MessageBox.Show(openFileDialog1.FileName);
				textBox2.Text = openFileDialog1.FileName;
				DosyaAdi = Path.GetFileName(openFileDialog1.FileName);
				//progressBar1.Value = 100;
			}
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int secim = listBox1.SelectedIndex;
			if (secim != -1)
			{
				listBox1.Items.RemoveAt(secim);
			}
			else
			{
				MessageBox.Show("Silinecek item belirtilmedi veya boş!", "Hata: Boş seçim", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(listBox1, e.X, e.Y);
				//contextMenuStrip1.Show(listBox1, new Point(e.X, e.Y)); pointler arası çakışma var!!!
			}
		}

		private void listBox2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip2.Show(listBox2, e.X, e.Y);
				//contextMenuStrip1.Show(listBox1, new Point(e.X, e.Y)); pointler arası çakışma var!!!
			}
		}

		private void silToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int scm = listBox2.SelectedIndex;
			if (scm != -1)
			{
				listBox2.Items.RemoveAt(scm);
			}
			else
			{
				MessageBox.Show("Silinecek item belirtilmedi veya boş!", "Hata: Boş seçim", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tümünüTemizleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
		}
	}
}
