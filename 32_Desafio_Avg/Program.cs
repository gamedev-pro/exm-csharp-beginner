using System;

namespace _4_Desafio_Avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = ReadNumberInput("Insira a primeira nota -> ");
            b = ReadNumberInput("Insira a segunda nota -> ");
            c = ReadNumberInput("Insira a terceira nota -> ");

            int sum = a + (2 * b) + (3 * c);
            float avg = (float)sum / 6;

            Console.WriteLine($"Media com peso (1, 2, 3): {avg}");
            Console.WriteLine($"Aluno passou: {avg >= 60}");

            Console.ReadKey();
        }

        static int ReadNumberInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            try
            {
                return int.Parse(input);
            }
            catch (System.Exception)
            {
                return -1;
            }
        }
    }
}
