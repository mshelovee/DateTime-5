namespace DateTime_5___96
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
            this.btnMka = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnBaslangic = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMka
            // 
            this.btnMka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMka.Location = new System.Drawing.Point(38, 104);
            this.btnMka.Name = "btnMka";
            this.btnMka.Size = new System.Drawing.Size(123, 42);
            this.btnMka.TabIndex = 0;
            this.btnMka.Text = "MKA";
            this.btnMka.UseVisualStyleBackColor = true;
            this.btnMka.Click += new System.EventHandler(this.btnMka_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(35, 66);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(22, 16);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "***";
            // 
            // btnBaslangic
            // 
            this.btnBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslangic.Location = new System.Drawing.Point(167, 104);
            this.btnBaslangic.Name = "btnBaslangic";
            this.btnBaslangic.Size = new System.Drawing.Size(123, 42);
            this.btnBaslangic.TabIndex = 2;
            this.btnBaslangic.Text = "Başlangıç";
            this.btnBaslangic.UseVisualStyleBackColor = true;
            this.btnBaslangic.Click += new System.EventHandler(this.btnBaslangic_Click);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToday.Location = new System.Drawing.Point(296, 104);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(123, 42);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 178);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnBaslangic);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnMka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMka;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnBaslangic;
        private System.Windows.Forms.Button btnToday;
    }
}

