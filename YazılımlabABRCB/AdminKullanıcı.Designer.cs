namespace YazılımlabABRCB
{
    partial class AdminKullanıcı
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
            this.kullanicisilmebutton = new System.Windows.Forms.Button();
            this.kullanicilistelemebutton = new System.Windows.Forms.Button();
            this.kullaniciguncellemebutton = new System.Windows.Forms.Button();
            this.kullanicieklemebutton = new System.Windows.Forms.Button();
            this.bolumgeributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanicisilmebutton
            // 
            this.kullanicisilmebutton.Location = new System.Drawing.Point(103, 324);
            this.kullanicisilmebutton.Name = "kullanicisilmebutton";
            this.kullanicisilmebutton.Size = new System.Drawing.Size(204, 29);
            this.kullanicisilmebutton.TabIndex = 7;
            this.kullanicisilmebutton.Text = "Kullanıcı Silme";
            this.kullanicisilmebutton.UseVisualStyleBackColor = true;
            // 
            // kullanicilistelemebutton
            // 
            this.kullanicilistelemebutton.Location = new System.Drawing.Point(103, 271);
            this.kullanicilistelemebutton.Name = "kullanicilistelemebutton";
            this.kullanicilistelemebutton.Size = new System.Drawing.Size(204, 29);
            this.kullanicilistelemebutton.TabIndex = 6;
            this.kullanicilistelemebutton.Text = "Kullanıcı Listeleme";
            this.kullanicilistelemebutton.UseVisualStyleBackColor = true;
            // 
            // kullaniciguncellemebutton
            // 
            this.kullaniciguncellemebutton.Location = new System.Drawing.Point(103, 216);
            this.kullaniciguncellemebutton.Name = "kullaniciguncellemebutton";
            this.kullaniciguncellemebutton.Size = new System.Drawing.Size(204, 29);
            this.kullaniciguncellemebutton.TabIndex = 5;
            this.kullaniciguncellemebutton.Text = "Kullanıcı Güncelleme";
            this.kullaniciguncellemebutton.UseVisualStyleBackColor = true;
            // 
            // kullanicieklemebutton
            // 
            this.kullanicieklemebutton.Location = new System.Drawing.Point(103, 160);
            this.kullanicieklemebutton.Name = "kullanicieklemebutton";
            this.kullanicieklemebutton.Size = new System.Drawing.Size(204, 29);
            this.kullanicieklemebutton.TabIndex = 4;
            this.kullanicieklemebutton.Text = "Kullanıcı Ekleme";
            this.kullanicieklemebutton.UseVisualStyleBackColor = true;
            // 
            // bolumgeributton
            // 
            this.bolumgeributton.Location = new System.Drawing.Point(165, 392);
            this.bolumgeributton.Name = "bolumgeributton";
            this.bolumgeributton.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton.TabIndex = 8;
            this.bolumgeributton.Text = "Geri ";
            this.bolumgeributton.UseVisualStyleBackColor = true;
            this.bolumgeributton.Click += new System.EventHandler(this.bolumgeributton_Click);
            // 
            // AdminKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 570);
            this.Controls.Add(this.bolumgeributton);
            this.Controls.Add(this.kullanicisilmebutton);
            this.Controls.Add(this.kullanicilistelemebutton);
            this.Controls.Add(this.kullaniciguncellemebutton);
            this.Controls.Add(this.kullanicieklemebutton);
            this.Name = "AdminKullanıcı";
            this.Text = "AdminKullanıcı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanicisilmebutton;
        private System.Windows.Forms.Button kullanicilistelemebutton;
        private System.Windows.Forms.Button kullaniciguncellemebutton;
        private System.Windows.Forms.Button kullanicieklemebutton;
        private System.Windows.Forms.Button bolumgeributton;
    }
}