
namespace PANSİYON_KAYIT_OTOMASYONU
{
    partial class FrmAdminGirişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGirişi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkulaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(224, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(359, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtkulaniciadi
            // 
            this.txtkulaniciadi.BackColor = System.Drawing.Color.PeachPuff;
            this.txtkulaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkulaniciadi.Location = new System.Drawing.Point(467, 117);
            this.txtkulaniciadi.Name = "txtkulaniciadi";
            this.txtkulaniciadi.Size = new System.Drawing.Size(280, 38);
            this.txtkulaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.Moccasin;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(467, 173);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(280, 38);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // btngirişyap
            // 
            this.btngirişyap.BackColor = System.Drawing.Color.Black;
            this.btngirişyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngirişyap.ForeColor = System.Drawing.Color.Crimson;
            this.btngirişyap.Location = new System.Drawing.Point(500, 255);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(221, 68);
            this.btngirişyap.TabIndex = 4;
            this.btngirişyap.Text = "Giriş Yap";
            this.btngirişyap.UseVisualStyleBackColor = false;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pansiyonumuza Hoşgeldiniz";
            // 
            // FrmAdminGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngirişyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkulaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGirişi";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.FrmAdminGirişi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkulaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngirişyap;
        private System.Windows.Forms.Label label3;
    }
}

