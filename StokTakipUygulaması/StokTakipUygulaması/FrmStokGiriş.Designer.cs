namespace StokTakipUygulaması
{
    partial class FrmStokGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokGiriş));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 387);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnAra);
            this.groupBox1.Controls.Add(this.BtnGeri);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnListele);
            this.groupBox1.Controls.Add(this.TxtAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // TxtAd
            // 
            this.TxtAd.ForeColor = System.Drawing.Color.Black;
            this.TxtAd.Location = new System.Drawing.Point(131, 59);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(223, 40);
            this.TxtAd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ürün Adı:";
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAra.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.ForeColor = System.Drawing.Color.Black;
            this.BtnAra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAra.Image")));
            this.BtnAra.Location = new System.Drawing.Point(195, 279);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(159, 48);
            this.BtnAra.TabIndex = 13;
            this.BtnAra.Text = "Ara";
            this.BtnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.ForeColor = System.Drawing.Color.Black;
            this.BtnGeri.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeri.Image")));
            this.BtnGeri.Location = new System.Drawing.Point(30, 279);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(159, 48);
            this.BtnGeri.TabIndex = 12;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.Image")));
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuncelle.Location = new System.Drawing.Point(195, 225);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(159, 48);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "Stok Ekle";
            this.BtnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListele.ForeColor = System.Drawing.Color.Black;
            this.BtnListele.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.Image")));
            this.BtnListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnListele.Location = new System.Drawing.Point(30, 225);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(159, 48);
            this.BtnListele.TabIndex = 9;
            this.BtnListele.Text = "Listele";
            this.BtnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAdet
            // 
            this.TxtAdet.ForeColor = System.Drawing.Color.Black;
            this.TxtAdet.Location = new System.Drawing.Point(131, 151);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(223, 40);
            this.TxtAdet.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adet:";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.ForeColor = System.Drawing.Color.Black;
            this.Txtid.Location = new System.Drawing.Point(131, 105);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(223, 40);
            this.Txtid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 387);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmStokGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 387);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "FrmStokGiriş";
            this.Text = "Stok Giriş";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAra;
    }
}