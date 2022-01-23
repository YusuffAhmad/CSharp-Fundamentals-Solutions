using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentTest.GetStudentName();
           // StudentTest.student1.PrintStudentFullDetails();
            Book book = new Book("The Lost Dog", "Yusuff Ahmad", "Arroqeem Press", DateTime.Today, Library.GenerateISBNNumber());
            Console.WriteLine(book);

            Console.ReadKey();

        }
    }
}
