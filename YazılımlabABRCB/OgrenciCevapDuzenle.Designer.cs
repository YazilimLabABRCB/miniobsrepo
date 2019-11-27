namespace YazılımlabABRCB
{
	partial class OgrenciCevapDuzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciCevapDuzenle));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.ogrcevapduzenletxt = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ogrcevaponaylabutton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 450);
			this.dataGridView1.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ogrcevapduzenletxt,
            this.toolStripSeparator3,
            this.ogrcevaponaylabutton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel1.Text = "Dosya Yolu:";
			// 
			// ogrcevapduzenletxt
			// 
			this.ogrcevapduzenletxt.Enabled = false;
			this.ogrcevapduzenletxt.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ogrcevapduzenletxt.Name = "ogrcevapduzenletxt";
			this.ogrcevapduzenletxt.Size = new System.Drawing.Size(100, 25);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// ogrcevaponaylabutton
			// 
			this.ogrcevaponaylabutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ogrcevaponaylabutton.Image = ((System.Drawing.Image)(resources.GetObject("ogrcevaponaylabutton.Image")));
			this.ogrcevaponaylabutton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ogrcevaponaylabutton.Name = "ogrcevaponaylabutton";
			this.ogrcevaponaylabutton.Size = new System.Drawing.Size(48, 22);
			this.ogrcevaponaylabutton.Text = "Onayla";
			this.ogrcevaponaylabutton.Click += new System.EventHandler(this.ogrcevaponaylabutton_Click);
			// 
			// OgrenciCevapDuzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "OgrenciCevapDuzenle";
			this.Text = "OgrenciCevapDuzenle";
			this.Load += new System.EventHandler(this.OgrenciCevapDuzenle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		public System.Windows.Forms.ToolStripTextBox ogrcevapduzenletxt;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton ogrcevaponaylabutton;
	}
}