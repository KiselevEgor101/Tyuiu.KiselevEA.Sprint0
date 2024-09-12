using Tyuiu.KiselevEA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KiselevEA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(50,2));
            Console.WriteLine("A + B = " + DataService.Substraction(54, 2));
            Console.WriteLine("A + B = " + DataService.Multiplication(26, 2));
            Console.WriteLine("A + B = " + DataService.Division(104, 2));
            Console.ReadKey();
        }
    }
}
