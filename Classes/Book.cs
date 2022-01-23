using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Book
    {
        public string Tittle;
        public static string Author;
        public string Publisher;
        public DateTime ReleaseDate;
        public string ISBNNumber;

        public Book(string tittle, string author, string publisher, DateTime releaseDate, string iSBNNumber)
        {
            Tittle = tittle;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBNNumber = iSBNNumber;
        }
    }
}
