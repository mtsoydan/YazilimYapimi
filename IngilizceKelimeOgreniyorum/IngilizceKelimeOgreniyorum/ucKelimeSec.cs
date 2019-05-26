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
        MyDataClassesDataContext mydata = new MyDataClassesDataContext();
        Data data = new Data();
        List<Kelime> KelimeListesi = null;
        void Listele (int index)
        {
            ListviewKelimeler.Items.Clear();

            if (index == 0)
            {
                KelimeListesi = data.KelimeleriGetir("baslangic");

            }
            else
            {
                KelimeListesi = data.KelimeleriAra(txt_ara.Text);
            }
            foreach (Kelime item in KelimeListesi)
            {
                ListViewItem eleman = ListviewKelimeler.Items.Add(item.KelimeID.ToString());
                eleman.SubItems.Add(item.KelimeTr);
                eleman.SubItems.Add(item.KelimeIng);
                eleman.SubItems.Add(item.KelimeOrnek);
                eleman.SubItems.Add(item.KelimeTuru);
            }
            KelimeListesi.Clear();

        }
        //private static ucKelimeSec _instance;
        //public static ucKelimeSec Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ucKelimeSec();
        //        }


        //        return _instance;
        //    }
        //}

        public ucKelimeSec()
        {
            InitializeComponent();
        }

        

        private void btn_Ogren_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListviewKelimeler.CheckedItems.Count; i++)
            {
                mydata.spKelimeDurumGüncelleOgren(int.Parse(ListviewKelimeler.CheckedItems[i].Text), "ogren", "0",DateTime.Now);
                mydata.SubmitChanges();
            }
            Listele(0);
        }

        private void ucKelimeSec_Load(object sender, EventArgs e)
        {
            Listele(0);
        }

        private void ucKelimeSec_ControlAdded(object sender, ControlEventArgs e)
        {
            Listele(0);

        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            Listele(1);
        }

        private void txt_ara_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_kaldir_Click(object sender, EventArgs e)
        {
            try
            {
                int[] dizi = new int[ListviewKelimeler.CheckedItems.Count];
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = int.Parse(ListviewKelimeler.CheckedItems[i].Text);
                    //MessageBox.Show(listView1.CheckedItems[i].Text);
                    data.KelimeSil(dizi[i]);
                }
                MessageBox.Show("Kayıtlar Silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Listele(0);
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}
