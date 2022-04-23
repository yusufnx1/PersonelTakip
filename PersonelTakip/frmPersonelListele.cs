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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            YenileListele();
            Personeller.ComboyaBilgiGetir(comboDepId);
        }

        private void YenileListele()
        {
            VeriTabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID");
            lblToplamKayit.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " Kayıt Listelendi.";
            decimal toplammaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                toplammaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
            }
            lblToplamMaas.Text = "Toplam Maaş tutarı " + toplammaas + "TL";
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelID = int.Parse(txtPersID.Text);
            p.Adi = txtPerAd.Text;
            p.Soyadi = txtPerSoyad.Text;
            p.Telefon = txtPerTel.Text;
            p.Adres = txtPerAdres.Text;
            p.Email = txtPersEmail.Text;
            p.DepartmanID = (int)comboDepId.SelectedValue;
            p.Maasi = decimal.Parse(txtPerMaas.Text);
            p.GirisTarihi = dateTimePicker1.Value;
            p.Aciklama = txtPerAcikla.Text;
            string sorgu = "update personeller set Adi='" + p.Adi + "',Soyadi='" + p.Soyadi + "',Telefon='" + p.Telefon + "',Adres='" + p.Adres + "',Email='" + p.Email + "',DepartmanID='" + p.DepartmanID + "', Maasi = @Maasi , GirisTarihi = @GirisTarihi , Aciklama='" + p.Aciklama + "' where PersonelID='" + p.PersonelID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
            VeriTabani.ESG(komut, sorgu);
            temizle();
            MessageBox.Show("İşlem Başarıyla Gerçekleşti", "Güncelleme İşlemi.", MessageBoxButtons.OK);
            YenileListele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPerAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPerSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPerTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPerAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPersEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPerMaas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtPerAcikla.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sorgu = "delete from personeller where PersonelID='" + p.PersonelID + "'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            temizle();
            MessageBox.Show("İşlem Başarılı", "Silme İşlemi", MessageBoxButtons.OK);
            YenileListele();
        }

        private void txtIDara_TextChanged(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and PersonelID like '%" + txtIDara.Text + "%'");

        }

        private void txtAdara_TextChanged(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Adi like '%" + txtAdara.Text + "%'");
        }

        private void txtSoyadara_TextChanged(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Soyadi like '%" + txtSoyadara.Text + "%'");
        }

        private void txtTelara_TextChanged(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, p.Maasi, p.GirisTarihi, p.Aciklama from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID and Telefon like '%" + txtTelara.Text + "%'");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //Personeller.TariheGore(dateTimePicker2,dataGridView1);
        }
    }
}
