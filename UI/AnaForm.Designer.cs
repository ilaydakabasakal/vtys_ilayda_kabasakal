
namespace veritabaniProje
{
    partial class AnaForm
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
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.btnUrunler = new System.Windows.Forms.ToolStripButton();
            this.btnSepet = new System.Windows.Forms.ToolStripButton();
            this.btnSatis = new System.Windows.Forms.ToolStripButton();
            this.btnOdeme = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriler,
            this.btnUrunler,
            this.btnSepet,
            this.btnSatis,
            this.btnOdeme});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1122, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = global::veritabaniProje.Properties.Resources.icons8_customer_50;
            this.btnMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(129, 54);
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Image = global::veritabaniProje.Properties.Resources.icons8_product_50;
            this.btnUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(111, 54);
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnSepet
            // 
            this.btnSepet.Image = global::veritabaniProje.Properties.Resources.icons8_basket_48;
            this.btnSepet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(124, 54);
            this.btnSepet.Text = "Siparişler";
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Image = global::veritabaniProje.Properties.Resources.icons8_shopping_mall_48;
            this.btnSatis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(111, 54);
            this.btnSatis.Text = "Satışlar";
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Image = global::veritabaniProje.Properties.Resources.icons8_sales_100;
            this.btnOdeme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(129, 54);
            this.btnOdeme.Text = "Ödemeler";
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 482);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AnaForm";
            this.Text = "Anaform";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.ToolStripButton btnUrunler;
        private System.Windows.Forms.ToolStripButton btnSepet;
        private System.Windows.Forms.ToolStripButton btnSatis;
        private System.Windows.Forms.ToolStripButton btnOdeme;
    }
}

