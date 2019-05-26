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
    public partial class ucOgrenilmisKelimeler : DevExpress.XtraEditors.XtraUserControl
    {
        public ucOgrenilmisKelimeler()
        {
            InitializeComponent();
        }
        Data data = new Data();
        List<Kelime> KelimeListesi = null;

        private void ucOgrenilmisKelimeler_Load(object sender, EventArgs e)
        {
            try
            {
                lstboxOgrenilmis.Items.Clear();

                KelimeListesi = data.KelimeleriGetir("ogrendi");

                foreach (Kelime item in KelimeListesi)
                {
                    lstboxOgrenilmis.Items.Add(item.KelimeID + "-" + item.KelimeTr + "-" + item.KelimeIng);
                }
                KelimeListesi.Clear();
                lbl_OgrenilmisKelimeSayisi.Text = lstboxOgrenilmis.Items.Count.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Öğrenilmiş kelime bulunamamıştır");
            }
                

            
        }
    }
}
