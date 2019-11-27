namespace YazılımlabABRCB
{
    partial class OgretimUyesiTestOkutma
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
			this.components = new System.ComponentModel.Container();
			this.sonucgosterBtn = new System.Windows.Forms.Button();
			this.ogrencicvptxt = new System.Windows.Forms.TextBox();
			this.ogrcevapsecBtn = new System.Windows.Forms.Button();
			this.cvpanahtarisecBtn = new System.Windows.Forms.Button();
			this.cvpanahtariTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tümünüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tümünüTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.sinavturusecCmb = new System.Windows.Forms.ComboBox();
			this.donemsecCmb = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.bolumsecCmb = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.derssecCmb = new System.Windows.Forms.ComboBox();
			this.testokutmaonaylaBtn = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// sonucgosterBtn
			// 
			this.sonucgosterBtn.Location = new System.Drawing.Point(214, 131);
			this.sonucgosterBtn.Name = "sonucgosterBtn";
			this.sonucgosterBtn.Size = new System.Drawing.Size(124, 23);
			this.sonucgosterBtn.TabIndex = 1;
			this.sonucgosterBtn.Text = "İşle ve Sonucu Göster";
			this.sonucgosterBtn.UseVisualStyleBackColor = true;
			this.sonucgosterBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// ogrencicvptxt
			// 
			this.ogrencicvptxt.Enabled = false;
			this.ogrencicvptxt.Location = new System.Drawing.Point(12, 25);
			this.ogrencicvptxt.Name = "ogrencicvptxt";
			this.ogrencicvptxt.Size = new System.Drawing.Size(100, 20);
			this.ogrencicvptxt.TabIndex = 3;
			// 
			// ogrcevapsecBtn
			// 
			this.ogrcevapsecBtn.Location = new System.Drawing.Point(118, 23);
			this.ogrcevapsecBtn.Name = "ogrcevapsecBtn";
			this.ogrcevapsecBtn.Size = new System.Drawing.Size(75, 23);
			this.ogrcevapsecBtn.TabIndex = 4;
			this.ogrcevapsecBtn.Text = "Seç";
			this.ogrcevapsecBtn.UseVisualStyleBackColor = true;
			this.ogrcevapsecBtn.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// cvpanahtarisecBtn
			// 
			this.cvpanahtarisecBtn.Location = new System.Drawing.Point(320, 26);
			this.cvpanahtarisecBtn.Name = "cvpanahtarisecBtn";
			this.cvpanahtarisecBtn.Size = new System.Drawing.Size(75, 23);
			this.cvpanahtarisecBtn.TabIndex = 6;
			this.cvpanahtarisecBtn.Text = "Seç";
			this.cvpanahtarisecBtn.UseVisualStyleBackColor = true;
			this.cvpanahtarisecBtn.Click += new System.EventHandler(this.button3_Click);
			// 
			// cvpanahtariTxt
			// 
			this.cvpanahtariTxt.Enabled = false;
			this.cvpanahtariTxt.Location = new System.Drawing.Point(214, 28);
			this.cvpanahtariTxt.Name = "cvpanahtariTxt";
			this.cvpanahtariTxt.Size = new System.Drawing.Size(100, 20);
			this.cvpanahtariTxt.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Öğrenci Cevapları";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(212, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Cevap Anahtarı";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(11, 131);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(197, 23);
			this.progressBar1.TabIndex = 9;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.tümünüSilToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
			// 
			// silToolStripMenuItem
			// 
			this.silToolStripMenuItem.Name = "silToolStripMenuItem";
			this.silToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.silToolStripMenuItem.Text = "Sil";
			this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
			// 
			// tümünüSilToolStripMenuItem
			// 
			this.tümünüSilToolStripMenuItem.Name = "tümünüSilToolStripMenuItem";
			this.tümünüSilToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.tümünüSilToolStripMenuItem.Text = "Tümünü Temzile";
			this.tümünüSilToolStripMenuItem.Click += new System.EventHandler(this.tümünüSilToolStripMenuItem_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.tümünüTemizleToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(164, 48);
			// 
			// silToolStripMenuItem1
			// 
			this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
			this.silToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
			this.silToolStripMenuItem1.Text = "Sil";
			this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
			// 
			// tümünüTemizleToolStripMenuItem
			// 
			this.tümünüTemizleToolStripMenuItem.Name = "tümünüTemizleToolStripMenuItem";
			this.tümünüTemizleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.tümünüTemizleToolStripMenuItem.Text = "Tümünü Temizle";
			this.tümünüTemizleToolStripMenuItem.Click += new System.EventHandler(this.tümünüTemizleToolStripMenuItem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(595, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Sınav Türü:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(404, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Dönem:";
			// 
			// sinavturusecCmb
			// 
			this.sinavturusecCmb.FormattingEnabled = true;
			this.sinavturusecCmb.Location = new System.Drawing.Point(663, 29);
			this.sinavturusecCmb.Name = "sinavturusecCmb";
			this.sinavturusecCmb.Size = new System.Drawing.Size(133, 21);
			this.sinavturusecCmb.TabIndex = 12;
			// 
			// donemsecCmb
			// 
			this.donemsecCmb.FormattingEnabled = true;
			this.donemsecCmb.Location = new System.Drawing.Point(454, 29);
			this.donemsecCmb.Name = "donemsecCmb";
			this.donemsecCmb.Size = new System.Drawing.Size(133, 21);
			this.donemsecCmb.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(474, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Bölüm:";
			// 
			// bolumsecCmb
			// 
			this.bolumsecCmb.FormattingEnabled = true;
			this.bolumsecCmb.Location = new System.Drawing.Point(524, 70);
			this.bolumsecCmb.Name = "bolumsecCmb";
			this.bolumsecCmb.Size = new System.Drawing.Size(133, 21);
			this.bolumsecCmb.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(474, 117);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Ders:";
			// 
			// derssecCmb
			// 
			this.derssecCmb.FormattingEnabled = true;
			this.derssecCmb.Location = new System.Drawing.Point(524, 115);
			this.derssecCmb.Name = "derssecCmb";
			this.derssecCmb.Size = new System.Drawing.Size(133, 21);
			this.derssecCmb.TabIndex = 17;
			// 
			// testokutmaonaylaBtn
			// 
			this.testokutmaonaylaBtn.Location = new System.Drawing.Point(551, 155);
			this.testokutmaonaylaBtn.Name = "testokutmaonaylaBtn";
			this.testokutmaonaylaBtn.Size = new System.Drawing.Size(75, 23);
			this.testokutmaonaylaBtn.TabIndex = 19;
			this.testokutmaonaylaBtn.Text = "Onayla";
			this.testokutmaonaylaBtn.UseVisualStyleBackColor = true;
			this.testokutmaonaylaBtn.Click += new System.EventHandler(this.testokutmaonaylaBtn_Click);
			// 
			// OgretimUyesiTestOkutma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 308);
			this.Controls.Add(this.testokutmaonaylaBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.derssecCmb);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bolumsecCmb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.sinavturusecCmb);
			this.Controls.Add(this.donemsecCmb);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cvpanahtarisecBtn);
			this.Controls.Add(this.cvpanahtariTxt);
			this.Controls.Add(this.ogrcevapsecBtn);
			this.Controls.Add(this.ogrencicvptxt);
			this.Controls.Add(this.sonucgosterBtn);
			this.Name = "OgretimUyesiTestOkutma";
			this.ShowIcon = false;
			this.Text = "Kullanıcı - Test Okutma";
			this.Load += new System.EventHandler(this.OgretimUyesiTestOkutma_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button sonucgosterBtn;
		private System.Windows.Forms.Button ogrcevapsecBtn;
		private System.Windows.Forms.Button cvpanahtarisecBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tümünüSilToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tümünüTemizleToolStripMenuItem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.ComboBox sinavturusecCmb;
		public System.Windows.Forms.ComboBox donemsecCmb;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ComboBox bolumsecCmb;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox derssecCmb;
		private System.Windows.Forms.Button testokutmaonaylaBtn;
		public System.Windows.Forms.TextBox ogrencicvptxt;
		public System.Windows.Forms.TextBox cvpanahtariTxt;
	}
}