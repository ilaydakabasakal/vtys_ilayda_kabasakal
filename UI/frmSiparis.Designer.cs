using System.Windows.Forms;

namespace veritabaniProje.UI
{
    partial class frmSiparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public NumericUpDown adet;
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
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.Gonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.textUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.adet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(561, 112);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(109, 26);
            this.btnUrunSec.TabIndex = 42;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(561, 72);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(109, 24);
            this.btnMusteriSec.TabIndex = 43;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Location = new System.Drawing.Point(467, 226);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 32);
            this.Iptal.TabIndex = 36;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(340, 226);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(75, 32);
            this.Gonder.TabIndex = 35;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Adet";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(211, 74);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(328, 22);
            this.txtMusteri.TabIndex = 31;
            this.txtMusteri.TabStop = false;
            // 
            // textUrun
            // 
            this.textUrun.Location = new System.Drawing.Point(212, 114);
            this.textUrun.Name = "textUrun";
            this.textUrun.Size = new System.Drawing.Size(328, 22);
            this.textUrun.TabIndex = 32;
            this.textUrun.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Müşteri";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(213, 32);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(328, 22);
            this.textID.TabIndex = 30;
            this.textID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID";
            // 
            // adet
            // 
            this.adet.DecimalPlaces = 2;
            this.adet.Location = new System.Drawing.Point(213, 153);
            this.adet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(329, 22);
            this.adet.TabIndex = 44;
            this.adet.ThousandsSeparator = true;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.btnUrunSec);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.textUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox textUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
    }
}