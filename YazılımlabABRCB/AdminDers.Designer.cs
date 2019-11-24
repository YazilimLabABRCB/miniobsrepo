namespace YazılımlabABRCB
{
    partial class AdminDers
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
            this.dersgeributton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dersekleme = new System.Windows.Forms.TabPage();
            this.derssilme = new System.Windows.Forms.TabPage();
            this.dersgüncelleme = new System.Windows.Forms.TabPage();
            this.derslisteleme = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.dersekleme.SuspendLayout();
            this.derssilme.SuspendLayout();
            this.dersgüncelleme.SuspendLayout();
            this.derslisteleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersgeributton
            // 
            this.dersgeributton.Location = new System.Drawing.Point(393, 471);
            this.dersgeributton.Name = "dersgeributton";
            this.dersgeributton.Size = new System.Drawing.Size(72, 52);
            this.dersgeributton.TabIndex = 8;
            this.dersgeributton.Text = "Geri ";
            this.dersgeributton.UseVisualStyleBackColor = true;
            this.dersgeributton.Click += new System.EventHandler(this.dersgeributton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dersekleme);
            this.tabControl1.Controls.Add(this.derssilme);
            this.tabControl1.Controls.Add(this.dersgüncelleme);
            this.tabControl1.Controls.Add(this.derslisteleme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 549);
            this.tabControl1.TabIndex = 9;
            // 
            // dersekleme
            // 
            this.dersekleme.Controls.Add(this.dersgeributton);
            this.dersekleme.Location = new System.Drawing.Point(4, 22);
            this.dersekleme.Name = "dersekleme";
            this.dersekleme.Padding = new System.Windows.Forms.Padding(3);
            this.dersekleme.Size = new System.Drawing.Size(465, 523);
            this.dersekleme.TabIndex = 0;
            this.dersekleme.Text = "Ders Ekleme";
            this.dersekleme.UseVisualStyleBackColor = true;
            // 
            // derssilme
            // 
            this.derssilme.Controls.Add(this.button1);
            this.derssilme.Location = new System.Drawing.Point(4, 22);
            this.derssilme.Name = "derssilme";
            this.derssilme.Padding = new System.Windows.Forms.Padding(3);
            this.derssilme.Size = new System.Drawing.Size(465, 523);
            this.derssilme.TabIndex = 1;
            this.derssilme.Text = "Ders Silme";
            this.derssilme.UseVisualStyleBackColor = true;
            // 
            // dersgüncelleme
            // 
            this.dersgüncelleme.Controls.Add(this.button2);
            this.dersgüncelleme.Location = new System.Drawing.Point(4, 22);
            this.dersgüncelleme.Name = "dersgüncelleme";
            this.dersgüncelleme.Size = new System.Drawing.Size(465, 523);
            this.dersgüncelleme.TabIndex = 2;
            this.dersgüncelleme.Text = "Ders Güncelleme";
            this.dersgüncelleme.UseVisualStyleBackColor = true;
            // 
            // derslisteleme
            // 
            this.derslisteleme.Controls.Add(this.button3);
            this.derslisteleme.Location = new System.Drawing.Point(4, 22);
            this.derslisteleme.Name = "derslisteleme";
            this.derslisteleme.Size = new System.Drawing.Size(465, 523);
            this.derslisteleme.TabIndex = 3;
            this.derslisteleme.Text = "Ders Listeleme";
            this.derslisteleme.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Geri ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Geri ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Geri ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDers";
            this.Text = "AdminDers";
            this.tabControl1.ResumeLayout(false);
            this.dersekleme.ResumeLayout(false);
            this.derssilme.ResumeLayout(false);
            this.dersgüncelleme.ResumeLayout(false);
            this.derslisteleme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dersgeributton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dersekleme;
        private System.Windows.Forms.TabPage derssilme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage dersgüncelleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage derslisteleme;
        private System.Windows.Forms.Button button3;
    }
}