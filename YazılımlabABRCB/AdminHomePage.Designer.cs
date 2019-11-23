namespace YazılımlabABRCB
{
    partial class AdminHomePage
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
			this.label1 = new System.Windows.Forms.Label();
			this.kullanicibutton = new System.Windows.Forms.Button();
			this.bolumbutton = new System.Windows.Forms.Button();
			this.dersbutton = new System.Windows.Forms.Button();
			this.donembutton = new System.Windows.Forms.Button();
			this.dersatamabutton = new System.Windows.Forms.Button();
			this.sınavsonucbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yapmak İstediğiniz İşlem Türünü Seçiniz";
			// 
			// kullanicibutton
			// 
			this.kullanicibutton.Location = new System.Drawing.Point(137, 250);
			this.kullanicibutton.Name = "kullanicibutton";
			this.kullanicibutton.Size = new System.Drawing.Size(162, 23);
			this.kullanicibutton.TabIndex = 1;
			this.kullanicibutton.Text = "KULLANICI";
			this.kullanicibutton.UseVisualStyleBackColor = true;
			this.kullanicibutton.Click += new System.EventHandler(this.kullanicibutton_Click);
			// 
			// bolumbutton
			// 
			this.bolumbutton.Location = new System.Drawing.Point(137, 108);
			this.bolumbutton.Name = "bolumbutton";
			this.bolumbutton.Size = new System.Drawing.Size(162, 23);
			this.bolumbutton.TabIndex = 2;
			this.bolumbutton.Text = "BÖLÜM";
			this.bolumbutton.UseVisualStyleBackColor = true;
			this.bolumbutton.Click += new System.EventHandler(this.bolumbutton_Click);
			// 
			// dersbutton
			// 
			this.dersbutton.Location = new System.Drawing.Point(137, 147);
			this.dersbutton.Name = "dersbutton";
			this.dersbutton.Size = new System.Drawing.Size(162, 23);
			this.dersbutton.TabIndex = 3;
			this.dersbutton.Text = "DERS";
			this.dersbutton.UseVisualStyleBackColor = true;
			this.dersbutton.Click += new System.EventHandler(this.dersbutton_Click);
			// 
			// donembutton
			// 
			this.donembutton.Location = new System.Drawing.Point(137, 212);
			this.donembutton.Name = "donembutton";
			this.donembutton.Size = new System.Drawing.Size(162, 23);
			this.donembutton.TabIndex = 4;
			this.donembutton.Text = "DÖNEM";
			this.donembutton.UseVisualStyleBackColor = true;
			this.donembutton.Click += new System.EventHandler(this.donembutton_Click);
			// 
			// dersatamabutton
			// 
			this.dersatamabutton.Location = new System.Drawing.Point(137, 183);
			this.dersatamabutton.Name = "dersatamabutton";
			this.dersatamabutton.Size = new System.Drawing.Size(162, 23);
			this.dersatamabutton.TabIndex = 5;
			this.dersatamabutton.Text = "DERS ATAMA";
			this.dersatamabutton.UseVisualStyleBackColor = true;
			this.dersatamabutton.Click += new System.EventHandler(this.dersatamabutton_Click);
			// 
			// sınavsonucbutton
			// 
			this.sınavsonucbutton.Location = new System.Drawing.Point(137, 288);
			this.sınavsonucbutton.Name = "sınavsonucbutton";
			this.sınavsonucbutton.Size = new System.Drawing.Size(162, 23);
			this.sınavsonucbutton.TabIndex = 6;
			this.sınavsonucbutton.Text = "SINAV SONUÇ";
			this.sınavsonucbutton.UseVisualStyleBackColor = true;
			this.sınavsonucbutton.Click += new System.EventHandler(this.sınavsonucbutton_Click);
			// 
			// AdminHomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 575);
			this.Controls.Add(this.sınavsonucbutton);
			this.Controls.Add(this.dersatamabutton);
			this.Controls.Add(this.donembutton);
			this.Controls.Add(this.dersbutton);
			this.Controls.Add(this.bolumbutton);
			this.Controls.Add(this.kullanicibutton);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "AdminHomePage";
			this.ShowIcon = false;
			this.Text = "Admin - Home Page";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kullanicibutton;
        private System.Windows.Forms.Button bolumbutton;
        private System.Windows.Forms.Button dersbutton;
        private System.Windows.Forms.Button donembutton;
        private System.Windows.Forms.Button dersatamabutton;
        private System.Windows.Forms.Button sınavsonucbutton;
    }
}