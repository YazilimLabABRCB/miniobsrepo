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
            this.donemsilmebutton = new System.Windows.Forms.Button();
            this.donemlistelemebutton = new System.Windows.Forms.Button();
            this.donemguncellemebutton = new System.Windows.Forms.Button();
            this.donemeklemebutton = new System.Windows.Forms.Button();
            this.donemgeributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donemsilmebutton
            // 
            this.donemsilmebutton.Location = new System.Drawing.Point(131, 345);
            this.donemsilmebutton.Name = "donemsilmebutton";
            this.donemsilmebutton.Size = new System.Drawing.Size(204, 29);
            this.donemsilmebutton.TabIndex = 7;
            this.donemsilmebutton.Text = "Dönem Silme";
            this.donemsilmebutton.UseVisualStyleBackColor = true;
            // 
            // donemlistelemebutton
            // 
            this.donemlistelemebutton.Location = new System.Drawing.Point(131, 292);
            this.donemlistelemebutton.Name = "donemlistelemebutton";
            this.donemlistelemebutton.Size = new System.Drawing.Size(204, 29);
            this.donemlistelemebutton.TabIndex = 6;
            this.donemlistelemebutton.Text = "Dönem Listeleme";
            this.donemlistelemebutton.UseVisualStyleBackColor = true;
            // 
            // donemguncellemebutton
            // 
            this.donemguncellemebutton.Location = new System.Drawing.Point(131, 237);
            this.donemguncellemebutton.Name = "donemguncellemebutton";
            this.donemguncellemebutton.Size = new System.Drawing.Size(204, 29);
            this.donemguncellemebutton.TabIndex = 5;
            this.donemguncellemebutton.Text = "Dönem Güncelleme ";
            this.donemguncellemebutton.UseVisualStyleBackColor = true;
            // 
            // donemeklemebutton
            // 
            this.donemeklemebutton.Location = new System.Drawing.Point(131, 181);
            this.donemeklemebutton.Name = "donemeklemebutton";
            this.donemeklemebutton.Size = new System.Drawing.Size(204, 29);
            this.donemeklemebutton.TabIndex = 4;
            this.donemeklemebutton.Text = "Dönem Ekleme";
            this.donemeklemebutton.UseVisualStyleBackColor = true;
            // 
            // donemgeributton
            // 
            this.donemgeributton.Location = new System.Drawing.Point(194, 413);
            this.donemgeributton.Name = "donemgeributton";
            this.donemgeributton.Size = new System.Drawing.Size(72, 52);
            this.donemgeributton.TabIndex = 8;
            this.donemgeributton.Text = "Geri ";
            this.donemgeributton.UseVisualStyleBackColor = true;
            this.donemgeributton.Click += new System.EventHandler(this.donemgeributton_Click);
            // 
            // AdminDonem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 554);
            this.Controls.Add(this.donemgeributton);
            this.Controls.Add(this.donemsilmebutton);
            this.Controls.Add(this.donemlistelemebutton);
            this.Controls.Add(this.donemguncellemebutton);
            this.Controls.Add(this.donemeklemebutton);
            this.Name = "AdminDonem";
            this.Text = "AdminDonem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button donemsilmebutton;
        private System.Windows.Forms.Button donemlistelemebutton;
        private System.Windows.Forms.Button donemguncellemebutton;
        private System.Windows.Forms.Button donemeklemebutton;
        private System.Windows.Forms.Button donemgeributton;
    }
}