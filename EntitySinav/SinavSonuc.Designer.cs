namespace EntitySinav
{
    partial class SinavSonuc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_soruSayisi = new System.Windows.Forms.Label();
            this.lbl_bos = new System.Windows.Forms.Label();
            this.lbl_dogru = new System.Windows.Forms.Label();
            this.lbl_yanlis = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Boş bırakılan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğru Cevap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yanlış Cevap:";
            // 
            // lbl_soruSayisi
            // 
            this.lbl_soruSayisi.AutoSize = true;
            this.lbl_soruSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soruSayisi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_soruSayisi.Location = new System.Drawing.Point(138, 32);
            this.lbl_soruSayisi.Name = "lbl_soruSayisi";
            this.lbl_soruSayisi.Size = new System.Drawing.Size(52, 18);
            this.lbl_soruSayisi.TabIndex = 1;
            this.lbl_soruSayisi.Text = "label5";
            // 
            // lbl_bos
            // 
            this.lbl_bos.AutoSize = true;
            this.lbl_bos.ForeColor = System.Drawing.Color.Black;
            this.lbl_bos.Location = new System.Drawing.Point(138, 62);
            this.lbl_bos.Name = "lbl_bos";
            this.lbl_bos.Size = new System.Drawing.Size(46, 18);
            this.lbl_bos.TabIndex = 1;
            this.lbl_bos.Text = "label5";
            // 
            // lbl_dogru
            // 
            this.lbl_dogru.AutoSize = true;
            this.lbl_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dogru.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_dogru.Location = new System.Drawing.Point(138, 96);
            this.lbl_dogru.Name = "lbl_dogru";
            this.lbl_dogru.Size = new System.Drawing.Size(52, 18);
            this.lbl_dogru.TabIndex = 1;
            this.lbl_dogru.Text = "label5";
            // 
            // lbl_yanlis
            // 
            this.lbl_yanlis.AutoSize = true;
            this.lbl_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yanlis.ForeColor = System.Drawing.Color.Red;
            this.lbl_yanlis.Location = new System.Drawing.Point(138, 130);
            this.lbl_yanlis.Name = "lbl_yanlis";
            this.lbl_yanlis.Size = new System.Drawing.Size(52, 18);
            this.lbl_yanlis.TabIndex = 1;
            this.lbl_yanlis.Text = "label5";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 164);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 237);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SinavSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 422);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_yanlis);
            this.Controls.Add(this.lbl_dogru);
            this.Controls.Add(this.lbl_bos);
            this.Controls.Add(this.lbl_soruSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SinavSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinavSonuc";
            this.Load += new System.EventHandler(this.SinavSonuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_soruSayisi;
        private System.Windows.Forms.Label lbl_bos;
        private System.Windows.Forms.Label lbl_dogru;
        private System.Windows.Forms.Label lbl_yanlis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}