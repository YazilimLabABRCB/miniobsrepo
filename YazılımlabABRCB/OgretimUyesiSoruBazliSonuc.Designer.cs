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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ogrcvponayBtn = new System.Windows.Forms.Button();
			this.ogrcevapsecBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
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
			// OgretimUyesiSoruBazliSonuc
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ogrcevapsecBtn);
			this.Controls.Add(this.ogrcvponayBtn);
			this.Controls.Add(this.textBox1);
			this.Name = "OgretimUyesiSoruBazliSonuc";
			this.ShowIcon = false;
			this.Text = "Kullanıcı - Soru Bazlı Sonuç";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OgretimUyesiSoruBazliSonuc_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.Button ogrcvponayBtn;
		public System.Windows.Forms.Button ogrcevapsecBtn;
		public System.Windows.Forms.TextBox textBox1;
	}
}