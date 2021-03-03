using System;
using BaseLib;

namespace Excercise03
{
    class Delegat
    {
        public static void Main()
        {
            Student[] arr = { 
                new Student("Peter", 4, FacultyEnum.FCHT),
                new Student("Tomas", 7, FacultyEnum.FEI),
                new Student("Michael", 2, FacultyEnum.FF),
                new Student("Mark", 1, FacultyEnum.FCHT),
                new Student("Bob", 10, FacultyEnum.FEI),
                new Student("Dan", 5, FacultyEnum.FES)
            };


            Students students = new Students(arr);
            Console.WriteLine("\nSort by name");
            students.Sort((s1, s2) => s2.Name.CompareTo(s1.Name));
            students.PrintStudents();
            Console.WriteLine("\nSort by number");
            students.Sort((s1, s2) => s2.Number.CompareTo(s1.Number));
            students.PrintStudents();
            Console.WriteLine("\nSort by faculty");
            students.Sort((s1, s2) => s2.Faculty.CompareTo(s1.Faculty));
            students.PrintStudents();

            Console.WriteLine($"\nRandom number from 17 to 31: {ExtraMath.GenerateRandomDouble(new Random(), 17, 31)}");
            if(ExtraMath.SolveQuadraticEquation(10, 5, -8, out double x1, out double x2))
            {
                Console.WriteLine($"\n10a + 5b + 3c => x1 = {x1}, x2 = {x2}");
            }

            Console.WriteLine($"\n27 to bin = {MathConvertor.DecimalToBinary(27)}");
            Console.WriteLine($"\n11011 to decimal = { MathConvertor.BinaryToDecimal("11011")}");

            Console.WriteLine($"7 to roman = {MathConvertor.IntegerToRoman(7)}, 49 to roman = {MathConvertor.IntegerToRoman(49)}" +
                $", 456 to roman = {MathConvertor.IntegerToRoman(456)}, 1988 to roman = { MathConvertor.IntegerToRoman(1988)}");

            Console.WriteLine($"LCD to arabic = {MathConvertor.RomanToInteger("LCD")}, MCMLXXVIII to arabic = {MathConvertor.RomanToInteger("MCMLXXVIII")}" +
                $", DCLXVII to arabic = {MathConvertor.RomanToInteger("DCLXVII")}, CMXXXIII to arabic = { MathConvertor.RomanToInteger("CMXXXIII")}");
        }
    }

   
}
