namespace _03_konsolowe;

class Program
{
    private static TextHandler textHandler = new();
    private static string[] OPTIONS =
    {
        "1) Is Palindrome?",
        "2) Is Anagram?",
        "3) Text Statistics",
        "0) End",
    };

    /*
        nazwa funkcji: GetUserInput
        opis funkcji: Pobiera wejście użytkownika
        parametry: string message - komunikat widziany przez użytkownika
        zwracany typ i opis: T - Typ genereczny. Umożliwia on wykorzystanie funkcji w wielu miejscach w kodzie, z różnymi typami danych - nie jest to konkretny typ, gdyż programista dopiero go ustawia w kodzie, bez przebudowy całej metody
        autor: 00000000000
    */
    private static T GetUserInput<T>(string message)
    {
        Console.Write(message);
        T userInput = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

        return userInput;
    }

    /*
        nazwa funkcji: Main
        opis funkcji: Główny punkt wejścia programu
        parametry: string[] args - parametry programu
        zwracany typ i opis: brak
        autor: 00000000000
    */
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n----------- MENU -----------");
            foreach (string option in OPTIONS)
                Console.WriteLine(option);

            try
            {
                int userOption = GetUserInput<int>("Selection: ");
                Console.WriteLine("----------------------------");

                string userInput = "";

                if (userOption == 1)
                {
                    userInput = GetUserInput<string>("Text: ");

                    Console.WriteLine($"-> Palindrome: {textHandler.IsPalindrome(userInput)}");
                }
                else if (userOption == 2)
                {
                    string textA = GetUserInput<string>("Text A: ");
                    string textB = GetUserInput<string>("Text B: ");

                    Console.WriteLine($"A: {textA}      B: {textB}");
                    Console.WriteLine(
                        $"-> Anagram: {(textHandler.IsAnagram(textA, textB) ? "TAK" : "NIE")}"
                    );
                }
                else if (userOption == 3)
                {
                    userInput = GetUserInput<string>("Text: ");

                    Console.WriteLine(
                        $"-> Words: {textHandler.WordCount(userInput)}, longest: {textHandler.LongestWord(userInput)}"
                    );
                    Console.WriteLine($"-> {textHandler.LettersFreq(userInput)}");
                }
                else if (userOption == 0)
                    break;
                else
                    throw new Exception("\nInvalid Option");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
