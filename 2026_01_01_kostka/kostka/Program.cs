using System;
using kostka;

class Program
{
    public static void Main(string[] args)
    {
        Kosc kosc1 = new Kosc();
        WyswietlInformacje(kosc1, "Kość 1 (losowa)");

        Console.Write("\nPodaj liczbę oczek dla drugiej kości (1-6): ");
        if (int.TryParse(Console.ReadLine(), out int podaneOczka))
        {
            Kosc kosc2 = new Kosc(podaneOczka);
            WyswietlInformacje(kosc2, "Kość 2 (z klawiatury)");
        }
        else
        {
            Kosc kosc2 = new Kosc(0);
            WyswietlInformacje(kosc2, "Kość 2 (niepoprawne dane wejściowe)");
        }
    }

    private static void WyswietlInformacje(Kosc kosc, string nazwaObiektu)
    {
        Console.WriteLine($"--- Informacje o: {nazwaObiektu} ---");
        Console.WriteLine($"Liczba utworzonych instancji klasy Kosc: {Kosc.ilosc_instancji}");
        Console.WriteLine($"Liczba oczek (liczbowo): {kosc.liczba_oczek}");
        Console.WriteLine($"Liczba oczek (napisowo): {kosc.ZwrocSlownie()}");
        Console.WriteLine($"Nazwa pliku graficznego: {kosc.obrazki[kosc.identyfikator_pliku]}");
    }
}
