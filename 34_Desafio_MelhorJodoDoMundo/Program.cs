using System;

namespace _5___Desafio___HalfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestGameOfTheUniverse = "Half-Life 3";

            PrintMessageAndWait("Ola, eu sou um genio e posso te conceder 3 desejos...");
            PrintMessageAndWait("Mas antes, voce tem que responder uma pergunta. Voce tem 3 tentativas.");
            Console.WriteLine();

            string answer = ReadTextInput("Qual eh o melhor jogo do Universo?! -> ");
            if (answer == bestGameOfTheUniverse)
            {
                PrintCorrectAnswerFeedback();
            }
            else
            {
                PrintMessageAndWait("Resposta errada! Voce tem 2 tentativas");
                answer = ReadTextInput("Qual eh o melhor jogo do Universo?! -> ");
                if (answer == bestGameOfTheUniverse)
                {
                    PrintCorrectAnswerFeedback();
                }
                else
                {
                    PrintMessageAndWait("Resposta errada! Sua batata esta assando!");
                    answer = ReadTextInput("Qual eh o melhor jogo do Universo?! -> ");
                    if (answer == bestGameOfTheUniverse)
                    {
                        PrintCorrectAnswerFeedback();
                    }
                    else
                    {
                        PrintMessageAndWait("Voce nao sabe de nada mesmo... Vou procurar alguem que entende de jogos");
                    }
                }
            }

            Console.ReadKey();
        }

        static void PrintMessageAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static string ReadTextInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static void PrintCorrectAnswerFeedback()
        {
            PrintMessageAndWait("ISSO! ISSO! Voce entende mesmo de jogos");
            PrintMessageAndWait("Agora sobre os seus desejos...");
            PrintMessageAndWait("Eu vou realizar todos eles assim que Half-Life 3 sair! Sugiro esperar sentado :)");
            PrintMessageAndWait("Mas pelo menos voce acertou a pergunta... ¯\\_(ツ)_/¯");
            PrintMessageAndWait("Ate mais!");
        }
    }
}
