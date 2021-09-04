using System;

namespace _7_Desafio_RockPaperScissors
{
    class Program
    {
        enum ElementOption
        {
            Unknown = -1,
            Rock,
            Paper,
            Scissor,
        }

        static void Main(string[] args)
        {
            PrintLineAndWait("Bem vindo ao Rock Paper Scissor com uma IA!");
            PrintLineAndWait("Esse eh o meu territorio, entao voce nao tem chance.");
            PrintLineAndWait("(eh serio, eu que fiz esse jogo)");

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            ElementOption playerChoice = ReadElementOption("Escolha Rock, Paper ou Scissor --> ");
            switch (playerChoice)
            {
                case ElementOption.Rock:
                    PrintLineAndWait("Eu escolhi Paper. Voce perdeu! :)");
                    break;
                case ElementOption.Paper:
                    PrintLineAndWait("Eu escolhi Scissor. Voce perdeu! :)");
                    break;
                case ElementOption.Scissor:
                    PrintLineAndWait("Eu escolhi Rock. Voce perdeu! :)");
                    break;
                default:
                    //logar no erro
                    PrintLineAndWait("Voce nao sabe jogar Rock Paper Scissor? ._.");
                    break;
            }

            Console.ReadKey();
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static ElementOption ReadElementOption(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            ElementOption option;
            if (Enum.TryParse<ElementOption>(input, out option))
            {
                return option;
            }
            else
            {
                return ElementOption.Unknown;
            }
        }
    }
}
