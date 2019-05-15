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
        Data data = new Data();
        MyDataClassesDataContext mydt = new MyDataClassesDataContext();
        DataTable datatable = null;
        int ToplamSoruSayisi = 0,sayac = 0;
        int[] rastgele = new int[4];
        int[] karmaSorular;

        Random rnd = new Random();
        public void Kontrol(string cevap)
        {
            DialogResult Cevap = new DialogResult();
            Cevap = MessageBox.Show("Son kararınızmı  ?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cevap == DialogResult.Yes)
            {
                var sorgu = from kelime in mydt.tbl_Kelimes where kelime.KelimeID == int.Parse(datatable.Rows[karmaSorular[sayac]][0].ToString()) select kelime;
                if (cevap == datatable.Rows[karmaSorular[sayac]][2].ToString())
                {
                    MessageBox.Show("Doğru Cevap");
                   
                    foreach (var item in sorgu)
                    {
                        
                        item.KelimeOgrenmeSeviye += 1;
                        item.KelimeOgrenmeTarihi = DateTime.Now;
                    }
                    mydt.SubmitChanges();
                    sayac++;

                }
                else
                {
                    MessageBox.Show("yanlış Cevap");

                    foreach (var item in sorgu)
                    {

                        item.KelimeOgrenmeSeviye -= 1;
                        item.KelimeOgrenmeDurumu = "ogren";
                    }
                    mydt.SubmitChanges();
                    sayac++;

                }
                if (sayac < ToplamSoruSayisi)
                {

                    int i = 0;

                    while (i < 3)
                    {
                        int sayi = rnd.Next(0, ToplamSoruSayisi);


                        if (rastgele.Contains(sayi))
                        {
                            continue;
                        }

                        rastgele[i] = sayi;
                        i++;


                    }
                    if (!rastgele.Contains(karmaSorular[sayac]))
                    {
                        rastgele[3] = karmaSorular[sayac];
                    }





                    //Array.Sort(rastgele);

                    lbl_tr.Text = datatable.Rows[karmaSorular[sayac]][1].ToString();
                    btn_Cevap1.Text = datatable.Rows[rastgele[0]][2].ToString();
                    btn_cevap2.Text = datatable.Rows[rastgele[1]][2].ToString();
                    btn_cevap3.Text = datatable.Rows[rastgele[2]][2].ToString();
                    btn_cevap4.Text = datatable.Rows[rastgele[3]][2].ToString();

                }
                else
                {
                    MessageBox.Show("Test Tamamlandı");
                    
                   
                }

            }
        }
        //private static ucTesteBasla _instance;
        //public static ucTesteBasla Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ucTesteBasla();
        //        }


        //        return _instance;
        //    }
        //}

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void ucTesteBasla_Load(object sender, EventArgs e)
        {
            try
            {
                
                datatable = data.DurumaGoreListele("test");
                ToplamSoruSayisi = datatable.Rows.Count;
                //  lbl_ing.Text = datatable.Rows[sayac][2].ToString();
                
                karmaSorular = new int[ToplamSoruSayisi];
                int i = 0;
                while (i < ToplamSoruSayisi-1)
                {
                    int deneme = rnd.Next(0, ToplamSoruSayisi);


                    if (karmaSorular.Contains(deneme))
                    {
                        continue;
                    }

                    karmaSorular[i] = deneme;
                    i++;


                }
                //lbl_tr.Text = datatable.Rows[sayac][1].ToString();
                //btn_Cevap1.Text = datatable.Rows[sayac][2].ToString();
                //btn_cevap2.Text = datatable.Rows[sayac + 1][2].ToString();
                //btn_cevap3.Text = datatable.Rows[sayac + 2][2].ToString();
                //btn_cevap4.Text = datatable.Rows[sayac + 3][2].ToString();
                i = 0;
                while (i < 3)
                {
                    int sayi = rnd.Next(0, ToplamSoruSayisi);


                    if (rastgele.Contains(sayi))
                    {
                        continue;
                    }

                    rastgele[i] = sayi;
                    i++;


                }
                if (!rastgele.Contains(karmaSorular[sayac]))
                {
                    rastgele[3] = karmaSorular[sayac];
                }
                lbl_tr.Text = datatable.Rows[karmaSorular[sayac]][1].ToString();
                btn_Cevap1.Text = datatable.Rows[rastgele[0]][2].ToString();
                btn_cevap2.Text = datatable.Rows[rastgele[1]][2].ToString();
                btn_cevap3.Text = datatable.Rows[rastgele[2]][2].ToString();
                btn_cevap4.Text = datatable.Rows[rastgele[3]][2].ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Cevap1_Click(object sender, EventArgs e)
        {
            Kontrol(btn_Cevap1.Text);
        }

        private void btn_cevap2_Click(object sender, EventArgs e)
        {
            Kontrol(btn_cevap2.Text);

        }

        private void btn_cevap3_Click(object sender, EventArgs e)
        {
            Kontrol(btn_cevap3.Text);

        }

        private void btn_cevap4_Click(object sender, EventArgs e)
        {
            Kontrol(btn_cevap4.Text);

        }
    }
}
