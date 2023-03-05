using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readers
{
    internal class Reader
    {
        private string name;
        int libraryСardNumber;
        string faculty;
        private DateTime dateOfBirth;
        string phoneNumber;

        public Reader(string name, int libraryСardNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.name = name;
            this.libraryСardNumber = libraryСardNumber;
            this.faculty = faculty;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }

        public void printData()
        {
            Console.WriteLine("Имя: " + name + ", номер читательского билета: " + libraryСardNumber + ", факультет: " + faculty + ", дата рождения: " + dateOfBirth + ", номер телефона: " + phoneNumber);
        }

        public void takeBook(int numberOfBooks)
        {
            Console.WriteLine(name + " взял " + numberOfBooks + " книг");
        }

        public void takeBook(params string[] bookTitles)
        {
            Console.WriteLine(name + " взял книги: " + string.Join(", ", bookTitles));
        }

        public void returnBook(int numberOfBooks)
        {
            Console.WriteLine(name + " вернул " + numberOfBooks + " книг");
        }

        public void returnBook(params string[] bookTitles)
        {
            Console.WriteLine(name + " вернул книги: " + string.Join(", ", bookTitles));
        }
    }
}
