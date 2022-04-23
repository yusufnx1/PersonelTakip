using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersonelGetir(comboAdSoyad);
        }
        Label lbl;
        private void comboAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboAdSoyad, lbl);
            MessageBox.Show(lbl.Text);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller(); // 3 sınıftan nesne türetildi.
            Mesailer m = new Mesailer();

            k.KullaniciID = Kullanicilar.kid;
            p.PersonelID = int.Parse(lbl.Text);
            m.Baslangic_Saati = dateBasla.Text + " " + maskedBasla.Text;
            m.Bitis_Saati = dateBitis.Text + " " + maskedBitis.Text; // sınıflardaki nesneler formdaki yerleriyle eşleştirildi.
            m.MesaiSaatUcreti = decimal.Parse(txtSaatUcret.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;

            string sorgu = "insert into Mesailer (KullaniciID,PersonelID,BaslangicSaati,BitisSaati,MesaiSaatUcreti,Tutar,Donem,Aciklama,Tarih) values ('"+k.KullaniciID+"','"+p.PersonelID+"','"+m.Baslangic_Saati+"','"+m.Bitis_Saati+"',@MSaatUcreti,@Tutar,'"+m.Donem+"','"+m.Aciklama+"',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MSaatUcreti", SqlDbType.Decimal).Value=m.MesaiSaatUcreti;
            komut.Parameters.Add("@Tutar",SqlDbType.Decimal).Value=m.Tutar;
            komut.Parameters.Add("@Tarih",SqlDbType.Date).Value=m.Tarih;
            VeriTabani.ESG(komut, sorgu);

            MessageBox.Show("Mesai Ekleme İşlemi Tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSaatUcret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangıc = dateBasla.Text + " " + maskedBasla.Text;
                string bitis = dateBitis.Text + " " + maskedBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangıc);
                double MSaatUcreti = double.Parse(txtSaatUcret.Text);
                double tutar = saatfarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

                
            }
        }
    }
}
