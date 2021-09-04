using System;

namespace _52_Const_ReadOnly
{
    //const, readonly
    //membros (variaveis de classe) - dados
    //readonly: pode ser alterada na INICIALIZACAO (constructor ou na definicao)

    public class Price
    {

    }
    public class Item
    {
        public readonly string Name;
        public readonly int Price = 1;

        public const int MinItemPrice = 2;

        public Item(string name, int price)
        {
            Name = name;
            if (price >= MinItemPrice)
            {
                Price = price;
            }
            else
            {
                Price = MinItemPrice;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Item1", 10);
            Console.WriteLine($"Item: {item.Name}, {item.Price}");
            item.Name = "Item2";
            item.Price = 0;
        }
    }
}
