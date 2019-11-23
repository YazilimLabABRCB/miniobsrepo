namespace YazılımlabABRCB
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.Admingiristab = new System.Windows.Forms.TabControl();
			this.admintab = new System.Windows.Forms.TabPage();
			this.adminsifretextbox = new System.Windows.Forms.TextBox();
			this.adminnotextbox = new System.Windows.Forms.TextBox();
			this.adminsifrelabel = new System.Windows.Forms.Label();
			this.adminnolabel = new System.Windows.Forms.Label();
			this.admingirisbutton = new System.Windows.Forms.Button();
			this.kullanicitab = new System.Windows.Forms.TabPage();
			this.ogretimuyesisifretextbox = new System.Windows.Forms.TextBox();
			this.ogretimuyesinotextbox = new System.Windows.Forms.TextBox();
			this.kullanicisifrelabel = new System.Windows.Forms.Label();
			this.ogretimuyesilabel = new System.Windows.Forms.Label();
			this.ogretimuyesigirisbutton = new System.Windows.Forms.Button();
			this.Admingiristab.SuspendLayout();
			this.admintab.SuspendLayout();
			this.kullanicitab.SuspendLayout();
			this.SuspendLayout();
			// 
			// Admingiristab
			// 
			this.Admingiristab.Controls.Add(this.admintab);
			this.Admingiristab.Controls.Add(this.kullanicitab);
			this.Admingiristab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Admingiristab.Location = new System.Drawing.Point(0, 0);
			this.Admingiristab.Name = "Admingiristab";
			this.Admingiristab.SelectedIndex = 0;
			this.Admingiristab.Size = new System.Drawing.Size(372, 364);
			this.Admingiristab.TabIndex = 0;
			this.Admingiristab.Tag = "";
			// 
			// admintab
			// 
			this.admintab.Controls.Add(this.adminsifretextbox);
			this.admintab.Controls.Add(this.adminnotextbox);
			this.admintab.Controls.Add(this.adminsifrelabel);
			this.admintab.Controls.Add(this.adminnolabel);
			this.admintab.Controls.Add(this.admingirisbutton);
			this.admintab.Location = new System.Drawing.Point(4, 22);
			this.admintab.Name = "admintab";
			this.admintab.Padding = new System.Windows.Forms.Padding(3);
			this.admintab.Size = new System.Drawing.Size(364, 338);
			this.admintab.TabIndex = 0;
			this.admintab.Text = "Admin";
			this.admintab.UseVisualStyleBackColor = true;
			// 
			// adminsifretextbox
			// 
			this.adminsifretextbox.Location = new System.Drawing.Point(160, 207);
			this.adminsifretextbox.Name = "adminsifretextbox";
			this.adminsifretextbox.PasswordChar = '*';
			this.adminsifretextbox.Size = new System.Drawing.Size(114, 20);
			this.adminsifretextbox.TabIndex = 9;
			// 
			// adminnotextbox
			// 
			this.adminnotextbox.Location = new System.Drawing.Point(160, 159);
			this.adminnotextbox.Name = "adminnotextbox";
			this.adminnotextbox.Size = new System.Drawing.Size(114, 20);
			this.adminnotextbox.TabIndex = 8;
			// 
			// adminsifrelabel
			// 
			this.adminsifrelabel.AutoSize = true;
			this.adminsifrelabel.Location = new System.Drawing.Point(68, 207);
			this.adminsifrelabel.Name = "adminsifrelabel";
			this.adminsifrelabel.Size = new System.Drawing.Size(28, 13);
			this.adminsifrelabel.TabIndex = 7;
			this.adminsifrelabel.Text = "Şifre";
			// 
			// adminnolabel
			// 
			this.adminnolabel.AutoSize = true;
			this.adminnolabel.Location = new System.Drawing.Point(68, 159);
			this.adminnolabel.Name = "adminnolabel";
			this.adminnolabel.Size = new System.Drawing.Size(53, 13);
			this.adminnolabel.TabIndex = 6;
			this.adminnolabel.Text = "Admin No";
			// 
			// admingirisbutton
			// 
			this.admingirisbutton.Location = new System.Drawing.Point(186, 254);
			this.admingirisbutton.Name = "admingirisbutton";
			this.admingirisbutton.Size = new System.Drawing.Size(75, 23);
			this.admingirisbutton.TabIndex = 5;
			this.admingirisbutton.Text = "Giriş";
			this.admingirisbutton.UseVisualStyleBackColor = true;
			this.admingirisbutton.Click += new System.EventHandler(this.admingirisbutton_Click);
			// 
			// kullanicitab
			// 
			this.kullanicitab.Controls.Add(this.ogretimuyesisifretextbox);
			this.kullanicitab.Controls.Add(this.ogretimuyesinotextbox);
			this.kullanicitab.Controls.Add(this.kullanicisifrelabel);
			this.kullanicitab.Controls.Add(this.ogretimuyesilabel);
			this.kullanicitab.Controls.Add(this.ogretimuyesigirisbutton);
			this.kullanicitab.Location = new System.Drawing.Point(4, 22);
			this.kullanicitab.Name = "kullanicitab";
			this.kullanicitab.Padding = new System.Windows.Forms.Padding(3);
			this.kullanicitab.Size = new System.Drawing.Size(364, 338);
			this.kullanicitab.TabIndex = 1;
			this.kullanicitab.Text = "Öğretim Üyesi";
			this.kullanicitab.UseVisualStyleBackColor = true;
			// 
			// ogretimuyesisifretextbox
			// 
			this.ogretimuyesisifretextbox.Location = new System.Drawing.Point(173, 211);
			this.ogretimuyesisifretextbox.Name = "ogretimuyesisifretextbox";
			this.ogretimuyesisifretextbox.PasswordChar = '*';
			this.ogretimuyesisifretextbox.Size = new System.Drawing.Size(100, 20);
			this.ogretimuyesisifretextbox.TabIndex = 14;
			// 
			// ogretimuyesinotextbox
			// 
			this.ogretimuyesinotextbox.Location = new System.Drawing.Point(173, 163);
			this.ogretimuyesinotextbox.Name = "ogretimuyesinotextbox";
			this.ogretimuyesinotextbox.Size = new System.Drawing.Size(100, 20);
			this.ogretimuyesinotextbox.TabIndex = 13;
			// 
			// kullanicisifrelabel
			// 
			this.kullanicisifrelabel.AutoSize = true;
			this.kullanicisifrelabel.Location = new System.Drawing.Point(67, 211);
			this.kullanicisifrelabel.Name = "kullanicisifrelabel";
			this.kullanicisifrelabel.Size = new System.Drawing.Size(28, 13);
			this.kullanicisifrelabel.TabIndex = 12;
			this.kullanicisifrelabel.Text = "Şifre";
			// 
			// ogretimuyesilabel
			// 
			this.ogretimuyesilabel.AutoSize = true;
			this.ogretimuyesilabel.Location = new System.Drawing.Point(67, 163);
			this.ogretimuyesilabel.Name = "ogretimuyesilabel";
			this.ogretimuyesilabel.Size = new System.Drawing.Size(89, 13);
			this.ogretimuyesilabel.TabIndex = 11;
			this.ogretimuyesilabel.Text = "Öğretim Üyesi No";
			// 
			// ogretimuyesigirisbutton
			// 
			this.ogretimuyesigirisbutton.Location = new System.Drawing.Point(185, 258);
			this.ogretimuyesigirisbutton.Name = "ogretimuyesigirisbutton";
			this.ogretimuyesigirisbutton.Size = new System.Drawing.Size(75, 23);
			this.ogretimuyesigirisbutton.TabIndex = 10;
			this.ogretimuyesigirisbutton.Text = "Giriş";
			this.ogretimuyesigirisbutton.UseVisualStyleBackColor = true;
			this.ogretimuyesigirisbutton.Click += new System.EventHandler(this.ogretimuyesigirisbutton_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 364);
			this.Controls.Add(this.Admingiristab);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.ShowIcon = false;
			this.Text = "Login Panel";
			this.Admingiristab.ResumeLayout(false);
			this.admintab.ResumeLayout(false);
			this.admintab.PerformLayout();
			this.kullanicitab.ResumeLayout(false);
			this.kullanicitab.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admingiristab;
        private System.Windows.Forms.TabPage admintab;
        private System.Windows.Forms.TextBox adminsifretextbox;
        private System.Windows.Forms.TextBox adminnotextbox;
        private System.Windows.Forms.Label adminsifrelabel;
        private System.Windows.Forms.Label adminnolabel;
        private System.Windows.Forms.Button admingirisbutton;
        private System.Windows.Forms.TabPage kullanicitab;
        private System.Windows.Forms.TextBox ogretimuyesisifretextbox;
        private System.Windows.Forms.TextBox ogretimuyesinotextbox;
        private System.Windows.Forms.Label kullanicisifrelabel;
        private System.Windows.Forms.Label ogretimuyesilabel;
        private System.Windows.Forms.Button ogretimuyesigirisbutton;
    }
}

