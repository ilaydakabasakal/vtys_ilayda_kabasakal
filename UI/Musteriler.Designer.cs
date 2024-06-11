namespace veritabaniProje.UI
{
    partial class Musteriler
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
            this.musteriHepsi = new System.Windows.Forms.ToolStripButton();
            this.musteriEkle = new System.Windows.Forms.ToolStripButton();
            this.musteriDuzenle = new System.Windows.Forms.ToolStripButton();
            this.musteriSil = new System.Windows.Forms.ToolStripButton();
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
            this.musteriHepsi,
            this.musteriEkle,
            this.musteriDuzenle,
            this.musteriSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // musteriHepsi
            // 
            this.musteriHepsi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.musteriHepsi.Image = global::veritabaniProje.Properties.Resources.add_group;
            this.musteriHepsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musteriHepsi.Name = "musteriHepsi";
            this.musteriHepsi.Size = new System.Drawing.Size(54, 24);
            this.musteriHepsi.Text = "Bul";
            this.musteriHepsi.Click += new System.EventHandler(this.musteriHepsi_Click);
            // 
            // musteriEkle
            // 
            this.musteriEkle.Image = global::veritabaniProje.Properties.Resources.add_group;
            this.musteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musteriEkle.Name = "musteriEkle";
            this.musteriEkle.Size = new System.Drawing.Size(60, 24);
            this.musteriEkle.Text = "Ekle";
            this.musteriEkle.Click += new System.EventHandler(this.musteriEkle_Click);
            // 
            // musteriDuzenle
            // 
            this.musteriDuzenle.Image = global::veritabaniProje.Properties.Resources.update;
            this.musteriDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musteriDuzenle.Name = "musteriDuzenle";
            this.musteriDuzenle.Size = new System.Drawing.Size(87, 24);
            this.musteriDuzenle.Text = "Düzenle";
            this.musteriDuzenle.Click += new System.EventHandler(this.musteriDuzenle_Click);
            // 
            // musteriSil
            // 
            this.musteriSil.Image = global::veritabaniProje.Properties.Resources.garbage;
            this.musteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musteriSil.Name = "musteriSil";
            this.musteriSil.Size = new System.Drawing.Size(49, 24);
            this.musteriSil.Text = "Sil";
            this.musteriSil.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(800, 361);
            this.dataGridView1.TabIndex = 4;
            // 
            // iptall
            // 
            this.iptall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptall.Location = new System.Drawing.Point(674, 409);
            this.iptall.Name = "iptall";
            this.iptall.Size = new System.Drawing.Size(96, 29);
            this.iptall.TabIndex = 6;
            this.iptall.Text = "İptal";
            this.iptall.UseVisualStyleBackColor = true;
            this.iptall.Click += new System.EventHandler(this.iptall_Click);
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(539, 409);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(96, 29);
            this.tamam.TabIndex = 7;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            this.tamam.Click += new System.EventHandler(this.tamam_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.iptall);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Musteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton musteriHepsi;
        private System.Windows.Forms.ToolStripButton musteriEkle;
        private System.Windows.Forms.ToolStripButton musteriDuzenle;
        private System.Windows.Forms.ToolStripButton musteriSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptall;
        private System.Windows.Forms.Button tamam;
    }
}