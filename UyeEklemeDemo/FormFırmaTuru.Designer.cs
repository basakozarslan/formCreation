namespace UyeEklemeDemo
{
    partial class FormFırmaTuru
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
            this.cbxFırmaTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxFırmaTuru
            // 
            this.cbxFırmaTuru.FormattingEnabled = true;
            this.cbxFırmaTuru.Location = new System.Drawing.Point(222, 123);
            this.cbxFırmaTuru.Name = "cbxFırmaTuru";
            this.cbxFırmaTuru.Size = new System.Drawing.Size(121, 24);
            this.cbxFırmaTuru.TabIndex = 0;
            this.cbxFırmaTuru.Text = "Firma Türü";
            // 
            // FormFırmaTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxFırmaTuru);
            this.Name = "FormFırmaTuru";
            this.Text = "FormFırmaTuru";
            this.Load += new System.EventHandler(this.FormFırmaTuru_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFırmaTuru;
    }
}