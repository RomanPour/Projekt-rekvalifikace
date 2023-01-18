using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazePojisteni
{
    class Pojistenec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public long Telefon { get; private set; }
        public int Vek { get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, int telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;   
        }

        public override string ToString()
        {
            return Jmeno.PadRight(15) + "\t" + Prijmeni.PadRight(15) + "\t" + Vek + "\t" + Telefon;
        }
    }
}
