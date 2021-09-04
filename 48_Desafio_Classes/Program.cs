using System;
using System.Collections.Generic;

namespace _48_Desafio_Classes
{
    class Item
    {
        public string Name;
        public int Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
                new Item
                {
                    Name = "Pao de Queijo",
                    Price = 1,
                },
                new Item
                {
                    Name = "Acaraje",
                    Price = 3,
                },
                new Item
                {
                    Name = "Feijoada",
                    Price = 3,
                }
            };

            int playerCoinCount = 5;
            List<Item> playerItems = new List<Item>();

            PrintLineAndWait("Bem vindo a nossa loja!");
            PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
            PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

            //enquanto o jogador tiver dinheiro E enquanto ele puder comprar alguma coisa
            while (CanBuyAnyItem(playerCoinCount, items))
            {
                PrintStoreOptions(items);
                playerCoinCount = TryBuyItem(items, playerCoinCount, playerItems);
            }

            Console.WriteLine();
            PrintPlayerItems(playerItems);

            Console.WriteLine();
            Console.ReadKey();
            PrintLineAndWait("...");
            PrintLineAndWait("Eh uma pena que esses items sao apenas bits no seu computador... (._.)");
        }

        static void PrintPlayerItems(List<Item> playerItems)
        {
            Console.WriteLine("Voce nao consegue comprar mais nada! Esses sao seus items: ");
            foreach (var item in playerItems)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }

        static int TryBuyItem(List<Item> itemOptions, int playerCoinCount, List<Item> playerItems)
        {
            Item item = ReadItem("Digite o numero do Item que voce quer comprar -> ", itemOptions);

            //jogador consegue comprar o item?
            if (playerCoinCount >= item.Price)
            {
                playerItems.Add(item);
                playerCoinCount -= item.Price;
                Console.WriteLine();
                PrintLineAndWait($"Voce comprou um {item.Name} por ${item.Price}! Voce tem ${playerCoinCount} coins.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                PrintLineAndWait($"Esse item custa ${item.Price} mas voce so tem ${playerCoinCount}");
                Console.WriteLine();
            }

            return playerCoinCount;
        }

        static void PrintStoreOptions(List<Item> items)
        {
            Console.WriteLine();
            Console.WriteLine("Essas sao as nossas opcoes:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i].Name} - ${items[i].Price}");
            }
        }

        static bool CanBuyAnyItem(int playerCoinCount, List<Item> items)
        {
            foreach (var item in items)
            {
                if (playerCoinCount >= item.Price)
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

        static Item ReadItem(string message, List<Item> itemOptions)
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
