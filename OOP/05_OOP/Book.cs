using System;
using System.Collections.Generic;
using System.Text;

namespace _05_OOP
{
    internal class Book
    {
        public string title;
        public string author;
        public int year;
        public int id;
        public bool isAvailable = true;

        private static int lastId = 0;


        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
         
            lastId += 1;
            this.id = lastId;
        }

        /*
         nazwa metody: Description
         opis metody: Zwraca opis książki w formacie "[id] title - author (year) - Dostępna/Wypożyczona"
         parametry: brak
         zwracany typ i opis: string - opis książki
         autor: 00000000000
         */
        public string Description() {
            return $"[{id}] {title} - {author} ({year}) - {(isAvailable ? "Dostępna" : "Wypożyczona")}";
        }
    }
}
