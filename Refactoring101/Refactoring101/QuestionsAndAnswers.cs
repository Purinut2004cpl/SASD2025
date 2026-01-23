using System;
using System.Collections.Generic;

namespace Refactoring101
{
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        public double GetMax(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }

        // 2. Duplicate Code
        public void Print()
        {
            PrintPerson("Mr.", "Harry Potter");
            PrintPerson("Ms.", "Mary Poppin");
            PrintPerson("Mr.", "Johny Black");
        }

        private void PrintPerson(string title, string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {title} {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        // 3. Shotgun Surgery
        public class StudentRepository
        {
            public const int StudentCount = 48;
        }

        public class StudentDisplay
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + StudentRepository.StudentCount);
            }

            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + StudentRepository.StudentCount);
            }
        }

        // 4 + 5. Data Clump + Feature Envy
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
    }

    // Date class (ข้อ 4 และ 5)
    public class Date
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string Format()
        {
            return $"{Day:00}/{Month:00}/{Year:0000}";
        }
    }
}
