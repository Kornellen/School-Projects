namespace _02_konsolowe;

internal class PESELValidator
{
    private static readonly int[] WAGES = { 1, 3, 7, 9 };

    /*
        nazwa funkcji: Validate
        opis funkcji: Dokonuje walidacji numeru PESEL
        parametry: string PESEL - numer PESEL
        zwracany typ i opis: bool - true jeśli prawidłowy / false jeśli nie
        autor: 00000000000
     */
    public static bool Validate(string PESEL)
    {
        bool areAllNumbers = false;

        if (PESEL.Length < 11)
        {
            Console.WriteLine("Niepoprawna długość nr PESEL");
            return false;
        }

        foreach (char c in PESEL)
        {
            if (char.IsNumber(c))
                areAllNumbers = true;
            else
            {
                areAllNumbers = false;
                break;
            }
        }

        if (!areAllNumbers)
        {
            Console.WriteLine("Numer PESEL zawiera niepoprawne znaki");
            return false;
        }

        if (!CompareCheckSum(PESEL))
        {
            Console.WriteLine("Niepoprawny nr PESEL");
            return false;
        }

        return true;
    }

    /*
        nazwa funkcji: CalculateCheckSum
        opis funkcji: Oblicza Sumę Kontrolną PESELu
        parametry: string PESEL - numer PESEL
        zwracany typ i opis: int - suma kontrolna
        autor: 00000000000
     */
    private static int CalculateChecksum(string PESEL)
    {
        int sum = 0;

        for (int i = 0; i < PESEL.Length - 1; i++)
            sum += (PESEL[i] - '0') * WAGES[i % WAGES.Length];

        int checksum = (10 - (sum % 10)) % 10;

        return checksum;
    }

    private static bool CompareCheckSum(string PESEL)
    {
        return CalculateChecksum(PESEL) == (PESEL[10] - '0');
    }
}
