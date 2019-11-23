using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımlabABRCB
{
    public partial class OgretimUyesiHomePage : Form
    {
        public OgretimUyesiHomePage()
        {
            InitializeComponent();
        }

		private void kAZANIMBAZLISONUÇToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var window = Application.OpenForms.OfType<OgretimUyesiKazanimBazliSonuc>().SingleOrDefault();
			if (window == null)
			{
				window = new OgretimUyesiKazanimBazliSonuc();
				window.MdiParent = this;
				window.Show();
			}
			else
			{
				MessageBox.Show("Zaten mevcut pencere açık!", "HATA: Devam Eden İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void sORUBAZLISONUÇToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var window1 = Application.OpenForms.OfType<OgretimUyesiSoruBazliSonuc>().SingleOrDefault();
			if (window1 == null)
			{
				window1 = new OgretimUyesiSoruBazliSonuc();
				window1.MdiParent = this;
				window1.Show();
			}
			else
			{
				MessageBox.Show("Zaten mevcut pencere açık!", "HATA: Devam Eden İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tESTOKUTMAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var window2 = Application.OpenForms.OfType<OgretimUyesiTestOkutma>().SingleOrDefault();
			if (window2 == null)
			{
				window2 = new OgretimUyesiTestOkutma();
				window2.MdiParent = this;
				window2.Show();
			}
			else
			{
				MessageBox.Show("Zaten mevcut pencere açık!", "HATA: Devam Eden İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
