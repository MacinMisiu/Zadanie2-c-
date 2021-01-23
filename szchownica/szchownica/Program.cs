using System;

namespace szchownica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar: ");
            string line = Console.ReadLine();
            int size = int.Parse(line);

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if ((y % 2 == 0) ^ (x % 2 == 0))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
