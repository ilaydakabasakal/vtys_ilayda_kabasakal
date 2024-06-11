namespace veritabaniProje.UI
{
    partial class FrmUrun
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
            this.textUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.Fiyat = new System.Windows.Forms.NumericUpDown();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Location = new System.Drawing.Point(413, 393);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(75, 32);
            this.Iptal.TabIndex = 7;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(286, 393);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(75, 32);
            this.Gonder.TabIndex = 6;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fiyat";
            // 
            // textUrun
            // 
            this.textUrun.Location = new System.Drawing.Point(160, 121);
            this.textUrun.Name = "textUrun";
            this.textUrun.Size = new System.Drawing.Size(328, 22);
            this.textUrun.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(161, 39);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(328, 22);
            this.textID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stok";
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Çelenkler",
            "Çiçek Buketleri",
            "Saksı Çiçekleri",
            "Yapay Çiçekler",
            "Güller",
            "Karanfiller",
            "Laleler",
            "Orkideler"});
            this.kategori.Location = new System.Drawing.Point(161, 76);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(328, 24);
            this.kategori.TabIndex = 1;
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(160, 164);
            this.Fiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(329, 22);
            this.Fiyat.TabIndex = 3;
            // 
            // Stok
            // 
            this.Stok.DecimalPlaces = 2;
            this.Stok.Location = new System.Drawing.Point(159, 204);
            this.Stok.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(329, 22);
            this.Stok.TabIndex = 4;
            this.Stok.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Açıklama";
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(159, 245);
            this.Aciklama.Multiline = true;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Aciklama.Size = new System.Drawing.Size(329, 104);
            this.Aciklama.TabIndex = 8;
            this.Aciklama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.Gonder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(622, 488);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.NumericUpDown Fiyat;
        private System.Windows.Forms.NumericUpDown Stok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}