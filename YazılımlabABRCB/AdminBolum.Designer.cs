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
            this.bolumgeributton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bolumekle = new System.Windows.Forms.TabPage();
            this.bolumsilme = new System.Windows.Forms.TabPage();
            this.bolumgeributton1 = new System.Windows.Forms.Button();
            this.bolumguncelleme = new System.Windows.Forms.TabPage();
            this.bolumgeributton2 = new System.Windows.Forms.Button();
            this.bolumlisteleme = new System.Windows.Forms.TabPage();
            this.bolumgeributton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.bolumekle.SuspendLayout();
            this.bolumsilme.SuspendLayout();
            this.bolumguncelleme.SuspendLayout();
            this.bolumlisteleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // bolumgeributton
            // 
            this.bolumgeributton.Location = new System.Drawing.Point(338, 422);
            this.bolumgeributton.Name = "bolumgeributton";
            this.bolumgeributton.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton.TabIndex = 4;
            this.bolumgeributton.Text = "Geri ";
            this.bolumgeributton.UseVisualStyleBackColor = true;
            this.bolumgeributton.Click += new System.EventHandler(this.bolumgeributton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bolumekle);
            this.tabControl1.Controls.Add(this.bolumsilme);
            this.tabControl1.Controls.Add(this.bolumguncelleme);
            this.tabControl1.Controls.Add(this.bolumlisteleme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 500);
            this.tabControl1.TabIndex = 5;
            // 
            // bolumekle
            // 
            this.bolumekle.Controls.Add(this.label3);
            this.bolumekle.Controls.Add(this.label2);
            this.bolumekle.Controls.Add(this.label1);
            this.bolumekle.Controls.Add(this.bolumgeributton);
            this.bolumekle.Location = new System.Drawing.Point(4, 22);
            this.bolumekle.Name = "bolumekle";
            this.bolumekle.Padding = new System.Windows.Forms.Padding(3);
            this.bolumekle.Size = new System.Drawing.Size(410, 474);
            this.bolumekle.TabIndex = 0;
            this.bolumekle.Text = "Bölüm Ekleme";
            this.bolumekle.UseVisualStyleBackColor = true;
            // 
            // bolumsilme
            // 
            this.bolumsilme.Controls.Add(this.bolumgeributton1);
            this.bolumsilme.Location = new System.Drawing.Point(4, 22);
            this.bolumsilme.Name = "bolumsilme";
            this.bolumsilme.Padding = new System.Windows.Forms.Padding(3);
            this.bolumsilme.Size = new System.Drawing.Size(410, 474);
            this.bolumsilme.TabIndex = 1;
            this.bolumsilme.Text = "Bölüm Silme";
            this.bolumsilme.UseVisualStyleBackColor = true;
            // 
            // bolumgeributton1
            // 
            this.bolumgeributton1.Location = new System.Drawing.Point(338, 422);
            this.bolumgeributton1.Name = "bolumgeributton1";
            this.bolumgeributton1.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton1.TabIndex = 5;
            this.bolumgeributton1.Text = "Geri ";
            this.bolumgeributton1.UseVisualStyleBackColor = true;
            this.bolumgeributton1.Click += new System.EventHandler(this.bolumgeributton1_Click);
            // 
            // bolumguncelleme
            // 
            this.bolumguncelleme.Controls.Add(this.bolumgeributton2);
            this.bolumguncelleme.Location = new System.Drawing.Point(4, 22);
            this.bolumguncelleme.Name = "bolumguncelleme";
            this.bolumguncelleme.Size = new System.Drawing.Size(410, 474);
            this.bolumguncelleme.TabIndex = 2;
            this.bolumguncelleme.Text = "Bölüm Güncelleme";
            this.bolumguncelleme.UseVisualStyleBackColor = true;
            // 
            // bolumgeributton2
            // 
            this.bolumgeributton2.Location = new System.Drawing.Point(338, 422);
            this.bolumgeributton2.Name = "bolumgeributton2";
            this.bolumgeributton2.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton2.TabIndex = 5;
            this.bolumgeributton2.Text = "Geri ";
            this.bolumgeributton2.UseVisualStyleBackColor = true;
            this.bolumgeributton2.Click += new System.EventHandler(this.bolumgeributton2_Click);
            // 
            // bolumlisteleme
            // 
            this.bolumlisteleme.Controls.Add(this.bolumgeributton3);
            this.bolumlisteleme.Location = new System.Drawing.Point(4, 22);
            this.bolumlisteleme.Name = "bolumlisteleme";
            this.bolumlisteleme.Size = new System.Drawing.Size(410, 474);
            this.bolumlisteleme.TabIndex = 3;
            this.bolumlisteleme.Text = "Bölüm Listeleme";
            this.bolumlisteleme.UseVisualStyleBackColor = true;
            // 
            // bolumgeributton3
            // 
            this.bolumgeributton3.Location = new System.Drawing.Point(338, 422);
            this.bolumgeributton3.Name = "bolumgeributton3";
            this.bolumgeributton3.Size = new System.Drawing.Size(72, 52);
            this.bolumgeributton3.TabIndex = 5;
            this.bolumgeributton3.Text = "Geri ";
            this.bolumgeributton3.UseVisualStyleBackColor = true;
            this.bolumgeributton3.Click += new System.EventHandler(this.bolumgeributton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // AdminBolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminBolum";
            this.Text = "AdminBolum";
            this.tabControl1.ResumeLayout(false);
            this.bolumekle.ResumeLayout(false);
            this.bolumekle.PerformLayout();
            this.bolumsilme.ResumeLayout(false);
            this.bolumguncelleme.ResumeLayout(false);
            this.bolumlisteleme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bolumgeributton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bolumekle;
        private System.Windows.Forms.TabPage bolumsilme;
        private System.Windows.Forms.TabPage bolumguncelleme;
        private System.Windows.Forms.TabPage bolumlisteleme;
        private System.Windows.Forms.Button bolumgeributton1;
        private System.Windows.Forms.Button bolumgeributton2;
        private System.Windows.Forms.Button bolumgeributton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}