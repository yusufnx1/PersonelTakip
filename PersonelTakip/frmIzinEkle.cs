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
    public partial class frmIzinEkle : Form
    {
        public frmIzinEkle()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIzinEkle_Load(object sender, EventArgs e)
        {
            txtIzinID.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            İzinler i = new İzinler();
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
          
            i.PersonelID = int.Parse(txtPerID.Text);
            i.İzinBaslangic = dateTimeBasla.Value;
            i.IzinBitis = dateTimebitis.Value;
            i.Tarih = DateTime.Now;
            i.Aciklama = txtAciklama.Text;
            
            string sorgu = "insert into İzinler values('"+i.İzinID+"','"+i.PersonelID+"',@İzinBaslangic,@İzinBitis,@Tarih,'"+i.Aciklama+"')";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@İzinBaslangic",SqlDbType.Date).Value=i.İzinBaslangic;
            komut.Parameters.Add("@İzinBitis",SqlDbType.Date).Value=i.IzinBitis;
            komut.Parameters.Add("@Tarih",SqlDbType.Date).Value=i.Tarih;
            VeriTabani.ESG(komut,sorgu);
            MessageBox.Show("İzin Eklenmiştir.","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtPerID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPerID, txtAdSoyad);
        }

        private void txtIzinID_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
