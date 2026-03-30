

namespace NASACLI13A
{
    public class Program
    {

        public static List<Kuldetes> kuldetesek = new List<Kuldetes>();

        static void Main(string[] args)
        {

            Beolvas("NASAmissions.txt");
            Feladat3();
            Feladat4();
            MagasKockzatuak();
            LegkisebbH();

        }

        private static void LegkisebbH()
        {
            Kuldetes legkisebb = kuldetesek.MinBy(x => x.HasznosTeher);
            Console.WriteLine($"6. feladat: A legkisebb hasznos teher: {legkisebb.HasznosTeher} kg ({legkisebb.Nev})");
        }

        private static void MagasKockzatuak()
        {
            Console.WriteLine("5. Feladat: Küldetések kockázati szintjei: ");
            foreach (var item in kuldetesek)
            {
                if (item.KockazatiSzint() == "Magas")
                {
                    Console.WriteLine(item.Nev + ": " + item.KockazatiSzint());
                }
            }
        }
        
        private static void Feladat4()
        {
            string nev;
            Kuldetes keresett = null;

            do
            {
                Console.Write("4. feladat: Adja meg egy küldetés nevének egy részletét: ");
                nev = Console.ReadLine();
                
               // keresett = kuldetesek.LastOrDefault(k => k.Nev.ToUpper().Contains(nev.ToUpper()));

                //hagyományos
                foreach (var item in kuldetesek)
                {
                    if (item.Nev.ToUpper().Contains(nev.ToUpper()))
                    {
                        keresett=item;
                    }
                }

            }
            while (keresett==null);

            Console.WriteLine($"Talált küldetés: {keresett.Nev} {keresett.Ev} {keresett.Celpont} {(keresett.Sikeres==true?"sikeres":"sikertelen")}");
        }

        public static void Beolvas(string file)
        {

            StreamReader sr = new StreamReader(file);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {

                kuldetesek.Add(new Kuldetes(sr.ReadLine()));

            }

            sr.Close();

        }

        static void Feladat3()
        {
            Console.WriteLine($"3. Feladat: {kuldetesek.Count} küldetés található az állományban.");
        }
    }
}
