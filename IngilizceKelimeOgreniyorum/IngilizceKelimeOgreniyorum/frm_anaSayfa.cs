using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IngilizceKelimeOgreniyorum
{
    public partial class frm_anaSayfa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_anaSayfa()
        {
            InitializeComponent();
        }

        private void aceKelimeEkle_Click(object sender, EventArgs e)
        {
            

                if (!FormContainer.Controls.Contains(ucKelimeEkle.Instance))
            {
                FormContainer.Controls.Add(ucKelimeEkle.Instance);
                ucKelimeEkle.Instance.Dock = DockStyle.Fill;
                ucKelimeEkle.Instance.BringToFront();
            }
            ucKelimeEkle.Instance.BringToFront();

        }

        private void aceKelimeSec_Click(object sender, EventArgs e)
        {
            if (!FormContainer.Controls.Contains(ucKelimeSec.Instance))
            {
                FormContainer.Controls.Add(ucKelimeSec.Instance);
                ucKelimeSec.Instance.Dock = DockStyle.Fill;
                ucKelimeSec.Instance.BringToFront();
            }
            ucKelimeSec.Instance.BringToFront();
        }

        private void AceKelimeOgren_Click(object sender, EventArgs e)
        {
            if (!FormContainer.Controls.Contains(ucKelimeOgren.Instance))
            {
                FormContainer.Controls.Add(ucKelimeOgren.Instance);
                ucKelimeOgren.Instance.Dock = DockStyle.Fill;
                ucKelimeOgren.Instance.BringToFront();
            }
            ucKelimeOgren.Instance.BringToFront();
        }

        private void aceTesteBasla_Click(object sender, EventArgs e)
        {
            

                 if (!FormContainer.Controls.Contains(ucTesteBasla.Instance))
            {
                FormContainer.Controls.Add(ucTesteBasla.Instance);
                ucTesteBasla.Instance.Dock = DockStyle.Fill;
                ucTesteBasla.Instance.BringToFront();
            }
            ucTesteBasla.Instance.BringToFront();
        }
    }
}
