using System;

namespace Classes
{
   public class Student
   {
       private string FullName;
       private string Course;
       private string Subject;
       private string University;
       private string Email;
       private string PhoneNumber;
       private static int NumberOfStudents = 0;

       public string GetFullName()
       {
           return FullName;
       }
        public void SetFullName( string fullName)
       {
           FullName = fullName;
        }
       public string GetCourse()
       {
           return Course;
       }
        public void SetCourse(string course)
       {
           Course = course;
       }
        public string GetSubject()
       {
           return Subject;
       }
        public void SetSubject(string subject)
       {
           Subject = subject;
       }
        public string GetUniversitye()
       {
           return University;
       }
        public void SetUniversity( string university)
       {
           University= university;
       }
        public string GetEmail()
       {
           return Email;
       }
        public void SetEmail( string email)
       {
           Email = email;
       }
       
       public Student()
       {

       }
       public Student(string fullName, string course, string subject, string university, 
       string email, string phoneNumber)
       {
         FullName = fullName;
         Course = course;
         Subject = subject;
         University = university;
         Email = email;
         PhoneNumber = phoneNumber;
         NumberOfStudents++;
       }
        public Student(string fullName, string course,string university)
        {
         FullName = fullName;
         Course = course;
         University = university;
         NumberOfStudents++;
        }

        public string PrintStudentFullDetails()
        {
            return $"FullName: {FullName} Course:  {Course} Subject: {Subject} University: {University} Email:  {Email} PhoneNumber: {PhoneNumber}";
        }
   }
}