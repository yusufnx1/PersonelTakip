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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDep.Text;
            d.Aciklama = txtAcikla.Text;
            string sorgu = "insert into Departmanlar values('" + d.Departman + "','" + d.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("Departman Eklenmiştir.", "Ekleme Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepID.Text);
            d.Departman = txtDep.Text;
            d.Aciklama = txtAcikla.Text;
            string sorgu = "update Departmanlar set Departman='" + d.Departman + "',Aciklama='" + d.Aciklama + "'where DepartmanID='" + d.DepartmanID + "'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("Departman Güncellendi.", "Ekleme Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            d.Departman = txtDep.Text;
            d.Aciklama = txtAcikla.Text;
            string sorgu = "delete from Departmanlar where DepartmanID='" + d.DepartmanID + "'";
            SqlCommand komut = new SqlCommand();
            VeriTabani.ESG(komut, sorgu);
            MessageBox.Show("Departman Silindi.", "Ekleme Tamamlandı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Departmanlar.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDep.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAcikla.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
