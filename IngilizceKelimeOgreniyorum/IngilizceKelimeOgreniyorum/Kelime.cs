using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceKelimeOgreniyorum
{
  public  class Kelime
    {
        public int KelimeID { get; set; }
        public string KelimeTr { get; set; }
        public string KelimeIng { get; set; }
        public string KelimeTuru { get; set; }
        public string KelimeOrnek { get; set; }
        public string KelimeOgrenmeDurumu { get; set; }
        public int KelimeOgrenmeSeviyesi { get; set; }
        public DateTime KelimeOgrenmeTarihi { get; set; }

    }
}
