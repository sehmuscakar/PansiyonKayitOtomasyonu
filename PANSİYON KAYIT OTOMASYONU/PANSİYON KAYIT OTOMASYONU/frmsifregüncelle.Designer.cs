
namespace PANSİYON_KAYIT_OTOMASYONU
{
    partial class frmsifregüncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtkulaniciadi = new System.Windows.Forms.TextBox();
            this.btnguncele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kulanıcı Adı:";
            // 
            // txtkulaniciadi
            // 
            this.txtkulaniciadi.BackColor = System.Drawing.Color.Yellow;
            this.txtkulaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkulaniciadi.Location = new System.Drawing.Point(199, 37);
            this.txtkulaniciadi.Name = "txtkulaniciadi";
            this.txtkulaniciadi.Size = new System.Drawing.Size(242, 38);
            this.txtkulaniciadi.TabIndex = 1;
            // 
            // btnguncele
            // 
            this.btnguncele.BackColor = System.Drawing.Color.Yellow;
            this.btnguncele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncele.Location = new System.Drawing.Point(234, 147);
            this.btnguncele.Name = "btnguncele";
            this.btnguncele.Size = new System.Drawing.Size(194, 49);
            this.btnguncele.TabIndex = 2;
            this.btnguncele.Text = "Güncelle";
            this.btnguncele.UseVisualStyleBackColor = false;
            this.btnguncele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.Yellow;
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(199, 85);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(242, 38);
            this.txtsifre.TabIndex = 4;
            // 
            // frmsifregüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(497, 231);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguncele);
            this.Controls.Add(this.txtkulaniciadi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsifregüncelle";
            this.Text = "frmsifregüncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkulaniciadi;
        private System.Windows.Forms.Button btnguncele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
    }
}