using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace CExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 0, 2, 4, 6, 8, 10 };
            int[] second = { 1, 3, 5, 7, 9 };
            int[] third = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            totalElements(first);
            totalElements(second);
            totalElements(third);

            Program.reverseElements(first);
            Program.reverseElements(second);
            Program.reverseElements(third);

            Program.RotateArray(first, 2, false);
            Program.RotateArray(second, 2, true);
            Program.RotateArray(third, 4, false);

            Program.Sort(third);





        }

        private static void totalElements(int[] first1)
        {
            int len1 = first1.Length;
            Console.WriteLine($" The length of the arrays is {len1}");
            double sum = 0;

            for (int i = 0; i < first1.Length; i++)
            {
                sum = first1[i] + sum;

                Console.WriteLine($"{first1[i]}, {sum}");
            }

        }
        public static int[] reverseElements(int[] first1)
        {

            int[] first2 = new int[first1.Length];
            Console.WriteLine($"\nThe reverse is : ");


            for (int i = first1.Length - 1; i > 0; i--)
            {
                first2[i] = first1[i];

                Console.Write(first2[i]);

            }
            return first2;


        }



        public static int[] RotateArray(int[] first1, int index, bool totheRight)
        {
            int j = 0;



            if (index > first1.Length)
                throw new IndexOutOfRangeException();






            while (index > 0)
            {



                if (totheRight)
                {
                    int temp = first1[first1.Length - 1];
                    for (j = first1.Length - 1; j > 0; j--)
                    {
                        first1[j] = first1[j - 1];
                    }
                    first1[j] = temp;
                    index--;
                }
                else
                {



                    if (index > first1.Length)
                        throw new IndexOutOfRangeException();
                    int temp = first1[0];
                    for (j = 0; j < first1.Length - 1; j++)
                    {
                        first1[j] = first1[j + 1];
                    }
                    first1[j] = temp;
                    index--;
                }



            }
            Console.WriteLine("\nNew Rotated Array: [{0}]\n", string.Join(", ", first1));

            return first1;

        }

        public static int[] Sort(int[] first1)
        {
            int temp = 0;
            int count = 0;
            for (int i = 0; i <= first1.Length - 1; i++)
            {
                for (int j = i + 1; j < first1.Length; j++)
                {
                    if (first1[i] > first1[j])
                    {
                        temp = first1[i];
                        first1[i] = first1[j];
                        first1[j] = temp;
                        count++;
                    }
                    if (count == first1.Length)
                    {
                        Console.WriteLine("\nNew Sorted Array: [{0}]\n", string.Join(", ", first1));
                    }
                }
            }
            return first1;

        }
    }
}