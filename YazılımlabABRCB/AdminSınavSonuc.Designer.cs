namespace YazılımlabABRCB
{
    partial class AdminSınavSonuc
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
            this.sinavsonucgeributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinavsonucgeributton
            // 
            this.sinavsonucgeributton.Location = new System.Drawing.Point(347, 507);
            this.sinavsonucgeributton.Name = "sinavsonucgeributton";
            this.sinavsonucgeributton.Size = new System.Drawing.Size(72, 52);
            this.sinavsonucgeributton.TabIndex = 5;
            this.sinavsonucgeributton.Text = "Geri ";
            this.sinavsonucgeributton.UseVisualStyleBackColor = true;
            this.sinavsonucgeributton.Click += new System.EventHandler(this.sinavsonucgeributton_Click);
            // 
            // AdminSınavSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 560);
            this.Controls.Add(this.sinavsonucgeributton);
            this.Name = "AdminSınavSonuc";
            this.Text = "AdminSınavSonuc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinavsonucgeributton;
    }
}