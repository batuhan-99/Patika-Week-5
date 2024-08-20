using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Kapanis
{
    public class Araba
    {
        public DateTime UretimTarihi { get;  }
        public string serinumarasi {  get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }
        public int kapisayisi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }

    }
}
