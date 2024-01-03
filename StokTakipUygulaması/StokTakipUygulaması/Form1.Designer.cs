namespace StokTakipUygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnÇıkış = new System.Windows.Forms.Button();
            this.BtnStokÇıkış = new System.Windows.Forms.Button();
            this.BtnStokGiriş = new System.Windows.Forms.Button();
            this.BtnStokTakip = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnÇıkış
            // 
            this.BtnÇıkış.BackColor = System.Drawing.Color.Black;
            this.BtnÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnÇıkış.ForeColor = System.Drawing.Color.White;
            this.BtnÇıkış.Image = ((System.Drawing.Image)(resources.GetObject("BtnÇıkış.Image")));
            this.BtnÇıkış.Location = new System.Drawing.Point(182, 222);
            this.BtnÇıkış.Name = "BtnÇıkış";
            this.BtnÇıkış.Size = new System.Drawing.Size(157, 72);
            this.BtnÇıkış.TabIndex = 4;
            this.BtnÇıkış.Text = "Çıkış";
            this.BtnÇıkış.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnÇıkış.UseVisualStyleBackColor = false;
            this.BtnÇıkış.Click += new System.EventHandler(this.BtnÇıkış_Click);
            // 
            // BtnStokÇıkış
            // 
            this.BtnStokÇıkış.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.BtnStokÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokÇıkış.ForeColor = System.Drawing.Color.White;
            this.BtnStokÇıkış.Image = ((System.Drawing.Image)(resources.GetObject("BtnStokÇıkış.Image")));
            this.BtnStokÇıkış.Location = new System.Drawing.Point(256, 120);
            this.BtnStokÇıkış.Name = "BtnStokÇıkış";
            this.BtnStokÇıkış.Size = new System.Drawing.Size(231, 95);
            this.BtnStokÇıkış.TabIndex = 3;
            this.BtnStokÇıkış.Text = "Stok Çıkış";
            this.BtnStokÇıkış.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStokÇıkış.UseVisualStyleBackColor = false;
            this.BtnStokÇıkış.Click += new System.EventHandler(this.BtnStokÇıkış_Click);
            // 
            // BtnStokGiriş
            // 
            this.BtnStokGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.BtnStokGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokGiriş.ForeColor = System.Drawing.Color.White;
            this.BtnStokGiriş.Image = ((System.Drawing.Image)(resources.GetObject("BtnStokGiriş.Image")));
            this.BtnStokGiriş.Location = new System.Drawing.Point(19, 120);
            this.BtnStokGiriş.Name = "BtnStokGiriş";
            this.BtnStokGiriş.Size = new System.Drawing.Size(231, 95);
            this.BtnStokGiriş.TabIndex = 2;
            this.BtnStokGiriş.Text = "Stok Giriş";
            this.BtnStokGiriş.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStokGiriş.UseVisualStyleBackColor = false;
            this.BtnStokGiriş.Click += new System.EventHandler(this.BtnStokGiriş_Click);
            // 
            // BtnStokTakip
            // 
            this.BtnStokTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.BtnStokTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokTakip.ForeColor = System.Drawing.Color.White;
            this.BtnStokTakip.Image = ((System.Drawing.Image)(resources.GetObject("BtnStokTakip.Image")));
            this.BtnStokTakip.Location = new System.Drawing.Point(256, 19);
            this.BtnStokTakip.Name = "BtnStokTakip";
            this.BtnStokTakip.Size = new System.Drawing.Size(231, 95);
            this.BtnStokTakip.TabIndex = 1;
            this.BtnStokTakip.Text = "Stok Takip";
            this.BtnStokTakip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStokTakip.UseVisualStyleBackColor = false;
            this.BtnStokTakip.Click += new System.EventHandler(this.BtnStokTakip_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.BtnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.BtnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunEkle.Image")));
            this.BtnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUrunEkle.Location = new System.Drawing.Point(19, 19);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(231, 95);
            this.BtnUrunEkle.TabIndex = 0;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(505, 306);
            this.Controls.Add(this.BtnÇıkış);
            this.Controls.Add(this.BtnStokÇıkış);
            this.Controls.Add(this.BtnStokGiriş);
            this.Controls.Add(this.BtnStokTakip);
            this.Controls.Add(this.BtnUrunEkle);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı";
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnStokTakip;
        private System.Windows.Forms.Button BtnStokGiriş;
        private System.Windows.Forms.Button BtnStokÇıkış;
        private System.Windows.Forms.Button BtnÇıkış;
    }
}

