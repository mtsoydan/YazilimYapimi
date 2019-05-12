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
    public partial class ucTesteBasla : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTesteBasla()
        {
            InitializeComponent();
        }

        private static ucTesteBasla _instance;
        public static ucTesteBasla Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTesteBasla();
                }


                return _instance;
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}
