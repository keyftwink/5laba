using readers;
using students;

namespace laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            Reader[] readers = new Reader[3];

            students[0] = new Student("Иванов И. И.", 142141, 17);
            students[1] = new Student("Козлов М. А.", 153255, 18);
            students[2] = new Student("Барков H. Д.", 123211, 19);

            readers[0] = new Reader("Кузнецов П. И.", 120, "Экономический", new DateTime(2005, 9, 24), "7(960)432-43-24");
            readers[1] = new Reader("Стрельцов Р. Ф.", 145, "Журналистика", new DateTime(2005, 3, 12), "7(960)766-74-12");
            readers[2] = new Reader("Милов А. Д.", 120, "Исторический", new DateTime(2005, 6, 4), "7(960)532-56-75");

            foreach (var student in students)
            {
                student.printData();
            }

            foreach (var reader in readers)
            {
                reader.printData();
            }

            readers[1].takeBook(3);
            readers[1].returnBook("\"Преступление и наказание\" - Достоевский Ф. М.", "\"Властелин колец\" - Дж. Р. Р. Толкин", "\"Мастер и Маргарита\" - Булгаков М. А.");
            readers[2].takeBook(2);
            readers[2].returnBook("\"1984\" - Джордж Оруэлл", "\"Идиот\" - Достоевский Ф. М.");
        }
    }
}

