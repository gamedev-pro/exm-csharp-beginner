using System;

namespace _40_ControleDeFluxo_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemsList = new string[] { "espada", "escudo", "capacete" };

            //magic numbers
            for (int i = 0; i < itemsList.Length; i++)
            {
                string item = itemsList[i];
                Console.WriteLine($"O item numero {i + 1} eh: {item}");
            }

            foreach (string item in itemsList)
            {
                Console.WriteLine($"O item numero eh: {item}");
            }

            //while
            int health = 10;
            bool isPoisoned = true;
            //tirar 1 hitpoint do player por segundo enquanto ele tiver poison e estiver vivo
            while (isPoisoned == true && health > 0)
            {
                health -= 1;
                Console.WriteLine($"Voce tomou dano. Hitpoints remanescentes: {health}");
                Console.ReadKey();
            }

            while (true)
            {
                health -= 1;
                Console.WriteLine($"Voce tomou dano. Hitpoints remanescentes: {health}");
                Console.ReadKey();

                if (isPoisoned == false || health <= 0)
                {
                    break;
                }
            }

            Console.WriteLine("Jogador nao tem mais nenhum hitpoint!");



            Console.ReadKey();
        }
    }
}
