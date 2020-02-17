namespace WFA_GlobalAlan
{
    partial class Form1
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
            this.btnArttir = new System.Windows.Forms.Button();
            this.lblSayi = new System.Windows.Forms.Label();
            this.btnEksilt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArttir
            // 
            this.btnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArttir.Location = new System.Drawing.Point(50, 15);
            this.btnArttir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(150, 109);
            this.btnArttir.TabIndex = 0;
            this.btnArttir.Text = "Arttır";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayi.Location = new System.Drawing.Point(207, 31);
            this.lblSayi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(70, 76);
            this.lblSayi.TabIndex = 1;
            this.lblSayi.Text = "0";
            // 
            // btnEksilt
            // 
            this.btnEksilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEksilt.Location = new System.Drawing.Point(321, 15);
            this.btnEksilt.Margin = new System.Windows.Forms.Padding(6);
            this.btnEksilt.Name = "btnEksilt";
            this.btnEksilt.Size = new System.Drawing.Size(150, 109);
            this.btnEksilt.TabIndex = 0;
            this.btnEksilt.Text = "Eksilt";
            this.btnEksilt.UseVisualStyleBackColor = true;
            this.btnEksilt.Click += new System.EventHandler(this.btnEksilt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 143);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.btnEksilt);
            this.Controls.Add(this.btnArttir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Button btnEksilt;
    }
}

