using System;

namespace z_gory_na_dol
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
                    Console.Write("#");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
