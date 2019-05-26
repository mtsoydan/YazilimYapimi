namespace IngilizceKelimeOgreniyorum
{
    partial class ucKelimeSec
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
            this.ListviewKelimeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_ara = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Ogren = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaldir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ara.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ListviewKelimeler
            // 
            this.ListviewKelimeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ListviewKelimeler.CheckBoxes = true;
            this.ListviewKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListviewKelimeler.FullRowSelect = true;
            this.ListviewKelimeler.GridLines = true;
            this.ListviewKelimeler.Location = new System.Drawing.Point(2, 77);
            this.ListviewKelimeler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListviewKelimeler.Name = "ListviewKelimeler";
            this.ListviewKelimeler.Size = new System.Drawing.Size(712, 354);
            this.ListviewKelimeler.TabIndex = 8;
            this.ListviewKelimeler.UseCompatibleStateImageBehavior = false;
            this.ListviewKelimeler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KelimeID";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Türkçe Anlamı";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İngilizce Anlamı";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Acıklama";
            this.columnHeader4.Width = 281;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kelime Türü";
            this.columnHeader5.Width = 226;
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(165, 6);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(388, 42);
            this.txt_ara.TabIndex = 12;
            this.txt_ara.EditValueChanged += new System.EventHandler(this.txt_ara_EditValueChanged);
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(0, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(712, 34);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 35);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Türkçe Anlamı :";
            // 
            // btn_Ogren
            // 
            this.btn_Ogren.ImageOptions.Image = global::IngilizceKelimeOgreniyorum.Properties.Resources.add_32x32;
            this.btn_Ogren.Location = new System.Drawing.Point(165, 445);
            this.btn_Ogren.Name = "btn_Ogren";
            this.btn_Ogren.Size = new System.Drawing.Size(141, 49);
            this.btn_Ogren.TabIndex = 9;
            this.btn_Ogren.Text = "Öğren";
            this.btn_Ogren.Click += new System.EventHandler(this.btn_Ogren_Click);
            // 
            // btn_kaldir
            // 
            this.btn_kaldir.ImageOptions.Image = global::IngilizceKelimeOgreniyorum.Properties.Resources.remove_32x32;
            this.btn_kaldir.Location = new System.Drawing.Point(312, 445);
            this.btn_kaldir.Name = "btn_kaldir";
            this.btn_kaldir.Size = new System.Drawing.Size(141, 49);
            this.btn_kaldir.TabIndex = 14;
            this.btn_kaldir.Text = "Listeden Kaldır";
            this.btn_kaldir.Click += new System.EventHandler(this.btn_kaldir_Click);
            // 
            // ucKelimeSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_kaldir);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Ogren);
            this.Controls.Add(this.ListviewKelimeler);
            this.Name = "ucKelimeSec";
            this.Size = new System.Drawing.Size(712, 497);
            this.Load += new System.EventHandler(this.ucKelimeSec_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ucKelimeSec_ControlAdded);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ara.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListviewKelimeler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevExpress.XtraEditors.SimpleButton btn_Ogren;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevExpress.XtraEditors.TextEdit txt_ara;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kaldir;
    }
}
