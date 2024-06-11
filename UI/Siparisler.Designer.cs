namespace veritabaniProje.UI
{
    partial class Siparisler
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.siparisHepsi = new System.Windows.Forms.ToolStripButton();
            this.siparisEkle = new System.Windows.Forms.ToolStripButton();
            this.siparisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.siparisSil = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iptall = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisHepsi,
            this.siparisEkle,
            this.siparisDuzenle,
            this.siparisSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // siparisHepsi
            // 
            this.siparisHepsi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.siparisHepsi.Image = global::veritabaniProje.Properties.Resources.icons8_basket_481;
            this.siparisHepsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siparisHepsi.Name = "siparisHepsi";
            this.siparisHepsi.Size = new System.Drawing.Size(54, 24);
            this.siparisHepsi.Text = "Bul";
            this.siparisHepsi.Click += new System.EventHandler(this.Siparisler_Load);
            // 
            // siparisEkle
            // 
            this.siparisEkle.Image = global::veritabaniProje.Properties.Resources.icons8_product_50;
            this.siparisEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siparisEkle.Name = "siparisEkle";
            this.siparisEkle.Size = new System.Drawing.Size(60, 24);
            this.siparisEkle.Text = "Ekle";
            this.siparisEkle.Click += new System.EventHandler(this.siparisEkle_Click);
            // 
            // siparisDuzenle
            // 
            this.siparisDuzenle.Image = global::veritabaniProje.Properties.Resources.icons8_pencil_16;
            this.siparisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siparisDuzenle.Name = "siparisDuzenle";
            this.siparisDuzenle.Size = new System.Drawing.Size(87, 24);
            this.siparisDuzenle.Text = "Düzenle";
            this.siparisDuzenle.Click += new System.EventHandler(this.siparisDuzenle_Click);
            // 
            // siparisSil
            // 
            this.siparisSil.Image = global::veritabaniProje.Properties.Resources.icons8_bin_48;
            this.siparisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.siparisSil.Name = "siparisSil";
            this.siparisSil.Size = new System.Drawing.Size(49, 24);
            this.siparisSil.Text = "Sil";
            this.siparisSil.Click += new System.EventHandler(this.siparisSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 292);
            this.dataGridView1.TabIndex = 4;
            // 
            // iptall
            // 
            this.iptall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptall.Location = new System.Drawing.Point(682, 352);
            this.iptall.Name = "iptall";
            this.iptall.Size = new System.Drawing.Size(96, 29);
            this.iptall.TabIndex = 6;
            this.iptall.Text = "İptal";
            this.iptall.UseVisualStyleBackColor = true;
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(547, 352);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(96, 29);
            this.tamam.TabIndex = 7;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.iptall);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Siparisler";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton siparisHepsi;
        private System.Windows.Forms.ToolStripButton siparisEkle;
        private System.Windows.Forms.ToolStripButton siparisDuzenle;
        private System.Windows.Forms.ToolStripButton siparisSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptall;
        private System.Windows.Forms.Button tamam;
    }
}