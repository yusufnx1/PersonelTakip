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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();

        }
        void temizle()
        {
            dateTimePicker1.Value = DateTime.Now;
            comboDepId.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtPerAd.Text;
            p.Soyadi = txtPerSoyad.Text;
            p.Telefon = txtPerTel.Text;
            p.Adres = txtPerAdres.Text;
            p.Email = txtPersEmail.Text;
            p.DepartmanID = (int)comboDepId.SelectedValue;
            p.Maasi = decimal.Parse(txtPerMaas.Text);
            p.GirisTarihi = dateTimePicker1.Value;
            p.Aciklama = txtPerAcikla.Text;
            string sorgu = "insert into Personeller(Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maasi,GirisTarihi,Aciklama) values('" + p.Adi + "','" + p.Soyadi + "','" + p.Telefon + "','" + p.Adres + "','" + p.Email + "','" + p.DepartmanID + "',@Maasi,@GirisTarihi,'" + p.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
            VeriTabani.ESG(komut, sorgu);
            temizle();
            MessageBox.Show("İşlem Başarılı.");
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaBilgiGetir(comboDepId);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
