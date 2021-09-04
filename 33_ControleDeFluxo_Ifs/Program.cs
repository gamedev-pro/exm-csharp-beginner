using System;

namespace _33_ControleDeFluxo_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo! Escolha seu nivel de dificuldade");
            Console.WriteLine("As opcoes sao: Iniciante, Normal e Expert");
            string difficultyLevel = Console.ReadLine();
            //forca do inimigo seja 1x no iniciante, 2x no normal e 5x no expert
            int enemyPower = 20;
            bool firstTimeUser = true;

            if (difficultyLevel == "Iniciante")
            {
                Console.WriteLine("Voce escolheu o nivel Iniciante!");
                Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
            }
            else if (difficultyLevel == "Normal")
            {
                Console.WriteLine("Voce escolheu o nivel Normal!");
                enemyPower *= 2;
                Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
            }
            else if (difficultyLevel == "Expert")
            {
                if (firstTimeUser == true)
                {
                    Console.WriteLine("Voce nao pode escolher o Expert no seu primeiro playthrough!");
                }
                else
                {
                    Console.WriteLine("Voce escolheu o nivel Expert!");
                    enemyPower *= 5;
                    Console.WriteLine($"Forca dos Inimigos: {enemyPower}");
                }
            }


            else
            {
                Console.WriteLine("Nivel de dificuldate incorreto. Por favor digite Iniciante, Normal ou Expert");
            }

            Console.ReadKey();
        }
    }
}
