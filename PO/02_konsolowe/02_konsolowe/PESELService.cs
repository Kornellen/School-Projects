namespace _02_konsolowe;

public class PESELService
{
    /*
        nazwa funkcji: ValidatePESEL
        opis funkcji: Wykonuje Metodę Validate Obiektu PESELValidator
        parametry: string PESEL - numer PESEL
        zwracany typ i opis: bool - true jeśli prawidłowy / false jeśli nie
        autor: 00000000000
     */
    public bool ValidatePESEL(string PESEL)
    {
        return PESELValidator.Validate(PESEL);
    }

    /*
        nazwa funkcji: GetDoB
        opis funkcji: "Wyciąga" Datę Urodzenia z PESELu
        parametry: string PESEL - numer PESEL
        zwracany typ i opis: string - sformatowna data urodzenia
        autor: 00000000000
     */
    public string GetDoB(string PESEL)
    {
        string year = PESEL.Substring(0, 2);
        string month = PESEL.Substring(2, 2);
        string day = PESEL.Substring(4, 2);

        if (month.StartsWith('8') || month.StartsWith('9'))
        {
            year = "18" + year;
            month = Convert.ToString(Convert.ToInt32(month) - 80);
        }
        else if (month.StartsWith('2') || month.StartsWith('3'))
        {
            year = "20" + year;
            month = Convert.ToString(Convert.ToInt32(month) - 20);
        }
        else if (month.StartsWith('4') || month.StartsWith('5'))
        {
            year = "21" + year;
            month = Convert.ToString(Convert.ToInt32(month) - 40);
        }
        else if (month.StartsWith('6') || month.StartsWith('7'))
        {
            year = "22" + year;
            month = Convert.ToString(Convert.ToInt32(month) - 60);
        }
        else
            year = "19" + year;

        if (month.Length == 1)
            month = "0" + month;

        return $"{day}.{month}.{year}";
    }

    /*
        nazwa funkcji: GetSex
        opis funkcji: "Wyciąga" Dane o Płci z PESELu
        parametry: string PESEL - numer PESEL
        zwracany typ i opis: string - Kobieta / Mężczyzna
        autor: 00000000000
     */
    public string GetSex(string PESEL)
    {
        if ((PESEL[9] - '0') % 2 == 0)
            return "Kobieta";

        return "Mężczyzna";
    }
}
