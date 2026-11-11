using System.Security.Cryptography.X509Certificates;

namespace sortowanie
{
    public class Program
    {
        public static List<int> WpiszDane()
        {
            List<int> lista = new List<int>();

            var licznik = 1;
            while (licznik < 11)
            {
                Console.WriteLine($"Podaj liczbę {licznik}:");
                var tekst = Console.ReadLine();

                if (int.TryParse(tekst, out int liczba))
                {
                    lista.Add(liczba);
                    licznik++;
                }
                else
                {
                    Console.WriteLine("Niepoprawna liczba. Spróbuj ponownie.");
                }
            }
            return lista;
        }

        public static List<int> SortujMalejaco(List<int>lista)
        {
            for(var i = 0; i<lista.Count; i++)
            {
                var najmniejszy_index = i;
                for(var j = 0; j < lista.Count; j++)
                {
                    if (lista[j] > lista[najmniejszy_index])
                    {
                        var temp = lista[najmniejszy_index];
                        lista[najmniejszy_index] = lista[j];
                        lista[j] = temp; 
                    }
                }
            }
            return lista;
        }

        public static List<int> SortujRosnaco(List<int> lista)
        {
            for (var i = 0; i < lista.Count; i++)
            {
                var najmniejszy_index = i;
                for (var j = 0; j < lista.Count; j++)
                {
                    if (lista[j] < lista[najmniejszy_index])
                    {
                        var temp = lista[najmniejszy_index];
                        lista[najmniejszy_index] = lista[j];
                        lista[j] = temp;
                    }
                }
            }
            return lista;
        }

        public static void Main()
        {
            var lista = WpiszDane();
            Console.WriteLine("");
            Console.WriteLine($"Tablica nieposortowana: {String.Join(", ", lista)}");
            Console.WriteLine($"Tablica posortowana malejąco: {String.Join(", ", SortujMalejaco(lista))}");
            Console.WriteLine($"Tablica posortowana rosnąco: {String.Join(", ", SortujRosnaco(lista))}");
        }

        }
    }

