using System;
using System.Collections.Generic;
using System.Text;

namespace wartownik
{
    public class Wartownik
    {
        private int n;
        private int x;

        private List<int> lista = new List<int>();

        public Wartownik(int Wielkosc, int Wartownik)
        {
            n = Wielkosc;
            x = Wartownik;

            //generowanie tablicy
            for (int i = 0; i < n; i++) 
            {
                lista.Add(new Random().Next(0, 101));
            }

            //dodanie wartownika na końcu
            lista.Add(x);
        }

        public string Wyszukaj()
        {
            string komunikat = "";
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == x)
                {
                    if (i == lista.Count - 1)
                    {
                        //jesli to ostatni element tablicy
                        komunikat = "W liście nie znaleziono szukanego elementu";
                        break;
                    }
                    //jesli wartownika znaleziono wczesniej
                    komunikat = $"Szukana liczba x = {x} została odnaleziona jako {i+1}. element tablicy";
                    break;
                }
            }
            return komunikat;
        }
    }
}
