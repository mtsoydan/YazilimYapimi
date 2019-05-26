namespace IngilizceKelimeOgreniyorum
{
    partial class ucOgrenilmisKelimeler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxOgrenilmis = new DevExpress.XtraEditors.ListBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_OgrenilmisKelimeSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstboxOgrenilmis)).BeginInit();
            this.SuspendLayout();
            // 
            // lstboxOgrenilmis
            // 
            this.lstboxOgrenilmis.Location = new System.Drawing.Point(71, 24);
            this.lstboxOgrenilmis.Name = "lstboxOgrenilmis";
            this.lstboxOgrenilmis.Size = new System.Drawing.Size(438, 364);
            this.lstboxOgrenilmis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Öğrenilmiş Kelime Sayısı : ";
            // 
            // lbl_OgrenilmisKelimeSayisi
            // 
            this.lbl_OgrenilmisKelimeSayisi.AutoSize = true;
            this.lbl_OgrenilmisKelimeSayisi.Location = new System.Drawing.Point(371, 408);
            this.lbl_OgrenilmisKelimeSayisi.Name = "lbl_OgrenilmisKelimeSayisi";
            this.lbl_OgrenilmisKelimeSayisi.Size = new System.Drawing.Size(42, 17);
            this.lbl_OgrenilmisKelimeSayisi.TabIndex = 2;
            this.lbl_OgrenilmisKelimeSayisi.Text = "label2";
            // 
            // ucOgrenilmisKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_OgrenilmisKelimeSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxOgrenilmis);
            this.Name = "ucOgrenilmisKelimeler";
            this.Size = new System.Drawing.Size(612, 455);
            this.Load += new System.EventHandler(this.ucOgrenilmisKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstboxOgrenilmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lstboxOgrenilmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_OgrenilmisKelimeSayisi;
    }
}
