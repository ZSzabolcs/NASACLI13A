using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI13A
{
    public class Kuldetes
    {
        public string Nev { get; private set; }
        public int Ev { get; private set; }
        public string Celpont { get; private set; }
        public int Legenyseg { get; private set; }
        public bool Sikeres { get; private set; }
        public string Leiras { get; private set; }
        public double Koltseg { get; private set; }

        public double HasznosTeher { get; private set; }

        public Kuldetes(string sor)
        {
            string[] temp = sor.Split(';');
            Nev = temp[0];
            Ev = int.Parse(temp[1]);
            Celpont = temp[2];
            Legenyseg = int.Parse(temp[3]);
            Sikeres = (temp[4] == "Igen" ? true : false);
            Leiras = temp[5];
            Koltseg = double.Parse(temp[6]);
            HasznosTeher = double.Parse(temp[7]);
        }

        public string KockazatiSzint()
        {
            if (Koltseg > 1 && HasznosTeher > 10000)
            {
                return "Magas";
            }
            else if (Koltseg > 1 || HasznosTeher > 10000) { return "Közepes"; }
            else
            {
                return "Alacsony";
            }
        }
    }
}
