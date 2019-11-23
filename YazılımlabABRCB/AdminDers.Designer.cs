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
            this.derssilmebutton = new System.Windows.Forms.Button();
            this.derslistelemebutton = new System.Windows.Forms.Button();
            this.dersgüncellemebutton = new System.Windows.Forms.Button();
            this.derseklemebutton = new System.Windows.Forms.Button();
            this.dersgeributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // derssilmebutton
            // 
            this.derssilmebutton.Location = new System.Drawing.Point(132, 326);
            this.derssilmebutton.Name = "derssilmebutton";
            this.derssilmebutton.Size = new System.Drawing.Size(204, 29);
            this.derssilmebutton.TabIndex = 7;
            this.derssilmebutton.Text = "Ders Silme";
            this.derssilmebutton.UseVisualStyleBackColor = true;
            // 
            // derslistelemebutton
            // 
            this.derslistelemebutton.Location = new System.Drawing.Point(132, 273);
            this.derslistelemebutton.Name = "derslistelemebutton";
            this.derslistelemebutton.Size = new System.Drawing.Size(204, 29);
            this.derslistelemebutton.TabIndex = 6;
            this.derslistelemebutton.Text = "Ders Listeleme";
            this.derslistelemebutton.UseVisualStyleBackColor = true;
            // 
            // dersgüncellemebutton
            // 
            this.dersgüncellemebutton.Location = new System.Drawing.Point(132, 218);
            this.dersgüncellemebutton.Name = "dersgüncellemebutton";
            this.dersgüncellemebutton.Size = new System.Drawing.Size(204, 29);
            this.dersgüncellemebutton.TabIndex = 5;
            this.dersgüncellemebutton.Text = "Ders Güncelleme";
            this.dersgüncellemebutton.UseVisualStyleBackColor = true;
            // 
            // derseklemebutton
            // 
            this.derseklemebutton.Location = new System.Drawing.Point(132, 162);
            this.derseklemebutton.Name = "derseklemebutton";
            this.derseklemebutton.Size = new System.Drawing.Size(204, 29);
            this.derseklemebutton.TabIndex = 4;
            this.derseklemebutton.Text = "Ders Ekleme";
            this.derseklemebutton.UseVisualStyleBackColor = true;
            // 
            // dersgeributton
            // 
            this.dersgeributton.Location = new System.Drawing.Point(196, 405);
            this.dersgeributton.Name = "dersgeributton";
            this.dersgeributton.Size = new System.Drawing.Size(72, 52);
            this.dersgeributton.TabIndex = 8;
            this.dersgeributton.Text = "Geri ";
            this.dersgeributton.UseVisualStyleBackColor = true;
            this.dersgeributton.Click += new System.EventHandler(this.dersgeributton_Click);
            // 
            // AdminDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 549);
            this.Controls.Add(this.dersgeributton);
            this.Controls.Add(this.derssilmebutton);
            this.Controls.Add(this.derslistelemebutton);
            this.Controls.Add(this.dersgüncellemebutton);
            this.Controls.Add(this.derseklemebutton);
            this.Name = "AdminDers";
            this.Text = "AdminDers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button derssilmebutton;
        private System.Windows.Forms.Button derslistelemebutton;
        private System.Windows.Forms.Button dersgüncellemebutton;
        private System.Windows.Forms.Button derseklemebutton;
        private System.Windows.Forms.Button dersgeributton;
    }
}