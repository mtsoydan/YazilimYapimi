using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceKelimeOgreniyorum
{
  public  class Data
    {


        MyDataClassesDataContext mydt = new MyDataClassesDataContext();
        List<Kelime> myListview = new List<Kelime>();

        public List<Kelime> KelimeleriGetir()
        {
            var sorgu = from Kelimeler in mydt.tbl_Kelimes where Kelimeler.KelimeOgrenmeDurumu =="baslangic" select Kelimeler;
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
                    myListview.Add(kelime);
            }
            return myListview;
        }
        public List<Kelime> KelimeleriGetir(string kelimeTr)
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
                myListview.Add(kelime);
            }
            return myListview;
        }


        public DataTable OgrenmeDurumundakiKelimeleriListele()
        {
            DataTable dttable = new DataTable();
            var sorgu = from kelime in mydt.OgrenmeDurumuTestOlanlar("ogren") select kelime;
            dttable.Columns.Add(new DataColumn("KelimeID", typeof(int)));
            dttable.Columns.Add(new DataColumn("KelimeTr", typeof(string)));
            dttable.Columns.Add(new DataColumn("KelimeIng", typeof(string)));
            dttable.Columns.Add(new DataColumn("KelimeTuru", typeof(string)));
            dttable.Columns.Add(new DataColumn("KelimeOrnek", typeof(string)));
            dttable.Columns.Add(new DataColumn("KelimeOgrenmeDurumu", typeof(string)));
            dttable.Columns.Add(new DataColumn("KelimeOgrenmeTarihi", typeof(DateTime)));
            sorgu.ToList().ForEach((durum) =>
            {
                DataRow newRow = dttable.NewRow();
                newRow.SetField<int>("KelimeID", durum.KelimeID);
                newRow.SetField<string>("KelimeTr", durum.KelimeTR);
                newRow.SetField<string>("KelimeIng", durum.KelimeIng);
                newRow.SetField<string>("KelimeTuru", durum.KelimeTuru);
                newRow.SetField<string>("KelimeOrnek", durum.KelimeOrnek);
                newRow.SetField<string>("KelimeOgrenmeDurumu", durum.KelimeOgrenmeDurumu);
                newRow.SetField<DateTime>("KelimeOgrenmeTarihi", durum.KelimeOgrenmeTarihi.Value);
                dttable.Rows.Add(newRow);
            });
            return dttable;
        }

        public void KelimeSil(int id)
        {
            mydt.spSoruSil(id);
            mydt.SubmitChanges();
        }
    }
}
