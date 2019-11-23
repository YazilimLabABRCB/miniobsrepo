namespace YazılımlabABRCB
{
    partial class OgretimUyesiHomePage
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
            this.testokutmabutton = new System.Windows.Forms.Button();
            this.sorubazlisonucbutton = new System.Windows.Forms.Button();
            this.kazanimbazlisonucbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapmak İstediğiniz İşlem Türünü Seçiniz";
            // 
            // testokutmabutton
            // 
            this.testokutmabutton.Location = new System.Drawing.Point(119, 203);
            this.testokutmabutton.Name = "testokutmabutton";
            this.testokutmabutton.Size = new System.Drawing.Size(143, 23);
            this.testokutmabutton.TabIndex = 1;
            this.testokutmabutton.Text = "TEST OKUTMA";
            this.testokutmabutton.UseVisualStyleBackColor = true;
            // 
            // sorubazlisonucbutton
            // 
            this.sorubazlisonucbutton.Location = new System.Drawing.Point(119, 163);
            this.sorubazlisonucbutton.Name = "sorubazlisonucbutton";
            this.sorubazlisonucbutton.Size = new System.Drawing.Size(143, 23);
            this.sorubazlisonucbutton.TabIndex = 2;
            this.sorubazlisonucbutton.Text = "SORU BAZLI SONUÇ";
            this.sorubazlisonucbutton.UseVisualStyleBackColor = true;
            // 
            // kazanimbazlisonucbutton
            // 
            this.kazanimbazlisonucbutton.Location = new System.Drawing.Point(119, 120);
            this.kazanimbazlisonucbutton.Name = "kazanimbazlisonucbutton";
            this.kazanimbazlisonucbutton.Size = new System.Drawing.Size(143, 23);
            this.kazanimbazlisonucbutton.TabIndex = 3;
            this.kazanimbazlisonucbutton.Text = "KAZANIM BAZLI SONUÇ";
            this.kazanimbazlisonucbutton.UseVisualStyleBackColor = true;
            // 
            // KullaniciHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 440);
            this.Controls.Add(this.kazanimbazlisonucbutton);
            this.Controls.Add(this.sorubazlisonucbutton);
            this.Controls.Add(this.testokutmabutton);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciHomePage";
            this.Text = "KullaniciHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testokutmabutton;
        private System.Windows.Forms.Button sorubazlisonucbutton;
        private System.Windows.Forms.Button kazanimbazlisonucbutton;
    }
}