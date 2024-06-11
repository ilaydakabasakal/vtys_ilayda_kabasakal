namespace veritabaniProje.UI
{
    partial class Urunler
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.urunEkle = new System.Windows.Forms.ToolStripButton();
            this.urunDuzenle = new System.Windows.Forms.ToolStripButton();
            this.urunSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iptall = new System.Windows.Forms.Button();
            this.tamam = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkle,
            this.urunDuzenle,
            this.urunSil,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // urunEkle
            // 
            this.urunEkle.Image = global::veritabaniProje.Properties.Resources.add_product;
            this.urunEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(60, 24);
            this.urunEkle.Text = "Ekle";
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // urunDuzenle
            // 
            this.urunDuzenle.Image = global::veritabaniProje.Properties.Resources.product;
            this.urunDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urunDuzenle.Name = "urunDuzenle";
            this.urunDuzenle.Size = new System.Drawing.Size(87, 24);
            this.urunDuzenle.Text = "Düzenle";
            this.urunDuzenle.Click += new System.EventHandler(this.urunDuzenle_Click);
            // 
            // urunSil
            // 
            this.urunSil.Image = global::veritabaniProje.Properties.Resources.delete_product;
            this.urunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(49, 24);
            this.urunSil.Text = "Sil";
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::veritabaniProje.Properties.Resources.add_product;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 24);
            this.toolStripButton2.Text = "Bul";
            this.toolStripButton2.Click += new System.EventHandler(this.Urunler_Load);
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
            this.dataGridView1.TabIndex = 6;
            // 
            // iptall
            // 
            this.iptall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptall.Location = new System.Drawing.Point(678, 339);
            this.iptall.Name = "iptall";
            this.iptall.Size = new System.Drawing.Size(96, 29);
            this.iptall.TabIndex = 8;
            this.iptall.Text = "İptal";
            this.iptall.UseVisualStyleBackColor = true;
            this.iptall.Click += new System.EventHandler(this.iptall_Click);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(543, 339);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(96, 29);
            this.tamam.TabIndex = 9;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.iptall);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Urunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load_1);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton urunEkle;
        private System.Windows.Forms.ToolStripButton urunDuzenle;
        private System.Windows.Forms.ToolStripButton urunSil;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptall;
        private System.Windows.Forms.Button tamam;
    }
}