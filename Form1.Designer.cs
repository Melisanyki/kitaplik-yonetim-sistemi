namespace kitaplikprojesi
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtKitapId = new TextBox();
            TxtKitapAd = new TextBox();
            TxtYazar = new TextBox();
            TxtSayfa = new TextBox();
            TxtFiyat = new TextBox();
            TxtYayinEvi = new TextBox();
            CmbTur = new ComboBox();
            groupBox1 = new GroupBox();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnKaydet = new Button();
            BtnListele = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 70);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Yazarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Sayfa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 197);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "Fiyat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 241);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Yayınevi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 285);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 6;
            label7.Text = "Tür:";
            // 
            // TxtKitapId
            // 
            TxtKitapId.Location = new Point(109, 25);
            TxtKitapId.Name = "TxtKitapId";
            TxtKitapId.Size = new Size(125, 27);
            TxtKitapId.TabIndex = 7;
            // 
            // TxtKitapAd
            // 
            TxtKitapAd.Location = new Point(109, 63);
            TxtKitapAd.Name = "TxtKitapAd";
            TxtKitapAd.Size = new Size(125, 27);
            TxtKitapAd.TabIndex = 8;
            // 
            // TxtYazar
            // 
            TxtYazar.Location = new Point(109, 106);
            TxtYazar.Name = "TxtYazar";
            TxtYazar.Size = new Size(125, 27);
            TxtYazar.TabIndex = 9;
            // 
            // TxtSayfa
            // 
            TxtSayfa.Location = new Point(109, 148);
            TxtSayfa.Name = "TxtSayfa";
            TxtSayfa.Size = new Size(125, 27);
            TxtSayfa.TabIndex = 10;
            // 
            // TxtFiyat
            // 
            TxtFiyat.Location = new Point(109, 190);
            TxtFiyat.Name = "TxtFiyat";
            TxtFiyat.Size = new Size(125, 27);
            TxtFiyat.TabIndex = 11;
            // 
            // TxtYayinEvi
            // 
            TxtYayinEvi.Location = new Point(109, 234);
            TxtYayinEvi.Name = "TxtYayinEvi";
            TxtYayinEvi.Size = new Size(125, 27);
            TxtYayinEvi.TabIndex = 12;
            // 
            // CmbTur
            // 
            CmbTur.FormattingEnabled = true;
            CmbTur.Location = new Point(109, 282);
            CmbTur.Name = "CmbTur";
            CmbTur.Size = new Size(125, 28);
            CmbTur.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnGuncelle);
            groupBox1.Controls.Add(BtnSil);
            groupBox1.Controls.Add(BtnKaydet);
            groupBox1.Controls.Add(BtnListele);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 482);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(95, 435);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(125, 29);
            BtnGuncelle.TabIndex = 15;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(95, 400);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(125, 29);
            BtnSil.TabIndex = 2;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(95, 365);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(125, 29);
            BtnKaydet.TabIndex = 1;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // BtnListele
            // 
            BtnListele.Location = new Point(95, 330);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(125, 29);
            BtnListele.TabIndex = 0;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            BtnListele.Click += BtnListele_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(266, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(839, 482);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(826, 452);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 506);
            Controls.Add(groupBox2);
            Controls.Add(CmbTur);
            Controls.Add(TxtYayinEvi);
            Controls.Add(TxtFiyat);
            Controls.Add(TxtSayfa);
            Controls.Add(TxtYazar);
            Controls.Add(TxtKitapAd);
            Controls.Add(TxtKitapId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtKitapId;
        private TextBox TxtKitapAd;
        private TextBox TxtYazar;
        private TextBox TxtSayfa;
        private TextBox TxtFiyat;
        private TextBox TxtYayinEvi;
        private ComboBox CmbTur;
        private GroupBox groupBox1;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnKaydet;
        private Button BtnListele;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}
