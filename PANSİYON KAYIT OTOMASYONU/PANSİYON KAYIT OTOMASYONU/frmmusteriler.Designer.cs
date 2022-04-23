
namespace PANSİYON_KAYIT_OTOMASYONU
{
    partial class frmmusteriler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnverilerigöster = new System.Windows.Forms.Button();
            this.btngüncele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.comboxcinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpcıkıştarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpgiriştarihi = new System.Windows.Forms.DateTimePicker();
            this.txtodanumara = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 499);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1167, 256);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda No";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ücret";
            this.columnHeader11.Width = 91;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giriş Tarihi";
            this.columnHeader9.Width = 141;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Çıkış Tarihi";
            this.columnHeader10.Width = 181;
            // 
            // btnverilerigöster
            // 
            this.btnverilerigöster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnverilerigöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnverilerigöster.Location = new System.Drawing.Point(600, 15);
            this.btnverilerigöster.Margin = new System.Windows.Forms.Padding(4);
            this.btnverilerigöster.Name = "btnverilerigöster";
            this.btnverilerigöster.Size = new System.Drawing.Size(250, 64);
            this.btnverilerigöster.TabIndex = 1;
            this.btnverilerigöster.Text = "Verileri Göster";
            this.btnverilerigöster.UseVisualStyleBackColor = false;
            this.btnverilerigöster.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngüncele
            // 
            this.btngüncele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btngüncele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncele.Location = new System.Drawing.Point(600, 92);
            this.btngüncele.Margin = new System.Windows.Forms.Padding(4);
            this.btngüncele.Name = "btngüncele";
            this.btngüncele.Size = new System.Drawing.Size(250, 61);
            this.btngüncele.TabIndex = 2;
            this.btngüncele.Text = "Güncelle";
            this.btngüncele.UseVisualStyleBackColor = false;
            this.btngüncele.Click += new System.EventHandler(this.btngüncele_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(600, 174);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(250, 61);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Location = new System.Drawing.Point(986, 349);
            this.btnara.Margin = new System.Windows.Forms.Padding(4);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(162, 50);
            this.btnara.TabIndex = 4;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // comboxcinsiyet
            // 
            this.comboxcinsiyet.BackColor = System.Drawing.SystemColors.Info;
            this.comboxcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboxcinsiyet.FormattingEnabled = true;
            this.comboxcinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.comboxcinsiyet.Location = new System.Drawing.Point(218, 94);
            this.comboxcinsiyet.Name = "comboxcinsiyet";
            this.comboxcinsiyet.Size = new System.Drawing.Size(218, 39);
            this.comboxcinsiyet.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(80, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 32);
            this.label10.TabIndex = 56;
            this.label10.Text = "Cınsiyet:";
            // 
            // txtucret
            // 
            this.txtucret.BackColor = System.Drawing.SystemColors.Info;
            this.txtucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtucret.Location = new System.Drawing.Point(213, 324);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(223, 38);
            this.txtucret.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(111, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 32);
            this.label9.TabIndex = 54;
            this.label9.Text = "Ücret:";
            // 
            // dtpcıkıştarihi
            // 
            this.dtpcıkıştarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpcıkıştarihi.Location = new System.Drawing.Point(207, 434);
            this.dtpcıkıştarihi.Name = "dtpcıkıştarihi";
            this.dtpcıkıştarihi.Size = new System.Drawing.Size(433, 38);
            this.dtpcıkıştarihi.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 52;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // dtpgiriştarihi
            // 
            this.dtpgiriştarihi.CausesValidation = false;
            this.dtpgiriştarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpgiriştarihi.Location = new System.Drawing.Point(207, 380);
            this.dtpgiriştarihi.Name = "dtpgiriştarihi";
            this.dtpgiriştarihi.Size = new System.Drawing.Size(433, 38);
            this.dtpgiriştarihi.TabIndex = 51;
            // 
            // txtodanumara
            // 
            this.txtodanumara.BackColor = System.Drawing.SystemColors.Info;
            this.txtodanumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtodanumara.Location = new System.Drawing.Point(213, 280);
            this.txtodanumara.Name = "txtodanumara";
            this.txtodanumara.Size = new System.Drawing.Size(220, 38);
            this.txtodanumara.TabIndex = 50;
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.SystemColors.Info;
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(216, 236);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(217, 38);
            this.txtTC.TabIndex = 49;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(218, 189);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(215, 38);
            this.txtmail.TabIndex = 48;
            // 
            // msktelefon
            // 
            this.msktelefon.BackColor = System.Drawing.SystemColors.Info;
            this.msktelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(218, 142);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(217, 38);
            this.msktelefon.TabIndex = 47;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.BackColor = System.Drawing.SystemColors.Info;
            this.txtsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadi.Location = new System.Drawing.Point(218, 50);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(218, 38);
            this.txtsoyadi.TabIndex = 46;
            // 
            // txtadi
            // 
            this.txtadi.BackColor = System.Drawing.SystemColors.Info;
            this.txtadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadi.Location = new System.Drawing.Point(218, 6);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(218, 38);
            this.txtadi.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 32);
            this.label7.TabIndex = 44;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Oda Numara:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "T.C Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(125, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Adı:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(934, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 38);
            this.textBox1.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(854, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 32);
            this.label11.TabIndex = 58;
            this.label11.Text = "İsim:";
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Yellow;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(600, 252);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(250, 66);
            this.btntemizle.TabIndex = 60;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // frmmusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 768);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboxcinsiyet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpcıkıştarihi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpgiriştarihi);
            this.Controls.Add(this.txtodanumara);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncele);
            this.Controls.Add(this.btnverilerigöster);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmusteriler";
            this.Text = "Müşteri Bilgileri ";
            this.Load += new System.EventHandler(this.frmmusteriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnverilerigöster;
        private System.Windows.Forms.Button btngüncele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.ComboBox comboxcinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpcıkıştarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpgiriştarihi;
        private System.Windows.Forms.TextBox txtodanumara;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}