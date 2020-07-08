namespace ApartmanOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Gelirler = new System.Windows.Forms.Button();
            this.btn_Giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gelirler
            // 
            this.btn_Gelirler.Location = new System.Drawing.Point(39, 48);
            this.btn_Gelirler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Gelirler.Name = "btn_Gelirler";
            this.btn_Gelirler.Size = new System.Drawing.Size(242, 436);
            this.btn_Gelirler.TabIndex = 0;
            this.btn_Gelirler.Text = "Gelirler";
            this.btn_Gelirler.UseVisualStyleBackColor = true;
            this.btn_Gelirler.Click += new System.EventHandler(this.btn_Gelirler_Click);
            // 
            // btn_Giderler
            // 
            this.btn_Giderler.Location = new System.Drawing.Point(394, 48);
            this.btn_Giderler.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Giderler.Name = "btn_Giderler";
            this.btn_Giderler.Size = new System.Drawing.Size(242, 436);
            this.btn_Giderler.TabIndex = 1;
            this.btn_Giderler.Text = "Giderler";
            this.btn_Giderler.UseVisualStyleBackColor = true;
            this.btn_Giderler.Click += new System.EventHandler(this.btn_Giderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 557);
            this.Controls.Add(this.btn_Giderler);
            this.Controls.Add(this.btn_Gelirler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gelirler;
        private System.Windows.Forms.Button btn_Giderler;
    }
}

