using _05_OOP;

internal class Program
{
    private static readonly string[] communicates = { "------------------------------------", "[1] Wyświetl Wszystkie", "[2] Wypożycz", "[3] Zwróć", "[4] Znajdź przez autora", "[5] Najstarsza Książka", "[6] Koniec", "" };
    private static readonly Book[] books = { new("Pan Tadeusz", "Adam Mickiewicz", 1834), new("Lalka", "Bolesław Prus", 1890) , new("Zemsta", "Aleksander Fredro", 1838) , new("Rok 1984", "George Orwell", 1949) , new("Folwark Zwierzęcy", "George Orwell", 1943) , new("Potop", "Henryk Sienkiewicz", 1886) };

    /*
     nazwa metody: Main
     opis metody: Główna metoda programu
     parametry: string[] args - tablica argumentów przekazanych do programu
     zwracany typ i opis: brak
     autor: Visual Studio 2026
     */
    private static void Main(string[] args)
    {
        bool isEnd = false;

        Library library = new Library();

        foreach (Book book in books)
            library.Add(book);


        while (!isEnd)
        {
            foreach (var communicate in communicates)
                Console.WriteLine(communicate);

            AskUserAction("Wybierz funkcję: ", (int option) =>
            {
                switch (option)
                {
                    case 1:
                        library.Books.ForEach((Book book) => Console.WriteLine(book.Description()));
                        break;
                    case 2:
                        AskUserAction("Podaj numer ksiązki: ", (int bookId) => library.Borrow(bookId));
                        break;
                    case 3:
                        AskUserAction("Podaj numer ksiązki: ", (int bookId) => library.Return(bookId));
                        break;
                    case 4:
                        AskUserAction("Szukaj Autora: ", (string author) => { 
                            library.FindByAuthor(author).ForEach((Book book) => Console.WriteLine(book.Description())); });
                        break;
                    case 5:
                        Console.Write("Najstarsza ksiązka: ");
                        Console.Write(library.FindOldest().Description() + "\n");
                        break;
                    case 6:
                    default:
                        isEnd = true;
                        break;
                }
            });
        }
    }

    /*      
     nazwa metody: AskUserAction
     opis metody: Metoda pomocnicza do pobierania danych od użytkownika i wykonywania akcji
     parametry: string message - komunikat do wyświetlenia, Action<T> action - akcja do wykonania
     zwracany typ i opis: brak
     autor: 00000000000
     */
    private static void AskUserAction<T>(string message, Action<T> action) {
        Console.Write(message);
        string value = Console.ReadLine();
        action((T)Convert.ChangeType(value,typeof(T)));
    }
}