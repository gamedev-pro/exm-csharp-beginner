using System;

namespace _1_Desafio_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducao
            PrintAndWait("Olá pessoal! Bem vindos ao mundo de Pokémon!");
            PrintAndWait("Sou Carvalho. Pode me chamar de POKÉMON PROF!");
            PrintAndWait("Esse mundo é habitado por seres chamados Pokémon");
            PrintAndWait("Pessoas usam Pokémons para cuidar ou em confrontos");
            PrintAndWait("Já eu...");
            PrintAndWait("Estudo Pokémons como profissão.");

            //Input do nome do Player
            PrintSeparator();

            Console.Write("Primeiro, qual é o seu nome? --> ");

            string nomeDoPlayer = Console.ReadLine();

            Console.Write("Tudo bem! Seu nome é: ");
            Console.WriteLine(nomeDoPlayer);
            Console.ReadKey();

            //Input do nome do Rival
            PrintSeparator();

            Console.WriteLine("Apresento o meu neto. Ele é seu rival desde que vocês nasceram");
            Console.ReadKey();

            Console.Write("... Eu esqueci o nome do rapaz! Você me pode me lembrar? --> ");

            string nomeDoRival = Console.ReadLine();
            Console.Write("Claro! Eu me lembro agora! O nome dele é: ");
            Console.WriteLine(nomeDoRival);

            //Final do dialogo
            PrintSeparator();

            Console.Write(nomeDoPlayer);
            Console.Write("!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Ache todos os Pokémons lendários desse mundo!");
            Console.WriteLine("Um mundo de aventuras começa agora!");

            Console.ReadKey();
        }

        static void PrintAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }
}
