namespace veritabaniProje.UI
{
    partial class Odemeler
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
            this.odemeHepsi = new System.Windows.Forms.ToolStripButton();
            this.odemeEkle = new System.Windows.Forms.ToolStripButton();
            this.odemeDuzenle = new System.Windows.Forms.ToolStripButton();
            this.odemeSil = new System.Windows.Forms.ToolStripButton();
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
            this.odemeHepsi,
            this.odemeEkle,
            this.odemeDuzenle,
            this.odemeSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // odemeHepsi
            // 
            this.odemeHepsi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odemeHepsi.Image = global::veritabaniProje.Properties.Resources.icons8_money_48;
            this.odemeHepsi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeHepsi.Name = "odemeHepsi";
            this.odemeHepsi.Size = new System.Drawing.Size(54, 24);
            this.odemeHepsi.Text = "Bul";
            this.odemeHepsi.Click += new System.EventHandler(this.odemeHepsi_Click);
            // 
            // odemeEkle
            // 
            this.odemeEkle.Image = global::veritabaniProje.Properties.Resources.icons8_sales_100;
            this.odemeEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeEkle.Name = "odemeEkle";
            this.odemeEkle.Size = new System.Drawing.Size(60, 24);
            this.odemeEkle.Text = "Ekle";
            this.odemeEkle.Click += new System.EventHandler(this.odemeEkle_Click);
            // 
            // odemeDuzenle
            // 
            this.odemeDuzenle.Image = global::veritabaniProje.Properties.Resources.icons8_pencil_16;
            this.odemeDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeDuzenle.Name = "odemeDuzenle";
            this.odemeDuzenle.Size = new System.Drawing.Size(87, 24);
            this.odemeDuzenle.Text = "Düzenle";
            this.odemeDuzenle.Click += new System.EventHandler(this.odemeDuzenle_Click);
            // 
            // odemeSil
            // 
            this.odemeSil.Image = global::veritabaniProje.Properties.Resources.icons8_bin_48;
            this.odemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeSil.Name = "odemeSil";
            this.odemeSil.Size = new System.Drawing.Size(49, 24);
            this.odemeSil.Text = "Sil";
            this.odemeSil.Click += new System.EventHandler(this.odemeSil_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(809, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // iptall
            // 
            this.iptall.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptall.Location = new System.Drawing.Point(674, 399);
            this.iptall.Name = "iptall";
            this.iptall.Size = new System.Drawing.Size(96, 29);
            this.iptall.TabIndex = 4;
            this.iptall.Text = "İptal";
            this.iptall.UseVisualStyleBackColor = true;
            // 
            // tamam
            // 
            this.tamam.Location = new System.Drawing.Point(539, 399);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(96, 29);
            this.tamam.TabIndex = 5;
            this.tamam.Text = "Tamam";
            this.tamam.UseVisualStyleBackColor = true;
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 440);
            this.Controls.Add(this.iptall);
            this.Controls.Add(this.tamam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Odemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.Odemeler_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton odemeHepsi;
        private System.Windows.Forms.ToolStripButton odemeEkle;
        private System.Windows.Forms.ToolStripButton odemeDuzenle;
        private System.Windows.Forms.ToolStripButton odemeSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button iptall;
        private System.Windows.Forms.Button tamam;
    }
}