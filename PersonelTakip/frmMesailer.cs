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
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPerID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPerID, txtAdSoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
                txtPerID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
                txtSaatUcret.Text = dataGridView1.CurrentRow.Cells["MesaiSaatUcreti"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

                string baslangıc = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
                string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();

                dateBasla.Text = baslangıc.Substring(0, 10);
                maskedBasla.Text = baslangıc.Substring(11);

                dateBitis.Text = bitis.Substring(0, 10);
                maskedBitis.Text = bitis.Substring(11);

                int say = donem.IndexOf("/");
                comboAy.Text = donem.Substring(0, say);
                comboYil.Text = donem.Substring(say + 1);
            }
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
                dateBasla.Value = DateTime.Now;
                dateBitis.Value = DateTime.Now;
            }
        }

        private void btnTumMesaiOde_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.OdemeDurumu = "Ödendi";
            string sorgu = "update Mesailer set OdemeDurumu='" + m.OdemeDurumu + "' where OdemeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("Tüm Mesailer Ödendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.MesaiID = int.Parse(txtMesaiID.Text);
            m.OdemeDurumu = "Ödendi";
            string sorgu = "update Mesailer set OdemeDurumu='" + m.OdemeDurumu + "'where MesaiID='" + m.MesaiID + "'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("Mesai Ödendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.MesaiID = int.Parse(txtMesaiID.Text);
            if (MessageBox.Show("Bu Kayıt Silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu = "delete from Mesailer where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.ESG(komut, sorgu);
                MessageBox.Show("Mesai Silidi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTemizle.PerformClick();
                VeriTabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Personeller p = new Personeller();

            p.PersonelID = int.Parse(txtPerID.Text);
            m.MesaiID = int.Parse(txtMesaiID.Text);
            m.Baslangic_Saati = dateBasla.Text + " " + maskedBasla.Text;
            m.Bitis_Saati = dateBitis.Text + " " + maskedBitis.Text;
            m.MesaiSaatUcreti = decimal.Parse(txtSaatUcret.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;

            string sorgu = "update Mesailer set PersonelID='"+p.PersonelID+"',BaslangicSaati='"+m.Baslangic_Saati+"',BitisSaati='"+m.Bitis_Saati+"',MesaiSaatUcreti=@MSaatUcreti,Tutar=@Tutar,Donem='"+m.Donem+"',Aciklama='"+m.Aciklama+"',Tarih=@Tarih where MesaiID='"+m.MesaiID+"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MSaatUcreti",SqlDbType.Decimal).Value=m.MesaiSaatUcreti;
            komut.Parameters.Add("@Tutar",SqlDbType.Decimal).Value=m.Tutar;
            komut.Parameters.Add("@Tarih",SqlDbType.Date).Value=m.Tarih;
            VeriTabani.ESG(komut,sorgu);

            MessageBox.Show("Mesai Güncelleme işlemi tamamlandı.","İşlem başarıl.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
        }
    }
}
