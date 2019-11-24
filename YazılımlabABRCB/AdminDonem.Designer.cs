namespace YazılımlabABRCB
{
    partial class AdminDonem
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
            this.donemgeributton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.donemekleme = new System.Windows.Forms.TabPage();
            this.donemsilme = new System.Windows.Forms.TabPage();
            this.donemgüncelleme = new System.Windows.Forms.TabPage();
            this.donemlisteleme = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.donemekleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // donemgeributton
            // 
            this.donemgeributton.Location = new System.Drawing.Point(386, 473);
            this.donemgeributton.Name = "donemgeributton";
            this.donemgeributton.Size = new System.Drawing.Size(72, 52);
            this.donemgeributton.TabIndex = 8;
            this.donemgeributton.Text = "Geri ";
            this.donemgeributton.UseVisualStyleBackColor = true;
            this.donemgeributton.Click += new System.EventHandler(this.donemgeributton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.donemekleme);
            this.tabControl1.Controls.Add(this.donemsilme);
            this.tabControl1.Controls.Add(this.donemgüncelleme);
            this.tabControl1.Controls.Add(this.donemlisteleme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 554);
            this.tabControl1.TabIndex = 9;
            // 
            // donemekleme
            // 
            this.donemekleme.Controls.Add(this.donemgeributton);
            this.donemekleme.Location = new System.Drawing.Point(4, 22);
            this.donemekleme.Name = "donemekleme";
            this.donemekleme.Padding = new System.Windows.Forms.Padding(3);
            this.donemekleme.Size = new System.Drawing.Size(458, 528);
            this.donemekleme.TabIndex = 0;
            this.donemekleme.Text = "Dönem Ekleme";
            this.donemekleme.UseVisualStyleBackColor = true;
            // 
            // donemsilme
            // 
            this.donemsilme.Location = new System.Drawing.Point(4, 22);
            this.donemsilme.Name = "donemsilme";
            this.donemsilme.Padding = new System.Windows.Forms.Padding(3);
            this.donemsilme.Size = new System.Drawing.Size(458, 528);
            this.donemsilme.TabIndex = 1;
            this.donemsilme.Text = "Dönem Silme";
            this.donemsilme.UseVisualStyleBackColor = true;
            // 
            // donemgüncelleme
            // 
            this.donemgüncelleme.Location = new System.Drawing.Point(4, 22);
            this.donemgüncelleme.Name = "donemgüncelleme";
            this.donemgüncelleme.Size = new System.Drawing.Size(458, 528);
            this.donemgüncelleme.TabIndex = 2;
            this.donemgüncelleme.Text = "Dönem Güncelleme";
            this.donemgüncelleme.UseVisualStyleBackColor = true;
            // 
            // donemlisteleme
            // 
            this.donemlisteleme.Location = new System.Drawing.Point(4, 22);
            this.donemlisteleme.Name = "donemlisteleme";
            this.donemlisteleme.Size = new System.Drawing.Size(458, 528);
            this.donemlisteleme.TabIndex = 3;
            this.donemlisteleme.Text = "Dönem Listeleme";
            this.donemlisteleme.UseVisualStyleBackColor = true;
            // 
            // AdminDonem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDonem";
            this.Text = "AdminDonem";
            this.tabControl1.ResumeLayout(false);
            this.donemekleme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button donemgeributton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage donemekleme;
        private System.Windows.Forms.TabPage donemsilme;
        private System.Windows.Forms.TabPage donemgüncelleme;
        private System.Windows.Forms.TabPage donemlisteleme;
    }
}