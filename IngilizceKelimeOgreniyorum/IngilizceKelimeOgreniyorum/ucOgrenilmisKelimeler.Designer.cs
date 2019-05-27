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
            this.lstboxOgrenilmis.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.lstboxOgrenilmis.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstboxOgrenilmis.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lstboxOgrenilmis.Appearance.Options.UseBackColor = true;
            this.lstboxOgrenilmis.Appearance.Options.UseFont = true;
            this.lstboxOgrenilmis.Appearance.Options.UseForeColor = true;
            this.lstboxOgrenilmis.Location = new System.Drawing.Point(122, 38);
            this.lstboxOgrenilmis.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstboxOgrenilmis.Name = "lstboxOgrenilmis";
            this.lstboxOgrenilmis.Size = new System.Drawing.Size(751, 569);
            this.lstboxOgrenilmis.TabIndex = 0;
            this.lstboxOgrenilmis.SelectedIndexChanged += new System.EventHandler(this.lstboxOgrenilmis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 638);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Öğrenilmiş Kelime Sayısı : ";
            // 
            // lbl_OgrenilmisKelimeSayisi
            // 
            this.lbl_OgrenilmisKelimeSayisi.AutoSize = true;
            this.lbl_OgrenilmisKelimeSayisi.Location = new System.Drawing.Point(636, 638);
            this.lbl_OgrenilmisKelimeSayisi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_OgrenilmisKelimeSayisi.Name = "lbl_OgrenilmisKelimeSayisi";
            this.lbl_OgrenilmisKelimeSayisi.Size = new System.Drawing.Size(67, 25);
            this.lbl_OgrenilmisKelimeSayisi.TabIndex = 2;
            this.lbl_OgrenilmisKelimeSayisi.Text = "label2";
            // 
            // ucOgrenilmisKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_OgrenilmisKelimeSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxOgrenilmis);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ucOgrenilmisKelimeler";
            this.Size = new System.Drawing.Size(1049, 711);
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
