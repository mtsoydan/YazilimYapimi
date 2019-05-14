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


            ucKelimeEkle uck = new ucKelimeEkle();
            FormContainer.Controls.Add(uck);
            uck.Dock = DockStyle.Fill;
            uck.BringToFront();


        }

        private void aceKelimeSec_Click(object sender, EventArgs e)
        {
            
            ucKelimeSec uck = new ucKelimeSec();
            FormContainer.Controls.Add(uck);
            uck.Dock = DockStyle.Fill;
            uck.BringToFront();
        }

        private void AceKelimeOgren_Click(object sender, EventArgs e)
        {

            ucKelimeOgren uck = new ucKelimeOgren();
            FormContainer.Controls.Add(uck);
            uck.Dock = DockStyle.Fill;
            uck.BringToFront();
        }

        private void aceTesteBasla_Click(object sender, EventArgs e)
        {
            ucTesteBasla uck = new ucTesteBasla();
            FormContainer.Controls.Add(uck);
            uck.Dock = DockStyle.Fill;
            uck.BringToFront();


            //if (!FormContainer.Controls.Contains(ucTesteBasla.Instance))
            //{
            //    FormContainer.Controls.Add(ucTesteBasla.Instance);
            //    ucTesteBasla.Instance.Dock = DockStyle.Fill;
            //    ucTesteBasla.Instance.BringToFront();
            //}
            //ucTesteBasla.Instance.BringToFront();
        }

        private void frm_anaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
