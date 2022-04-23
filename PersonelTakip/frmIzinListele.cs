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
    public partial class frmIzinListele : Form
    {
        public frmIzinListele()
        {
            InitializeComponent();
            VeriTabani.Listele_Ara(dataGridView1, "select * from izinler");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            İzinler i = new İzinler();
            Kullanicilar k = new Kullanicilar();

            i.İzinID = int.Parse(txtIzinID.Text);
            i.PersonelID = int.Parse(txtPerID.Text);
            i.İzinBaslangic = dateTimeBasla.Value;
            i.IzinBitis = dateTimeBitis.Value;
            i.Tarih = dateTimeTarih.Value;
            i.Aciklama = txtAciklama.Text;
            k.KullaniciID = Kullanicilar.kid;

            string sorgu = "Update İzinler set İzinBaslangic=@İzinBaslangic,İzinBitis=@İzinBitis,Tarih=@Tarih, Aciklama = '" + i.Aciklama + "' where İzinID='"+i.İzinID+"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@İzinBaslangic", SqlDbType.Date).Value = i.İzinBaslangic;
            komut.Parameters.Add("@İzinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("Tarih", SqlDbType.Date).Value = i.Tarih;
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("İzin Güncellendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "select * from izinler");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIzinID.Text = dataGridView1.CurrentRow.Cells["İzinID"].Value.ToString();
            txtPerID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            dateTimeBasla.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["İzinBaslangic"].Value.ToString());
            dateTimeBitis.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["İzinBitis"].Value.ToString());
            dateTimeTarih.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            İzinler i = new İzinler();
            i.İzinID = int.Parse(txtIzinID.Text);

            string sorgu = "Delete from İzinler where İzinID='"+i.İzinID+"'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut,sorgu);
            MessageBox.Show("İzin Silinmiştir.","İşlem Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            VeriTabani.Listele_Ara(dataGridView1, "select * from izinler");
        }
    }
}
