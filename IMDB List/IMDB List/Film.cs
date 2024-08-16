using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IMDB_List
{
    public class Film
    {
        public string ismi { get; set; }
        public double puan {  get; set; }

        public Film(string Ismi, double Puan)
        {
            ismi = Ismi;
            puan = Puan;
        }

    }
}
