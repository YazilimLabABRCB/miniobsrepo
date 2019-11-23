namespace YazılımlabABRCB
{
    partial class AdminDersAtama
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
			this.dersatamasilmebutton = new System.Windows.Forms.Button();
			this.dersatamalisteleme = new System.Windows.Forms.Button();
			this.dersatamagüncellemebutton = new System.Windows.Forms.Button();
			this.dersatamaeklemebutton = new System.Windows.Forms.Button();
			this.dersatamageributton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dersatamasilmebutton
			// 
			this.dersatamasilmebutton.Location = new System.Drawing.Point(142, 322);
			this.dersatamasilmebutton.Name = "dersatamasilmebutton";
			this.dersatamasilmebutton.Size = new System.Drawing.Size(204, 29);
			this.dersatamasilmebutton.TabIndex = 7;
			this.dersatamasilmebutton.Text = "Ders Atama Silme";
			this.dersatamasilmebutton.UseVisualStyleBackColor = true;
			// 
			// dersatamalisteleme
			// 
			this.dersatamalisteleme.Location = new System.Drawing.Point(142, 269);
			this.dersatamalisteleme.Name = "dersatamalisteleme";
			this.dersatamalisteleme.Size = new System.Drawing.Size(204, 29);
			this.dersatamalisteleme.TabIndex = 6;
			this.dersatamalisteleme.Text = "Ders Atama Listeleme";
			this.dersatamalisteleme.UseVisualStyleBackColor = true;
			// 
			// dersatamagüncellemebutton
			// 
			this.dersatamagüncellemebutton.Location = new System.Drawing.Point(142, 214);
			this.dersatamagüncellemebutton.Name = "dersatamagüncellemebutton";
			this.dersatamagüncellemebutton.Size = new System.Drawing.Size(204, 29);
			this.dersatamagüncellemebutton.TabIndex = 5;
			this.dersatamagüncellemebutton.Text = "Ders Atama Güncelleme";
			this.dersatamagüncellemebutton.UseVisualStyleBackColor = true;
			// 
			// dersatamaeklemebutton
			// 
			this.dersatamaeklemebutton.Location = new System.Drawing.Point(142, 158);
			this.dersatamaeklemebutton.Name = "dersatamaeklemebutton";
			this.dersatamaeklemebutton.Size = new System.Drawing.Size(204, 29);
			this.dersatamaeklemebutton.TabIndex = 4;
			this.dersatamaeklemebutton.Text = "Ders Atama Ekleme";
			this.dersatamaeklemebutton.UseVisualStyleBackColor = true;
			// 
			// dersatamageributton
			// 
			this.dersatamageributton.Location = new System.Drawing.Point(199, 396);
			this.dersatamageributton.Name = "dersatamageributton";
			this.dersatamageributton.Size = new System.Drawing.Size(72, 52);
			this.dersatamageributton.TabIndex = 9;
			this.dersatamageributton.Text = "Geri ";
			this.dersatamageributton.UseVisualStyleBackColor = true;
			this.dersatamageributton.Click += new System.EventHandler(this.dersatamageributton_Click);
			// 
			// AdminDersAtama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 546);
			this.Controls.Add(this.dersatamageributton);
			this.Controls.Add(this.dersatamasilmebutton);
			this.Controls.Add(this.dersatamalisteleme);
			this.Controls.Add(this.dersatamagüncellemebutton);
			this.Controls.Add(this.dersatamaeklemebutton);
			this.MaximizeBox = false;
			this.Name = "AdminDersAtama";
			this.ShowIcon = false;
			this.Text = "Admin - Ders Atama";
			this.Load += new System.EventHandler(this.AdminDersAtama_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dersatamasilmebutton;
        private System.Windows.Forms.Button dersatamalisteleme;
        private System.Windows.Forms.Button dersatamagüncellemebutton;
        private System.Windows.Forms.Button dersatamaeklemebutton;
        private System.Windows.Forms.Button dersatamageributton;
    }
}