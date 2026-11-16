namespace _02_konsolowe;

internal class Program
{
    private static PESELService peselService = new();

    /*
        nazwa funkcji: Main
        opis funkcji: Punkt Wejścia Programu
        parametry: string[] args - Parametry Programu
        zwracany typ i opis: brak
        autor: 00000000000
     */
    static void Main(string[] args)
    {
        string userPESEL = "";

        while (userPESEL != "koniec")
        {
            Console.Write("PESEL: ");
            userPESEL = Console.ReadLine()!.ToLower();

            if (userPESEL == "koniec")
                return;

            Console.Write(
                (
                    peselService.ValidatePESEL(userPESEL)
                        ? $"PESEL Poprawny - Data Urodzenia: {peselService.GetDoB(userPESEL)}, płeć: {peselService.GetSex(userPESEL)}\n"
                        : ""
                )
            );
        }
    }
}
