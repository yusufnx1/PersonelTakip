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
    public partial class frmPrimEkle : Form
    {
        public frmPrimEkle()
        {
            InitializeComponent();
        }

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            VeriTabani.Listele_Ara(dataGridView1, "select PersonelID, Adi, Soyadi, Maasi, GirisTarihi from personeller");
        }

        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.KullaniciID = Kullanicilar.kid;
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimTutari = decimal.Parse(txtPrimTutar.Text);
            p.Aciklama = txtAciklama.Text;
            p.Tarih = DateTime.Now;
            if (radioKisi.Checked)
            {
                p.PersonelID = int.Parse(txtPerID.Text);
                string sorgu = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih) " +
                    "values('" + p.KullaniciID + "','" + p.PersonelID + "','" + p.Donem + "',@PrimTutari,'" + p.Aciklama + "',@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                VeriTabani.ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı.", "Tamamlandı", MessageBoxButtons.OK);
            }
            else if (radioPersonel.Checked)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string sorgu = "insert into Primler(KullaniciID,PersonelID,Donem,PrimTutari,Aciklama,Tarih) " +
                    "values('" + p.KullaniciID + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + p.Donem + "',@PrimTutari,'" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    VeriTabani.ESG(komut, sorgu);
                    MessageBox.Show("İşlem Başarılı.", "Tamamlandı", MessageBoxButtons.OK);
                }
            }
            btnTemizle.PerformClick();
        }

        private void btnPrimGoster_Click(object sender, EventArgs e)
        {
            frmPrimleriGoster frm = new frmPrimleriGoster();
            frm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPerAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void radioPersonel_CheckedChanged(object sender, EventArgs e)
        {
            txtPerID.Enabled = false;
            txtPerAdSoyad.Enabled = false;
        }

        private void comboYil_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelPrimleri_Click(object sender, EventArgs e)
        {
            frmPersoneleGorePrimler frm = new frmPersoneleGorePrimler();
            frm.txtPersID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            VeriTabani.Listele_Ara(frm.dataGridView1,"Select * from Primler where PersonelID='"+frm.txtPersID.Text+"'");
            frm.ShowDialog();
        }
    }
}
