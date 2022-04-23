using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnDepEkle_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersListe_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.ShowDialog();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            frmKullanicilar k = new frmKullanicilar();
            k.ShowDialog();
        }

        private void btnZamYap_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar frm = new frmYapilanZamlar();
            frm.ShowDialog();
        }

        private void btnPrimler_Click(object sender, EventArgs e)
        {
            frmPrimEkle frm = new frmPrimEkle();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnİzinHareketEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnİzinHareketListele_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmIzinEkle frm = new frmIzinEkle();
            frm.ShowDialog();
        }

        private void btnIzinListele_Click(object sender, EventArgs e)
        {
            frmIzinListele frm = new frmIzinListele();
            frm.ShowDialog();
        }
    }
}
