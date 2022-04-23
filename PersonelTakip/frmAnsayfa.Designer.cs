
namespace PersonelTakip
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.btnPerEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDepEkle = new System.Windows.Forms.Button();
            this.btnPersListe = new System.Windows.Forms.Button();
            this.btnZamYap = new System.Windows.Forms.Button();
            this.btnPrimler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIzinListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerEkle.ImageKey = "indir.png";
            this.btnPerEkle.ImageList = this.ımageList1;
            this.btnPerEkle.Location = new System.Drawing.Point(16, 12);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(149, 69);
            this.btnPerEkle.TabIndex = 0;
            this.btnPerEkle.Text = "Personel Ekle ";
            this.btnPerEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerEkle.UseVisualStyleBackColor = true;
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1678759.png");
            this.ımageList1.Images.SetKeyName(1, "2278827.png");
            this.ımageList1.Images.SetKeyName(2, "images.png");
            this.ımageList1.Images.SetKeyName(3, "indir (1).png");
            this.ımageList1.Images.SetKeyName(4, "indir (2).png");
            this.ımageList1.Images.SetKeyName(5, "save-time-icon-2.jpg");
            this.ımageList1.Images.SetKeyName(6, "indir.png");
            this.ımageList1.Images.SetKeyName(7, "images.png");
            this.ımageList1.Images.SetKeyName(8, "indir (3).png");
            // 
            // btnDepEkle
            // 
            this.btnDepEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepEkle.ImageKey = "1678759.png";
            this.btnDepEkle.ImageList = this.ımageList1;
            this.btnDepEkle.Location = new System.Drawing.Point(175, 12);
            this.btnDepEkle.Name = "btnDepEkle";
            this.btnDepEkle.Size = new System.Drawing.Size(153, 69);
            this.btnDepEkle.TabIndex = 0;
            this.btnDepEkle.Text = "Departman Ekle";
            this.btnDepEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepEkle.UseVisualStyleBackColor = true;
            this.btnDepEkle.Click += new System.EventHandler(this.btnDepEkle_Click);
            // 
            // btnPersListe
            // 
            this.btnPersListe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersListe.ImageKey = "indir (1).png";
            this.btnPersListe.ImageList = this.ımageList1;
            this.btnPersListe.Location = new System.Drawing.Point(340, 12);
            this.btnPersListe.Name = "btnPersListe";
            this.btnPersListe.Size = new System.Drawing.Size(153, 69);
            this.btnPersListe.TabIndex = 0;
            this.btnPersListe.Text = "Personel Listele ";
            this.btnPersListe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersListe.UseVisualStyleBackColor = true;
            this.btnPersListe.Click += new System.EventHandler(this.btnPersListe_Click);
            // 
            // btnZamYap
            // 
            this.btnZamYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamYap.ImageKey = "images.png";
            this.btnZamYap.ImageList = this.ımageList1;
            this.btnZamYap.Location = new System.Drawing.Point(340, 85);
            this.btnZamYap.Name = "btnZamYap";
            this.btnZamYap.Size = new System.Drawing.Size(153, 69);
            this.btnZamYap.TabIndex = 0;
            this.btnZamYap.Text = "Maaş Zamları";
            this.btnZamYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamYap.UseVisualStyleBackColor = true;
            this.btnZamYap.Click += new System.EventHandler(this.btnZamYap_Click);
            // 
            // btnPrimler
            // 
            this.btnPrimler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimler.ImageKey = "images.png";
            this.btnPrimler.ImageList = this.ımageList1;
            this.btnPrimler.Location = new System.Drawing.Point(340, 158);
            this.btnPrimler.Name = "btnPrimler";
            this.btnPrimler.Size = new System.Drawing.Size(153, 69);
            this.btnPrimler.TabIndex = 1;
            this.btnPrimler.Text = "Primler";
            this.btnPrimler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimler.UseVisualStyleBackColor = true;
            this.btnPrimler.Click += new System.EventHandler(this.btnPrimler_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "indir (2).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(16, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mesai Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "save-time-icon-2.jpg";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(175, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mesai Listele ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageKey = "2278827.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(175, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "İzin Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnIzinListele
            // 
            this.btnIzinListele.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzinListele.ImageKey = "indir (3).png";
            this.btnIzinListele.ImageList = this.ımageList1;
            this.btnIzinListele.Location = new System.Drawing.Point(16, 158);
            this.btnIzinListele.Name = "btnIzinListele";
            this.btnIzinListele.Size = new System.Drawing.Size(149, 69);
            this.btnIzinListele.TabIndex = 4;
            this.btnIzinListele.Text = "İzin Listele";
            this.btnIzinListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzinListele.UseVisualStyleBackColor = true;
            this.btnIzinListele.Click += new System.EventHandler(this.btnIzinListele_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 244);
            this.Controls.Add(this.btnIzinListele);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrimler);
            this.Controls.Add(this.btnZamYap);
            this.Controls.Add(this.btnPersListe);
            this.Controls.Add(this.btnDepEkle);
            this.Controls.Add(this.btnPerEkle);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerEkle;
        private System.Windows.Forms.Button btnDepEkle;
        private System.Windows.Forms.Button btnPersListe;
        private System.Windows.Forms.Button btnZamYap;
        private System.Windows.Forms.Button btnPrimler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIzinListele;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

