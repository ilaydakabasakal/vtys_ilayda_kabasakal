
namespace veritabaniProje.UI
{
    partial class FrmOdeme
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
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.Iptal = new System.Windows.Forms.Button();
            this.Gonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Durum = new System.Windows.Forms.ComboBox();
            this.Tutar = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(188, 161);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(327, 22);
            this.tarih.TabIndex = 3;
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Location = new System.Drawing.Point(443, 394);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 32);
            this.Iptal.TabIndex = 6;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(316, 394);
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
            this.label5.Location = new System.Drawing.Point(108, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Durum";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(187, 81);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(328, 22);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Müşteri";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(189, 39);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(328, 22);
            this.textID.TabIndex = 0;
            this.textID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // Durum
            // 
            this.Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Durum.FormattingEnabled = true;
            this.Durum.Items.AddRange(new object[] {
            "Kredi Kartı ",
            "Kapıda Ödeme",
            "Banka Kartı"});
            this.Durum.Location = new System.Drawing.Point(189, 208);
            this.Durum.Name = "Durum";
            this.Durum.Size = new System.Drawing.Size(328, 24);
            this.Durum.TabIndex = 4;
            // 
            // Tutar
            // 
            this.Tutar.Location = new System.Drawing.Point(187, 122);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(329, 22);
            this.Tutar.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(537, 81);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(109, 24);
            this.btnMusteriSec.TabIndex = 41;
            this.btnMusteriSec.Text = "Müşteri Seç";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(189, 255);
            this.Aciklama.Multiline = true;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Aciklama.Size = new System.Drawing.Size(329, 104);
            this.Aciklama.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Açıklama";
            // 
            // FrmOdeme
            // 
            this.AcceptButton = this.Gonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(711, 481);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.Tutar);
            this.Controls.Add(this.Durum);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOdeme";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Durum;
        private System.Windows.Forms.NumericUpDown Tutar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.Label label4;
    }
}