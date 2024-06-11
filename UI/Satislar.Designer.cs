namespace veritabaniProje.UI
{
    partial class Satislar
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
            this.satisHepsi = new System.Windows.Forms.ToolStripButton();
            this.satisEkle = new System.Windows.Forms.ToolStripButton();
            this.SatisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.satisSil = new System.Windows.Forms.ToolStripButton();
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
            this.satisHepsi,
            this.satisEkle,
            this.SatisDuzenle,
            this.satisSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
         
            // 
            // satisHepsi
            // 
            this.satisHepsi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.satisHepsi.Image = global::veritabaniProje.Properties.Resources.icons8_basket_481;
            this.satisHepsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.satisHepsi.Name = "satisHepsi";
            this.satisHepsi.Size = new System.Drawing.Size(54, 24);
            this.satisHepsi.Text = "Bul";
            this.satisHepsi.Click += new System.EventHandler(this.satisHepsi_Click);
            // 
            // satisEkle
            // 
            this.satisEkle.Image = global::veritabaniProje.Properties.Resources.icons8_shopping_mall_48;
            this.satisEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.satisEkle.Name = "satisEkle";
            this.satisEkle.Size = new System.Drawing.Size(60, 24);
            this.satisEkle.Text = "Ekle";
            this.satisEkle.Click += new System.EventHandler(this.satisEkle_Click);
            // 
            // SatisDuzenle
            // 
            this.SatisDuzenle.Image = global::veritabaniProje.Properties.Resources.icons8_pencil_16;
            this.SatisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SatisDuzenle.Name = "SatisDuzenle";
            this.SatisDuzenle.Size = new System.Drawing.Size(87, 24);
            this.SatisDuzenle.Text = "Düzenle";
            this.SatisDuzenle.Click += new System.EventHandler(this.SatisDuzenle_Click);
            // 
            // satisSil
            // 
            this.satisSil.Image = global::veritabaniProje.Properties.Resources.icons8_bin_48;
            this.satisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.satisSil.Name = "satisSil";
            this.satisSil.Size = new System.Drawing.Size(49, 24);
            this.satisSil.Text = "Sil";
            this.satisSil.Click += new System.EventHandler(this.satisSil_Click);
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
            this.dataGridView1.TabIndex = 3;
            // 
            // iptall
            // 
            this.iptall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptall.Location = new System.Drawing.Point(681, 351);
            this.iptall.Name = "iptall";
            this.iptall.Size = new System.Drawing.Size(96, 29);
            this.iptall.TabIndex = 4;
            this.iptall.Text = "İptal";
            this.iptall.UseVisualStyleBackColor = true;
            this.iptall.Click += new System.EventHandler(this.iptall_Click);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(546, 351);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(96, 29);
            this.tamam.TabIndex = 5;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.iptall);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Satislar";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.Satislar_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton satisHepsi;
        private System.Windows.Forms.ToolStripButton satisEkle;
        private System.Windows.Forms.ToolStripButton SatisDuzenle;
        private System.Windows.Forms.ToolStripButton satisSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptall;
        private System.Windows.Forms.Button tamam;
    }
}