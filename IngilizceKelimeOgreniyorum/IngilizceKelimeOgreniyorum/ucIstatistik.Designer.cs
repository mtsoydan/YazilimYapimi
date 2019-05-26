namespace IngilizceKelimeOgreniyorum
{
    partial class ucIstatistik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.Chart_istatistik = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_istatistik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_istatistik
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "";
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "";
            this.Chart_istatistik.Diagram = xyDiagram1;
            this.Chart_istatistik.Legend.Name = "Default Legend";
            this.Chart_istatistik.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.Chart_istatistik.Location = new System.Drawing.Point(4, 6);
            this.Chart_istatistik.Name = "Chart_istatistik";
            series1.Name = "Series 1";
            this.Chart_istatistik.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.Chart_istatistik.Size = new System.Drawing.Size(545, 341);
            this.Chart_istatistik.TabIndex = 0;
            this.Chart_istatistik.Click += new System.EventHandler(this.Chart_istatistik_Click);
            // 
            // ucIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chart_istatistik);
            this.Name = "ucIstatistik";
            this.Size = new System.Drawing.Size(626, 414);
            this.Load += new System.EventHandler(this.ucIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_istatistik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl Chart_istatistik;
    }
}
