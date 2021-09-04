using System;

namespace _1._2_ErrosDeLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            nome = nome.Trim();
            Console.Write("Seu nome eh -> ");
            Console.WriteLine(nome);

            Console.ReadKey();
        }
    }
}
