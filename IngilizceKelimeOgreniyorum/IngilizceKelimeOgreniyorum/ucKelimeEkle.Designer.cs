namespace IngilizceKelimeOgreniyorum
{
    partial class ucKelimeEkle
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_turkce = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKelimeTur = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.txt_aciklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.txt_ingilizce = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_turkce.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKelimeTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ingilizce.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 55);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Türkçe Anlamı :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txt_turkce
            // 
            this.txt_turkce.EditValue = "";
            this.txt_turkce.Location = new System.Drawing.Point(207, 20);
            this.txt_turkce.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_turkce.Name = "txt_turkce";
            this.txt_turkce.Size = new System.Drawing.Size(665, 68);
            this.txt_turkce.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbKelimeTur);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.windowsUIButtonPanel1);
            this.panel1.Controls.Add(this.txt_aciklama);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.txt_ingilizce);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txt_turkce);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(48, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 554);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbKelimeTur
            // 
            this.cmbKelimeTur.EditValue = "";
            this.cmbKelimeTur.Location = new System.Drawing.Point(207, 293);
            this.cmbKelimeTur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbKelimeTur.Name = "cmbKelimeTur";
            this.cmbKelimeTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKelimeTur.Properties.Items.AddRange(new object[] {
            "Verb (v) - Fiil/eylem ",
            "Noun (n) - İsim",
            "Adjective (adj) - Sıfat",
            "Adverb (adv) - Zarf",
            "Preposition (prep) - Edat",
            "Pronouns - Zamirler ",
            "Conjunctions - Zağlaçlar",
            "Interjections - Ünlemler"});
            this.cmbKelimeTur.Size = new System.Drawing.Size(665, 68);
            this.cmbKelimeTur.TabIndex = 14;
            this.cmbKelimeTur.SelectedIndexChanged += new System.EventHandler(this.cmbKelimeTur_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 330);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(902, 85);
            this.labelControl7.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl8.Location = new System.Drawing.Point(22, 288);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(175, 55);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "      Kelime Türü :";
            // 
            // windowsUIButtonPanel1
            // 
            windowsUIButtonImageOptions1.Image = global::IngilizceKelimeOgreniyorum.Properties.Resources.apply_32x32;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Ekle", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(439, 411);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(154, 114);
            this.windowsUIButtonPanel1.TabIndex = 10;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Click += new System.EventHandler(this.windowsUIButtonPanel1_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(207, 200);
            this.txt_aciklama.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(665, 68);
            this.txt_aciklama.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 247);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(902, 53);
            this.labelControl5.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.label.Location = new System.Drawing.Point(22, 205);
            this.label.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(175, 55);
            this.label.TabIndex = 7;
            this.label.Text = "          Açıklama :";
            // 
            // txt_ingilizce
            // 
            this.txt_ingilizce.Location = new System.Drawing.Point(207, 116);
            this.txt_ingilizce.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_ingilizce.Name = "txt_ingilizce";
            this.txt_ingilizce.Size = new System.Drawing.Size(665, 68);
            this.txt_ingilizce.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 162);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(902, 53);
            this.labelControl2.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 120);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 55);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "İngilizce Anlamı : ";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(129, 95);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 25);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.UseMnemonic = false;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 67);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(902, 53);
            this.labelControl6.TabIndex = 1;
            // 
            // ucKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ucKelimeEkle";
            this.Size = new System.Drawing.Size(1042, 684);
            this.Load += new System.EventHandler(this.ucKelimeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_turkce.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbKelimeTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ingilizce.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_turkce;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txt_ingilizce;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.TextEdit txt_aciklama;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKelimeTur;
    }
}
