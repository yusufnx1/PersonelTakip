
namespace PersonelTakip
{
    partial class frmMesaiEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAdSoyad = new System.Windows.Forms.ComboBox();
            this.dateBasla = new System.Windows.Forms.DateTimePicker();
            this.maskedBasla = new System.Windows.Forms.MaskedTextBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtSaatUcret = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad - Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Saati : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mesai Saat Ücreti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tutar :";
            // 
            // comboAdSoyad
            // 
            this.comboAdSoyad.FormattingEnabled = true;
            this.comboAdSoyad.Location = new System.Drawing.Point(119, 34);
            this.comboAdSoyad.Name = "comboAdSoyad";
            this.comboAdSoyad.Size = new System.Drawing.Size(221, 23);
            this.comboAdSoyad.TabIndex = 1;
            this.comboAdSoyad.SelectedIndexChanged += new System.EventHandler(this.comboAdSoyad_SelectedIndexChanged);
            // 
            // dateBasla
            // 
            this.dateBasla.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBasla.Location = new System.Drawing.Point(120, 63);
            this.dateBasla.Name = "dateBasla";
            this.dateBasla.Size = new System.Drawing.Size(115, 23);
            this.dateBasla.TabIndex = 2;
            // 
            // maskedBasla
            // 
            this.maskedBasla.Location = new System.Drawing.Point(241, 63);
            this.maskedBasla.Mask = "90:00";
            this.maskedBasla.Name = "maskedBasla";
            this.maskedBasla.Size = new System.Drawing.Size(99, 23);
            this.maskedBasla.TabIndex = 3;
            this.maskedBasla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBasla.ValidatingType = typeof(System.DateTime);
            // 
            // dateBitis
            // 
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(120, 95);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(115, 23);
            this.dateBitis.TabIndex = 2;
            // 
            // maskedBitis
            // 
            this.maskedBitis.Location = new System.Drawing.Point(241, 95);
            this.maskedBitis.Mask = "90:00";
            this.maskedBitis.Name = "maskedBitis";
            this.maskedBitis.Size = new System.Drawing.Size(99, 23);
            this.maskedBitis.TabIndex = 3;
            this.maskedBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBitis.ValidatingType = typeof(System.DateTime);
            // 
            // txtSaatUcret
            // 
            this.txtSaatUcret.Location = new System.Drawing.Point(119, 130);
            this.txtSaatUcret.Name = "txtSaatUcret";
            this.txtSaatUcret.Size = new System.Drawing.Size(221, 23);
            this.txtSaatUcret.TabIndex = 4;
            this.txtSaatUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaatUcret.TextChanged += new System.EventHandler(this.txtSaatUcret_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(120, 159);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(221, 23);
            this.txtTutar.TabIndex = 4;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1 - Ocak",
            "2 - Şubat",
            "3 - Mart ",
            "4 - Nisan",
            "5 - Mayıs ",
            "6 - Haziran ",
            "7 - Temmuz ",
            "8 - Ağustos ",
            "9 - Eylül ",
            "10 - Ekim",
            "11 - Kasım ",
            "12 - Aralık"});
            this.comboAy.Location = new System.Drawing.Point(120, 188);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(99, 23);
            this.comboAy.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dönem :";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(241, 188);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(99, 23);
            this.comboYil.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 223);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 80);
            this.txtAciklama.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Açıklama :";
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesaiEkle.ImageKey = "insert-icon.png";
            this.btnMesaiEkle.ImageList = this.ımageList1;
            this.btnMesaiEkle.Location = new System.Drawing.Point(119, 327);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(116, 40);
            this.btnMesaiEkle.TabIndex = 7;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit-icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(241, 327);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(99, 40);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(222, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "/";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete-icon.jpg");
            this.ımageList1.Images.SetKeyName(1, "exit-icon.png");
            this.ımageList1.Images.SetKeyName(2, "insert-icon.png");
            this.ımageList1.Images.SetKeyName(3, "save-icon.png");
            this.ımageList1.Images.SetKeyName(4, "update-icon.png");
            // 
            // frmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 383);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtSaatUcret);
            this.Controls.Add(this.maskedBitis);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.maskedBasla);
            this.Controls.Add(this.dateBasla);
            this.Controls.Add(this.comboAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAdSoyad;
        private System.Windows.Forms.DateTimePicker dateBasla;
        private System.Windows.Forms.MaskedTextBox maskedBasla;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.MaskedTextBox maskedBitis;
        private System.Windows.Forms.TextBox txtSaatUcret;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
    }
}