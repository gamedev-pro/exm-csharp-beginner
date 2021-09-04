using System;

namespace _9_Desafio_2_LojaDeItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemOptions = new string[]
            {
                "Pao de Queijo",
                "Acaraje",
                "Feijoada"
            };

            int playerCoinCount = 5;
            string[] playerItems = new string[playerCoinCount];
            int counter = 0;
            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
            PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");
            while (playerCoinCount > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Essas sao as nossas opcoes:");
                for (int i = 0; i < itemOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {itemOptions[i]}");
                }
                string item = ReadItem("Digite o numero do Item que voce quer comprar -> ", itemOptions);
                playerItems[counter] = item;
                playerCoinCount--;
                counter++;

                Console.WriteLine();
                PrintLineAndWait($"Voce comprou um {item} por 1 coin! Voce tem {playerCoinCount} coins.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Voce nao tem mais dinheiro! Esses sao seus items: ");
            foreach (var item in playerItems)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine();
            Console.ReadKey();
            PrintLineAndWait("...");
            PrintLineAndWait("Eh uma pena que esses items sao apenas bits no seu computador... (._.)");
        }

        static void PrintLineAndWait(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static int ReadNumber(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            return -1;
        }

        static string ReadItem(string message, string[] itemOptions)
        {
            int index = ReadNumber(message);
            index -= 1;
            while (index < 0 || index >= itemOptions.Length)
            {
                Console.WriteLine("Eu nao conheco esse item. E voce nao sai daqui ate comprar!");
                index = ReadNumber(message);
                index -= 1;
            }
            return itemOptions[index];
        }
    }
}
