using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is { circumference }");
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area is {area}");
            checked 
            {
                circumference = 2 * Math.PI * intradius;
                area = Math.PI * intradius * intradius;
            }


                try
                {
                    int intraradius = int.Parse(strradius);
                    if (intraradius <= 0)
                    {
                        throw new NumberLessthanZero($"\n Number must be greater than zero");
                    }
                    
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine($"\n {fEx.Message}");
                    
                }
                catch (NumberLessthanZero NLZ)
                {
                    Console.WriteLine($"\n {NLZ.Message}");
                }

                finally
                {
                    Console.WriteLine($"\n Try Again");
                    Console.WriteLine("\nPart 1, circumference and area of a circle.");
                    Console.Write("Enter an integer for the radius: ");
                    Console.ReadLine();
                }
            

                
                
            

            //Console.WriteLine("\nPart 2, volume of hemisphere.");
            //double volume = (.75 * Math.PI * (intradius * intradius * intradius)) / 2;
            //Console.WriteLine($"The volume is {volume}");

            //Console.WriteLine("\nPart 3, area of a triangle (Heron's Formula).");
            //int sidea = 20;
            //area = Math.Sqrt(intradius * (intradius - sidea) * (intradius - 78) * (intradius - 8));
            //Console.WriteLine($"The area is {area}");

            //Console.WriteLine("\nPart 4, solving a quadratic equation.");
            //double postive_num = -69 + Math.Sqrt(69 * 69) - 4 * (40 * 20);
            //double negative_num = -69 - Math.Sqrt(69 * 69) - 4 * (40 * 20);
            //double denominator = 2 / 40;
            //Console.WriteLine($"The positive solution is {postive_num / denominator}.");
            //Console.WriteLine($" The negative solution is {negative_num / denominator}.");
        }
        
        
        
        
        

    }

}

    [Serializable]
    internal class NumberLessthanZero : Exception
    {
        public NumberLessthanZero()
        {

        }

        public NumberLessthanZero(string message) : base(message)
        {
        }

        public NumberLessthanZero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumberLessthanZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }