using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySinav
{
    public partial class SoruYonet : Form
    {
        public SoruYonet()
        {
            InitializeComponent();
        }

        private void SoruYonet_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        public void Yenile()
        {
            SoruContext ctx = new SoruContext();
            listBox1.DataSource = (from x in ctx.Sorular select x).ToList(); //Tolist olmazsa sorgu olarak kalıyor.
            listBox1.DisplayMember = "SoruCumlesi";
            listBox1.ValueMember = "SoruID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoruContext ctx = new SoruContext();

            if (button1.Text == "EKLE")
            {
                Soru s = new Soru();
                s.Konu = textBox1.Text;
                s.SoruCumlesi = richTextBox1.Text;
                s.Cevap = textBox2.Text;

                DbEntityValidationResult d = ctx.Entry(s).GetValidationResult();
                if (d.IsValid)
                {
                    ctx.Sorular.Add(s);
                    MessageBox.Show("Başarıyla eklendi.");
                    EskiHali();
                }
                else
                {
                    string hata = "";
                    foreach (var item in d.ValidationErrors)
                    {
                        hata += item.ErrorMessage + "\n";
                    }
                    MessageBox.Show(hata);
                }
                ctx.SaveChanges();
            }
            else
            {
                //** UZUN HALİ **//
                //Soru duzenlenecek = (from x in ctx.Sorular where x.SoruID == (int)listBox1.SelectedValue select x).FirstOrDefault();

                Soru duzenlecek = ctx.Sorular.Find(listBox1.SelectedValue);
                //Find metodu verilen id deki elemanı getirir.
                duzenlecek.Konu = textBox1.Text;
                duzenlecek.Cevap = textBox2.Text;
                duzenlecek.SoruCumlesi = richTextBox1.Text;

                //** Düzenlenen şey modele uygunluğunu kontrol etmek için **//
                DbEntityValidationResult d = ctx.Entry(duzenlecek).GetValidationResult();
                if(d.IsValid) //modele uygunsa
                {
                    ctx.Entry(duzenlecek).State = System.Data.Entity.EntityState.Modified; //Kayıtta değişiklik yapıldığının belirtilmesi gerekiyor.State ile.
                    ctx.SaveChanges();
                    MessageBox.Show("Kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu");
                }
                EskiHali();
            }

            Yenile();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int i = listBox1.IndexFromPoint(e.Location);
                listBox1.SelectedIndex = i;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult d = MessageBox.Show("Emin misiniz?","Soru sil",MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                SoruContext ctx = new SoruContext();
                Soru silinecek = ctx.Sorular.Find(listBox1.SelectedValue);
                ctx.Sorular.Remove(silinecek);
                ctx.SaveChanges();
                Yenile();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "DÜZENLE";
            groupBox1.Text = "Soru Düzenle";

            SoruContext ctx = new SoruContext();
            Soru soru = ctx.Sorular.Find(listBox1.SelectedValue);
            textBox1.Text = soru.Konu;
            textBox2.Text = soru.Cevap;
            richTextBox1.Text = soru.SoruCumlesi;
        }

        public void EskiHali()
        {
            button1.Text = "EKLE";
            groupBox1.Text = "Yeni Soru";

            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
