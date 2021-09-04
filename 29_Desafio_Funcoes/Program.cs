using System;

namespace _2_Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducao
            PlayIntroduction();

            //Input do nome do Player
            PrintDialogueDivision();
            PlayPlayerIntroduction();

            //Input do nome do Rival
            PrintDialogueDivision();
            PlayRivalIntroduction();

            //Final do dialogo
            PrintDialogueDivision();
            PrintDialogueEnd();

            Console.ReadKey();
        }

        static string ReadTextInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }

        static void PrintDialogueDivision()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static void PlayIntroduction()
        {
            PrintLineAndWait("Olá pessoal! Bem vindos ao mundo de Pokémon!");
            PrintLineAndWait("Sou Carvalho. Pode me chamar de POKÉMON PROF!");
            PrintLineAndWait("Esse mundo é habitado por seres chamados Pokémon");
            PrintLineAndWait("Pessoas usam Pokémons para cuidar ou em confrontos");
            PrintLineAndWait("Já eu...");
            PrintLineAndWait("Estudo Pokémons como profissão.");
        }

        static void PlayPlayerIntroduction()
        {
            string nomeDoPlayer = ReadTextInput("Primeiro, qual é o seu nome? --> ");

            Console.Write("Tudo bem! Seu nome é: ");
            PrintLineAndWait(nomeDoPlayer);
        }

        static void PlayRivalIntroduction()
        {
            PrintLineAndWait("Apresento o meu neto. Ele é seu rival desde que vocês nasceram");

            string nomeDoRival = ReadTextInput("... Eu esqueci o nome do rapaz! Você me pode me lembrar? --> ");

            Console.Write("Claro! Eu me lembro agora! O nome dele é: ");
            PrintLineAndWait(nomeDoRival);
        }

        static void PrintDialogueEnd()
        {
            PrintLineAndWait("Ache todos os Pokémons lendários desse mundo!");
            PrintLineAndWait("Um mundo de aventuras começa agora!");
        }
    }
}
