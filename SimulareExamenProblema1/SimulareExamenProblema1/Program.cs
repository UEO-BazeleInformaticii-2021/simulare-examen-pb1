using System;

namespace SimulareExamenProblema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int fact = Recursivity.Fact(5);
            Console.WriteLine($"Fact({n})={fact}");
        }
    }
}
