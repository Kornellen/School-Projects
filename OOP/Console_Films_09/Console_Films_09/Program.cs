using Console_Films_09;

namespace Class_Films_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();

            film.Tytul = "Testowy Tytuł";

            Console.WriteLine(film.Tytul);

            Console.WriteLine(film.LiczbaWypozyczen);

            film.inkrementuj();

            Console.WriteLine(film.LiczbaWypozyczen);
        }
    }
}

