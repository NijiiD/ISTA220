

namespace TextHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            System.Console.Write("Enter your name:");
            name = System.Console.ReadLine();
            System.Console.WriteLine($"Hello,{name}");
        }
    }
}
