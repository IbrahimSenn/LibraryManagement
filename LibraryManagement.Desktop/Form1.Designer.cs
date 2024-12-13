namespace LibraryManagement.Desktop
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
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtYazar = new TextBox();
            label3 = new Label();
            txtYayinEvi = new TextBox();
            label4 = new Label();
            txtSayfaSayisi = new TextBox();
            label5 = new Label();
            txtTür = new TextBox();
            btnEkle = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(137, 119);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 122);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 151);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Yazar :";
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(137, 148);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(100, 23);
            txtYazar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 180);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Yayın Evi :";
            // 
            // txtYayinEvi
            // 
            txtYayinEvi.Location = new Point(137, 177);
            txtYayinEvi.Name = "txtYayinEvi";
            txtYayinEvi.Size = new Size(100, 23);
            txtYayinEvi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 209);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Sayfa Sayısı :";
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(137, 206);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(100, 23);
            txtSayfaSayisi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 235);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Tür :";
            // 
            // txtTür
            // 
            txtTür.Location = new Point(137, 235);
            txtTür.Name = "txtTür";
            txtTür.Size = new Size(100, 23);
            txtTür.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(393, 279);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(558, 279);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 12;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(474, 279);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(252, 119);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(381, 139);
            lstListe.TabIndex = 14;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(712, 396);
            Controls.Add(lstListe);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(txtTür);
            Controls.Add(label4);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(label3);
            Controls.Add(txtYayinEvi);
            Controls.Add(label2);
            Controls.Add(txtYazar);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private TextBox txtYazar;
        private Label label3;
        private TextBox txtYayinEvi;
        private Label label4;
        private TextBox txtSayfaSayisi;
        private Label label5;
        private TextBox txtTür;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnSil;
        private ListBox lstListe;
    }
}
