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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGiris(txtKulAdi.Text,txtSifre.Text);
            if (Kullanicilar.durum==true)
            {
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Temizle();
            }
        }

        void Temizle()
        {
            txtKulAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
         
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {

        }
    }
}
