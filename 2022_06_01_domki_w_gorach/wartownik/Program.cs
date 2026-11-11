namespace wartownik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wartownik = 0;
            int wielkosc = 0;

            var skonczono_wpisywac = false;
            while (!skonczono_wpisywac)
            {
                Console.WriteLine("Podaj wielkość tablicy: ");
                wielkosc = int.Parse(Console.ReadLine());

                if (wielkosc < 50)
                {
                    Console.WriteLine("Wielkosc musi być większa lub równa 50");
                }
                else
                {
                    skonczono_wpisywac = true;
                }
            }

            skonczono_wpisywac = false;
            while (!skonczono_wpisywac)
            {
                Console.WriteLine("Podaj szukany element w zakresie 1-100: ");
                wartownik = int.Parse(Console.ReadLine());

                if (wartownik < 0 || wartownik > 100)
                {
                    Console.WriteLine("Szukany element musi być w zakresie [0,100]");
                }
                else
                {
                    skonczono_wpisywac = true;
                }
            }


            Wartownik obiekt = new Wartownik(wielkosc, wartownik);

            Console.WriteLine(obiekt.Wyszukaj());
        }
    }
}
