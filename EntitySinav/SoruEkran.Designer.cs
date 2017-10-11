namespace EntitySinav
{
    partial class SoruEkran
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
            this.lbl_Konu = new System.Windows.Forms.Label();
            this.lbl_Soru = new System.Windows.Forms.Label();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.lbl_Kactayiz = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Konu
            // 
            this.lbl_Konu.AutoSize = true;
            this.lbl_Konu.Location = new System.Drawing.Point(13, 22);
            this.lbl_Konu.Name = "lbl_Konu";
            this.lbl_Konu.Size = new System.Drawing.Size(46, 18);
            this.lbl_Konu.TabIndex = 0;
            this.lbl_Konu.Text = "label1";
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.Location = new System.Drawing.Point(13, 52);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(576, 123);
            this.lbl_Soru.TabIndex = 1;
            this.lbl_Soru.Text = "label2";
            // 
            // txt_cevap
            // 
            this.txt_cevap.Location = new System.Drawing.Point(85, 197);
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(440, 24);
            this.txt_cevap.TabIndex = 2;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(16, 354);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(98, 33);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "<< Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(472, 354);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(94, 33);
            this.btn_ileri.TabIndex = 3;
            this.btn_ileri.Text = "İleri >>";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // lbl_Kactayiz
            // 
            this.lbl_Kactayiz.AutoSize = true;
            this.lbl_Kactayiz.Location = new System.Drawing.Point(520, 22);
            this.lbl_Kactayiz.Name = "lbl_Kactayiz";
            this.lbl_Kactayiz.Size = new System.Drawing.Size(46, 18);
            this.lbl_Kactayiz.TabIndex = 0;
            this.lbl_Kactayiz.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SoruEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txt_cevap);
            this.Controls.Add(this.lbl_Soru);
            this.Controls.Add(this.lbl_Kactayiz);
            this.Controls.Add(this.lbl_Konu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SoruEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruEkran";
            this.Load += new System.EventHandler(this.SoruEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Konu;
        private System.Windows.Forms.Label lbl_Soru;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Label lbl_Kactayiz;
        private System.Windows.Forms.Button button1;
    }
}