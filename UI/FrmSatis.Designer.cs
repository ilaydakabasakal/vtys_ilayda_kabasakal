namespace veritabaniProje.UI
{
    partial class FrmSatis
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
            this.Iptal = new System.Windows.Forms.Button();
            this.Gonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnUrunSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Location = new System.Drawing.Point(443, 395);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 32);
            this.Iptal.TabIndex = 6;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(316, 395);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(75, 32);
            this.Gonder.TabIndex = 5;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tarih";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(189, 210);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Adres.Size = new System.Drawing.Size(329, 104);
            this.Adres.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Adres";
            // 
            // textUrun
            // 
            this.textUrun.Location = new System.Drawing.Point(190, 123);
            this.textUrun.Name = "textUrun";
            this.textUrun.Size = new System.Drawing.Size(328, 22);
            this.textUrun.TabIndex = 2;
            this.textUrun.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Müşteri";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(191, 41);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(328, 22);
            this.textID.TabIndex = 0;
            this.textID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(189, 83);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(328, 22);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(190, 163);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(327, 22);
            this.tarih.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(539, 81);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(109, 24);
            this.btnMusteriSec.TabIndex = 29;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(539, 121);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(109, 26);
            this.btnUrunSec.TabIndex = 29;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // FrmSatis
            // 
            this.AcceptButton = this.Gonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(846, 500);
            this.Controls.Add(this.btnUrunSec);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.textUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSatis";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.Button btnMusteriSec;
    }
}