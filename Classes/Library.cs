using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Library
    {
        public List<Book> libraries = new List<Book>(); 

        public void AddBook()
        {
            string Tittle = "The Lost Dog";
            string Author = "Yusuff Ahmad";
            string Publisher = "Arroqeem Press";
            DateTime ReleaseDate = DateTime.Today;
            string ISBNNumber = GenerateISBNNumber();
            Book book = new Book(Tittle, Author, Publisher, ReleaseDate, ISBNNumber);

            libraries.Add(book);
        }
        public  Book searchBook(string Author)
        {
            Book result = GetBook(Author);
            return result;
        }
        public  Book GetBook(string identity)
        {
            foreach (var book in libraries)
            {
                if (Book.Author.Equals(identity))
                {
                    return book;
                }
            }
            return null;
        }
        public string BookInfo()
        {
            return $"Book Tittle: The Lost Dog Author: Yusuff Ahmad Publisher: Arroqeem Press ReleaseDate: {DateTime.Today} ISBNNumber: {GenerateISBNNumber()}";
        }
        public void DeleteBooks()
        {
            libraries.Clear();
        }
        public static string GenerateISBNNumber()
        {
            Random random = new Random();
            string ISBNNumber = random.Next(1, 56).ToString();
            return ISBNNumber;
        }
    }
}
