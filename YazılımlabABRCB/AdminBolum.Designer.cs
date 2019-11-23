namespace YazılımlabABRCB
{
    partial class AdminBolum
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
            this.bolumeklemebutton = new System.Windows.Forms.Button();
            this.bolumguncellemebutton = new System.Windows.Forms.Button();
            this.bolumlistelemebutton = new System.Windows.Forms.Button();
            this.bolumsilmebutton = new System.Windows.Forms.Button();
            this.bolumgeributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bolumeklemebutton
            // 
            this.bolumeklemebutton.Location = new System.Drawing.Point(118, 105);
            this.bolumeklemebutton.Name = "bolumeklemebutton";
            this.bolumeklemebutton.Size = new System.Drawing.Size(204, 29);
            this.bolumeklemebutton.TabIndex = 0;
            this.bolumeklemebutton.Text = "Bölüm Ekleme";
            this.bolumeklemebutton.UseVisualStyleBackColor = true;
            // 
            // bolumguncellemebutton
            // 
            this.bolumguncellemebutton.Location = new System.Drawing.Point(118, 161);
            this.bolumguncellemebutton.Name = "bolumguncellemebutton";
            this.bolumguncellemebutton.Size = new System.Drawing.Size(204, 29);
            this.bolumguncellemebutton.TabIndex = 1;
            this.bolumguncellemebutton.Text = "Bölüm Güncelleme";
            this.bolumguncellemebutton.UseVisualStyleBackColor = true;
            // 
            // bolumlistelemebutton
            // 
            this.bolumlistelemebutton.Location = new System.Drawing.Point(118, 216);
            this.bolumlistelemebutton.Name = "bolumlistelemebutton";
            this.bolumlistelemebutton.Size = new System.Drawing.Size(204, 29);
            this.bolumlistelemebutton.TabIndex = 2;
            this.bolumlistelemebutton.Text = "Bölüm Listeleme";
            this.bolumlistelemebutton.UseVisualStyleBackColor = true;
            // 
            // bolumsilmebutton
            // 
            this.bolumsilmebutton.Location = new System.Drawing.Point(118, 269);
            this.bolumsilmebutton.Name = "bolumsilmebutton";
            this.bolumsilmebutton.Size = new System.Drawing.Size(204, 29);
            this.bolumsilmebutton.TabIndex = 3;
            this.bolumsilmebutton.Text = "Bölüm Silme";
            this.bolumsilmebutton.UseVisualStyleBackColor = true;
            // 
            // bolumgeributton
            // 
            this.bolumgeributton.Location = new System.Drawing.Point(182, 352);
            this.bolumgeributton.Name = "bolumgeributton";
            this.bolumgeributton.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton.TabIndex = 4;
            this.bolumgeributton.Text = "Geri ";
            this.bolumgeributton.UseVisualStyleBackColor = true;
            this.bolumgeributton.Click += new System.EventHandler(this.bolumgeributton_Click);
            // 
            // AdminBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 500);
            this.Controls.Add(this.bolumgeributton);
            this.Controls.Add(this.bolumsilmebutton);
            this.Controls.Add(this.bolumlistelemebutton);
            this.Controls.Add(this.bolumguncellemebutton);
            this.Controls.Add(this.bolumeklemebutton);
            this.Name = "AdminBolum";
            this.Text = "AdminBolum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bolumeklemebutton;
        private System.Windows.Forms.Button bolumguncellemebutton;
        private System.Windows.Forms.Button bolumlistelemebutton;
        private System.Windows.Forms.Button bolumsilmebutton;
        private System.Windows.Forms.Button bolumgeributton;
    }
}