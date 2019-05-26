namespace IngilizceKelimeOgreniyorum
{
    partial class frm_anaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_anaSayfa));
            this.FormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKelimeEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKelimeSec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AceKelimeOgren = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTesteBasla = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.aceOgrenilmis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormContainer
            // 
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(202, 62);
            this.FormContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(637, 451);
            this.FormContainer.TabIndex = 0;
            this.FormContainer.Click += new System.EventHandler(this.FormContainer_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 62);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(202, 451);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceKelimeEkle,
            this.aceKelimeSec,
            this.AceKelimeOgren,
            this.aceTesteBasla,
            this.aceOgrenilmis});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Kullanıcı İşlemleri";
            // 
            // aceKelimeEkle
            // 
            this.aceKelimeEkle.Name = "aceKelimeEkle";
            this.aceKelimeEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKelimeEkle.Text = "Kelime Ekle";
            this.aceKelimeEkle.Click += new System.EventHandler(this.aceKelimeEkle_Click);
            // 
            // aceKelimeSec
            // 
            this.aceKelimeSec.Name = "aceKelimeSec";
            this.aceKelimeSec.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKelimeSec.Text = "Kelime Seç";
            this.aceKelimeSec.Click += new System.EventHandler(this.aceKelimeSec_Click);
            // 
            // AceKelimeOgren
            // 
            this.AceKelimeOgren.Name = "AceKelimeOgren";
            this.AceKelimeOgren.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AceKelimeOgren.Text = "Kelime Öğren";
            this.AceKelimeOgren.Click += new System.EventHandler(this.AceKelimeOgren_Click);
            // 
            // aceTesteBasla
            // 
            this.aceTesteBasla.Name = "aceTesteBasla";
            this.aceTesteBasla.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTesteBasla.Text = "Teste Başla";
            this.aceTesteBasla.Click += new System.EventHandler(this.aceTesteBasla_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(839, 62);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // aceOgrenilmis
            // 
            this.aceOgrenilmis.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.aceOgrenilmis.Name = "aceOgrenilmis";
            this.aceOgrenilmis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceOgrenilmis.Text = "Öğrenilmiş Kelimeler";
            this.aceOgrenilmis.Click += new System.EventHandler(this.aceOgrenilmis_Click);
            // 
            // frm_anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 513);
            this.ControlContainer = this.FormContainer;
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_anaSayfa";
            this.NavigationControl = this.accordionControl1;
            this.Text = "İngilizce Kelime Öğreniyorum";
            this.Load += new System.EventHandler(this.frm_anaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer FormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKelimeEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKelimeSec;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AceKelimeOgren;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTesteBasla;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceOgrenilmis;
    }
}

