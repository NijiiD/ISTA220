using System;

namespace Lab3C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many feet? ");
            string enteredfeet = Console.ReadLine();
            int feet = Int32.Parse(enteredfeet);
            int sum = feet * 12;
            Console.WriteLine("$\n {sum} inches");
        }

     
   

    }
}
