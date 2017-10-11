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
    public partial class SoruEkran : Form
    {
        public SoruEkran()
        {
            InitializeComponent();
        }

        int kactayiz = 0;
        int soruSayisi = 5;
        List<Soru> sinav = new List<Soru>(); //0 1 2 3 4
        List<string> cevaplar = new List<string>(); //Kullanıcının verdiği cevaplar

        void SoruGoster(string islem)
        {
            cevaplar[kactayiz] = txt_cevap.Text;

            if (islem == "geri")
                kactayiz--;
            else if (islem == "ileri")
                kactayiz++;

            Soru s = sinav[kactayiz];
            lbl_Konu.Text = s.Konu;
            lbl_Soru.Text = s.SoruCumlesi;

            lbl_Kactayiz.Text = (kactayiz + 1) + " / " + soruSayisi;

            if (kactayiz == 0)
                btn_geri.Enabled = false;
            else
                btn_geri.Enabled = true;

            if (kactayiz == soruSayisi - 1)
                btn_ileri.Enabled = false;
            else
                btn_ileri.Enabled = true;
        }

        private void SoruEkran_Load(object sender, EventArgs e)
        {
            SoruContext ctx = new SoruContext();
            sinav = ctx.Sorular.Take(soruSayisi).ToList(); //ilk soruSayisi kadar
            //sinav = ctx.Sorular.OrderBy(x => new Guid()).ToList(); //Rastgele soru
            //sinav = ctx.Sorular.OrderByDescending(x => x.SoruID).Take(5).ToList(); //Sondan 5 soru
            soruSayisi = sinav.Count;
            foreach (var item in sinav)
            {
                cevaplar.Add("");
            }
            SoruGoster("");
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            SoruGoster("ileri");
            txt_cevap.Text = "";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            SoruGoster("geri");
            txt_cevap.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cevaplar[kactayiz] = txt_cevap.Text;
            SinavSonuc s = new SinavSonuc();
            s.yanitlar = cevaplar;
            s.sorular = sinav;
            s.Show();
            this.Hide();

        }
    }
}
