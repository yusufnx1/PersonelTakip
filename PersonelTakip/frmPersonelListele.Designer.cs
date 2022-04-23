
namespace PersonelTakip
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.txtIDara = new System.Windows.Forms.TextBox();
            this.txtAdara = new System.Windows.Forms.TextBox();
            this.txtSoyadara = new System.Windows.Forms.TextBox();
            this.txtTelara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerTel = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersEmail = new System.Windows.Forms.TextBox();
            this.txtPerAdres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPerAcikla = new System.Windows.Forms.TextBox();
            this.txtPerMaas = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboDepId = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPersID = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDara
            // 
            this.txtIDara.Location = new System.Drawing.Point(90, 12);
            this.txtIDara.Name = "txtIDara";
            this.txtIDara.Size = new System.Drawing.Size(100, 23);
            this.txtIDara.TabIndex = 0;
            this.txtIDara.TextChanged += new System.EventHandler(this.txtIDara_TextChanged);
            // 
            // txtAdara
            // 
            this.txtAdara.Location = new System.Drawing.Point(267, 12);
            this.txtAdara.Name = "txtAdara";
            this.txtAdara.Size = new System.Drawing.Size(100, 23);
            this.txtAdara.TabIndex = 1;
            this.txtAdara.TextChanged += new System.EventHandler(this.txtAdara_TextChanged);
            // 
            // txtSoyadara
            // 
            this.txtSoyadara.Location = new System.Drawing.Point(494, 12);
            this.txtSoyadara.Name = "txtSoyadara";
            this.txtSoyadara.Size = new System.Drawing.Size(100, 23);
            this.txtSoyadara.TabIndex = 2;
            this.txtSoyadara.TextChanged += new System.EventHandler(this.txtSoyadara_TextChanged);
            // 
            // txtTelara
            // 
            this.txtTelara.Location = new System.Drawing.Point(744, 12);
            this.txtTelara.Name = "txtTelara";
            this.txtTelara.Size = new System.Drawing.Size(100, 23);
            this.txtTelara.TabIndex = 3;
            this.txtTelara.TextChanged += new System.EventHandler(this.txtTelara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel Telefon :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(846, 256);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Personel Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel Adı :";
            // 
            // txtPerTel
            // 
            this.txtPerTel.Location = new System.Drawing.Point(105, 388);
            this.txtPerTel.Name = "txtPerTel";
            this.txtPerTel.Size = new System.Drawing.Size(173, 23);
            this.txtPerTel.TabIndex = 6;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(105, 363);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(173, 23);
            this.txtPerSoyad.TabIndex = 7;
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(105, 338);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(173, 23);
            this.txtPerAd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "E-Posta :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adres :";
            // 
            // txtPersEmail
            // 
            this.txtPersEmail.Location = new System.Drawing.Point(105, 494);
            this.txtPersEmail.Name = "txtPersEmail";
            this.txtPersEmail.Size = new System.Drawing.Size(173, 23);
            this.txtPersEmail.TabIndex = 12;
            // 
            // txtPerAdres
            // 
            this.txtPerAdres.Location = new System.Drawing.Point(105, 417);
            this.txtPerAdres.Multiline = true;
            this.txtPerAdres.Name = "txtPerAdres";
            this.txtPerAdres.Size = new System.Drawing.Size(173, 72);
            this.txtPerAdres.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Giriş Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Açıklama :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Maaş :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 364);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtPerAcikla
            // 
            this.txtPerAcikla.Location = new System.Drawing.Point(373, 393);
            this.txtPerAcikla.Multiline = true;
            this.txtPerAcikla.Name = "txtPerAcikla";
            this.txtPerAcikla.Size = new System.Drawing.Size(221, 87);
            this.txtPerAcikla.TabIndex = 16;
            // 
            // txtPerMaas
            // 
            this.txtPerMaas.Location = new System.Drawing.Point(373, 335);
            this.txtPerMaas.Name = "txtPerMaas";
            this.txtPerMaas.Size = new System.Drawing.Size(221, 23);
            this.txtPerMaas.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit-icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(769, 499);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 42);
            this.btnCikis.TabIndex = 22;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "delete-icon.jpg";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(674, 499);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 42);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Location = new System.Drawing.Point(716, 309);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(142, 15);
            this.lblToplamKayit.TabIndex = 24;
            this.lblToplamKayit.Text = "Toplam 50 kayıt listelendi.";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(703, 329);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(155, 15);
            this.lblToplamMaas.TabIndex = 24;
            this.lblToplamMaas.Text = "Toplam 50.000 Maaş Ödendi";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageKey = "update-icon.png";
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(550, 499);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(118, 42);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Departman ID :";
            // 
            // comboDepId
            // 
            this.comboDepId.FormattingEnabled = true;
            this.comboDepId.Location = new System.Drawing.Point(373, 310);
            this.comboDepId.Name = "comboDepId";
            this.comboDepId.Size = new System.Drawing.Size(221, 23);
            this.comboDepId.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Personel ID :";
            // 
            // txtPersID
            // 
            this.txtPersID.Location = new System.Drawing.Point(105, 310);
            this.txtPersID.Name = "txtPersID";
            this.txtPersID.Size = new System.Drawing.Size(173, 23);
            this.txtPersID.TabIndex = 27;
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
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 553);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPersID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboDepId);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPerAcikla);
            this.Controls.Add(this.txtPerMaas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPersEmail);
            this.Controls.Add(this.txtPerAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPerTel);
            this.Controls.Add(this.txtPerSoyad);
            this.Controls.Add(this.txtPerAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelara);
            this.Controls.Add(this.txtSoyadara);
            this.Controls.Add(this.txtAdara);
            this.Controls.Add(this.txtIDara);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Personel Listele, Ara,  Silme ve Güncelleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDara;
        private System.Windows.Forms.TextBox txtAdara;
        private System.Windows.Forms.TextBox txtSoyadara;
        private System.Windows.Forms.TextBox txtTelara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPerTel;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersEmail;
        private System.Windows.Forms.TextBox txtPerAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPerAcikla;
        private System.Windows.Forms.TextBox txtPerMaas;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboDepId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPersID;
        private System.Windows.Forms.ImageList ımageList1;
    }
}