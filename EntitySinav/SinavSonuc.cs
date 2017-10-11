using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySinav
{
    public partial class SinavSonuc : Form
    {
        public SinavSonuc()
        {
            InitializeComponent();
        }

        public List<Soru> sorular { get; set; }
        public List<string> yanitlar { get; set; }

        private void SinavSonuc_Load(object sender, EventArgs e)
        {
            lbl_soruSayisi.Text = sorular.Count.ToString();
            lbl_bos.Text = yanitlar.Where(x => string.IsNullOrEmpty(x)).Count().ToString();

            int yanlislar = 0;
            for (int i = 0; i < sorular.Count; i++) //List'in inisleri belli, kıyaslamak daha kolay o yüzden for
            {
                Soru s = sorular[i];

                Label a = new Label();
                a.Text = s.SoruCumlesi + " - Doğru Cevap: " + s.Cevap + " - ";
                a.AutoSize = false;
                a.Height = 50;
                a.Margin = new Padding(0,0,0,10); //Altta 10px boşluk
                a.Width = flowLayoutPanel1.Width;
                a.Font = new Font("Arial",12);

                if (s.Cevap != yanitlar[i])
                {
                    yanlislar++;
                    a.Text += " ("+ yanitlar[i]+ ")";
                    a.ForeColor = Color.Red;
                }
                flowLayoutPanel1.Controls.Add(a);
            }
            lbl_yanlis.Text = yanlislar.ToString();
            lbl_dogru.Text = (sorular.Count - (sorular.Count - yanitlar.Count) - yanlislar).ToString();
            //Doğru yanıt sayısı = Toplam soru sayısı - boş sayısı - yanlış yanıt sayısı
        }
    }
}
