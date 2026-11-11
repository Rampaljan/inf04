using System;

namespace kostka
{
    public class Kosc
    {
        public static int ilosc_instancji = 0;
        public string[] obrazki = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int liczba_oczek;
        public int identyfikator_pliku; 
        public bool dostepna;

        public Kosc(int oczka)
        {
            ilosc_instancji += 1;

            if (oczka > 6 || oczka < 1)
            {
                oczka = 0;
            }

            this.liczba_oczek = oczka;
            this.identyfikator_pliku = oczka;
            this.dostepna = true;
        }

        public Kosc()
        {
            ilosc_instancji += 1;
            Random losuj = new Random();
            int wylosowana = losuj.Next(1, 7);

            this.liczba_oczek = wylosowana;
            this.identyfikator_pliku = wylosowana;
            this.dostepna = true;
        }

        public void Rzuc()
        {
            if (dostepna)
            {
                Random losuj = new Random();
                int wylosowana = losuj.Next(1, 7);
                this.liczba_oczek = wylosowana;
                this.identyfikator_pliku = wylosowana;
            }
        }

        public void Zablokuj()
        {
            dostepna = false;
        }

        public string ZwrocSlownie()
        {
            switch (liczba_oczek)
            {
                case 1: return "jeden";
                case 2: return "dwa";
                case 3: return "trzy";
                case 4: return "cztery";
                case 5: return "pięć";
                case 6: return "sześć";
                default: return "zero";
            }
        }
    }
}
