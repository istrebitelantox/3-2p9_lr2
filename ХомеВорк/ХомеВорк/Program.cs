using System;

namespace ХомеВорк
{
    class Program
    {
        static void Main(string[] args)
        {
            Drob d1 = new Drob(2,3);
            Drob d2 = new Drob(2, 3, 4);
            Drob d3 = new Drob(-3);
            Console.WriteLine(d1.Des());
            Console.WriteLine((d1 * d3).Des());
            Console.WriteLine((d1 * d2).Znak);
            Console.ReadKey();
        }
    }
}
