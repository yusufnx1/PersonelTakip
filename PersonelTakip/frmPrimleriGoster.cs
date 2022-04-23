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
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdemeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPerID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutar.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            }
        }

        private void txtPerID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPerID, txtPerAdSoyad);
        }

        private void txtPerAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            string sorgu = "Update Primler set Donem='" + p.Donem + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı", "Dönem Değiştirildi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
            btnTemizle.PerformClick();
        }

        private void txtTumPrimOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            string sorgu = "Update Primler set OdemeDurumu='" + p.OdenmeDurumu + "' where OdemeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı", "Prim Ödendi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
            btnTemizle.PerformClick();
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrimID.Text);
            string sorgu = "Update Primler set OdemeDurumu='" + p.OdenmeDurumu + "' where PrimID='" + p.PrimID + "' and OdemeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı", "Prim Ödendi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
            btnTemizle.PerformClick();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPerID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutar.Text);
            p.Aciklama = txtAciklama.Text;
            string sorgu = "Update Primler set PersonelID='" + p.PersonelID + "',PrimTutari=@PrimTutari,Aciklama='" + p.Aciklama + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value=p.PrimTutari;
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı", "Prim Güncellendi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
            btnTemizle.PerformClick();
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Primler p = new Primler();
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                string sorgu = "Delete from Primler where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı", "Prim Silindi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView1, "Select * from Primler");
                btnTemizle.PerformClick();
            }
        }
    }
}
