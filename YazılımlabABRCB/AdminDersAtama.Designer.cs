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
            this.dersatamageributton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dersatama = new System.Windows.Forms.TabPage();
            this.dersatamasilme = new System.Windows.Forms.TabPage();
            this.dersatamagüncelleme = new System.Windows.Forms.TabPage();
            this.dersatamalisteleme = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.dersatama.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersatamageributton
            // 
            this.dersatamageributton.Location = new System.Drawing.Point(393, 468);
            this.dersatamageributton.Name = "dersatamageributton";
            this.dersatamageributton.Size = new System.Drawing.Size(72, 52);
            this.dersatamageributton.TabIndex = 9;
            this.dersatamageributton.Text = "Geri ";
            this.dersatamageributton.UseVisualStyleBackColor = true;
            this.dersatamageributton.Click += new System.EventHandler(this.dersatamageributton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dersatama);
            this.tabControl1.Controls.Add(this.dersatamasilme);
            this.tabControl1.Controls.Add(this.dersatamagüncelleme);
            this.tabControl1.Controls.Add(this.dersatamalisteleme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 546);
            this.tabControl1.TabIndex = 10;
            // 
            // dersatama
            // 
            this.dersatama.Controls.Add(this.dersatamageributton);
            this.dersatama.Location = new System.Drawing.Point(4, 22);
            this.dersatama.Name = "dersatama";
            this.dersatama.Padding = new System.Windows.Forms.Padding(3);
            this.dersatama.Size = new System.Drawing.Size(465, 520);
            this.dersatama.TabIndex = 0;
            this.dersatama.Text = "Ders Atama";
            this.dersatama.UseVisualStyleBackColor = true;
            // 
            // dersatamasilme
            // 
            this.dersatamasilme.Location = new System.Drawing.Point(4, 22);
            this.dersatamasilme.Name = "dersatamasilme";
            this.dersatamasilme.Padding = new System.Windows.Forms.Padding(3);
            this.dersatamasilme.Size = new System.Drawing.Size(465, 520);
            this.dersatamasilme.TabIndex = 1;
            this.dersatamasilme.Text = "Ders Atama Silme";
            this.dersatamasilme.UseVisualStyleBackColor = true;
            // 
            // dersatamagüncelleme
            // 
            this.dersatamagüncelleme.Location = new System.Drawing.Point(4, 22);
            this.dersatamagüncelleme.Name = "dersatamagüncelleme";
            this.dersatamagüncelleme.Size = new System.Drawing.Size(465, 520);
            this.dersatamagüncelleme.TabIndex = 2;
            this.dersatamagüncelleme.Text = "Ders Atama Güncelleme";
            this.dersatamagüncelleme.UseVisualStyleBackColor = true;
            // 
            // dersatamalisteleme
            // 
            this.dersatamalisteleme.Location = new System.Drawing.Point(4, 22);
            this.dersatamalisteleme.Name = "dersatamalisteleme";
            this.dersatamalisteleme.Size = new System.Drawing.Size(465, 520);
            this.dersatamalisteleme.TabIndex = 3;
            this.dersatamalisteleme.Text = "Ders Atama Listeleme";
            this.dersatamalisteleme.UseVisualStyleBackColor = true;
            // 
            // AdminDersAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDersAtama";
            this.Text = "AdminDersAtama";
            this.Load += new System.EventHandler(this.AdminDersAtama_Load);
            this.tabControl1.ResumeLayout(false);
            this.dersatama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dersatamageributton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dersatama;
        private System.Windows.Forms.TabPage dersatamasilme;
        private System.Windows.Forms.TabPage dersatamagüncelleme;
        private System.Windows.Forms.TabPage dersatamalisteleme;
    }
}