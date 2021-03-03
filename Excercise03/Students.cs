using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise03
{
    class Students
    {
        private Student[] studentsArray;
        public Student[] StudentsArray 
        { 
            get => studentsArray;
            set=> studentsArray = value;
        }

        public Students() { }

        public Students(Student[] students)
        {
            StudentsArray = students;
        }

        public delegate int CompareDelegateStudents(Student s1, Student s2);

        public void Sort(CompareDelegateStudents sortDelegate)
        {
            for (int i = 0; i < studentsArray.Length - 1; i++)
            {
                for (int j = 0; j < studentsArray.Length - i - 1; j++)
                {
                    if (sortDelegate(this.studentsArray[j], studentsArray[j + 1]) < 1)
                    {
                        Student temp = studentsArray[j];
                        studentsArray[j] = studentsArray[j + 1];
                        studentsArray[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintStudents()
        {
            for (int i = 0; i < StudentsArray.Length; i++)
            {
                Console.WriteLine($"{StudentsArray[i].Number}, {StudentsArray[i].Name}, {StudentsArray[i].Faculty}");
            }
        }
    }
}
