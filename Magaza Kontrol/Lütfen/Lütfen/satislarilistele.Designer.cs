namespace Lütfen
{
    partial class satislarilistele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnYenile = new System.Windows.Forms.Button();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.TxtUrun = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.RdbAd = new System.Windows.Forms.RadioButton();
            this.RdbUrun = new System.Windows.Forms.RadioButton();
            this.BtnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnGeri);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnYenile);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.TxtUrun);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(843, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.Khaki;
            this.BtnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGeri.Location = new System.Drawing.Point(9, 579);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(84, 41);
            this.BtnGeri.TabIndex = 12;
            this.BtnGeri.Text = "GERİ";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            this.BtnGeri.MouseEnter += new System.EventHandler(this.BtnGeri_MouseEnter);
            this.BtnGeri.MouseLeave += new System.EventHandler(this.BtnGeri_MouseLeave);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Khaki;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSil.Location = new System.Drawing.Point(79, 415);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(139, 41);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            this.BtnSil.MouseEnter += new System.EventHandler(this.BtnSil_MouseEnter);
            this.BtnSil.MouseLeave += new System.EventHandler(this.BtnSil_MouseLeave);
            // 
            // BtnYenile
            // 
            this.BtnYenile.BackColor = System.Drawing.Color.Khaki;
            this.BtnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYenile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnYenile.Location = new System.Drawing.Point(79, 368);
            this.BtnYenile.Name = "BtnYenile";
            this.BtnYenile.Size = new System.Drawing.Size(139, 41);
            this.BtnYenile.TabIndex = 9;
            this.BtnYenile.Text = "YENİLE";
            this.BtnYenile.UseVisualStyleBackColor = false;
            this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            this.BtnYenile.MouseEnter += new System.EventHandler(this.BtnYenile_MouseEnter);
            this.BtnYenile.MouseLeave += new System.EventHandler(this.BtnYenile_MouseLeave);
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFiyat.Enabled = false;
            this.TxtFiyat.Location = new System.Drawing.Point(108, 265);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(162, 32);
            this.TxtFiyat.TabIndex = 8;
            // 
            // TxtUrun
            // 
            this.TxtUrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUrun.Enabled = false;
            this.TxtUrun.Location = new System.Drawing.Point(108, 227);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Size = new System.Drawing.Size(162, 32);
            this.TxtUrun.TabIndex = 7;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSoyad.Enabled = false;
            this.TxtSoyad.Location = new System.Drawing.Point(108, 189);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(162, 32);
            this.TxtSoyad.TabIndex = 6;
            // 
            // TxtAd
            // 
            this.TxtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAd.Enabled = false;
            this.TxtAd.Location = new System.Drawing.Point(108, 151);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(162, 32);
            this.TxtAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "FİYAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATIŞLAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAra);
            this.groupBox2.Controls.Add(this.RdbUrun);
            this.groupBox2.Controls.Add(this.RdbAd);
            this.groupBox2.Controls.Add(this.TxtAra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, -10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(108, 114);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(162, 32);
            this.TxtID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "ARA:";
            // 
            // TxtAra
            // 
            this.TxtAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAra.Location = new System.Drawing.Point(89, 49);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(175, 32);
            this.TxtAra.TabIndex = 15;
            // 
            // RdbAd
            // 
            this.RdbAd.AutoSize = true;
            this.RdbAd.Location = new System.Drawing.Point(312, 49);
            this.RdbAd.Name = "RdbAd";
            this.RdbAd.Size = new System.Drawing.Size(66, 29);
            this.RdbAd.TabIndex = 16;
            this.RdbAd.TabStop = true;
            this.RdbAd.Text = "AD";
            this.RdbAd.UseVisualStyleBackColor = true;
            // 
            // RdbUrun
            // 
            this.RdbUrun.AutoSize = true;
            this.RdbUrun.Location = new System.Drawing.Point(450, 49);
            this.RdbUrun.Name = "RdbUrun";
            this.RdbUrun.Size = new System.Drawing.Size(98, 29);
            this.RdbUrun.TabIndex = 17;
            this.RdbUrun.TabStop = true;
            this.RdbUrun.Text = "ÜRÜN";
            this.RdbUrun.UseVisualStyleBackColor = true;
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.Khaki;
            this.BtnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAra.Location = new System.Drawing.Point(650, 41);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(139, 41);
            this.BtnAra.TabIndex = 15;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            this.BtnAra.MouseEnter += new System.EventHandler(this.BtnAra_MouseEnter);
            this.BtnAra.MouseLeave += new System.EventHandler(this.BtnAra_MouseLeave);
            // 
            // satislarilistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "satislarilistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞLARI LİSTELE";
            this.Load += new System.EventHandler(this.satislarilistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.TextBox TxtUrun;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnYenile;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.RadioButton RdbUrun;
        private System.Windows.Forms.RadioButton RdbAd;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Label label7;
    }
}