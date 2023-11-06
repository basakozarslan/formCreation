using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyeEklemeDemo
{
    public class UyeEkleme
    {
        public int OdaSicilNo { get; set; }
        public int Ilce { get; set; }
        public DateTime TescilTarihi { get; set; }
        public string Yetkili { get; set; }
        public int KlasorNo { get; set; }
        public string TescilTuru { get; set; }
        public DateTime KapanısTarihi { get; set; }
        public string KapanısSebebi { get; set; }
        public string AltSırketTipi { get; set; }
        public int FaaliyetSuresi { get; set; }
        public object firmaTuruId { get; internal set; }
        public object merkezSubePlaka { get; internal set; }
    }
}


