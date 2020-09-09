using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EXercise04
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    class Prog
    {
        static void Main (string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is { circumference }");
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of hemisphere.");
            double volume = (.75 * Math.PI * (intradius * intradius * intradius)) / 2;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's Formula).");
            int sidea = 20;
            area = Math.Sqrt(intradius * (intradius - sidea) * (intradius - 78) * (intradius - 8));
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            double postive_num = -69 + Math.Sqrt(69 * 69) - 4 * (40 * 20);
            double negative_num = -69 - Math.Sqrt(69 * 69) - 4 * (40 * 20);
            double denominator = 2 / 40;
            Console.WriteLine($"The positive solution is {postive_num / denominator}.");
            Console.WriteLine($" The negative solution is {negative_num / denominator}.");

        }
    }
}
