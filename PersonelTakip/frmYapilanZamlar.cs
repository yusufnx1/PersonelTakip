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
    public partial class frmYapilanZamlar : Form
    {
        public frmYapilanZamlar()
        {
            InitializeComponent();
            comboPersoneller.SelectedIndex = 0;
            radioYuzde.Checked = true;

            YapilanZamlar.ComboyaPersonelGetir(comboPersoneller);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = false;
            txtYuzde.Enabled = true;
        }

        private void radioTl_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = true;
            txtYuzde.Enabled = false;
        }

        private void frmYapilanZamlar_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersoneller.SelectedIndex == 0)
            {
                lbl_PersonelID.Text = "0";
                return;
            }
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersoneller, lbl_PersonelID);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            YapilanZamlar y = new YapilanZamlar();
            y.Donem = comboAy.Text + "/" + comboYil.Text;
            y.Personel = comboPersoneller.Text;
            k.KullaniciID = Kullanicilar.kid;
            y.Aciklama = txtAciklama.Text;
            y.Tarih = DateTime.Now;
            if (radioYuzde.Checked)
            {
                y.Yuzde = decimal.Parse(txtYuzde.Text);
                //decimal yuzde = decimal.Parse(txtYuzde.Text);
                if (comboPersoneller.SelectedIndex == 0)
                {
                    string sogru = "update personeller set Maasi=maasi+(maasi*'" + y.Yuzde + "')/100";
                    SqlCommand komut = new();
                    VeriTabani.ESG(komut, sogru);
                    MessageBox.Show("Tüm personellere " + y.Yuzde + " zam yapıldı.", "Maaş zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sogru = "update personeller set Maasi=maasi+(maasi*'" + y.Yuzde + "')/100 where PersonelID='" + lbl_PersonelID.Text + "'";
                    SqlCommand komut = new();
                    VeriTabani.ESG(komut, sogru);
                    MessageBox.Show("" + comboPersoneller.Text + " personelin maaşına " + y.Yuzde + " zam yapıldı.", "Maaş zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sorgu2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Yuzde,Aciklama,Tarih)" +
                    "values ('" + k.KullaniciID + "','" + y.Donem + "','" + y.Personel + "',@Yuzde,'" + y.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = y.Yuzde;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                VeriTabani.ESG(komut2, sorgu2);

            }
            if (radioTl.Checked)
            {
                y.Fiyat = decimal.Parse(txtFiyat.Text);
                //decimal fiyat = decimal.Parse(txtFiyat.Text);
                if (comboPersoneller.SelectedIndex == 0)
                {
                    string sogru = "update personeller set Maasi=maasi+'" + y.Fiyat + "'";
                    SqlCommand komut = new();
                    VeriTabani.ESG(komut, sogru);
                    MessageBox.Show("Tüm personellere " + y.Fiyat + " zam yapıldı.", "Maaş zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sogru = "update personeller set Maasi=maasi+'" + y.Fiyat + "' where PersonelID='" + lbl_PersonelID.Text + "'";
                    SqlCommand komut = new();
                    VeriTabani.ESG(komut, sogru);
                    MessageBox.Show("" + comboPersoneller.Text + " Personelin maaşına  " + y.Fiyat + " zam yapıldı.", "Maaş zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sorgu2 = "insert into YapilanZamlar(KullaniciID,Donem,Personeller,Fiyat,Aciklama,Tarih)" +
                    "values ('" + k.KullaniciID + "','" + y.Donem + "','" + y.Personel + "',@Fiyat,'" + y.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = y.Fiyat;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                VeriTabani.ESG(komut2, sorgu2);
            }
        }
    }
}
