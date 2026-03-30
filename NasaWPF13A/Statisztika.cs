using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaWPF13A
{
    public class Statisztika
    {
        public Statisztika(string kategoria, int darab, string atlagTeher, string atlagKoltseg)
        {
            Kategoria = kategoria;
            Darab = darab;
            AtlagTeher = atlagTeher;
            AtlagKoltseg = atlagKoltseg;
        }

        public string Kategoria { get; set; }
        public int Darab { get; set; }
        public string AtlagTeher { get; set; }
        public string AtlagKoltseg { get; set; }


    }
}
