﻿namespace YazılımlabABRCB
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
            this.donemekledonemidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.donemeklebutton = new System.Windows.Forms.Button();
            this.donemekledonemadtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.donemsilme = new System.Windows.Forms.TabPage();
            this.donemsilmebutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.donemgüncelleme = new System.Windows.Forms.TabPage();
            this.donemarabutton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.donemlisteleme = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.donemekleme.SuspendLayout();
            this.donemsilme.SuspendLayout();
            this.donemgüncelleme.SuspendLayout();
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
            this.donemekleme.Controls.Add(this.donemekledonemidtxt);
            this.donemekleme.Controls.Add(this.label4);
            this.donemekleme.Controls.Add(this.donemeklebutton);
            this.donemekleme.Controls.Add(this.donemekledonemadtxt);
            this.donemekleme.Controls.Add(this.label1);
            this.donemekleme.Controls.Add(this.donemgeributton);
            this.donemekleme.Location = new System.Drawing.Point(4, 22);
            this.donemekleme.Name = "donemekleme";
            this.donemekleme.Padding = new System.Windows.Forms.Padding(3);
            this.donemekleme.Size = new System.Drawing.Size(458, 528);
            this.donemekleme.TabIndex = 0;
            this.donemekleme.Text = "Dönem Ekleme";
            this.donemekleme.UseVisualStyleBackColor = true;
            // 
            // donemekledonemidtxt
            // 
            this.donemekledonemidtxt.Location = new System.Drawing.Point(248, 135);
            this.donemekledonemidtxt.Name = "donemekledonemidtxt";
            this.donemekledonemidtxt.Size = new System.Drawing.Size(100, 20);
            this.donemekledonemidtxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Donem id";
            // 
            // donemeklebutton
            // 
            this.donemeklebutton.Location = new System.Drawing.Point(258, 225);
            this.donemeklebutton.Name = "donemeklebutton";
            this.donemeklebutton.Size = new System.Drawing.Size(75, 23);
            this.donemeklebutton.TabIndex = 14;
            this.donemeklebutton.Text = "Ekle";
            this.donemeklebutton.UseVisualStyleBackColor = true;
            this.donemeklebutton.Click += new System.EventHandler(this.donemeklebutton_Click);
            // 
            // donemekledonemadtxt
            // 
            this.donemekledonemadtxt.Location = new System.Drawing.Point(248, 172);
            this.donemekledonemadtxt.Name = "donemekledonemadtxt";
            this.donemekledonemadtxt.Size = new System.Drawing.Size(100, 20);
            this.donemekledonemadtxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Donem ad";
            // 
            // donemsilme
            // 
            this.donemsilme.Controls.Add(this.donemsilmebutton);
            this.donemsilme.Controls.Add(this.textBox2);
            this.donemsilme.Controls.Add(this.label2);
            this.donemsilme.Location = new System.Drawing.Point(4, 22);
            this.donemsilme.Name = "donemsilme";
            this.donemsilme.Padding = new System.Windows.Forms.Padding(3);
            this.donemsilme.Size = new System.Drawing.Size(458, 528);
            this.donemsilme.TabIndex = 1;
            this.donemsilme.Text = "Dönem Silme";
            this.donemsilme.UseVisualStyleBackColor = true;
            // 
            // donemsilmebutton
            // 
            this.donemsilmebutton.Location = new System.Drawing.Point(246, 279);
            this.donemsilmebutton.Name = "donemsilmebutton";
            this.donemsilmebutton.Size = new System.Drawing.Size(75, 23);
            this.donemsilmebutton.TabIndex = 17;
            this.donemsilmebutton.Text = "Sil";
            this.donemsilmebutton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dönem id";
            // 
            // donemgüncelleme
            // 
            this.donemgüncelleme.Controls.Add(this.donemarabutton);
            this.donemgüncelleme.Controls.Add(this.textBox3);
            this.donemgüncelleme.Controls.Add(this.label3);
            this.donemgüncelleme.Location = new System.Drawing.Point(4, 22);
            this.donemgüncelleme.Name = "donemgüncelleme";
            this.donemgüncelleme.Size = new System.Drawing.Size(458, 528);
            this.donemgüncelleme.TabIndex = 2;
            this.donemgüncelleme.Text = "Dönem Güncelleme";
            this.donemgüncelleme.UseVisualStyleBackColor = true;
            // 
            // donemarabutton
            // 
            this.donemarabutton.Location = new System.Drawing.Point(246, 279);
            this.donemarabutton.Name = "donemarabutton";
            this.donemarabutton.Size = new System.Drawing.Size(75, 23);
            this.donemarabutton.TabIndex = 20;
            this.donemarabutton.Text = "Ara";
            this.donemarabutton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dönem id";
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
            this.donemekleme.PerformLayout();
            this.donemsilme.ResumeLayout(false);
            this.donemsilme.PerformLayout();
            this.donemgüncelleme.ResumeLayout(false);
            this.donemgüncelleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button donemgeributton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage donemekleme;
        private System.Windows.Forms.TabPage donemsilme;
        private System.Windows.Forms.TabPage donemgüncelleme;
        private System.Windows.Forms.TabPage donemlisteleme;
        private System.Windows.Forms.Button donemeklebutton;
        private System.Windows.Forms.TextBox donemekledonemadtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button donemsilmebutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button donemarabutton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox donemekledonemidtxt;
        private System.Windows.Forms.Label label4;
    }
}