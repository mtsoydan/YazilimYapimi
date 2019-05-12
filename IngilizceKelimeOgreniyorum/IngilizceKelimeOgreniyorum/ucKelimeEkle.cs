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
    public partial class ucKelimeEkle : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKelimeEkle()
        {
            InitializeComponent();
        }
        private static ucKelimeEkle _instance;

        public static ucKelimeEkle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucKelimeEkle();
                }


                return _instance;
            }
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void ucKelimeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
