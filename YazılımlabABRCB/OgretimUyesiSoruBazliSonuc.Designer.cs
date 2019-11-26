namespace YazılımlabABRCB
{
		public partial class OgretimUyesiSoruBazliSonuc
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ogrcvponayBtn = new System.Windows.Forms.Button();
			this.ogrcevapsecBtn = new System.Windows.Forms.Button();
			this.donemsecCmb = new System.Windows.Forms.ComboBox();
			this.sinavturusecCmb = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 226);
			this.dataGridView1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 20);
			this.textBox1.TabIndex = 1;
			// 
			// ogrcvponayBtn
			// 
			this.ogrcvponayBtn.Location = new System.Drawing.Point(241, 12);
			this.ogrcvponayBtn.Name = "ogrcvponayBtn";
			this.ogrcvponayBtn.Size = new System.Drawing.Size(75, 23);
			this.ogrcvponayBtn.TabIndex = 2;
			this.ogrcvponayBtn.Text = "oku onay";
			this.ogrcvponayBtn.UseVisualStyleBackColor = true;
			this.ogrcvponayBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// ogrcevapsecBtn
			// 
			this.ogrcevapsecBtn.Location = new System.Drawing.Point(160, 11);
			this.ogrcevapsecBtn.Name = "ogrcevapsecBtn";
			this.ogrcevapsecBtn.Size = new System.Drawing.Size(75, 23);
			this.ogrcevapsecBtn.TabIndex = 3;
			this.ogrcevapsecBtn.Text = "seç";
			this.ogrcevapsecBtn.UseVisualStyleBackColor = true;
			this.ogrcevapsecBtn.Click += new System.EventHandler(this.button2_Click);
			// 
			// donemsecCmb
			// 
			this.donemsecCmb.FormattingEnabled = true;
			this.donemsecCmb.Location = new System.Drawing.Point(372, 17);
			this.donemsecCmb.Name = "donemsecCmb";
			this.donemsecCmb.Size = new System.Drawing.Size(165, 21);
			this.donemsecCmb.TabIndex = 4;
			// 
			// sinavturusecCmb
			// 
			this.sinavturusecCmb.FormattingEnabled = true;
			this.sinavturusecCmb.Location = new System.Drawing.Point(623, 16);
			this.sinavturusecCmb.Name = "sinavturusecCmb";
			this.sinavturusecCmb.Size = new System.Drawing.Size(165, 21);
			this.sinavturusecCmb.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(322, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Dönem:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(555, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Sınav Türü:";
			// 
			// OgretimUyesiSoruBazliSonuc
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sinavturusecCmb);
			this.Controls.Add(this.donemsecCmb);
			this.Controls.Add(this.ogrcevapsecBtn);
			this.Controls.Add(this.ogrcvponayBtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "OgretimUyesiSoruBazliSonuc";
			this.ShowIcon = false;
			this.Text = "Kullanıcı - Soru Bazlı Sonuç";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OgretimUyesiSoruBazliSonuc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.Button ogrcvponayBtn;
		public System.Windows.Forms.Button ogrcevapsecBtn;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.ComboBox donemsecCmb;
		public System.Windows.Forms.ComboBox sinavturusecCmb;
	}
}