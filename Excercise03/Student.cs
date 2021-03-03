using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise03
{
    enum FacultyEnum
    {
        FES, FEI, FF, FCHT
    }
    class Student
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private int number;
        public int Number
        {
            get => number;
            set => number = value;
        }

        private FacultyEnum faculty;
        public FacultyEnum Faculty
        {
            get => faculty;
            set => faculty = value;
        }


        public Student(string name, int number, FacultyEnum faculty)
        {
            Faculty = faculty;
            Name = name;
            Number = number;
        }
    }
}
