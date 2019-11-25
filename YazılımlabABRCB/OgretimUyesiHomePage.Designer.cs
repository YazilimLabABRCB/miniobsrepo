namespace YazılımlabABRCB
{
    partial class OgretimUyesiHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.kAZANIMBAZLISONUÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sORUBAZLISONUÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tESTOKUTMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAZANIMBAZLISONUÇToolStripMenuItem,
            this.sORUBAZLISONUÇToolStripMenuItem,
            this.tESTOKUTMAToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(689, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// kAZANIMBAZLISONUÇToolStripMenuItem
			// 
			this.kAZANIMBAZLISONUÇToolStripMenuItem.Name = "kAZANIMBAZLISONUÇToolStripMenuItem";
			this.kAZANIMBAZLISONUÇToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
			this.kAZANIMBAZLISONUÇToolStripMenuItem.Text = "KAZANIM BAZLI SONUÇ";
			this.kAZANIMBAZLISONUÇToolStripMenuItem.Click += new System.EventHandler(this.kAZANIMBAZLISONUÇToolStripMenuItem_Click);
			// 
			// sORUBAZLISONUÇToolStripMenuItem
			// 
			this.sORUBAZLISONUÇToolStripMenuItem.Name = "sORUBAZLISONUÇToolStripMenuItem";
			this.sORUBAZLISONUÇToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
			this.sORUBAZLISONUÇToolStripMenuItem.Text = "SORU BAZLI SONUÇ";
			this.sORUBAZLISONUÇToolStripMenuItem.Click += new System.EventHandler(this.sORUBAZLISONUÇToolStripMenuItem_Click);
			// 
			// tESTOKUTMAToolStripMenuItem
			// 
			this.tESTOKUTMAToolStripMenuItem.Name = "tESTOKUTMAToolStripMenuItem";
			this.tESTOKUTMAToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.tESTOKUTMAToolStripMenuItem.Text = "TEST OKUTMA";
			this.tESTOKUTMAToolStripMenuItem.Click += new System.EventHandler(this.tESTOKUTMAToolStripMenuItem_Click);
			// 
			// OgretimUyesiHomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 440);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "OgretimUyesiHomePage";
			this.ShowIcon = false;
			this.Text = "Kullanıcı - Home Page";
			this.Load += new System.EventHandler(this.OgretimUyesiHomePage_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem kAZANIMBAZLISONUÇToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sORUBAZLISONUÇToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tESTOKUTMAToolStripMenuItem;
	}
}