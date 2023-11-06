using System;

namespace UyeSorgulamaDemo
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
            this.dgwUyeler = new System.Windows.Forms.DataGridView();
            this.lblsicilNo = new System.Windows.Forms.Label();
            this.tbxOdaSicil = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.tbxkod = new System.Windows.Forms.TextBox();
            this.lblTicaretSicil = new System.Windows.Forms.Label();
            this.tbxsicilno = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.tbxUnvan = new System.Windows.Forms.TextBox();
            this.gbxSorgu = new System.Windows.Forms.GroupBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).BeginInit();
            this.gbxSorgu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUyeler
            // 
            this.dgwUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUyeler.Location = new System.Drawing.Point(163, 193);
            this.dgwUyeler.Name = "dgwUyeler";
            this.dgwUyeler.RowHeadersWidth = 51;
            this.dgwUyeler.RowTemplate.Height = 24;
            this.dgwUyeler.Size = new System.Drawing.Size(759, 150);
            this.dgwUyeler.TabIndex = 0;
            this.dgwUyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUyeler_CellContentClick);
            // 
            // lblsicilNo
            // 
            this.lblsicilNo.AutoSize = true;
            this.lblsicilNo.Location = new System.Drawing.Point(20, 38);
            this.lblsicilNo.Name = "lblsicilNo";
            this.lblsicilNo.Size = new System.Drawing.Size(85, 16);
            this.lblsicilNo.TabIndex = 1;
            this.lblsicilNo.Text = "Oda Sicil No:";
            this.lblsicilNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxOdaSicil
            // 
            this.tbxOdaSicil.Location = new System.Drawing.Point(111, 35);
            this.tbxOdaSicil.Name = "tbxOdaSicil";
            this.tbxOdaSicil.Size = new System.Drawing.Size(117, 22);
            this.tbxOdaSicil.TabIndex = 2;
            this.tbxOdaSicil.TextChanged += new System.EventHandler(this.tbxOdaSicil_TextChanged);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(245, 35);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(65, 16);
            this.lblKod.TabIndex = 3;
            this.lblKod.Text = "İlçe Kodu:";
            this.lblKod.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxkod
            // 
            this.tbxkod.Location = new System.Drawing.Point(316, 32);
            this.tbxkod.Name = "tbxkod";
            this.tbxkod.Size = new System.Drawing.Size(53, 22);
            this.tbxkod.TabIndex = 4;
            this.tbxkod.TextChanged += new System.EventHandler(this.tbxkod_TextChanged);
            // 
            // lblTicaretSicil
            // 
            this.lblTicaretSicil.AutoSize = true;
            this.lblTicaretSicil.Location = new System.Drawing.Point(422, 35);
            this.lblTicaretSicil.Name = "lblTicaretSicil";
            this.lblTicaretSicil.Size = new System.Drawing.Size(101, 16);
            this.lblTicaretSicil.TabIndex = 5;
            this.lblTicaretSicil.Text = "Ticaret Sicil No:";
            this.lblTicaretSicil.Click += new System.EventHandler(this.lblTicaretSicil_Click);
            // 
            // tbxsicilno
            // 
            this.tbxsicilno.Location = new System.Drawing.Point(529, 32);
            this.tbxsicilno.Name = "tbxsicilno";
            this.tbxsicilno.Size = new System.Drawing.Size(106, 22);
            this.tbxsicilno.TabIndex = 6;
            this.tbxsicilno.TextChanged += new System.EventHandler(this.tbxsicilno_TextChanged);
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(20, 91);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(49, 16);
            this.lblUnvan.TabIndex = 7;
            this.lblUnvan.Text = "Ünvan:";
            this.lblUnvan.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbxUnvan
            // 
            this.tbxUnvan.Location = new System.Drawing.Point(111, 88);
            this.tbxUnvan.Name = "tbxUnvan";
            this.tbxUnvan.Size = new System.Drawing.Size(578, 22);
            this.tbxUnvan.TabIndex = 8;
            // 
            // gbxSorgu
            // 
            this.gbxSorgu.Controls.Add(this.btnSorgula);
            this.gbxSorgu.Controls.Add(this.tbxUnvan);
            this.gbxSorgu.Controls.Add(this.lblUnvan);
            this.gbxSorgu.Controls.Add(this.tbxsicilno);
            this.gbxSorgu.Controls.Add(this.lblTicaretSicil);
            this.gbxSorgu.Controls.Add(this.tbxkod);
            this.gbxSorgu.Controls.Add(this.lblKod);
            this.gbxSorgu.Controls.Add(this.tbxOdaSicil);
            this.gbxSorgu.Controls.Add(this.lblsicilNo);
            this.gbxSorgu.Location = new System.Drawing.Point(163, 12);
            this.gbxSorgu.Name = "gbxSorgu";
            this.gbxSorgu.Size = new System.Drawing.Size(759, 147);
            this.gbxSorgu.TabIndex = 9;
            this.gbxSorgu.TabStop = false;
            this.gbxSorgu.Text = "Üye Bilgi Sorgulama";
            this.gbxSorgu.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(677, 38);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(55, 30);
            this.btnSorgula.TabIndex = 9;
            this.btnSorgula.Text = "Enter";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1051, 457);
            this.Controls.Add(this.gbxSorgu);
            this.Controls.Add(this.dgwUyeler);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).EndInit();
            this.gbxSorgu.ResumeLayout(false);
            this.gbxSorgu.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.DataGridView dgwUyeler;
        private System.Windows.Forms.Label lblsicilNo;
        private System.Windows.Forms.TextBox tbxOdaSicil;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox tbxkod;
        private System.Windows.Forms.Label lblTicaretSicil;
        private System.Windows.Forms.TextBox tbxsicilno;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox tbxUnvan;
        private System.Windows.Forms.GroupBox gbxSorgu;
        private System.Windows.Forms.Button btnSorgula;
    }
}

