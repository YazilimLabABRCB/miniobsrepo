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
    public partial class OgretimUyesiTestOkutma : Form
    {
        public OgretimUyesiTestOkutma()
        {
            InitializeComponent();
        }

		string DosyaAdi;

		private void OgretimUyesiTestOkutma_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
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
	}
}
