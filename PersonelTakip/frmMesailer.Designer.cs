
namespace PersonelTakip
{
    partial class frmMesailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesailer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtSaatUcret = new System.Windows.Forms.TextBox();
            this.maskedBitis = new System.Windows.Forms.MaskedTextBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedBasla = new System.Windows.Forms.MaskedTextBox();
            this.dateBasla = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPerID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTumMesaiOde = new System.Windows.Forms.Button();
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(875, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(531, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(551, 282);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(96, 23);
            this.comboYil.TabIndex = 22;
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
            this.comboAy.Location = new System.Drawing.Point(426, 282);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(99, 23);
            this.comboAy.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dönem :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(426, 311);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 77);
            this.txtAciklama.TabIndex = 17;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(112, 469);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(221, 23);
            this.txtTutar.TabIndex = 18;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaatUcret
            // 
            this.txtSaatUcret.Location = new System.Drawing.Point(112, 440);
            this.txtSaatUcret.Name = "txtSaatUcret";
            this.txtSaatUcret.Size = new System.Drawing.Size(221, 23);
            this.txtSaatUcret.TabIndex = 19;
            this.txtSaatUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaatUcret.TextChanged += new System.EventHandler(this.txtSaatUcret_TextChanged);
            // 
            // maskedBitis
            // 
            this.maskedBitis.Location = new System.Drawing.Point(234, 405);
            this.maskedBitis.Mask = "90:00";
            this.maskedBitis.Name = "maskedBitis";
            this.maskedBitis.Size = new System.Drawing.Size(99, 23);
            this.maskedBitis.TabIndex = 15;
            this.maskedBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateBitis
            // 
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(113, 405);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(115, 23);
            this.dateBitis.TabIndex = 13;
            // 
            // maskedBasla
            // 
            this.maskedBasla.Location = new System.Drawing.Point(234, 373);
            this.maskedBasla.Mask = "90:00";
            this.maskedBasla.Name = "maskedBasla";
            this.maskedBasla.Size = new System.Drawing.Size(99, 23);
            this.maskedBasla.TabIndex = 16;
            this.maskedBasla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBasla.ValidatingType = typeof(System.DateTime);
            // 
            // dateBasla
            // 
            this.dateBasla.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBasla.Location = new System.Drawing.Point(113, 373);
            this.dateBasla.Name = "dateBasla";
            this.dateBasla.Size = new System.Drawing.Size(115, 23);
            this.dateBasla.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mesai Saat Ücreti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bitiş Saati :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Başlangıç Saati : ";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(112, 282);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(140, 23);
            this.txtMesaiID.TabIndex = 25;
            // 
            // txtPerID
            // 
            this.txtPerID.Location = new System.Drawing.Point(112, 311);
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(140, 23);
            this.txtPerID.TabIndex = 25;
            this.txtPerID.TextChanged += new System.EventHandler(this.txtPerID_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(112, 340);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(221, 23);
            this.txtAdSoyad.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mesai ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Personel Sicil :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ad - Soyad :";
            // 
            // btnTumMesaiOde
            // 
            this.btnTumMesaiOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumMesaiOde.ImageKey = "images.png";
            this.btnTumMesaiOde.ImageList = this.ımageList1;
            this.btnTumMesaiOde.Location = new System.Drawing.Point(710, 282);
            this.btnTumMesaiOde.Name = "btnTumMesaiOde";
            this.btnTumMesaiOde.Size = new System.Drawing.Size(178, 42);
            this.btnTumMesaiOde.TabIndex = 27;
            this.btnTumMesaiOde.Text = "Tüm Mesaileri Öde ";
            this.btnTumMesaiOde.UseVisualStyleBackColor = true;
            this.btnTumMesaiOde.Click += new System.EventHandler(this.btnTumMesaiOde_Click);
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesaiOde.ImageKey = "images.png";
            this.btnMesaiOde.ImageList = this.ımageList1;
            this.btnMesaiOde.Location = new System.Drawing.Point(710, 330);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(178, 44);
            this.btnMesaiOde.TabIndex = 28;
            this.btnMesaiOde.Text = "Mesai Öde";
            this.btnMesaiOde.UseVisualStyleBackColor = true;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "update-icon.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(710, 380);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(178, 43);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "delete-icon.jpg";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(710, 429);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(178, 43);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit-icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(710, 478);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(178, 43);
            this.btnCikis.TabIndex = 30;
            this.btnCikis.Text = "Çıkış ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "999902.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(526, 478);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(178, 43);
            this.btnTemizle.TabIndex = 30;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
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
            this.ımageList1.Images.SetKeyName(5, "999902.png");
            this.ımageList1.Images.SetKeyName(6, "images.png");
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 531);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.btnTumMesaiOde);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtPerID);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtSaatUcret;
        private System.Windows.Forms.MaskedTextBox maskedBitis;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.MaskedTextBox maskedBasla;
        private System.Windows.Forms.DateTimePicker dateBasla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPerID;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTumMesaiOde;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}