Console.WriteLine("Hello, World!");

public abstract class Pytanie
{
    protected string Tresc_pytania;
    protected string Zdjecie_do_pytania;
    protected bool Czy_poprawna;

    public Pytanie (string tresc_pytania, string zdjecie_do_pytania)
    {
        Tresc_pytania = tresc_pytania;
        Zdjecie_do_pytania = zdjecie_do_pytania;
        Czy_poprawna = false;
    }

    public abstract bool sprawdz(char litera);
    

}

public class PytanieZamkniete : Pytanie
{
    private string A_odp;
    private string B_odp;
    private string C_odp;

    private char Poprawna_odpowiedz;

    PytanieZamkniete(string tresc_pytania, string zdjecie_do_pytania, string a_odp, string b_odp, string c_odp, char poprawna_odpowiedz) : base(tresc_pytania, zdjecie_do_pytania)
    {
        A_odp = a_odp;
        B_odp = b_odp;
        C_odp = c_odp;

        Poprawna_odpowiedz = poprawna_odpowiedz;
    }

    public override bool sprawdz(char litera)
    {
        if (litera == Poprawna_odpowiedz)
        {
            Czy_poprawna = true;
        }
        else
        {
            Czy_poprawna = false;
        }
        return Czy_poprawna;
    }
}
