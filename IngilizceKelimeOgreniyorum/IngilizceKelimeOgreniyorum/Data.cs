using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IngilizceKelimeOgreniyorum
{
  public  class Data
    {

   
        MyDataClassesDataContext mydt = new MyDataClassesDataContext();
        List<Kelime> KelimeListesi = new List<Kelime>();
        DataTable dttable = new DataTable();



        public int AyaGoreToplamKelime(int ay)
        {
            int toplam = 0;
            var sorgu = from Kelimeler in mydt.tbl_Kelimes where Kelimeler.KelimeOgrenmeTarihi.Value.Month == ay && Kelimeler.KelimeOgrenmeDurumu =="ogrendi" select Kelimeler;
            foreach (var item in sorgu)
            {
                toplam += 1;
            }
            return toplam;
        }
        public List<Kelime> KelimeleriGetir(string durum)
        {
            var sorgu = from Kelimeler in mydt.tbl_Kelimes where Kelimeler.KelimeOgrenmeDurumu ==durum select Kelimeler;
            foreach (var item in sorgu)
            {
                Kelime kelime = new Kelime();
                kelime.KelimeID = item.KelimeID;
                kelime.KelimeTr = item.KelimeTR;
                kelime.KelimeIng = item.KelimeIng;
                kelime.KelimeTuru = item.KelimeTuru;
                kelime.KelimeOrnek = item.KelimeOrnek;
                kelime.KelimeOgrenmeDurumu = item.KelimeOgrenmeDurumu;
                kelime.KelimeOgrenmeSeviyesi = item.KelimeOgrenmeSeviye.Value;
                kelime.KelimeOgrenmeTarihi = item.KelimeOgrenmeTarihi.Value;

                KelimeListesi.Add(kelime);
            }
            return KelimeListesi;
        }
        public List<Kelime> KelimeleriAra(string kelimeTr)
        {
            var sorgu = from Kelimeler in mydt.tbl_Kelimes where Kelimeler.KelimeOgrenmeDurumu == "baslangic" && SqlMethods.Like(Kelimeler.KelimeTR, "%" + kelimeTr + "%") select Kelimeler;
            foreach (var item in sorgu)
            {
                Kelime kelime = new Kelime();
                kelime.KelimeID = item.KelimeID;
                kelime.KelimeTr = item.KelimeTR;
                kelime.KelimeIng = item.KelimeIng;
                kelime.KelimeTuru = item.KelimeTuru;
                kelime.KelimeOrnek = item.KelimeOrnek;
                kelime.KelimeOgrenmeDurumu = item.KelimeOgrenmeDurumu;
                kelime.KelimeOgrenmeSeviyesi = item.KelimeOgrenmeSeviye.Value;
                kelime.KelimeOgrenmeTarihi = item.KelimeOgrenmeTarihi.Value;
                

                KelimeListesi.Add(kelime);
            }
            return KelimeListesi;
        }
       


        public DataTable DurumaGoreListele(string _durum)
        {

            var sorgu = from kelime in mydt.OgrenmeDurumuTestOlanlar(_durum) select kelime;
            dttable.Columns.Add(new DataColumn("KelimeID", typeof(int)));//0
            dttable.Columns.Add(new DataColumn("KelimeTr", typeof(string)));//1
            dttable.Columns.Add(new DataColumn("KelimeIng", typeof(string)));//2
            dttable.Columns.Add(new DataColumn("KelimeTuru", typeof(string)));//3
            dttable.Columns.Add(new DataColumn("KelimeOrnek", typeof(string)));//4
            dttable.Columns.Add(new DataColumn("KelimeOgrenmeDurumu", typeof(string)));//5
            dttable.Columns.Add(new DataColumn("KelimeSeviye", typeof(int)));//6

            dttable.Columns.Add(new DataColumn("KelimeOgrenmeTarihi", typeof(DateTime)));//7
            
            if (_durum == "ogren")
            {
                sorgu.ToList().ForEach((durum) =>
                {
                    DataRow newRow = dttable.NewRow();
                    newRow.SetField<int>("KelimeID", durum.KelimeID);
                    newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                    newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                    newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                    newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                    newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                    newRow.SetField<int>("KelimeSeviye", durum.KelimeOgrenmeSeviye.Value);

                    newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                


                    dttable.Rows.Add(newRow);
                });
            }
            else
            {




                sorgu.ToList().ForEach((durum) =>
                {
                    if (durum.KelimeOgrenmeSeviye == 0)
                    {
                        TimeSpan fark = DateTime.Now - Convert.ToDateTime(durum.KelimeOgrenmeTarihi);
                        if (fark.Days == 1)
                        {
                            DataRow newRow = dttable.NewRow();
                            newRow.SetField<int>("KelimeID", durum.KelimeID);
                            newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                            newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                            newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                            newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                            newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                            newRow.SetField<int>("KelimeSeviye", durum.KelimeOgrenmeSeviye.Value);

                            newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                            
                            dttable.Rows.Add(newRow);

                        }
                    }
                    else if (durum.KelimeOgrenmeSeviye == 1)
                    {
                        TimeSpan fark = DateTime.Now - Convert.ToDateTime(durum.KelimeOgrenmeTarihi);
                        if (fark.Days <= 7)
                        {
                            DataRow newRow = dttable.NewRow();
                            newRow.SetField<int>("KelimeID", durum.KelimeID);
                            newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                            newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                            newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                            newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                            newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                            newRow.SetField<int>("KelimeSeviye", durum.KelimeOgrenmeSeviye.Value);

                            newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                           
                            dttable.Rows.Add(newRow);

                        }
                    }
                    else if (durum.KelimeOgrenmeSeviye == 2)
                    {
                        TimeSpan fark = DateTime.Now - Convert.ToDateTime(durum.KelimeOgrenmeTarihi);
                        if (fark.Days <= 10)
                        {
                            DataRow newRow = dttable.NewRow();
                            newRow.SetField<int>("KelimeID", durum.KelimeID);
                            newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                            newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                            newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                            newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                            newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                            newRow.SetField<int>("KelimeSeviye", durum.KelimeOgrenmeSeviye.Value);

                            newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                          
                            dttable.Rows.Add(newRow);

                        }
                    }
                    else if (durum.KelimeOgrenmeSeviye == 3)
                    {
                        TimeSpan fark = DateTime.Now - Convert.ToDateTime(durum.KelimeOgrenmeTarihi);
                        if (fark.Days <= 15)
                        {
                            DataRow newRow = dttable.NewRow();
                            newRow.SetField<int>("KelimeID", durum.KelimeID);
                            newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                            newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                            newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                            newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                            newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                            newRow.SetField<int>("KelimeSeviye", durum.KelimeOgrenmeSeviye.Value);

                            newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                            dttable.Rows.Add(newRow);

                        }
                    }


                });
            }
            return dttable;
        }

        public void KelimeSil(int id)
        {
            mydt.spSoruSil(id);
            mydt.SubmitChanges();
        }
    }
}
