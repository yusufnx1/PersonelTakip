
namespace PersonelTakip
{
    partial class frmPrimEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimEkle));
            this.radioKisi = new System.Windows.Forms.RadioButton();
            this.radioPersonel = new System.Windows.Forms.RadioButton();
            this.txtPerID = new System.Windows.Forms.TextBox();
            this.txtPerAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPrimTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimGoster = new System.Windows.Forms.Button();
            this.btnPersonelPrimleri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioKisi
            // 
            this.radioKisi.AutoSize = true;
            this.radioKisi.Location = new System.Drawing.Point(57, 22);
            this.radioKisi.Name = "radioKisi";
            this.radioKisi.Size = new System.Drawing.Size(109, 19);
            this.radioKisi.TabIndex = 0;
            this.radioKisi.TabStop = true;
            this.radioKisi.Text = "Kişiye Özel Prim";
            this.radioKisi.UseVisualStyleBackColor = true;
            // 
            // radioPersonel
            // 
            this.radioPersonel.AutoSize = true;
            this.radioPersonel.Location = new System.Drawing.Point(189, 22);
            this.radioPersonel.Name = "radioPersonel";
            this.radioPersonel.Size = new System.Drawing.Size(147, 19);
            this.radioPersonel.TabIndex = 1;
            this.radioPersonel.TabStop = true;
            this.radioPersonel.Text = "Tüm Personel için Prim";
            this.radioPersonel.UseVisualStyleBackColor = true;
            this.radioPersonel.CheckedChanged += new System.EventHandler(this.radioPersonel_CheckedChanged);
            // 
            // txtPerID
            // 
            this.txtPerID.Location = new System.Drawing.Point(86, 52);
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(181, 23);
            this.txtPerID.TabIndex = 2;
            // 
            // txtPerAdSoyad
            // 
            this.txtPerAdSoyad.Location = new System.Drawing.Point(86, 81);
            this.txtPerAdSoyad.Name = "txtPerAdSoyad";
            this.txtPerAdSoyad.Size = new System.Drawing.Size(181, 23);
            this.txtPerAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dönem :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(200, 110);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(67, 23);
            this.comboYil.TabIndex = 3;
            this.comboYil.SelectedIndexChanged += new System.EventHandler(this.comboYil_SelectedIndexChanged);
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
            "6 - Haziran",
            "7 - Temmuz ",
            "8 - Ağustos ",
            "9 - Eylül ",
            "10 - Ekim",
            "11 - Kasım ",
            "12 - Aralık"});
            this.comboAy.Location = new System.Drawing.Point(86, 110);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(78, 23);
            this.comboAy.TabIndex = 4;
            // 
            // txtPrimTutar
            // 
            this.txtPrimTutar.Location = new System.Drawing.Point(359, 52);
            this.txtPrimTutar.Name = "txtPrimTutar";
            this.txtPrimTutar.Size = new System.Drawing.Size(199, 23);
            this.txtPrimTutar.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(359, 81);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(199, 52);
            this.txtAciklama.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 210);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Soyad  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personel ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prim Tutarı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Açıklama :";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimEkle.ImageKey = "insert-icon.png";
            this.btnPrimEkle.ImageList = this.ımageList1;
            this.btnPrimEkle.Location = new System.Drawing.Point(12, 158);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(117, 37);
            this.btnPrimEkle.TabIndex = 8;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimGoster
            // 
            this.btnPrimGoster.Location = new System.Drawing.Point(135, 158);
            this.btnPrimGoster.Name = "btnPrimGoster";
            this.btnPrimGoster.Size = new System.Drawing.Size(89, 37);
            this.btnPrimGoster.TabIndex = 8;
            this.btnPrimGoster.Text = "Prim Göster";
            this.btnPrimGoster.UseVisualStyleBackColor = true;
            this.btnPrimGoster.Click += new System.EventHandler(this.btnPrimGoster_Click);
            // 
            // btnPersonelPrimleri
            // 
            this.btnPersonelPrimleri.Location = new System.Drawing.Point(230, 158);
            this.btnPersonelPrimleri.Name = "btnPersonelPrimleri";
            this.btnPersonelPrimleri.Size = new System.Drawing.Size(106, 37);
            this.btnPersonelPrimleri.TabIndex = 8;
            this.btnPersonelPrimleri.Text = "Personel Primleri";
            this.btnPersonelPrimleri.UseVisualStyleBackColor = true;
            this.btnPersonelPrimleri.Click += new System.EventHandler(this.btnPersonelPrimleri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "999902.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(342, 158);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 37);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit-icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(469, 158);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 37);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 423);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPersonelPrimleri);
            this.Controls.Add(this.btnPrimGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutar);
            this.Controls.Add(this.txtPerAdSoyad);
            this.Controls.Add(this.txtPerID);
            this.Controls.Add(this.radioPersonel);
            this.Controls.Add(this.radioKisi);
            this.Name = "frmPrimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioKisi;
        private System.Windows.Forms.RadioButton radioPersonel;
        private System.Windows.Forms.TextBox txtPerID;
        private System.Windows.Forms.TextBox txtPerAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPrimTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimGoster;
        private System.Windows.Forms.Button btnPersonelPrimleri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}