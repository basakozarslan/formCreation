namespace UyeEklemeDemo{
    partial class FormWithAdd{
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithAdd));
            this.dgwShow = new System.Windows.Forms.DataGridView();
            this.lblOdaSicil = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblYetkili = new System.Windows.Forms.Label();
            this.lblKlasorNo = new System.Windows.Forms.Label();
            this.lblMerkezSube = new System.Windows.Forms.Label();
            this.lblFirmaTuru = new System.Windows.Forms.Label();
            this.txtOdaSicil = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbxTescilTuru = new System.Windows.Forms.ComboBox();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.cbxMerkezSube = new System.Windows.Forms.ComboBox();
            this.cbxFırmaTuru = new System.Windows.Forms.ComboBox();
            this.txtKlasorNo = new System.Windows.Forms.TextBox();
            this.lblFaaliyetSuresi = new System.Windows.Forms.Label();
            this.txtFaaliyetSuresi = new System.Windows.Forms.TextBox();
            this.cbxKapanısSebebi = new System.Windows.Forms.ComboBox();
            this.lblAltSirket = new System.Windows.Forms.Label();
            this.cbxAltSirket = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbxTescilTarihi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxKapanısTarihi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwShow
            // 
            this.dgwShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShow.Location = new System.Drawing.Point(90, 284);
            this.dgwShow.Name = "dgwShow";
            this.dgwShow.RowHeadersWidth = 51;
            this.dgwShow.RowTemplate.Height = 24;
            this.dgwShow.Size = new System.Drawing.Size(920, 302);
            this.dgwShow.TabIndex = 0;
            this.dgwShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblOdaSicil
            // 
            this.lblOdaSicil.AutoSize = true;
            this.lblOdaSicil.Location = new System.Drawing.Point(87, 44);
            this.lblOdaSicil.Name = "lblOdaSicil";
            this.lblOdaSicil.Size = new System.Drawing.Size(85, 16);
            this.lblOdaSicil.TabIndex = 1;
            this.lblOdaSicil.Text = "Oda Sicil No:";
            this.lblOdaSicil.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(140, 86);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(31, 16);
            this.lblIlce.TabIndex = 2;
            this.lblIlce.Text = "İlçe:";
            // 
            // lblYetkili
            // 
            this.lblYetkili.AutoSize = true;
            this.lblYetkili.Location = new System.Drawing.Point(433, 47);
            this.lblYetkili.Name = "lblYetkili";
            this.lblYetkili.Size = new System.Drawing.Size(46, 16);
            this.lblYetkili.TabIndex = 3;
            this.lblYetkili.Text = "Yetkili:";
            // 
            // lblKlasorNo
            // 
            this.lblKlasorNo.AutoSize = true;
            this.lblKlasorNo.Location = new System.Drawing.Point(672, 83);
            this.lblKlasorNo.Name = "lblKlasorNo";
            this.lblKlasorNo.Size = new System.Drawing.Size(69, 16);
            this.lblKlasorNo.TabIndex = 5;
            this.lblKlasorNo.Text = "Klasör No:";
            // 
            // lblMerkezSube
            // 
            this.lblMerkezSube.AutoSize = true;
            this.lblMerkezSube.Location = new System.Drawing.Point(389, 83);
            this.lblMerkezSube.Name = "lblMerkezSube";
            this.lblMerkezSube.Size = new System.Drawing.Size(90, 16);
            this.lblMerkezSube.TabIndex = 6;
            this.lblMerkezSube.Text = "Merkez/Şube:";
            // 
            // lblFirmaTuru
            // 
            this.lblFirmaTuru.AutoSize = true;
            this.lblFirmaTuru.Location = new System.Drawing.Point(405, 130);
            this.lblFirmaTuru.Name = "lblFirmaTuru";
            this.lblFirmaTuru.Size = new System.Drawing.Size(74, 16);
            this.lblFirmaTuru.TabIndex = 7;
            this.lblFirmaTuru.Text = "Firma Türü:";
            // 
            // txtOdaSicil
            // 
            this.txtOdaSicil.Location = new System.Drawing.Point(178, 41);
            this.txtOdaSicil.Name = "txtOdaSicil";
            this.txtOdaSicil.Size = new System.Drawing.Size(140, 22);
            this.txtOdaSicil.TabIndex = 8;
            this.txtOdaSicil.Text = "0";
            this.txtOdaSicil.TextChanged += new System.EventHandler(this.txtOdaSicil_TextChanged);
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(178, 86);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(140, 22);
            this.txtIlce.TabIndex = 9;
            this.txtIlce.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(90, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(306, 26);
            this.dataGridView2.TabIndex = 10;
            // 
            // cbxTescilTuru
            // 
            this.cbxTescilTuru.FormattingEnabled = true;
            this.cbxTescilTuru.Location = new System.Drawing.Point(344, 181);
            this.cbxTescilTuru.Name = "cbxTescilTuru";
            this.cbxTescilTuru.Size = new System.Drawing.Size(182, 24);
            this.cbxTescilTuru.TabIndex = 12;
            this.cbxTescilTuru.Text = "Tescil Türü";
            this.cbxTescilTuru.SelectedIndexChanged += new System.EventHandler(this.cbxTescilTuru_SelectedIndexChanged);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(485, 44);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(303, 22);
            this.txtYetkili.TabIndex = 13;
            // 
            // cbxMerkezSube
            // 
            this.cbxMerkezSube.FormattingEnabled = true;
            this.cbxMerkezSube.Location = new System.Drawing.Point(485, 80);
            this.cbxMerkezSube.Name = "cbxMerkezSube";
            this.cbxMerkezSube.Size = new System.Drawing.Size(170, 24);
            this.cbxMerkezSube.TabIndex = 14;
            this.cbxMerkezSube.Text = "Merkez-Şube Seçiniz";
            this.cbxMerkezSube.SelectedIndexChanged += new System.EventHandler(this.cbxMerkezSube_SelectedIndexChanged);
            // 
            // cbxFırmaTuru
            // 
            this.cbxFırmaTuru.FormattingEnabled = true;
            this.cbxFırmaTuru.Location = new System.Drawing.Point(485, 127);
            this.cbxFırmaTuru.Name = "cbxFırmaTuru";
            this.cbxFırmaTuru.Size = new System.Drawing.Size(192, 24);
            this.cbxFırmaTuru.TabIndex = 15;
            this.cbxFırmaTuru.Text = "Seçiniz";
            this.cbxFırmaTuru.SelectedIndexChanged += new System.EventHandler(this.cbxFırmaTuru_SelectedIndexChanged);
            // 
            // txtKlasorNo
            // 
            this.txtKlasorNo.Location = new System.Drawing.Point(747, 80);
            this.txtKlasorNo.Name = "txtKlasorNo";
            this.txtKlasorNo.Size = new System.Drawing.Size(41, 22);
            this.txtKlasorNo.TabIndex = 16;
            // 
            // lblFaaliyetSuresi
            // 
            this.lblFaaliyetSuresi.AutoSize = true;
            this.lblFaaliyetSuresi.Location = new System.Drawing.Point(803, 83);
            this.lblFaaliyetSuresi.Name = "lblFaaliyetSuresi";
            this.lblFaaliyetSuresi.Size = new System.Drawing.Size(99, 16);
            this.lblFaaliyetSuresi.TabIndex = 17;
            this.lblFaaliyetSuresi.Text = "Faaliyet Süresi:";
            // 
            // txtFaaliyetSuresi
            // 
            this.txtFaaliyetSuresi.Location = new System.Drawing.Point(920, 80);
            this.txtFaaliyetSuresi.Name = "txtFaaliyetSuresi";
            this.txtFaaliyetSuresi.Size = new System.Drawing.Size(42, 22);
            this.txtFaaliyetSuresi.TabIndex = 18;
            this.txtFaaliyetSuresi.Text = "0";
            // 
            // cbxKapanısSebebi
            // 
            this.cbxKapanısSebebi.FormattingEnabled = true;
            this.cbxKapanısSebebi.Location = new System.Drawing.Point(793, 181);
            this.cbxKapanısSebebi.Name = "cbxKapanısSebebi";
            this.cbxKapanısSebebi.Size = new System.Drawing.Size(169, 24);
            this.cbxKapanısSebebi.TabIndex = 21;
            this.cbxKapanısSebebi.Text = "Kapanış Sebebi";
            // 
            // lblAltSirket
            // 
            this.lblAltSirket.AutoSize = true;
            this.lblAltSirket.Location = new System.Drawing.Point(700, 130);
            this.lblAltSirket.Name = "lblAltSirket";
            this.lblAltSirket.Size = new System.Drawing.Size(88, 16);
            this.lblAltSirket.TabIndex = 22;
            this.lblAltSirket.Text = "Alt Şirket Tipi:";
            // 
            // cbxAltSirket
            // 
            this.cbxAltSirket.FormattingEnabled = true;
            this.cbxAltSirket.Location = new System.Drawing.Point(794, 127);
            this.cbxAltSirket.Name = "cbxAltSirket";
            this.cbxAltSirket.Size = new System.Drawing.Size(156, 24);
            this.cbxAltSirket.TabIndex = 23;
            this.cbxAltSirket.Text = "Seçiniz";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(344, 41);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(68, 31);
            this.btnEnter.TabIndex = 24;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(302, 624);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 37);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(404, 624);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 37);
            this.btnVazgec.TabIndex = 26;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(863, 41);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(97, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 236);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tescil Tarihi";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbxTescilTarihi
            // 
            this.tbxTescilTarihi.Location = new System.Drawing.Point(178, 183);
            this.tbxTescilTarihi.Name = "tbxTescilTarihi";
            this.tbxTescilTarihi.Size = new System.Drawing.Size(135, 22);
            this.tbxTescilTarihi.TabIndex = 29;
            this.tbxTescilTarihi.Text = "Tescil Tarihi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(565, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 53);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tbxKapanısTarihi
            // 
            this.tbxKapanısTarihi.Location = new System.Drawing.Point(637, 183);
            this.tbxKapanısTarihi.Name = "tbxKapanısTarihi";
            this.tbxKapanısTarihi.Size = new System.Drawing.Size(135, 22);
            this.tbxKapanısTarihi.TabIndex = 32;
            this.tbxKapanısTarihi.Text = "Kapanış Tarihi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar2);
            this.groupBox2.Location = new System.Drawing.Point(565, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 236);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kapanış Tarihi";
            this.groupBox2.Visible = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(0, 27);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 624);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 37);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWithAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 677);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxKapanısTarihi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxTescilTarihi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbxAltSirket);
            this.Controls.Add(this.lblAltSirket);
            this.Controls.Add(this.cbxKapanısSebebi);
            this.Controls.Add(this.txtFaaliyetSuresi);
            this.Controls.Add(this.lblFaaliyetSuresi);
            this.Controls.Add(this.txtKlasorNo);
            this.Controls.Add(this.cbxFırmaTuru);
            this.Controls.Add(this.cbxMerkezSube);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.cbxTescilTuru);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtOdaSicil);
            this.Controls.Add(this.lblFirmaTuru);
            this.Controls.Add(this.lblMerkezSube);
            this.Controls.Add(this.lblKlasorNo);
            this.Controls.Add(this.lblYetkili);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblOdaSicil);
            this.Controls.Add(this.dgwShow);
            this.Name = "FormWithAdd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwShow;
        private System.Windows.Forms.Label lblOdaSicil;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblYetkili;
        private System.Windows.Forms.Label lblKlasorNo;
        private System.Windows.Forms.Label lblMerkezSube;
        private System.Windows.Forms.Label lblFirmaTuru;
        private System.Windows.Forms.TextBox txtOdaSicil;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbxTescilTuru;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.ComboBox cbxMerkezSube;
        private System.Windows.Forms.ComboBox cbxFırmaTuru;
        private System.Windows.Forms.TextBox txtKlasorNo;
        private System.Windows.Forms.Label lblFaaliyetSuresi;
        private System.Windows.Forms.TextBox txtFaaliyetSuresi;
        private System.Windows.Forms.ComboBox cbxKapanısSebebi;
        private System.Windows.Forms.Label lblAltSirket;
        private System.Windows.Forms.ComboBox cbxAltSirket;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbxTescilTarihi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxKapanısTarihi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btnUpdate;
    }
}

