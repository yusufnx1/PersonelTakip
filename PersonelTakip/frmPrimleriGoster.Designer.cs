
namespace PersonelTakip
{
    partial class frmPrimleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutar = new System.Windows.Forms.TextBox();
            this.txtPerAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.txtTumPrimOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(836, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Açıklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Prim Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Personel ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad Soyad  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dönem :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(277, 330);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(85, 23);
            this.comboYil.TabIndex = 11;
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
            this.comboAy.Location = new System.Drawing.Point(163, 330);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(78, 23);
            this.comboAy.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(494, 270);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(206, 81);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtPrimTutar
            // 
            this.txtPrimTutar.Location = new System.Drawing.Point(494, 241);
            this.txtPrimTutar.Name = "txtPrimTutar";
            this.txtPrimTutar.Size = new System.Drawing.Size(206, 23);
            this.txtPrimTutar.TabIndex = 8;
            // 
            // txtPerAdSoyad
            // 
            this.txtPerAdSoyad.Location = new System.Drawing.Point(163, 301);
            this.txtPerAdSoyad.Name = "txtPerAdSoyad";
            this.txtPerAdSoyad.Size = new System.Drawing.Size(199, 23);
            this.txtPerAdSoyad.TabIndex = 9;
            this.txtPerAdSoyad.TextChanged += new System.EventHandler(this.txtPerAdSoyad_TextChanged);
            // 
            // txtPerID
            // 
            this.txtPerID.Location = new System.Drawing.Point(163, 272);
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(199, 23);
            this.txtPerID.TabIndex = 10;
            this.txtPerID.TextChanged += new System.EventHandler(this.txtPerID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prim ID :";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(163, 243);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(199, 23);
            this.txtPrimID.TabIndex = 19;
            // 
            // txtTumPrimOde
            // 
            this.txtTumPrimOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTumPrimOde.ImageKey = "images.png";
            this.txtTumPrimOde.ImageList = this.ımageList1;
            this.txtTumPrimOde.Location = new System.Drawing.Point(12, 386);
            this.txtTumPrimOde.Name = "txtTumPrimOde";
            this.txtTumPrimOde.Size = new System.Drawing.Size(148, 34);
            this.txtTumPrimOde.TabIndex = 21;
            this.txtTumPrimOde.Text = "Tüm Primleri Öde";
            this.txtTumPrimOde.UseVisualStyleBackColor = true;
            this.txtTumPrimOde.Click += new System.EventHandler(this.txtTumPrimOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimOde.ImageKey = "images.png";
            this.btnPrimOde.ImageList = this.ımageList1;
            this.btnPrimOde.Location = new System.Drawing.Point(166, 386);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(108, 34);
            this.btnPrimOde.TabIndex = 21;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimGuncelle.ImageKey = "update-icon.png";
            this.btnPrimGuncelle.ImageList = this.ımageList1;
            this.btnPrimGuncelle.Location = new System.Drawing.Point(280, 386);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(108, 34);
            this.btnPrimGuncelle.TabIndex = 21;
            this.btnPrimGuncelle.Text = "Güncelle";
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimSil.ImageKey = "delete-icon.jpg";
            this.btnPrimSil.ImageList = this.ımageList1;
            this.btnPrimSil.Location = new System.Drawing.Point(394, 386);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(108, 34);
            this.btnPrimSil.TabIndex = 21;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonemDegistir.ImageKey = "update-icon.png";
            this.btnDonemDegistir.ImageList = this.ımageList1;
            this.btnDonemDegistir.Location = new System.Drawing.Point(508, 386);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(151, 34);
            this.btnDonemDegistir.TabIndex = 21;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit-icon.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(765, 385);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 35);
            this.btnCikis.TabIndex = 22;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "999902.png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(665, 385);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(94, 34);
            this.btnTemizle.TabIndex = 23;
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
            this.ımageList1.Images.SetKeyName(6, "admin-giris.png");
            this.ımageList1.Images.SetKeyName(7, "images.png");
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 433);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.txtTumPrimOde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimID);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Personellerin Primleri";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutar;
        private System.Windows.Forms.TextBox txtPerAdSoyad;
        private System.Windows.Forms.TextBox txtPerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Button txtTumPrimOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}