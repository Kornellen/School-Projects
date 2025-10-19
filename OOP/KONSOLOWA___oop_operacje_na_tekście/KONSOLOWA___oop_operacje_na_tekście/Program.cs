namespace KONSOLOWA___oop_operacje_na_tekście
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczanie Ilości samogłosek i usuwanie duplikatów z tekstu");
            Console.Write("Podaj Ciąg znaków: ");
            var userInput = Console.ReadLine();

            Console.WriteLine($"Liczba samogłosek w \"{userInput}\": {OperacjeNaTekscie.LiczSamogloski(userInput)}");

            Console.WriteLine($"Tekst \"{userInput}\" po usunięciu powtórzeń: {OperacjeNaTekscie.UsunPowtorzenia(userInput)}");
        }
    }

    class OperacjeNaTekscie
    {
        public static int LiczSamogloski(string? text)
        {
            string samogloski = "aąeęiouóyAĄEĘIOUÓY";
            int counter = 0;

            if (text is null || text.Length == 0)
                return 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (samogloski.Contains(text[i])) counter++;
            }

            return counter;
        }

        public static string UsunPowtorzenia(string? text)
        {
            string output = "";

            if (text is null || text == "") return "";

            output += text[0].ToString();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1]) output += text[i];
            }

            return output;
        }
    }
}
