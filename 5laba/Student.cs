using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    internal class Student
    {
        string name;
        int group;
        int age;

        public Student(string name, int group, int age)
        {
            this.name = name;
            this.group = group;
            this.age = age;
        }

        public void printData()
        {
            Console.WriteLine("Имя: " + name + ", группа: " + group + ", возраст: " + age);
        }
    }
}
