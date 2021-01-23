using System;

namespace od_lewo_do_prawo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Podaj rozmiar: ");
            string line = Console.ReadLine();
            int size = int.Parse(line);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
