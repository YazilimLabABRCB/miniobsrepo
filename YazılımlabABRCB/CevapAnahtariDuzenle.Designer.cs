namespace YazılımlabABRCB
{
	partial class CevapAnahtariDuzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CevapAnahtariDuzenle));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.cvpanahtariduzenleTxt = new System.Windows.Forms.ToolStripTextBox();
			this.cvpanahtarionayBtn = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 450);
			this.dataGridView1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cvpanahtariduzenleTxt,
            this.cvpanahtarionayBtn});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel1.Text = "Dosya Yolu:";
			// 
			// cvpanahtariduzenleTxt
			// 
			this.cvpanahtariduzenleTxt.Enabled = false;
			this.cvpanahtariduzenleTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cvpanahtariduzenleTxt.Name = "cvpanahtariduzenleTxt";
			this.cvpanahtariduzenleTxt.Size = new System.Drawing.Size(100, 25);
			// 
			// cvpanahtarionayBtn
			// 
			this.cvpanahtarionayBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cvpanahtarionayBtn.Image = ((System.Drawing.Image)(resources.GetObject("cvpanahtarionayBtn.Image")));
			this.cvpanahtarionayBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cvpanahtarionayBtn.Name = "cvpanahtarionayBtn";
			this.cvpanahtarionayBtn.Size = new System.Drawing.Size(48, 22);
			this.cvpanahtarionayBtn.Text = "Onayla";
			this.cvpanahtarionayBtn.Click += new System.EventHandler(this.cvpanahtarionayBtn_Click);
			// 
			// CevapAnahtariDuzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CevapAnahtariDuzenle";
			this.Text = "CevapAnahtariDuzenle";
			this.Load += new System.EventHandler(this.CevapAnahtariDuzenle_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.ToolStripTextBox cvpanahtariduzenleTxt;
		public System.Windows.Forms.ToolStripButton cvpanahtarionayBtn;
	}
}