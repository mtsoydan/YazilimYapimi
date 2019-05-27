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
        //private static ucKelimeEkle _instance;

        //public static ucKelimeEkle Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ucKelimeEkle();
        //        }


        //        return _instance;
        //    }
        //}

        MyDataClassesDataContext mydt = new MyDataClassesDataContext();
        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void ucKelimeEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            try
            {
               
                mydt.spKelimeEkle(txt_turkce.Text, txt_ingilizce.Text, cmbKelimeTur.SelectedItem.ToString(), txt_aciklama.Text, "Baslangic", -1, DateTime.Now);

                    mydt.SubmitChanges();
                MessageBox.Show("Kayıt Başarıyla Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbKelimeTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
