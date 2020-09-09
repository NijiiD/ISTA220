using System;
using System.Dynamic;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum of 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten intergers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermind number of scores.");
            Console.Write("How many scores do you wish to enter?: ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}.");

            Console.WriteLine("\nPart 4, average non predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine("$The average is {avg2} and the letter grade is {letterGrade}");



        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (sum > 0)
                return AvgAnyInts(sum, count);

            if (int.Parse(input) <= 0)
                return sum / count;

            else
                return sum;
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return sum / numScores;

        }

        private static char ConvertNumericToLetterGrade(double avg)
        {
            char lettergrade = 'X';
            if (avg >= 90)
            {
                lettergrade = 'A';
                return lettergrade;
            }
            else if (avg >= 80)
            {
                lettergrade = 'B';
                return lettergrade;
            }
            else if (avg >= 70)
            {
                lettergrade = 'C';
                return lettergrade;
            }
            else if (avg >= 60)
            {
                lettergrade = 'D';
                return lettergrade;
            }
            else if (avg <= 59)
            {
                lettergrade = 'F';
                return lettergrade;
            }
            else
                return lettergrade;
        }

        private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return sum / 10;

        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}
