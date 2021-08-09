using System;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rumfanget


            // H = Højde

            Console.WriteLine("Højde: ");

            double h = double.Parse(Console.ReadLine());

            // H = Bredde

            Console.WriteLine("Bredde: ");

            double b = double.Parse(Console.ReadLine());

            // H = Længde

            Console.WriteLine("Længde: ");

            double l = double.Parse(Console.ReadLine());



            // Tager de tre tal og ganger dem.

            double v = h * b * l;



            Console.WriteLine("Rumfanget er: " + v);



            // Prevens the program from shutting down.
            Console.ReadKey();
        }
    }
}
