using System;

namespace Classes
{
    public class StudentTest
    {
        public static Student student1 { get; set; }
        public static Student student2 { get; set; }
        public static Student student3 { get; set; }
        public static void GetStudentName()
        {
            Student student1 = new Student("Yusuff Ahmad", "Animal Science", "Algorithm", "Code Learners Hub", "Ahmad@gmail.com", "08079586319");
            Console.WriteLine($"The name of the student is {student1.GetFullName()}");
        }
        public static void Objects()
        {
            student1 = new Student();
            student2 = new Student();
            student3 = new Student();
        }
    }
}