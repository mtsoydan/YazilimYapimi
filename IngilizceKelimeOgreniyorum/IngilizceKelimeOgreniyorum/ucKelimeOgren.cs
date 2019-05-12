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
    public partial class ucKelimeOgren : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKelimeOgren()
        {
            InitializeComponent();
        }
        private static ucKelimeOgren _instance;
        public static ucKelimeOgren Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucKelimeOgren();
                }


                return _instance;
            }
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geri");

        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ileri");
        }

        private void ucKelimeOgren_Load(object sender, EventArgs e)
        {

        }
    }
}
