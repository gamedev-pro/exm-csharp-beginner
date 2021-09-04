using System;
using System.Collections.Generic;

namespace _44_Desafio_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> itemOptions = new List<string>()
            {
                "Pao de Queijo",
                "Acaraje",
                "Feijoada"
            };

            List<int> itemPrices = new List<int>()
            {
                1,3,3
            };

            int playerCoinCount = 5;
            List<string> playerItems = new List<string>();

            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
            PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

            //enquanto o jogador tiver dinheiro E enquanto ele puder comprar alguma coisa
            while (CanBuyAnyItem(playerCoinCount, itemPrices))
            {
                PrintStoreOptions(itemOptions, itemPrices);
                playerCoinCount = TryBuyItem(itemOptions, itemPrices, playerCoinCount, playerItems);
            }

            Console.WriteLine();
            PrintPlayerItems(playerItems);

            Console.WriteLine();
            Console.ReadKey();
            PrintLineAndWait("...");
            PrintLineAndWait("Eh uma pena que esses items sao apenas bits no seu computador... (._.)");
        }

        static void PrintPlayerItems(List<string> playerItems)
        {
            Console.WriteLine("Voce nao consegue comprar mais nada! Esses sao seus items: ");
            foreach (var item in playerItems)
            {
                Console.WriteLine($"- {item}");
            }
        }

        static int TryBuyItem(List<string> itemOptions, List<int> itemPrices, int playerCoinCount, List<string> playerItems)
        {
            string item = ReadItem("Digite o numero do Item que voce quer comprar -> ", itemOptions);

            int itemIndex = itemOptions.IndexOf(item);
            int itemPrice = itemPrices[itemIndex];
            //jogador consegue comprar o item?
            if (playerCoinCount >= itemPrice)
            {
                playerItems.Add(item);
                playerCoinCount -= itemPrice;
                Console.WriteLine();
                PrintLineAndWait($"Voce comprou um {item} por ${itemPrice}! Voce tem ${playerCoinCount} coins.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                PrintLineAndWait($"Esse item custa ${itemPrice} mas voce so tem ${playerCoinCount}");
                Console.WriteLine();
            }

            return playerCoinCount;
        }

        static void PrintStoreOptions(List<string> itemOptions, List<int> itemPrices)
        {
            Console.WriteLine();
            Console.WriteLine("Essas sao as nossas opcoes:");
            for (int i = 0; i < itemOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {itemOptions[i]} - ${itemPrices[i]}");
                System.Console.WriteLine();
            }
        }

        static bool CanBuyAnyItem(int playerCoinCount, List<int> itemPrices)
        {
            foreach (var price in itemPrices)
            {
                if (playerCoinCount >= price)
                {
                    return true;
                }
            }
            return false;
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

        static string ReadItem(string message, List<string> itemOptions)
        {
            int index = ReadNumber(message);
            index -= 1;
            while (index < 0 || index >= itemOptions.Count)
            {
                Console.WriteLine("Eu nao conheco esse item. E voce nao sai daqui ate comprar!");
                index = ReadNumber(message);
                index -= 1;
            }
            return itemOptions[index];
        }
    }
}
