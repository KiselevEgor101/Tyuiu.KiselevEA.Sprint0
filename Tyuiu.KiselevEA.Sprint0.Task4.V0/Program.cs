using Tyuiu.KiselevEA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KiselevEA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(50, 2));
            Console.WriteLine(DataService.Division(104, 2));
            Console.WriteLine(DataService.Multiplication(26, 2));
            Console.WriteLine(DataService.Substraction(54, 2));

            Console.ReadKey();
        }
    }
}
