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
        Data data = new Data();
        DataTable datatable;
        int toplamKelime = 0,sayac = 0;

        //private static ucKelimeOgren _instance;
        //public static ucKelimeOgren Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ucKelimeOgren();
        //        }


        //        return _instance;
        //    }
        //}

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

        private void Btn_Geri_Click(object sender, EventArgs e)
        {
            if (sayac>0)
            {

                sayac--;
                lbl_turkce.Text = datatable.Rows[sayac][1].ToString();
                lbl_ingilizce.Text = datatable.Rows[sayac][2].ToString();
                lbl_tur.Text = datatable.Rows[sayac][3].ToString();
                lbl_Aciklama.Text = datatable.Rows[sayac][4].ToString();
            }
            if (sayac <= toplamKelime - 1)
            {
                btn_OgrenmeyiBitir.Enabled = false;
            }
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            if (sayac < toplamKelime-1)
            {

                sayac++;
                lbl_turkce.Text = datatable.Rows[sayac][1].ToString();
                lbl_ingilizce.Text = datatable.Rows[sayac][2].ToString();
                lbl_tur.Text = datatable.Rows[sayac][3].ToString();
                lbl_Aciklama.Text = datatable.Rows[sayac][4].ToString();
                //btn_ileri.Enabled = true;

            }
            //else
            //{
            //    btn_ileri.Enabled = false;
            //}
            if (sayac == toplamKelime-1)
            {
                btn_OgrenmeyiBitir.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucKelimeOgren_Load(object sender, EventArgs e)
        {
            btn_OgrenmeyiBitir.Enabled = false;
            try
            {
                datatable = data.OgrenmeDurumundakiKelimeleriListele();
                toplamKelime = datatable.Rows.Count;
                lbl_turkce.Text = datatable.Rows[sayac][1].ToString();
                lbl_ingilizce.Text = datatable.Rows[sayac][2].ToString();
                lbl_tur.Text = datatable.Rows[sayac][3].ToString();

                lbl_Aciklama.Text = datatable.Rows[sayac][4].ToString();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            

        }
    }
}
