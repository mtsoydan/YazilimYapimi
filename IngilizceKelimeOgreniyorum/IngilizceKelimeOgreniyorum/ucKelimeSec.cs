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
    public partial class ucKelimeSec : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucKelimeSec _instance;
        public static ucKelimeSec Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucKelimeSec();
                }


                return _instance;
            }
        }

        public ucKelimeSec()
        {
            InitializeComponent();
        }

        private void btn_Ogren_Click(object sender, EventArgs e)
        {
            //todo:listboxda checked edilmiş verilerin ogrenme durumlarını test yap listeye aktar
        }
    }
}
