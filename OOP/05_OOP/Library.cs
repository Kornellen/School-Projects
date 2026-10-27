using System;
using System.Collections.Generic;
using System.Text;

namespace _05_OOP
{
    internal class Library
    {
        private List<Book> books = new();
        
        public List<Book> Books { get { return books; } }

        /*
         nazwa metody: Add
         opis metody: Dodaje książkę do biblioteki
         parametry: book - obiekt Book, który ma zostać dodany do biblioteki
         zwracany typ i opis: brak
         autor: 00000000000
         */
        public void Add(Book book)
        {
            books.Add(book);
        }

        /*
         nazwa metody: Borrow
         opis metody: Wypożycza książkę z biblioteki
         parametry: id - identyfikator książki do wypożyczenia
         zwracany typ i opis: bool - true, jeśli książka została wypożyczona, false w przeciwnym razie
         autor: 00000000000
         */
        public bool Borrow(int id) {
            Book? book = books.Find((Book book) => book.id == id);

            if (book == null || !book.isAvailable) { 
                Console.WriteLine("Książka nie istnieje lub jest już wypożyczona!");
                return false;
            }

            book.isAvailable = false;

            return true;
        }

        /*
         nazwa metody: Return
         opis metody: Zwraca książkę do biblioteki
         parametry: id - identyfikator książki do zwrócenia
         zwracany typ i opis: bool - true, jeśli książka została zwrócona, false w przeciwnym razie
         autor: 00000000000
         */
        public bool Return(int id)
        {
            Book? book = books.Find((Book book) => book.id == id);

            if (book == null || book.isAvailable) {
                Console.WriteLine("Książka nie istnieje lub jest już zwrócona!");
                return false; }

            book.isAvailable = true;

            return true;
        }

        /*
         nazwa metody: FindByAuthor
         opis metody: Zwraca listę książek napisanych przez danego autora
         parametry: author - nazwa autora, lub ciąg znaków znajdujący się w jego nazwie
         zwracany typ i opis: List<Book> - lista książek danego autora
         autor: 00000000000
         */
        public List<Book> FindByAuthor(string author) {
            return books.FindAll((Book book) => book.author.Contains(author));
        }

        /*
         nazwa metody: FindOldest
         opis metody: Zwraca najstarszą książkę z biblioteki
         parametry: brak
         zwracany typ i opis: Book - najstarsza książka z biblioteki
         autor: 00000000000
         */
        public Book FindOldest()
        {
            Book book = books[0];

            for (int i = 0; i < books.Count; i++)
                if (books[i].year < book.year)
                       book = books[i];

            return book;
        }
    }
}
