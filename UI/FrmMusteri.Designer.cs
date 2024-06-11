
namespace veritabaniProje.UI
{
    partial class FrmMusteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.Gonder = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(130, 34);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(312, 22);
            this.textID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(130, 75);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(312, 22);
            this.textAd.TabIndex = 1;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(129, 116);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(312, 22);
            this.textSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(129, 155);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(312, 22);
            this.textMail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(129, 195);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(312, 22);
            this.textTelefon.TabIndex = 4;
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(240, 266);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(75, 32);
            this.Gonder.TabIndex = 5;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Location = new System.Drawing.Point(367, 266);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 32);
            this.Iptal.TabIndex = 6;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMusteri
            // 
            this.AcceptButton = this.Gonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}