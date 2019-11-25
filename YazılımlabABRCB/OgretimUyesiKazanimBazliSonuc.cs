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

namespace YazılımlabABRCB
{
    public partial class OgretimUyesiKazanimBazliSonuc : Form
    {

		string DosyaAdi;
		bool dahaoncedenacildiMi = false;

		public OgretimUyesiKazanimBazliSonuc()
        {
            InitializeComponent();
        }


		private void OgretimUyesiKazanimBazliSonuc_Load(object sender, EventArgs e)
		{
			label1.Visible = false;
		}

		private void açToolStripButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Metin Belgesi (*.txt) | *.txt";
			openFileDialog1.FileName = "";

			if (openFileDialog1.ShowDialog() == DialogResult.OK) //OK, YES ise load yap.
			{
				// MessageBox.Show(openFileDialog1.FileName);
				listBox1.Items.Add(openFileDialog1.FileName);
				DosyaAdi = Path.GetFileName(openFileDialog1.FileName);
				progressBar1.Value = 100;
				label1.Visible = true;
				label1.Text = "Yüklendi";
			}
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int secim = listBox1.SelectedIndex;
			if (secim!=-1)
			{
				listBox1.Items.RemoveAt(secim);
			}
			else
			{
				MessageBox.Show("Silinecek item belirtilmedi veya boş!", "Hata: Boş seçim", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(listBox1, e.X, e.Y);
				//contextMenuStrip1.Show(listBox1, new Point(e.X, e.Y)); pointler arası çakışma var!!!
			}
		}

		private void tümünüSilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
