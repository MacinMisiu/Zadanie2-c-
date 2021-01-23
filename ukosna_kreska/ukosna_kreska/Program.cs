using System;

namespace ukosna_kreska
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar: ");
            string line = Console.ReadLine();
            int size = int.Parse(line);

            for (int i = 1; i <= size; i++) 
            {
                Console.Write("#");
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                
            }
        }
    }
}
