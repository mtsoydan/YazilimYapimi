using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IngilizceKelimeOgreniyorum
{
    public partial class ucIstatistik : DevExpress.XtraEditors.XtraUserControl
    {
        public ucIstatistik()
        {
            InitializeComponent();
        }
        List<Kelime> KelimeListesi = null;
        Data data = new Data();
        string[] aylar = new string[12] { "Ocak", "Subat", "Mart", "Nisan", "Mayis", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

        private void ucIstatistik_Load(object sender, EventArgs e)
        {
            int i = 0, j = 1;
            KelimeListesi = data.KelimeleriGetir("ogrendi");
            while (KelimeListesi.Count > 0 && i < KelimeListesi.Count)
            {
                if (KelimeListesi[i].KelimeOgrenmeTarihi.Month == j)
                {
                    
                    Chart_istatistik.Series["Series 1"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(aylar[j - 1],data.AyaGoreToplamKelime(j)));
                    i++; j = 1;
                }
                else j++;
            }

        }

        private void Chart_istatistik_Click(object sender, EventArgs e)
        {

        }
    }
}
